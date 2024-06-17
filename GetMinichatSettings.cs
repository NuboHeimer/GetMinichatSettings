///----------------------------------------------------------------------------
///   Module:       Get minichat settings
///   Author:       NuboHeimer (https://vkplay.live/nuboheimer)
///   Email:        nuboheimer@yandex.ru
///   Telegram:     t.me/nuboheimer
///   Version:      0.1.0
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

    public class MiniChatSettings
    {
        public TwitchData Twitch { get; set; }
    }

    public class TwitchData
    {
        public string ChannelName { get; set; }
        public string AccessToken { get; set; }
        public string UserID { get; set; }
        public string Login { get; set; }
    }
}