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
    
    public static partial class CryptoSteamSDK
    {
        public static Config GetConfig() => JsonUtility.FromJson<Config>(Internal.getConfig());
        public static string CreateReceipt() => Internal.createReceipt();
        public static async Task<bool> IsAdEnabledAsync() => await Internal.isAdEnabledAsync();
        public static async Task<Profile> GetProfileAsync() => JsonUtility.FromJson<Profile>(await Internal.getProfileAsync());
        public static string GetVersion() => Internal.getVersion();
        
        // New methods
        public static void RunAd() => Internal.runAd();
        public static bool IsAdRunning() => Internal.isAdRunning();
    }
}
