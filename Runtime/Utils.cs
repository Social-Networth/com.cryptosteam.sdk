using UnityEngine;

namespace CryptoSteam.Utils
{
    public static class Utils
    {
        public static async void PrintDebugLogs()
        {
            Debug.Log($"Host: {Window.Location.Host}");
            Debug.Log($"GetVersion: {CryptoSteamSDK.GetVersion()}");
            Debug.Log($"CreateReceipt: {CryptoSteamSDK.CreateReceipt()}");
            Debug.Log($"IsAdEnabled: {await CryptoSteamSDK.IsAdEnabledAsync()}");
            Debug.Log("GetConfig:\n" + JsonUtility.ToJson(CryptoSteamSDK.GetConfig(), true));
            Debug.Log("GetProfile:\n" + JsonUtility.ToJson(await CryptoSteamSDK.GetProfileAsync(), true));
            Debug.Log("IsAdRunning:\n" + CryptoSteamSDK.IsAdRunning());
        }
    }
}