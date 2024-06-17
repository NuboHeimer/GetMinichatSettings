///----------------------------------------------------------------------------
///   Module:       Get minichat settings
///   Author:       NuboHeimer (https://vkplay.live/nuboheimer)
///   Email:        nuboheimer@yandex.ru
///   Telegram:     t.me/nuboheimer
///   Version:      0.3.0
///----------------------------------------------------------------------------

using System;
using System.IO;
using Newtonsoft.Json;

public class CPHInline
{
    public string GetAllSettings()
    {
        string miniChatSettingsPath = args["miniChatSettingsPath"].ToString();
        string miniChatSettings = File.ReadAllText(miniChatSettingsPath);
        return miniChatSettings;
    }

    public bool GetTwitchChannelName()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("twitchChannelName", data.Twitch.ChannelName);
        return true;
    }
    public bool GetTwitchAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("twitchAccessToken", data.Twitch.AccessToken);
        return true;
    }
    public bool GetTwitchUserID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("twitchUserID", data.Twitch.UserID);
        return true;
    }
    public bool GetTwitchLogin()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("twitchLogin", data.Twitch.Login);
        return true;
    }
    public bool GetYouTubeChannelID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("YouTubeChannelID", data.YouTube.ChannelID);
        return true;
    }
    public bool GetYouTubeCreatorChannelID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("YouTubeCreatorChannelID", data.YouTube.CreatorChannelID);
        return true;
    }
    public bool GetYouTubeAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("YouTubeAccessToken", data.YouTube.AccessToken);
        return true;
    }
    public bool GetYouTubeExpires()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("YouTubeExpires", data.YouTube.Expires);
        return true;
    }
    public bool GetYouTubeRefreshToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("YouTubeRefreshToken", data.YouTube.RefreshToken);
        return true;
    }
    public bool GetGoodGameChannelKey()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("GoodGameChannelKey", data.GoodGame.ChannelKey);
        return true;
    }
    public bool GetGoodGameToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("GoodGameToken", data.GoodGame.Token);
        return true;
    }
    public bool GetGoodGameAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("GoodGameAccessToken", data.GoodGame.AccessToken);
        return true;
    }
    public bool GetGoodGameUserID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("GoodGameUserID", data.GoodGame.UserID);
        return true;
    }

    public class MiniChatSettings
    {
        public TwitchData Twitch { get; set; }
        public YouTubeData YouTube { get; set; }
        public GoodGameData GoodGame { get; set; }
    }

    public class TwitchData
    {
        public string ChannelName { get; set; }
        public string AccessToken { get; set; }
        public string UserID { get; set; }
        public string Login { get; set; }
    }
    public class YouTubeData
    {
        public string ChannelID { get; set; }
        public string CreatorChannelID { get; set; }
        public string AccessToken { get; set; }
        public string Expires { get; set; }
        public string RefreshToken { get; set; }
    }
    public class GoodGameData
    {
        public string ChannelKey { get; set; }
        public string Token { get; set; }
        public string AccessToken { get; set; }
        public string UserID { get; set; }
    }
}