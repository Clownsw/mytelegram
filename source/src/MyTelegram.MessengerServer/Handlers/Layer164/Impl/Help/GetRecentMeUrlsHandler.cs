using MyTelegram.Handlers.Help;

namespace MyTelegram.MessengerServer.Handlers.Impl.Help;

public class GetRecentMeUrlsHandler : RpcResultObjectHandler<RequestGetRecentMeUrls, IRecentMeUrls>,
    IGetRecentMeUrlsHandler
{
    protected override Task<IRecentMeUrls> HandleCoreAsync(IRequestInput input,
        RequestGetRecentMeUrls obj)
    {
        throw new NotImplementedException();
    }
}