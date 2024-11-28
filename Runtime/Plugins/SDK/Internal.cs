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

#region API Method: getShopItems
            
private static TaskCompletionSource<string> getShopItemsCS;
[MonoPInvokeCallback(typeof(Action<int>))] private static void getShopItemsCallback(string val) => getShopItemsCS.TrySetResult(val);

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void getShopItems(Action<string> callback);
#else
private static void getShopItems(Action<string> cb) => cb(null);
#endif

public static Task<string> getShopItemsAsync()
{
    getShopItemsCS = new TaskCompletionSource<string>();
    getShopItems(getShopItemsCallback);
    return getShopItemsCS.Task;
}
#endregion

#region API Method: getBalance
            
            private static TaskCompletionSource<string> getBalanceCS;
            [MonoPInvokeCallback(typeof(Action<string>))] private static void getBalanceCallback(string val) => getBalanceCS.TrySetResult(val);

            #if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void getBalance(Action<string> callback);
            #else
            private static void getBalance(Action<string> cb) => cb(null);
            #endif

            public static Task<string> getBalanceAsync()
            {
                getBalanceCS = new TaskCompletionSource<string>();
                getBalance(getBalanceCallback);
                return getBalanceCS.Task;
            }
#endregion

#region API Method: buyShopItem
            
            private static TaskCompletionSource<string> buyShopItemCS;
            [MonoPInvokeCallback(typeof(Action<int>))] private static void buyShopItemCallback(string val) => buyShopItemCS.TrySetResult(val);

            #if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void buyShopItem(int itemId, Action<string> callback);
            #else
            private static void buyShopItem(int itemId, Action<string> cb) => cb(null);
            #endif

            public static Task<string> buyShopItemAsync(int itemId)
            {
                buyShopItemCS = new TaskCompletionSource<string>();
                buyShopItem(itemId, buyShopItemCallback);
                return buyShopItemCS.Task;
            }
#endregion

// Ready methods      
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string setShareParam(string param);
#else
            public static string setShareParam(string param) => null;
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getStartParam();
#else
            public static string getStartParam() => null;
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getVersion();
#else
            public static string getVersion() => null;
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getConfig();
#else
            public static string getConfig() => null;
#endif
            
// Emu methods
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern bool isAdRunning();
#else
            public static bool isAdRunning() => false;
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void reloadAd();
#else
            public static void reloadAd() {}
#endif
            
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void emuRequestAd();
#else
            public static void emuRequestAd() {}
#endif

        }
    }
}