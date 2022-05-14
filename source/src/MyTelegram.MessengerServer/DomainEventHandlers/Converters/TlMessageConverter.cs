﻿namespace MyTelegram.MessengerServer.DomainEventHandlers.Converters;

public class TlMessageConverter : ITlMessageConverter
{
    private readonly IPeerHelper _peerHelper;

    public TlMessageConverter(IPeerHelper peerHelper)
    {
        _peerHelper = peerHelper;
    }

    public IMessage ToMessage(MessageItem item,
        long selfUserId = 0)
    {
        var isOut = item.IsOut;
        if (item.ToPeer.PeerType == PeerType.Channel && selfUserId != 0)
        {
            isOut = item.SenderPeer.PeerId == selfUserId;
        }

        switch (item.SendMessageType)
        {
            case SendMessageType.MessageService:
            {
                if (string.IsNullOrEmpty(item.MessageActionData))
                {
                    throw new ArgumentNullException(nameof(item),
                        "MessageActionData can not be null for service message");
                }

                var bytes = item.MessageActionData.ToBytes();
                var fromId = item.SenderPeer.ToPeer();
                //if (box.ToPeer.PeerType == PeerType.Channel && box.Post)
                //{
                //    fromId = null;
                //}

                var m = new TMessageService
                {
                    Date = item.Date,
                    //Silent = outbox.Silent,
                    Post = false, // outbox.Post,
                    PeerId = item.ToPeer.ToPeer(),
                    FromId = fromId,
                    Id = item.MessageId,
                    //Out = item.IsOut,
                    Out = isOut,
                    Action = bytes.ToTObject<IMessageAction>(),
                    ReplyTo = ToMessageReplyHeader(item.ReplyToMsgId)
                };

                return m;
            }
            //break;

            default:
            {
                var m = new TMessage
                {
                    Date = item.Date,
                    Entities = item.Entities.ToTObject<TVector<IMessageEntity>>(),
                    FromId = item.SenderPeer.ToPeer(),
                    PeerId = item.ToPeer.ToPeer(),
                    Id = item.MessageId,
                    Message = item.Message,
                    Out = isOut,
                    FwdFrom = ToMessageFwdHeader(item.FwdHeader),
                    GroupedId = item.GroupId,
                    Media = item.Media.ToTObject<IMessageMedia>(),
                    Views = item.Views,
                    Forwards = item.Views.HasValue ? 0 : null,
                    Post = item.Post
                };
                if (item.ToPeer.PeerType == PeerType.Channel)
                {
                    //m.FromId = null;
                    if (item.Post /*|| item.SenderPeer.PeerId == selfUserId*/)
                    {
                        m.FromId = null;
                    }

                    if (item.Post)
                    {
                        m.Replies = new TMessageReplies { Comments = true, ChannelId = item.ToPeer.PeerId };
                    }
                }

                m.ReplyTo = ToMessageReplyHeader(item.ReplyToMsgId);

                return m;
            }
            //break;
        }
    }

    public IList<IMessage> ToMessages(IReadOnlyCollection<IMessageReadModel> readModels,
        long selfUserId)
    {
        var messages = new List<IMessage>();
        foreach (var readModel in readModels)
        {
            messages.Add(ToMessage(readModel, selfUserId));
        }

        return messages;
    }

    public IMessage ToMessage(InboxMessageEditCompletedEvent aggregateEvent)
    {
        return new TMessage
        {
            Date = aggregateEvent.EditDate,
            EditDate = aggregateEvent.EditDate,
            Entities = aggregateEvent.Entities.ToTObject<TVector<IMessageEntity>>(),
            FromId = new TPeerUser { UserId = aggregateEvent.SenderPeerId },
            PeerId = aggregateEvent.ToPeer.ToPeer(),
            Id = aggregateEvent.MessageId,
            Out = false,
            Message = aggregateEvent.Message,
            Media = aggregateEvent.Media.ToTObject<IMessageMedia>()
        };
    }

    public IMessage ToMessage(OutboxMessageEditCompletedEvent aggregateEvent,
        long selfUserId)
    {
        var m = new TMessage
        {
            Date = aggregateEvent.Date,
            Entities = aggregateEvent.Entities.ToTObject<TVector<IMessageEntity>>(),
            FromId = new Peer(PeerType.User, aggregateEvent.SenderPeerId).ToPeer(),
            PeerId = aggregateEvent.ToPeer.ToPeer(),
            Id = aggregateEvent.MessageId,
            EditDate = aggregateEvent.Date,
            Out = aggregateEvent.SenderPeerId == selfUserId,
            Message = aggregateEvent.Message,
            Views = aggregateEvent.Views,
            Forwards = aggregateEvent.Views.HasValue ? 0 : null,
            Post = aggregateEvent.Post,
            Media = aggregateEvent.Media.ToTObject<IMessageMedia>()
        };
        if (aggregateEvent.Post)
        {
            m.FromId = null;
        }

        return m;
    }

    public IMessageFwdHeader? ToMessageFwdHeader(MessageFwdHeader? fwdHeader)
    {
        if (fwdHeader == null)
        {
            return null;
        }

        return new TMessageFwdHeader
        {
            ChannelPost = fwdHeader.ChannelPost,
            Date = fwdHeader.Date,
            FromId = fwdHeader.FromId.ToPeer(),
            FromName = fwdHeader.FromName,
            PostAuthor = fwdHeader.PostAuthor,
            SavedFromPeer = fwdHeader.SavedFromPeer.ToPeer(),
            SavedFromMsgId = fwdHeader.SavedFromMsgId
        };
    }

    public IMessageReplyHeader? ToMessageReplyHeader(int? replyToMsgId)
    {
        if (replyToMsgId > 0)
        {
            return new TMessageReplyHeader { ReplyToMsgId = replyToMsgId.Value };
        }

        return null;
    }

    private IMessage ToMessage(IMessageReadModel readModel,
        long selfUserId)
    {
        switch (readModel.SendMessageType)
        {
            case SendMessageType.MessageService:
            {
                ArgumentNullException.ThrowIfNull(readModel.MessageActionData);

                var bytes = readModel.MessageActionData.ToBytes();
                var fromId = _peerHelper.ToPeer(PeerType.User, readModel.SenderPeerId);
                if (readModel.ToPeerType == PeerType.Channel && readModel.Post &&
                    readModel.MessageActionType != MessageActionType.ChatAddUser)
                {
                    fromId = null;
                }

                var m = new TMessageService
                {
                    Date = readModel.Date,
                    Silent = readModel.Silent,
                    Post = readModel.Post,
                    PeerId = _peerHelper.ToPeer(readModel.ToPeerType, readModel.ToPeerId),
                    FromId = fromId,
                    Id = readModel.MessageId,
                    Out = readModel.SenderPeerId == selfUserId,
                    Action = bytes.ToTObject<IMessageAction>(),
                    ReplyTo = ToMessageReplyHeader(readModel.ReplyToMsgId)
                };

                return m;
            }
            default:
            {
                var fromId = _peerHelper.ToPeer(PeerType.User, readModel.SenderPeerId);
                var toPeerId = _peerHelper.ToPeer(readModel.ToPeerType, readModel.ToPeerId);

                var m = new TMessage
                {
                    Date = readModel.Date,
                    EditDate = readModel.EditDate,
                    Message = readModel.Message,
                    Silent = readModel.Silent,
                    Post = readModel.Post,
                    PostAuthor = readModel.PostAuthor,
                    GroupedId = readModel.GroupedId,
                    Views = readModel.Views,
                    Forwards = readModel.Views.HasValue ? 0 : null,
                    Entities = readModel.Entities.ToTObject<TVector<IMessageEntity>>(),
                    PeerId = toPeerId,
                    FromId = fromId,
                    Id = readModel.MessageId,
                    Out = readModel.SenderPeerId == selfUserId,
                    Pinned = readModel.Pinned,
                    FwdFrom = ToMessageFwdHeader(readModel.FwdHeader),
                    Media = readModel.Media.ToTObject<IMessageMedia>(),
                    ReplyTo = ToMessageReplyHeader(readModel.ReplyToMsgId)
                };

                if (readModel.ToPeerType == PeerType.Channel)
                {
                    if (readModel.Post)
                    {
                        m.FromId = null;
                        m.Replies = new TMessageReplies { ChannelId = readModel.ToPeerId, Comments = true };
                    }
                }

                return m;
            }
        }
    }
}
