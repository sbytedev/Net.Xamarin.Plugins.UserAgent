using SByteDev.Xamarin.Plugins.Base;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.UserAgent
{
    public static class UserAgentPlugin
    {
        private static readonly Plugin<IUserAgent> Plugin;

        public static bool IsSupported => Plugin.IsSupported;

        public static IUserAgent Instance => Plugin.Instance;

        static UserAgentPlugin()
        {
            Plugin = new Plugin<IUserAgent>(() =>
            {
#if NETSTANDARD2_0
                return null;
#else
                return new UserAgent();
#endif
            });
        }
    }
}