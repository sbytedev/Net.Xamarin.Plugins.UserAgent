using Android.App;
using Android.Content.PM;
using Android.OS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

namespace SByteDev.Xamarin.Plugins.UserAgent.Demo.Android
{
    [Activity(
        Theme = "@style/Theme.AppCompat.Light.NoActionBar",
        MainLauncher = true,
        ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation
    )]
    public class MainActivity : FormsApplicationActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            Forms.Init(this, savedInstanceState);

            LoadApplication(new App());
        }
    }
}