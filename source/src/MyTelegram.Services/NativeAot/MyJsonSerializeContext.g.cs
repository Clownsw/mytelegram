// <auto-generated/>
// ReSharper disable All
using System.Text.Json.Serialization;

namespace MyTelegram.Services.NativeAot;

// Generation time:2023-12-09 05:52:02Z ,count:72
// MyTelegram.Core
[JsonSerializable(typeof(MyTelegram.Core.AcksDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.AppCodeCreatedIntegrationEvent))]
[JsonSerializable(typeof(MyTelegram.Core.AuthKeyCreatedIntegrationEvent))]
[JsonSerializable(typeof(MyTelegram.Core.AuthKeyNotFoundEvent))]
[JsonSerializable(typeof(MyTelegram.Core.AuthKeyUnRegisteredIntegrationEvent))]
[JsonSerializable(typeof(MyTelegram.Core.BindUidToAuthKeyIntegrationEvent))]
[JsonSerializable(typeof(MyTelegram.Core.BindUidToSessionEvent))]
[JsonSerializable(typeof(MyTelegram.Core.ChannelMemberChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.ChatMemberChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.ClientDisconnectedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.CreateEncryptedPushMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Core.CreatePushMessageEvent))]
[JsonSerializable(typeof(MyTelegram.Core.DataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.DataResultResponseReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.DataResultResponseWithUserIdReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.DomainEventMessage))]
[JsonSerializable(typeof(MyTelegram.Core.DownloadDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.DuplicateCommandEvent))]
[JsonSerializable(typeof(MyTelegram.Core.EncryptedMessage))]
[JsonSerializable(typeof(MyTelegram.Core.EncryptedMessageResponse))]
[JsonSerializable(typeof(MyTelegram.Core.FileDataResultResponseReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.ISessionMessage))]
[JsonSerializable(typeof(MyTelegram.Core.LayeredAuthKeyIdMessageCreatedIntegrationEvent))]
[JsonSerializable(typeof(MyTelegram.Core.LayeredPushMessageCreatedIntegrationEvent))]
[JsonSerializable(typeof(MyTelegram.Core.MessengerCommandDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.MessengerDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.MessengerQueryDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.NewDeviceCreatedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.NewPtsMessageHasSentEvent))]
[JsonSerializable(typeof(MyTelegram.Core.PhoneCallDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.PushDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.PushMessageToPeerEvent))]
[JsonSerializable(typeof(MyTelegram.Core.RpcMessageHasSentEvent))]
[JsonSerializable(typeof(MyTelegram.Core.SessionPasswordStateChangedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.SetSessionPasswordStateEvent))]
[JsonSerializable(typeof(MyTelegram.Core.StickerDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UnRegisterAuthKeyEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UnencryptedMessage))]
[JsonSerializable(typeof(MyTelegram.Core.UnencryptedMessageResponse))]
[JsonSerializable(typeof(MyTelegram.Core.UpdateSelfPtsEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UpdatesDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UploadDataReceivedEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UserCacheItem))]
[JsonSerializable(typeof(MyTelegram.Core.UserIsOnlineEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UserSignInSuccessEvent))]
[JsonSerializable(typeof(MyTelegram.Core.UserSignUpSuccessIntegrationEvent))]

// MyTelegram.Domain.Shared
[JsonSerializable(typeof(MyTelegram.Peer))]
[JsonSerializable(typeof(MyTelegram.PeerColor))]
[JsonSerializable(typeof(MyTelegram.PhotoSize))]
[JsonSerializable(typeof(MyTelegram.VideoSize))]
[JsonSerializable(typeof(MyTelegram.VideoSizeEmojiMarkup))]

// EventFlow
[JsonSerializable(typeof(EventFlow.Aggregates.Metadata))]
[JsonSerializable(typeof(EventFlow.Provided.Jobs.DispatchToAsynchronousEventSubscribersJob))]
[JsonSerializable(typeof(EventFlow.Snapshots.SnapshotMetadata))]
[JsonSerializable(typeof(MyTelegram.Peer))]
[JsonSerializable(typeof(MyTelegram.RequestInfo))]
[JsonSerializable(typeof(MyTelegram.Core.UserCacheItem))]
[JsonSerializable(typeof(MyTelegram.Services.Services.AckCacheItem))]
[JsonSerializable(typeof(MyTelegram.Services.Services.PtsCacheItem))]

[JsonSerializable(typeof(System.Collections.Generic.List<PhotoSize>))]
[JsonSerializable(typeof(System.Collections.Generic.List<VideoSize>))]

[JsonSourceGenerationOptions(PropertyNamingPolicy = JsonKnownNamingPolicy.CamelCase)]
public partial class MyJsonSerializeContext : JsonSerializerContext
{
}
