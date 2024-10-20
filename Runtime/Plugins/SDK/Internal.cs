using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using AOT;
#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

namespace CryptoSteam
{
    public static partial class CryptoSteamSDK
    {
        [SuppressMessage("ReSharper", "InconsistentNaming")]
        private static class Internal
        {
            
#region API Method: isAdEnabled
            
            private static TaskCompletionSource<bool> isAdEnabledCS;
            [MonoPInvokeCallback(typeof(Action<int>))] private static void isAdEnabledCallback(bool val) => isAdEnabledCS.TrySetResult(val);

            #if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void isAdEnabled(Action<bool> callback);
            #else
            private static void isAdEnabled(Action<bool> cb) => cb(true);
            #endif

            public static Task<bool> isAdEnabledAsync()
            {
                isAdEnabledCS = new TaskCompletionSource<bool>();
                isAdEnabled(isAdEnabledCallback);
                return isAdEnabledCS.Task;
            }
#endregion
            
#region API Method: getProfile
            
            private static TaskCompletionSource<string> getProfileCS;
            [MonoPInvokeCallback(typeof(Action<int>))] private static void getProfileCallback(string val) => getProfileCS.TrySetResult(val);

            #if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void getProfile(Action<string> callback);
            #else
            private static void getProfile(Action<string> cb) => cb(null);
            #endif

            public static Task<string> getProfileAsync()
            {
                getProfileCS = new TaskCompletionSource<string>();
                getProfile(getProfileCallback);
                return getProfileCS.Task;
            }
#endregion





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