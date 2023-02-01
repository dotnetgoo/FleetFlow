using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Widget;

namespace FleetFlow.Mobile
{
    [Activity(Theme = "@style/Maui.SplashTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation | ConfigChanges.UiMode | ConfigChanges.ScreenLayout | ConfigChanges.SmallestScreenSize | ConfigChanges.Density)]
    public class MainActivity : MauiAppCompatActivity
    {
        protected override void OnCreate(Bundle? bundle)
        {
            // show hello world to text view component
            TextView textView = new TextView(this);
            textView.Text = "Hello World";
            SetContentView(textView);
            
        }
    }
}