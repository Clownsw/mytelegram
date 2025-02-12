﻿// ReSharper disable All

namespace MyTelegram.Schema;

///<summary>
/// Contains information about a <a href="https://corefork.telegram.org/api/bots/webapps#named-bot-web-apps">named bot web app</a>.
/// See <a href="https://corefork.telegram.org/constructor/BotApp" />
///</summary>
[JsonDerivedType(typeof(TBotAppNotModified), nameof(TBotAppNotModified))]
[JsonDerivedType(typeof(TBotApp), nameof(TBotApp))]
public interface IBotApp : IObject
{

}
