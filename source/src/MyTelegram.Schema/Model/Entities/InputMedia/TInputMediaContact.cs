﻿// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;


///<summary>
///See <a href="https://core.telegram.org/constructor/inputMediaContact" />
///</summary>
[TlObject(0xf8ab7dfb)]
public class TInputMediaContact : IInputMedia
{
    public uint ConstructorId => 0xf8ab7dfb;
    public string PhoneNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Vcard { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(PhoneNumber);
        bw.Serialize(FirstName);
        bw.Serialize(LastName);
        bw.Serialize(Vcard);
    }

    public void Deserialize(BinaryReader br)
    {
        PhoneNumber = br.Deserialize<string>();
        FirstName = br.Deserialize<string>();
        LastName = br.Deserialize<string>();
        Vcard = br.Deserialize<string>();
    }
}