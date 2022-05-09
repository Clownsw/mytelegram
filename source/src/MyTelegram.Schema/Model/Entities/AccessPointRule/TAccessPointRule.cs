// <auto-generated/>
// ReSharper disable All

namespace MyTelegram.Schema;

[TlObject(0x4679b65f)]
public class TAccessPointRule : IAccessPointRule
{
    public uint ConstructorId => 0x4679b65f;
    public string PhonePrefixRules { get; set; }
    public int DcId { get; set; }
    public TVector<TIpPort> Ips { get; set; }

    public void ComputeFlag()
    {

    }

    public void Serialize(BinaryWriter bw)
    {
        ComputeFlag();
        bw.Write(ConstructorId);
        bw.Serialize(PhonePrefixRules);
        bw.Write(DcId);
        Ips.Serialize(bw);
    }

    public void Deserialize(BinaryReader br)
    {
        PhonePrefixRules = br.Deserialize<string>();
        DcId = br.ReadInt32();
        Ips = br.Deserialize<TVector<TIpPort>>();
    }
}