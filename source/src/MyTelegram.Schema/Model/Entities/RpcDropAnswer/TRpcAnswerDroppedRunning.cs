﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


[TlObject(0xcd78e586)]
public class TRpcAnswerDroppedRunning : IRpcDropAnswer
{
    public uint ConstructorId => 0xcd78e586;


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