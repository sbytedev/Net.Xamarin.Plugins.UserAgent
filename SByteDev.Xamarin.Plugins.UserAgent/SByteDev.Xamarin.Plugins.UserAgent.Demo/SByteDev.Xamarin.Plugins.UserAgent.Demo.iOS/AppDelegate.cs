using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

namespace SByteDev.Xamarin.Plugins.UserAgent.Demo.iOS
{
    [Register(nameof(AppDelegate))]
    public class AppDelegate : FormsApplicationDelegate
    {
        private static void Main(string[] args)
        {
            UIApplication.Main(args, null, nameof(AppDelegate));
        }

        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            Forms.Init();

            LoadApplication(new App());

            return base.FinishedLaunching(app, options);
        }
    }
}