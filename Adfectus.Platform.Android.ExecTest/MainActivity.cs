#region Using

using Adfectus.Android;
using Adfectus.Common;
using Android.App;
using Android.OS;
using Android.Support.V7.App;

#endregion

namespace Adfectus.Platform.Android.ExecTest
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);

            AndroidPlatform.SetActivity(this);
            Engine.Setup<AndroidPlatform>(new EngineBuilder());
            Engine.Run();
        }
    }
}