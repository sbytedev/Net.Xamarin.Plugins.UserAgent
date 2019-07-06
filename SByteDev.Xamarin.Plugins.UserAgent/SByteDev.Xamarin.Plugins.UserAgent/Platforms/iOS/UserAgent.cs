using System;
using System.Threading;
using System.Threading.Tasks;
using CoreGraphics;
using Foundation;
using WebKit;

// ReSharper disable once CheckNamespace

namespace SByteDev.Xamarin.Plugins.UserAgent
{
    [Preserve(AllMembers = true)]
    internal sealed class UserAgent : NSObject, IUserAgent
    {
        private string _userAgent;

        public Task<string> GetUserAgentAsync(CancellationToken cancellationToken)
        {
            if (!string.IsNullOrWhiteSpace(_userAgent))
            {
                return Task.FromResult(_userAgent);
            }

            var taskCompletionSource = new TaskCompletionSource<string>();

            this.InvokeOnMainThreadIfNeeded(async () =>
            {
                try
                {
                    using (var webView = new WKWebView(CGRect.Empty, new WKWebViewConfiguration()))
                    {
                        webView.LoadHtmlString("<html></html>", null);

                        if (cancellationToken.IsCancellationRequested)
                        {
                            taskCompletionSource.TrySetCanceled();

                            return;
                        }

                        var userAgent = await webView
                            .EvaluateJavaScriptAsync("navigator.userAgent")
                            .ConfigureAwait(false);

                        _userAgent = userAgent as NSString;

                        taskCompletionSource.TrySetResult(_userAgent);
                    }
                }
                catch (Exception exception)
                {
                    taskCompletionSource.TrySetException(exception);
                }
            });

            return taskCompletionSource.Task;
        }
    }
}