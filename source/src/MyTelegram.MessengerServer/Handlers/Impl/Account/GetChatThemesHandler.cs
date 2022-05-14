using MyTelegram.Handlers.Account;
using MyTelegram.Schema.Account;

namespace MyTelegram.MessengerServer.Handlers.Impl.Account;

public class GetChatThemesHandler : RpcResultObjectHandler<RequestGetChatThemes, MyTelegram.Schema.Account.IThemes>,
    IGetChatThemesHandler
{
    protected override Task<MyTelegram.Schema.Account.IThemes> HandleCoreAsync(IRequestInput input,
        RequestGetChatThemes obj)
    {
        throw new NotImplementedException();
    }
}
