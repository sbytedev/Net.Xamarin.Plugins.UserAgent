using System.Threading;
using System.Threading.Tasks;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.UserAgent
{
    public interface IUserAgent
    {
        Task<string> GetUserAgentAsync(CancellationToken cancellationToken);
    }
}