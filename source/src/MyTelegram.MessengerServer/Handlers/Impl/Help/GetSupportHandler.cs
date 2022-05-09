using MyTelegram.Handlers.Help;
using MyTelegram.Schema.Help;

namespace MyTelegram.MessengerServer.Handlers.Impl.Help;

public class GetSupportHandler : RpcResultObjectHandler<RequestGetSupport, ISupport>,
    IGetSupportHandler
{
    protected override Task<ISupport> HandleCoreAsync(IRequestInput input,
        RequestGetSupport obj)
    {
        throw new NotImplementedException();
    }
}
