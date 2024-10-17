#if UNITY_WEBGL && !UNITY_EDITOR
using System.Runtime.InteropServices;
#endif

namespace CryptoSteam.Utils
{
    public static class Window
    {
        public static class Location
        {
            public static string Host => LocationHost();
            public static string Hash => LocationHash();
            public static string Href => LocationHref();

            public static void RedirectRelative(string url) => SetLocationRelative(url);

            public static void RedirectRelativeWindow(string url) => SetLocationRelativeWindow(url);

            public static void Redirect(string url) => SetLocation(url);
            public static void RedirectWindow(string url) => SetLocationWindow(url);
            public static void Reload() => WindowReload();


#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern string LocationHref();
#else
            private static string LocationHref() => null;
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern string LocationHash();
#else
            private static string LocationHash() => null;
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern string LocationHost();
#else
            private static string LocationHost() => null;
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern void SetLocationRelative(string url);
#else
            private static void SetLocationRelative(string url) { }
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern void SetLocationRelativeWindow(string url);
#else
            private static void SetLocationRelativeWindow(string url) { }
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern void SetLocation(string url);
#else
            private static void SetLocation(string url) { }
#endif


#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern void SetLocationWindow(string url);
#else
            private static void SetLocationWindow(string url) { }
#endif

#if UNITY_WEBGL && !UNITY_EDITOR
            [DllImport("__Internal")]
            private static extern void WindowReload();
#else
            private static void WindowReload() { }
#endif
        }
    }
}
