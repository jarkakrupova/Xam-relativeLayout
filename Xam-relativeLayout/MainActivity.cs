using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace Xam_relativeLayout
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.layout1);

            Toast.MakeText(this, "onCreate", ToastLength.Short).Show();
        }

        protected override void OnStart() {
            base.OnStart();
            Toast.MakeText(this, "OnStart", ToastLength.Short).Show();
        }

        protected override void OnResume() {
            base.OnResume();
            Toast.MakeText(this, "OnResume", ToastLength.Short).Show();
        }

        protected override void OnPause() {
            base.OnPause();
            Toast.MakeText(this, "OnPause", ToastLength.Short).Show();
        }

        protected override void OnStop() {
            base.OnStop();
            Toast.MakeText(this, "OnStop", ToastLength.Short).Show();
        }

        protected override void OnDestroy() {
            base.OnDestroy();
            Toast.MakeText(this, "OnDestroy", ToastLength.Short).Show();
        }

        protected override void OnRestart() {
            base.OnRestart();
            Toast.MakeText(this, "OnRestart", ToastLength.Short).Show();
        }

        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);
            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}