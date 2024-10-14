using UnityEngine;

namespace CryptoSteam.Utils
{
    public static class Utils
    {
        public static void PrintDebugLogs()
        {
            Debug.Log($"Host: {Window.Location.Host}");

            Debug.Log($"GetVersion: {CryptoSteamSDK.GetVersion()}");
            Debug.Log($"CreateReceipt: {CryptoSteamSDK.CreateReceipt()}");
            Debug.Log($"IsAdEnabled: {CryptoSteamSDK.IsAdEnabled()}");
            Debug.Log("GetConfig:\n" + JsonUtility.ToJson(CryptoSteamSDK.GetConfig(), true));
            Debug.Log("GetProfile:\n" + JsonUtility.ToJson(CryptoSteamSDK.GetProfile(), true));
            Debug.Log("IsAdRunning:\n" + JsonUtility.ToJson(CryptoSteamSDK.IsAdRunning(), true));
        }
    }
}