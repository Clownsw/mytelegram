﻿// ReSharper disable All

namespace MyTelegram.Schema.Help;

///<summary>
/// See <a href="https://corefork.telegram.org/constructor/help.PeerColors" />
///</summary>
[JsonDerivedType(typeof(TPeerColorsNotModified), nameof(TPeerColorsNotModified))]
[JsonDerivedType(typeof(TPeerColors), nameof(TPeerColors))]
public interface IPeerColors : IObject
{

}
