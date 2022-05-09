﻿// ReSharper disable All

namespace MyTelegram.Schema;

public interface IInputPeerNotifySettings : IObject
{
    BitArray Flags { get; set; }
    bool? ShowPreviews { get; set; }
    bool? Silent { get; set; }
    int? MuteUntil { get; set; }
    string? Sound { get; set; }

}
