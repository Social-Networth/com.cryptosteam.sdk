using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;

namespace CryptoSteam
{
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class CryptoSteamSDKProfile
    {
        public string id;
        public string name;
        public string avatar;
    }
    
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    public class CryptoSteamSDKConfig
    {
        public string orientation;
        public string[] supportedDevices;
    }
    
    public static partial class CryptoSteamSDK
    {
        public static CryptoSteamSDKConfig GetConfig() => JsonUtility.FromJson<CryptoSteamSDKConfig>(Internal.getConfig());
        public static string CreateReceipt() => Internal.createReceipt();
        public static async Awaitable<bool> IsAdEnabledAsync() => await Internal.isAdEnabledAsync();
        public static async Awaitable<CryptoSteamSDKProfile> GetProfileAsync() => JsonUtility.FromJson<CryptoSteamSDKProfile>(await Internal.getProfileAsync());
        public static string GetVersion() => Internal.getVersion();
        
        // New methods
        public static void RunAd() => Internal.runAd();
        public static bool IsAdRunning() => Internal.isAdRunning();
    }
}
