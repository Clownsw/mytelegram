﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMessagesFilterRoundVideo" />
///</summary>
[TlObject(0xb549da53)]
public class TInputMessagesFilterRoundVideo : IMessagesFilter
{
    public uint ConstructorId => 0xb549da53;


    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);

    }

    public void Deserialize(BinaryReader br)
    {

    }
}