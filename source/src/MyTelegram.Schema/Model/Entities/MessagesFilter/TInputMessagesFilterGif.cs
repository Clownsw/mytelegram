﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMessagesFilterGif" />
///</summary>
[TlObject(0xffc86587)]
public class TInputMessagesFilterGif : IMessagesFilter
{
    public uint ConstructorId => 0xffc86587;


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