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
            
            #region Advertisement
            
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
            
            #region API Method: isAdRunning
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern bool isAdRunning();
#else
            public static bool isAdRunning() => false;
#endif
            #endregion
            
            #region API Method: reloadAd
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void reloadAd();
#else
            public static void reloadAd() {}
#endif
            #endregion
            
            #region API Method: requestAd
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void requestAd();
#else
            public static void requestAd() {}
#endif
            #endregion
            
            #endregion
            
            #region SDK Information
            
            #region API Method: getVersion
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getVersion();
#else
            public static string getVersion() => null;
#endif
            #endregion

            #endregion
            
            #region Per-App Information
            
            #region API Method: getConfig
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getConfig();
#else
            public static string getConfig() => null;
#endif
            #endregion
            
            #endregion
            
            #region User
            
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
            
            #region API Method: getLocale
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getLocale();
#else
            public static string getLocale() => null;
#endif
            #endregion
            
            #endregion
            
            #region Share
            
            #region API Method: getStartParam
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string getStartParam();
#else
            public static string getStartParam() => null;
#endif
            #endregion
            
            #region API Method: showSharing
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern string showSharing(string url, string text);
#else
            public static string showSharing(string url, string text) => null;
#endif
            #endregion
            
            
            #endregion
            
            #region IAP
            
            #region API Method: getPurchasedShopItems
            
            private static TaskCompletionSource<string> getPurchasedShopItemsCS;
            [MonoPInvokeCallback(typeof(Action<int>))] private static void getPurchasedShopItemsCallback(string val) => getPurchasedShopItemsCS.TrySetResult(val);

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void getPurchasedShopItems(Action<string> callback);
#else
            private static void getPurchasedShopItems(Action<string> cb) => cb(null);
#endif

            public static Task<string> getPurchasedShopItemsAsync()
            {
                getPurchasedShopItemsCS = new TaskCompletionSource<string>();
                getPurchasedShopItems(getPurchasedShopItemsCallback);
                return getPurchasedShopItemsCS.Task;
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
            
            #region API Method: openPurchaseConfirmModal
            
            private static TaskCompletionSource<string> openPurchaseConfirmModalCS;
            [MonoPInvokeCallback(typeof(Action<int>))] private static void openPurchaseConfirmModalCallback(string val) => openPurchaseConfirmModalCS.TrySetResult(val);

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void openPurchaseConfirmModal(int itemId, Action<string> callback);
#else
            private static void openPurchaseConfirmModal(int itemId, Action<string> cb) => cb(null);
#endif

            public static Task<string> openPurchaseConfirmModalAsync(int itemId)
            {
                openPurchaseConfirmModalCS = new TaskCompletionSource<string>();
                openPurchaseConfirmModal(itemId, openPurchaseConfirmModalCallback);
                return openPurchaseConfirmModalCS.Task;
            }
            #endregion

            
            #endregion
            
            #region PlayerPrefs
            
            #region API Method: setValue
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void setValue(string key, string value);
#else
            public static void setValue(string key, string value) {}
#endif
            #endregion
            
            #region API Method: getValue
            
            private static TaskCompletionSource<string> getValueCS;
            [MonoPInvokeCallback(typeof(Action<string>))] private static void getValueCallback(string val) => getValueCS.TrySetResult(val);

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void getValue(string key, Action<string> callback);
#else
            private static void getValue(string key, Action<string> cb) => cb(null);
#endif

            public static Task<string> getValueAsync(string key)
            {
                getValueCS = new TaskCompletionSource<string>();
                getValue(key, getValueCallback);
                return getValueCS.Task;
            }
            #endregion
            
            #region API Method: removeValue
#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")] public static extern void removeValue(string key);
#else
            public static void removeValue(string key) {}
#endif
            #endregion
            
            #endregion
            
            #region Achievements
            // not implemented
            #endregion
            
            #region Game Events
            // not implemented
            #endregion
         

        }
    }
}