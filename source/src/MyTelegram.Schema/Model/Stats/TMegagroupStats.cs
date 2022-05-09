﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema.Stats;


///<summary>
///See <a href="https://core.telegram.org/constructor/stats.megagroupStats" />
///</summary>
[TlObject(0xef7ff916)]
public class TMegagroupStats : IMegagroupStats
{
    public uint ConstructorId => 0xef7ff916;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsDateRangeDays" />
    ///</summary>
    public MyTelegram.Schema.IStatsDateRangeDays Period { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsAbsValueAndPrev" />
    ///</summary>
    public MyTelegram.Schema.IStatsAbsValueAndPrev Members { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsAbsValueAndPrev" />
    ///</summary>
    public MyTelegram.Schema.IStatsAbsValueAndPrev Messages { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsAbsValueAndPrev" />
    ///</summary>
    public MyTelegram.Schema.IStatsAbsValueAndPrev Viewers { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsAbsValueAndPrev" />
    ///</summary>
    public MyTelegram.Schema.IStatsAbsValueAndPrev Posters { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph GrowthGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph MembersGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph NewMembersBySourceGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph LanguagesGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph MessagesGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph ActionsGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph TopHoursGraph { get; set; }

    ///<summary>
    ///See <a href="https://core.telegram.org/type/StatsGraph" />
    ///</summary>
    public MyTelegram.Schema.IStatsGraph WeekdaysGraph { get; set; }
    public TVector<MyTelegram.Schema.IStatsGroupTopPoster> TopPosters { get; set; }
    public TVector<MyTelegram.Schema.IStatsGroupTopAdmin> TopAdmins { get; set; }
    public TVector<MyTelegram.Schema.IStatsGroupTopInviter> TopInviters { get; set; }
    public TVector<MyTelegram.Schema.IUser> Users { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Period.Serialize(bw);
        Members.Serialize(bw);
        Messages.Serialize(bw);
        Viewers.Serialize(bw);
        Posters.Serialize(bw);
        GrowthGraph.Serialize(bw);
        MembersGraph.Serialize(bw);
        NewMembersBySourceGraph.Serialize(bw);
        LanguagesGraph.Serialize(bw);
        MessagesGraph.Serialize(bw);
        ActionsGraph.Serialize(bw);
        TopHoursGraph.Serialize(bw);
        WeekdaysGraph.Serialize(bw);
        TopPosters.Serialize(bw);
        TopAdmins.Serialize(bw);
        TopInviters.Serialize(bw);
        Users.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Period = br.Deserialize<MyTelegram.Schema.IStatsDateRangeDays>();
        Members = br.Deserialize<MyTelegram.Schema.IStatsAbsValueAndPrev>();
        Messages = br.Deserialize<MyTelegram.Schema.IStatsAbsValueAndPrev>();
        Viewers = br.Deserialize<MyTelegram.Schema.IStatsAbsValueAndPrev>();
        Posters = br.Deserialize<MyTelegram.Schema.IStatsAbsValueAndPrev>();
        GrowthGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        MembersGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        NewMembersBySourceGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        LanguagesGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        MessagesGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        ActionsGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        TopHoursGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        WeekdaysGraph = br.Deserialize<MyTelegram.Schema.IStatsGraph>();
        TopPosters = br.Deserialize<TVector<MyTelegram.Schema.IStatsGroupTopPoster>>();
        TopAdmins = br.Deserialize<TVector<MyTelegram.Schema.IStatsGroupTopAdmin>>();
        TopInviters = br.Deserialize<TVector<MyTelegram.Schema.IStatsGroupTopInviter>>();
        Users = br.Deserialize<TVector<MyTelegram.Schema.IUser>>();
    }
}