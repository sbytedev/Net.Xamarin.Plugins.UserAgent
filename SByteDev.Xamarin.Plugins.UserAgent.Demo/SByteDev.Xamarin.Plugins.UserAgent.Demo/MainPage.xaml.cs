using System;
using System.Threading;
using Xamarin.Forms;

namespace SByteDev.Xamarin.Plugins.UserAgent.Demo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        public async void OnButtonClicked(object sender, EventArgs args)
        {
            if (!UserAgentPlugin.IsSupported)
            {
                return;
            }

            _label.Text = await UserAgentPlugin.Instance.GetUserAgentAsync(CancellationToken.None);
        }
    }
}