﻿// ReSharper disable All

namespace MyTelegram.Handlers.Channels.LayerN;

///<summary>
/// Get link and embed info of a message in a <a href="https://corefork.telegram.org/api/channel">channel/supergroup</a>
/// <para>Possible errors</para>
/// Code Type Description
/// 400 CHANNEL_INVALID The provided channel is invalid.
/// 400 CHANNEL_PRIVATE You haven't joined this channel/supergroup.
/// 400 MESSAGE_ID_INVALID The provided message id is invalid.
/// 400 MSG_ID_INVALID Invalid message ID provided.
/// See <a href="https://corefork.telegram.org/method/channels.exportMessageLink" />
///</summary>
internal sealed class ExportMessageLinkHandler : RpcResultObjectHandler<MyTelegram.Schema.Channels.LayerN.RequestExportMessageLink, IExportedMessageLink>,
    Channels.LayerN.IExportMessageLinkHandler, IProcessedHandler
{
    protected override Task<IExportedMessageLink> HandleCoreAsync(IRequestInput input,
        MyTelegram.Schema.Channels.LayerN.RequestExportMessageLink obj)
    {
        throw new NotImplementedException();
    }
}
