﻿// ReSharper disable All

namespace MyTelegram.Schema.Stats;

///<summary>
/// Message statistics
/// See <a href="https://corefork.telegram.org/constructor/stats.MessageStats" />
///</summary>
public interface IMessageStats : IObject
{
    ///<summary>
    /// Message view graph
    /// See <a href="https://corefork.telegram.org/type/StatsGraph" />
    ///</summary>
    MyTelegram.Schema.IStatsGraph ViewsGraph { get; set; }
}
