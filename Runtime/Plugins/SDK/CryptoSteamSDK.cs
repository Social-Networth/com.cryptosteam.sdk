using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using UnityEngine;

namespace CryptoSteam
{
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class Profile
    {
        public string id;
        public string name;
        public string avatar;
    }
    
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class Config
    {
        public string orientation;
        public string[] supportedDevices;
    }
    
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class SDKAd
    {
        public bool is_available;
        public string url;
        public string mediaType;
        public double? durationS;
    }

    public static class SDKAdMediaType
    {
        public const string Image = "image";
        public const string Gif = "gif";
        public const string Video = "video";
    }
    
    public static partial class CryptoSteamSDK
    {
        public static Config GetConfig() => JsonUtility.FromJson<Config>(Internal.getConfig());
        public static async Task<bool> IsAdEnabledAsync() => await Internal.isAdEnabledAsync();
        public static async Task<Profile> GetProfileAsync() => JsonUtility.FromJson<Profile>(await Internal.getProfileAsync());
        public static string GetVersion() => Internal.getVersion();
        public static void TrackGameTimeTick() => Internal.trackGameTimeTick();
        public static async Task<string> GetBalanceAsync() => await Internal.getBalanceAsync();
        
        // New methods
        public static string GetStartParam() => Internal.getStartParam();
        
        // Not ready methods
        public static string CreateReceipt(double number, double amount) => Internal.createReceipt(number, amount);
        
        // Emu 
        public static void SimpleRequestAd() => Internal.emuRequestAd();
        public static bool IsAdRunning() => Internal.isAdRunning();
    }
}
