using MyTelegram.Handlers.Help;
using MyTelegram.Schema.Help;

namespace MyTelegram.MessengerServer.Handlers.Impl.Help;

public class DismissSuggestionHandler : RpcResultObjectHandler<RequestDismissSuggestion, IBool>,
    IDismissSuggestionHandler
{
    protected override Task<IBool> HandleCoreAsync(IRequestInput input,
        RequestDismissSuggestion obj)
    {
        throw new NotImplementedException();
    }
}
