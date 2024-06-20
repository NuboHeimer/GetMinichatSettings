///----------------------------------------------------------------------------
///   Module:       Get minichat settings
///   Author:       NuboHeimer (https://vkplay.live/nuboheimer)
///   Email:        nuboheimer@yandex.ru
///   Telegram:     t.me/nuboheimer
///   Version:      0.7.0
///----------------------------------------------------------------------------

using System;
using System.IO;
using Newtonsoft.Json;

public class CPHInline
{
    public MiniChatSettings ParseAllSettings()
    {
        string miniChatSettingsPath = args["miniChatSettingsPath"].ToString();
        string miniChatSettings = File.ReadAllText(miniChatSettingsPath);
        return JsonConvert.DeserializeObject<MiniChatSettings>(miniChatSettings);
    }

    public bool GetTwitchChannelName()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("twitchChannelName", data.Twitch.ChannelName);
        return true;
    }
    public bool GetTwitchAccessToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("twitchAccessToken", data.Twitch.AccessToken);
        return true;
    }
    public bool GetTwitchUserID()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("twitchUserID", data.Twitch.UserID);
        return true;
    }
    public bool GetTwitchLogin()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("twitchLogin", data.Twitch.Login);
        return true;
    }
    public bool GetYouTubeChannelID()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("youTubeChannelID", data.YouTube.ChannelID);
        return true;
    }
    public bool GetYouTubeCreatorChannelID()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("youTubeCreatorChannelID", data.YouTube.CreatorChannelID);
        return true;
    }
    public bool GetYouTubeAccessToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("youTubeAccessToken", data.YouTube.AccessToken);
        return true;
    }
    public bool GetYouTubeExpires()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("youTubeExpires", data.YouTube.Expires);
        return true;
    }
    public bool GetYouTubeRefreshToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("youTubeRefreshToken", data.YouTube.RefreshToken);
        return true;
    }
    public bool GetGoodGameChannelKey()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("goodGameChannelKey", data.GoodGame.ChannelKey);
        return true;
    }
    public bool GetGoodGameToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("goodGameToken", data.GoodGame.Token);
        return true;
    }
    public bool GetGoodGameAccessToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("goodGameAccessToken", data.GoodGame.AccessToken);
        return true;
    }
    public bool GetGoodGameUserID()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("goodGameUserID", data.GoodGame.UserID);
        return true;
    }
    public bool GetDonationAlertsToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("donationAlertsToken", data.DonationAlertsToken);
        return true;
    }
    public bool GetVKPlayBlogUrl()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("vkPlayBlogUrl", data.VKPlay.BlogUrl);
        return true;
    }
    public bool GetVKPlayClientID()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("vkPlayClientID", data.VKPlay.ClientID);
        return true;
    }
    public bool GetVKPlayAccessToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("vkPlayAccessToken", data.VKPlay.AccessToken);
        return true;
    }
    public bool GetVKPlayRefreshToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("vkPlayRefreshToken", data.VKPlay.RefreshToken);
        return true;
    }
    public bool GetVKPlayExpiresAt()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("vkPlayExpiresAt", data.VKPlay.ExpiresAt);
        return true;
    }
    public bool GetBoostyBlogUrl()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("boostyBlogUrl", data.Boosty.BlogUrl);
        return true;
    }
    public bool GetBoostyClientID()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("boostyClientID", data.Boosty.ClientID);
        return true;
    }
    public bool GetBoostyAccessToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("boostyAccessToken", data.Boosty.AccessToken);
        return true;
    }
    public bool GetBoostyRefreshToken()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("boostyRefreshToken", data.Boosty.RefreshToken);
        return true;
    }
    public bool GetBoostyExpiresAt()
    {
        var data = ParseAllSettings();
        CPH.SetArgument("boostyExpiresAt", data.Boosty.ExpiresAt);
        return true;
    }

    public class MiniChatSettings
    {
        public TwitchData Twitch { get; set; }
        public YouTubeData YouTube { get; set; }
        public GoodGameData GoodGame { get; set; }
        public string DonationAlertsToken { get; set; }
        public VKPlayData VKPlay { get; set; }
        public BoostyData Boosty { get; set; }
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
    public class VKPlayData
    {
        public string BlogUrl { get; set; }
        public string ClientID { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiresAt { get; set; }
    }
    public class BoostyData
    {
        public string BlogUrl { get; set; }
        public string ClientID { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string ExpiresAt { get; set; }
    }
}