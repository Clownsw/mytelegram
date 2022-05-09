using MyTelegram.Handlers.Messages;
using MyTelegram.Schema.Messages;

namespace MyTelegram.MessengerServer.Handlers.Impl.Messages;

public class GetDialogsHandler : RpcResultObjectHandler<RequestGetDialogs, IDialogs>,
    IGetDialogsHandler, IProcessedHandler
{
    private readonly IDialogAppService _dialogAppService;
    private readonly IPeerHelper _peerHelper;
    private readonly IRpcResultProcessor _rpcResultProcessor;

    public GetDialogsHandler(IDialogAppService dialogAppService,
        IRpcResultProcessor rpcResultProcessor,
        IPeerHelper peerHelper)
    {
        _dialogAppService = dialogAppService;
        _rpcResultProcessor = rpcResultProcessor;
        _peerHelper = peerHelper;
    }

    protected override async Task<IDialogs> HandleCoreAsync(IRequestInput input,
        RequestGetDialogs obj)
    {
        var userId = input.UserId;
        var offsetPeer = _peerHelper.GetPeer(obj.OffsetPeer);
        bool? pinned = null;
        if (obj.ExcludePinned)
        {
            pinned = false;
        }

        var r = await _dialogAppService.GetDialogsAsync(new GetDialogInput {
            FolderId = obj.FolderId,
            Limit = obj.Limit,
            Pinned = pinned,
            //Pinned = !obj.ExcludePinned,
            //ExcludePinned = obj.ExcludePinned,
            OwnerId = userId,
            OffsetPeer = offsetPeer
        }).ConfigureAwait(false);

        return _rpcResultProcessor.ToDialogs(r);
    }
}
