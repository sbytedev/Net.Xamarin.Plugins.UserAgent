using System;
using System.Threading;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.UserAgent
{
    public static class UserAgentPlugin
    {
        private static readonly Lazy<IUserAgent> UserAgentLazy;

        public static bool IsSupported => UserAgentLazy.Value != null;

        public static IUserAgent Instance => UserAgentLazy.Value ?? throw CreateNotImplementedException();

        static UserAgentPlugin()
        {
            UserAgentLazy = new Lazy<IUserAgent>(CreateUserAgent, LazyThreadSafetyMode.PublicationOnly);
        }

        private static IUserAgent CreateUserAgent()
        {
#if NETSTANDARD2_0
            return null;
#else
            return new UserAgent();
#endif
        }

        private static Exception CreateNotImplementedException()
        {
            return new NotImplementedException(
                "This functionality is not implemented in the portable version of this assembly." +
                "You should reference the NuGet package from your main application project " +
                "in order to reference the platform-specific implementation.");
        }
    }
}