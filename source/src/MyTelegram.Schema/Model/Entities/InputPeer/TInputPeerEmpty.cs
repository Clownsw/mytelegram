﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputPeerEmpty" />
///</summary>
[TlObject(0x7f3b18ea)]
public class TInputPeerEmpty : IInputPeer,IEmpty
{
    public uint ConstructorId => 0x7f3b18ea;


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