#nullable enable

using Newtonsoft.Json

namespace ATCSharpSDK.Websocket;

public record WsMessage
{
  public WsMessage(string command, object? data, string game)
  {
    Command = command;
    Data = data;
    Game = game;
  }

  [JsonProperty("command", Order=0)]
  public readonly string command;

  [JsonProperty("game", Order=10)]
  public readonly string Game;

  [JsonProperty("data", Order=20)]
  public readonly object? Data;
}
