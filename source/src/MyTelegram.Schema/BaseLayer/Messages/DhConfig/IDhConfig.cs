﻿// ReSharper disable All

namespace MyTelegram.Schema.Messages;

///<summary>
/// Contains Diffie-Hellman key generation protocol parameters.
/// See <a href="https://corefork.telegram.org/constructor/messages.DhConfig" />
///</summary>
public interface IDhConfig : IObject
{
    ///<summary>
    /// Random sequence of bytes of assigned length
    ///</summary>
    byte[] Random { get; set; }
}
