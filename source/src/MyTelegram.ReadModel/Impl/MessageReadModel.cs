﻿namespace MyTelegram.ReadModel.Impl;

public class MessageReadModel : IMessageReadModel,
    IAmReadModelFor<MessageAggregate, MessageId, OutboxMessageCreatedEvent>,
    IAmReadModelFor<MessageAggregate, MessageId, InboxMessageCreatedEvent>,
    IAmReadModelFor<MessageAggregate, MessageId, OutboxMessageEditedEvent>,
    IAmReadModelFor<MessageAggregate, MessageId, InboxMessageEditedEvent>,
    IAmReadModelFor<MessageSaga,MessageSagaId,SendOutboxMessageCompletedEvent>,
    IAmReadModelFor<MessageSaga,MessageSagaId,ReceiveInboxMessageCompletedEvent>,
    IAmReadModelFor<MessageAggregate, MessageId, InboxMessagePinnedUpdatedEvent>,
    IAmReadModelFor<MessageAggregate, MessageId, OutboxMessagePinnedUpdatedEvent>,
    IAmReadModelFor<MessageAggregate, MessageId, UpdatePinnedMessageStartedEvent>
{
    public int Date { get; private set; }
    public int EditDate { get; private set; }
    public byte[]? Entities { get; private set; }
    public MessageFwdHeader? FwdHeader { get; private set; }
    public long? GroupedId { get; private set; }
    public string Id { get; private set; } = default!;
    public byte[]? Media { get; private set; }
    public string Message { get; private set; } = default!;
    public string? MessageActionData { get; private set; }
    public MessageActionType MessageActionType { get; private set; }
    public MessageType MessageType { get; private set; }
    public int MessageId { get; private set; }
    public bool Out { get; private set; }
    public long OwnerPeerId { get; private set; }
    public bool Pinned { get; private set; }
    public bool Post { get; private set; }
    public string? PostAuthor { get; private set; } = null;
    public int Pts { get; private set; }
    public int? ReplyToMsgId { get; private set; }
    public int SenderMessageId { get; private set; }
    public long SenderPeerId { get; private set; }
    public SendMessageType SendMessageType { get; private set; }
    public bool Silent { get; private set; }
    public long ToPeerId { get; private set; }
    public PeerType ToPeerType { get; private set; }
    public int? Views { get; private set; }
    public virtual long? Version { get; set; }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, OutboxMessageCreatedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        var messageItem = domainEvent.AggregateEvent.OutboxMessageItem;
        Id = domainEvent.AggregateIdentity.Value;
        OwnerPeerId = messageItem.OwnerPeer.PeerId;
        SenderPeerId = messageItem.SenderPeer.PeerId;
        ToPeerType = messageItem.ToPeer.PeerType;
        ToPeerId = messageItem.ToPeer.PeerId;
        MessageType = messageItem.MessageType;
        MessageId = messageItem.MessageId;
        Message = messageItem.Message;
        Entities = messageItem.Entities;
        Date = messageItem.Date;
        SenderMessageId = messageItem.MessageId;
        MessageActionData = messageItem.MessageActionData;
        MessageActionType = messageItem.MessageActionType;
        ReplyToMsgId = messageItem.ReplyToMsgId;
        FwdHeader = messageItem.FwdHeader;
        SendMessageType = messageItem.SendMessageType;
        Media = messageItem.Media;
        GroupedId = messageItem.GroupId;
        Out = messageItem.IsOut;
        Views = messageItem.Views;
        Post= messageItem.Post;

        Silent = false;

        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, InboxMessageCreatedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        var messageItem = domainEvent.AggregateEvent.InboxMessageItem;
        Id = domainEvent.AggregateIdentity.Value;
        OwnerPeerId = messageItem.OwnerPeer.PeerId;
        SenderPeerId = messageItem.SenderPeer.PeerId;
        ToPeerType = messageItem.ToPeer.PeerType;
        ToPeerId = messageItem.ToPeer.PeerId;
        MessageType = messageItem.MessageType;
        MessageId = messageItem.MessageId;
        Message = messageItem.Message;
        Entities = messageItem.Entities;
        Date = messageItem.Date;
        SenderMessageId = messageItem.MessageId;
        MessageActionData = messageItem.MessageActionData;
        MessageActionType = messageItem.MessageActionType;
        ReplyToMsgId = messageItem.ReplyToMsgId;
        FwdHeader = messageItem.FwdHeader;
        SendMessageType = messageItem.SendMessageType;
        Media = messageItem.Media;
        GroupedId = messageItem.GroupId;
        Out = messageItem.IsOut;
        Views = messageItem.Views;

        Silent = false;

        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, OutboxMessageEditedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        Message = domainEvent.AggregateEvent.NewMessage;
        Entities = domainEvent.AggregateEvent.Entities;
        EditDate = domainEvent.AggregateEvent.EditDate;
        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, InboxMessageEditedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        Message = domainEvent.AggregateEvent.NewMessage;
        Entities = domainEvent.AggregateEvent.Entities;
        EditDate = domainEvent.AggregateEvent.EditDate;
        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageSaga, MessageSagaId, SendOutboxMessageCompletedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(Id))
        {
            Id = MyTelegram.Domain.Aggregates.Messaging.MessageId.Create(
                domainEvent.AggregateEvent.MessageItem.OwnerPeer.PeerId,
                domainEvent.AggregateEvent.MessageItem.MessageId).Value;
        }
        Pts =domainEvent.AggregateEvent.Pts;
        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageSaga, MessageSagaId, ReceiveInboxMessageCompletedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        if (string.IsNullOrEmpty(Id))
        {
            Id = MyTelegram.Domain.Aggregates.Messaging.MessageId.Create(
                domainEvent.AggregateEvent.MessageItem.OwnerPeer.PeerId,
                domainEvent.AggregateEvent.MessageItem.MessageId).Value;
        }
        Pts = domainEvent.AggregateEvent.Pts;
        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, InboxMessagePinnedUpdatedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        Pinned=domainEvent.AggregateEvent.Pinned;
        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, OutboxMessagePinnedUpdatedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        Pinned = domainEvent.AggregateEvent.Pinned;
        return Task.CompletedTask;
    }

    public Task ApplyAsync(IReadModelContext context,
        IDomainEvent<MessageAggregate, MessageId, UpdatePinnedMessageStartedEvent> domainEvent,
        CancellationToken cancellationToken)
    {
        Pinned = domainEvent.AggregateEvent.Pinned;
        return Task.CompletedTask;
    }
}