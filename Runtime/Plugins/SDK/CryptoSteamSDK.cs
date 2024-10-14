using System;
using System.Diagnostics.CodeAnalysis;
using UnityEngine;
#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

namespace CryptoSteam
{
    [Serializable]
    public class CryptoSteamSDKProfile
    {
        public string id;
        public string name;
        public string avatar;
    }
    
    [Serializable]
    public class CryptoSteamSDKConfig
    {
        public string orientation;
        public string[] supportedDevices;
    }
    
    public static class CryptoSteamSDK
    {
        public static CryptoSteamSDKConfig GetConfig() => JsonUtility.FromJson<CryptoSteamSDKConfig>(Internal.getConfig());
        public static string CreateReceipt() => Internal.createReceipt();
        public static bool IsAdEnabled() => Internal.isAdEnabled();
        public static CryptoSteamSDKProfile GetProfile() => JsonUtility.FromJson<CryptoSteamSDKProfile>(Internal.getProfile());
        public static void TrackLaunch() => Internal.trackLaunch();
        public static string GetVersion() => Internal.getVersion();
        
        // New methods
        public static void RunAd() => Internal.runAd();
        public static bool IsAdRunning() => Internal.isAdRunning();
        
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private static class Internal
        {
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getConfig();
#else
            public static string getConfig() => null;
#endif
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string createReceipt();
#else
            public static string createReceipt() => null;
#endif
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern bool isAdEnabled();
#else
            public static bool isAdEnabled() => false;
#endif
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getProfile();
#else
            public static string getProfile() => null;
#endif
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void trackLaunch();
#else
            public static void trackLaunch() {}
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getVersion();
#else
            public static string getVersion() => null;
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void runAd();
#else
            public static void runAd() {}
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern bool isAdRunning();
#else
            public static bool isAdRunning() => false;
#endif
        }
        
        
    }
}
