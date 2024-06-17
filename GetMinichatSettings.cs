///----------------------------------------------------------------------------
///   Module:       Get minichat settings
///   Author:       NuboHeimer (https://vkplay.live/nuboheimer)
///   Email:        nuboheimer@yandex.ru
///   Telegram:     t.me/nuboheimer
///   Version:      0.6.0
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
        CPH.SetArgument("youTubeChannelID", data.YouTube.ChannelID);
        return true;
    }
    public bool GetYouTubeCreatorChannelID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("youTubeCreatorChannelID", data.YouTube.CreatorChannelID);
        return true;
    }
    public bool GetYouTubeAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("youTubeAccessToken", data.YouTube.AccessToken);
        return true;
    }
    public bool GetYouTubeExpires()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("youTubeExpires", data.YouTube.Expires);
        return true;
    }
    public bool GetYouTubeRefreshToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("youTubeRefreshToken", data.YouTube.RefreshToken);
        return true;
    }
    public bool GetGoodGameChannelKey()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("goodGameChannelKey", data.GoodGame.ChannelKey);
        return true;
    }
    public bool GetGoodGameToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("goodGameToken", data.GoodGame.Token);
        return true;
    }
    public bool GetGoodGameAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("goodGameAccessToken", data.GoodGame.AccessToken);
        return true;
    }
    public bool GetGoodGameUserID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("goodGameUserID", data.GoodGame.UserID);
        return true;
    }
    public bool GetDonationAlertsToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("donationAlertsToken", data.DonationAlertsToken);
        return true;
    }
    public bool GetVKPlayBlogUrl()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("vkPlayBlogUrl", data.VKPlay.BlogUrl);
        return true;
    }
    public bool GetVKPlayClientID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("vkPlayClientID", data.VKPlay.ClientID);
        return true;
    }
    public bool GetVKPlayAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("vkPlayAccessToken", data.VKPlay.AccessToken);
        return true;
    }
    public bool GetVKPlayRefreshToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("vkPlayRefreshToken", data.VKPlay.RefreshToken);
        return true;
    }
    public bool GetVKPlayExpiresAt()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("vkPlayExpiresAt", data.VKPlay.ExpiresAt);
        return true;
    }
    public bool GetBoostyBlogUrl()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("boostyBlogUrl", data.Boosty.BlogUrl);
        return true;
    }
    public bool GetBoostyClientID()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("boostyClientID", data.Boosty.ClientID);
        return true;
    }
    public bool GetBoostyAccessToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("boostyAccessToken", data.Boosty.AccessToken);
        return true;
    }
    public bool GetBoostyRefreshToken()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
        CPH.SetArgument("boostyRefreshToken", data.Boosty.RefreshToken);
        return true;
    }
    public bool GetBoostyExpiresAt()
    {
        var data = JsonConvert.DeserializeObject<MiniChatSettings>(GetAllSettings());
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