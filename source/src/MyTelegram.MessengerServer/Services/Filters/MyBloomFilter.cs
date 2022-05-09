﻿using BloomFilter;

namespace MyTelegram.MessengerServer.Services.Filters;

public class MyBloomFilter : IBloomFilter
{
    private readonly BloomFilter.IBloomFilter _filter = FilterBuilder.Build(5_000_000, 0.001, HashMethod.LCGWithFNV1a);
    public Task<bool> ExistsAsync(byte[] value)
    {
        return _filter.ContainsAsync(value);
    }

    public Task<bool> AddAsync(byte[] value)
    {
        return _filter.AddAsync(value);
    }

    public Task<IList<bool>> ExistsAsync(IEnumerable<byte[]> values)
    {
        return _filter.ContainsAsync(values);
    }

    public Task<IList<bool>> AddAsync(IEnumerable<byte[]> values)
    {
        return _filter.AddAsync(values);
    }
}