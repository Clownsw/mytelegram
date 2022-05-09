﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/dialogFilterSuggested" />
///</summary>
[TlObject(0x77744d4a)]
public class TDialogFilterSuggested : IDialogFilterSuggested
{
    public uint ConstructorId => 0x77744d4a;

    ///<summary>
    ///See <a href="https://core.telegram.org/type/DialogFilter" />
    ///</summary>
    public MyTelegram.Schema.IDialogFilter Filter { get; set; }
    public string Description { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        Filter.Serialize(bw);
        bw.Serialize(Description);
    }

    public void Deserialize(BinaryReader br)
    {
        Filter = br.Deserialize<MyTelegram.Schema.IDialogFilter>();
        Description = br.Deserialize<string>();
    }
}