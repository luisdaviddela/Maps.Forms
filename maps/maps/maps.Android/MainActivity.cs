using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Plugin.Permissions;
using Android.Support.V4.App;
using Android;

namespace maps.Droid
{
    [Activity(Label = "maps", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            //bool permissionGranted = ActivityCompat.CheckSelfPermission(this, Manifest.Permission.AccessFineLocation) == PackageManager.PERMISSION_GRANTED;
            //if (ApplicationContext.CheckCallingOrSelfPermission(Android.Manifest.Permission.AccessFineLocation) == Android.Content.PM.Permission.Granted)
            //{

            //}
            bool permissionGranted = ApplicationContext.CheckCallingOrSelfPermission(Android.Manifest.Permission.AccessFineLocation) == Android.Content.PM.Permission.Granted;
            if (permissionGranted)
            {
                // {Some Code}
            }
            else
            {
                ActivityCompat.RequestPermissions(this, new String[] { Manifest.Permission.AccessFineLocation},1);
            }
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;
            Xamarin.FormsMaps.Init(this, savedInstanceState);
            base.OnCreate(savedInstanceState);
            global::Xamarin.Forms.Forms.Init(this, savedInstanceState);
            LoadApplication(new App());
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, Permission[] grantResults)
        {
            PermissionsImplementation.Current.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
        
    }
}