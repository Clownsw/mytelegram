﻿namespace MyTelegram.QueryHandlers.MongoDB.ChatInvite;

// ReSharper disable once UnusedMember.Global
public class
    GetChatInvitesQueryHandler : IQueryHandler<GetChatInvitesQuery, IReadOnlyCollection<IChatInviteReadModel>>
{
    private readonly IMongoDbReadModelStore<ChatInviteReadModel> _store;

    public GetChatInvitesQueryHandler(IMongoDbReadModelStore<ChatInviteReadModel> store)
    {
        _store = store;
    }

    public async Task<IReadOnlyCollection<IChatInviteReadModel>> ExecuteQueryAsync(GetChatInvitesQuery query,
        CancellationToken cancellationToken)
    {
        var cursor = await _store.FindAsync(p =>
                    p.Revoked == query.Revoked && p.ChannelId == query.ChannelId && p.AdminId == query.AdminId,
                cancellationToken: cancellationToken)
            .ConfigureAwait(false);

        return await cursor.ToListAsync(cancellationToken).ConfigureAwait(false);
    }
}
