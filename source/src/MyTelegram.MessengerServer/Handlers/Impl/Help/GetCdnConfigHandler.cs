using MyTelegram.Handlers.Help;
using MyTelegram.Schema.Help;

namespace MyTelegram.MessengerServer.Handlers.Impl.Help;

public class GetCdnConfigHandler : RpcResultObjectHandler<RequestGetCdnConfig, ICdnConfig>,
    IGetCdnConfigHandler
{
    protected override Task<ICdnConfig> HandleCoreAsync(IRequestInput input,
        RequestGetCdnConfig obj)
    {
        throw new NotImplementedException();
    }
}
