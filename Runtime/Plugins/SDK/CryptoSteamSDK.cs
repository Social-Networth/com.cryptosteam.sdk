using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading.Tasks;
using UnityEngine;

namespace CryptoSteam
{
    /// <summary>
    /// Represents a user profile in the CryptoSteam SDK.
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class UserProfile
    {
        /// <summary>
        /// The unique identifier of the user.
        /// </summary>
        public ulong id;
        //
        // /// <summary>
        // /// Indicates whether the user is an administrator.
        // /// </summary>
        // public bool is_admin;

        /// <summary>
        /// The total experience points the user has earned.
        /// </summary>
        public ulong experience;

        /// <summary>
        /// The username of the user.
        /// </summary>
        public string user_name;

        /// <summary>
        /// The first name of the user.
        /// </summary>
        public string first_name;

        /// <summary>
        /// The last name of the user.
        /// </summary>
        public string last_name;

        /// <summary>
        /// The URL of the user's avatar image.
        /// </summary>
        public string avatar;
        //
        // /// <summary>
        // /// The user's account balance.
        // /// </summary>
        // public ulong balance;
        //
        // /// <summary>
        // /// Indicates whether the user's account is free from advertisements.
        // /// </summary>
        // public bool ads_free;
        //
        // /// <summary>
        // /// The number of games associated with the user.
        // /// </summary>
        // public ulong games_count;
        //
        // /// <summary>
        // /// The number of users the current user has invited.
        // /// </summary>
        // public ulong invited;

        // /// <summary>
        // /// The user's email address.
        // /// </summary>
        // public string email;
        //
        // /// <summary>
        // /// The user's phone number.
        // /// </summary>
        // public string phone_number;
        //
        // /// <summary>
        // /// The user's location or address.
        // /// </summary>
        // public string location;
        //
        // /// <summary>
        // /// The user's date of birth.
        // /// </summary>
        // public string birth_date;
    }


    /// <summary>
    /// Represents the configuration of game
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class GameConfig
    {
        /// <summary>
        /// The orientation of the application ('landscape' | 'portrait' | 'fullscreen').
        /// </summary>
        public string[] supported_screen_formats;

        /// <summary>
        /// A list of supported devices for the application.
        /// </summary>
        public string[] supported_devices;
    }
    
    /// <summary>
    /// Represents an item in the CryptoSteam SDK shop.
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ShopItem
    {
        /// <summary>
        /// The unique identifier of the shop item.
        /// </summary>
        public int id;

        /// <summary>
        /// The name of the shop item.
        /// </summary>
        public string name;

        /// <summary>
        /// The description of the shop item.
        /// </summary>
        public string description;

        /// <summary>
        /// The price of the shop item.
        /// </summary>
        public int price;

        /// <summary>
        /// The date and time when the shop item was created.
        /// </summary>
        public DateTime created;

        /// <summary>
        /// The date and time when the shop item was last updated.
        /// </summary>
        public DateTime updated;
        
        /// <summary>
        /// Quantity of purchased items
        /// </summary>
        public int quantity;
    }

    /// <summary>
    /// Represents the response from creating an invoice.
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class InvoiceResponse
    {
        /// <summary>
        /// The link to the created invoice.
        /// </summary>
        public string invoice_link;
    }

    /// <summary>
    /// Represents achievement
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class Achievement
    {
        /// <summary>
        /// Achievement ID
        /// </summary>
        public uint id;
        /// <summary>
        /// Achievement name
        /// </summary>
        public string name;
        
        /// <summary>
        /// Achievement description
        /// </summary>
        public string description;
        
        /// <summary>
        /// Achieved status
        /// </summary>
        public bool achieved;
        
        /// <summary>
        /// Icon url
        /// </summary>
        public string icon;
    }
    
    /// <summary>
    /// Represents the response from get shop items
    /// </summary>
    [Serializable]
    [SuppressMessage("ReSharper", "UnusedMember.Global")]
    [SuppressMessage("ReSharper", "InconsistentNaming")]
    public class ShopItemsResponse
    {
        /// <summary>
        /// List of shop items.
        /// </summary>
        public ShopItem[] items;
    }

    /// <summary>
    /// Provides various methods for interacting with the CryptoSteam SDK.
    /// </summary>
    public static partial class CryptoSteamSDK
    {
        /// <summary>
        /// Retrieves the configuration for loaded game
        /// </summary>
        /// <returns>The configuration of game.</returns>
        public static GameConfig GetConfig() => JsonUtility.FromJson<GameConfig>(Internal.getConfig());

        /// <summary>
        /// Checks if advertisements are enabled.
        /// </summary>
        /// <returns>True if ads are enabled; otherwise, false.</returns>
        public static async Task<bool> IsAdEnabled() => await Internal.isAdEnabledAsync();

        /// <summary>
        /// Retrieves the user's profile.
        /// </summary>
        /// <returns>The user's profile.</returns>
        public static async Task<UserProfile> GetProfile() => JsonUtility.FromJson<UserProfile>(await Internal.getProfileAsync());

        /// <summary>
        /// Retrieves the version of the SDK.
        /// </summary>
        /// <returns>The version string.</returns>
        public static string GetVersion() => Internal.getVersion();

        /// <summary>
        /// Retrieves the user's balance.
        /// </summary>
        /// <returns>The balance as a string.</returns>
        public static async Task<string> GetBalance() => await Internal.getBalanceAsync();

        /// <summary>
        /// Retrieves any start parameter of the application. Currently used for transferring multiplayer session IDs to games.
        /// </summary>
        /// <returns>The start parameter.</returns>
        public static string GetStartParam() => Internal.getStartParam();

        /// <summary>
        /// Shares any parameter via the Telegram Share API. Currently used for sharing links to games with multiplayer session ID.
        /// </summary>
        /// <param name="param">The parameter to share.</param>
        /// <returns>A result indicating the status of the operation.</returns>
        public static string Share(string param) => Internal.showSharing(param);
        
        /// <summary>
        /// Tracks a custom game event. For example level completions or level ups.
        /// </summary>
        /// <param name="eventName">Any custom name. E.g. level_completed</param>
        /// <param name="eventData">Any related data. E.g. completed level name</param>
        public static void TrackGameEvent(string eventName, string eventData) {}

        /// <summary>
        /// Creates an invoice.
        /// </summary>
        /// <param name="title">The title of the invoice.</param>
        /// <param name="description">The description of the invoice.</param>
        /// <param name="amount">The amount for the invoice.</param>
        /// <returns>The response from the invoice creation.</returns>
        public static async Task<InvoiceResponse> CreateInvoice(string title, string description, decimal amount) => null;

        /// <summary>
        /// Retrieves all shop items.
        /// </summary>
        /// <returns>A list of shop items.</returns>
        public static async Task<ShopItemsResponse> GetShopItems()
        {
            return JsonUtility.FromJson<ShopItemsResponse>(await Internal.getShopItemsAsync());
        }
        
        /// <summary>
        /// Retrieves purchased shop items.
        /// </summary>
        public static async Task<ShopItemsResponse> GetPurchasedShopItems()
        {
            return JsonUtility.FromJson<ShopItemsResponse>(await Internal.getPurchasedShopItemsAsync());
        }
        
        /// <summary>
        /// Buy shop item.
        /// </summary>
        /// <param name="itemId">ID of item</param>
        public static async Task BuyShopItem(int itemId) => await Internal.buyShopItemAsync(itemId);
        
        /// <summary>
        /// Requests an advertisement to be shown.
        /// </summary>
        public static void RequestAd() => Internal.emuRequestAd();

        /// <summary>
        /// Checks if an advertisement is currently running.
        /// </summary>
        /// <returns>True if an ad is running; otherwise, false.</returns>
        public static bool IsAdRunning() => Internal.isAdRunning();

        /// <summary>
        /// Reload active advertisement
        /// </summary>
        public static void ReloadAd() => Internal.reloadAd();
        
        /// <summary>
        /// Show share button for join new players into multiplayer session right from game overlay
        /// </summary>
        /// <param name="roomId">Your internal sessionId/roomId</param>
        public static void ShowSharing(string roomId) {}

        /// <summary>
        /// Get current user locale
        /// </summary>
        /// <returns>User locale</returns>
        public static string GetLocale() => null;
        
        /// <summary>
        /// Key-value storage (similar to PlayerPrefs). Set value.
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <param name="value">Value</param>
        public static void SetValue(string key, string value) {}

        /// <summary>
        /// Key-value storage (similar to PlayerPrefs). Get value.
        /// </summary>
        /// <param name="key">Unique key</param>
        /// <returns>Value or null if value not exist</returns>
        public static string GetValue(string key) => null;

        /// <summary>
        /// Unlock achievement/trophy for player
        /// </summary>
        /// <param name="id"></param>
        public static void SetAchievement(string id) {}

        /// <summary>
        /// Get all achievements available for game
        /// </summary>
        /// <returns></returns>
        public static Task<Achievement> GetAchievements() => null;
   
    }
}
