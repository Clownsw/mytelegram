﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
///See <a href="https://core.telegram.org/method/invokeWithLayer" />
///</summary>
[TlObject(0xda9b0d0d)]
public sealed class RequestInvokeWithLayer : IRequest<IObject>
{
    public uint ConstructorId => 0xda9b0d0d;
    public int Layer { get; set; }
    public IObject Query { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Write(Layer);
        Query.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        Layer = br.ReadInt32();
        Query = br.Deserialize<IObject>();
    }
}
