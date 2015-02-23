using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace HomeControl.Droid
{
    [Activity(Label = "HomeControl", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            UpdateCurrentRotation();
            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }

        public override void OnConfigurationChanged(Android.Content.Res.Configuration newConfig)
        {
            base.OnConfigurationChanged(newConfig);
            UpdateCurrentRotation();
        }
 

        private void UpdateCurrentRotation()
        {
            switch (WindowManager.DefaultDisplay.Rotation)
            {
                case SurfaceOrientation.Rotation0:
                    Orientation.Rotation = Rotation.Rotation0;
                    break;
                case SurfaceOrientation.Rotation90:
                    Orientation.Rotation = Rotation.Rotation90;
                    break;
                case SurfaceOrientation.Rotation180:
                    Orientation.Rotation = Rotation.Rotation180;
                    break;
                case SurfaceOrientation.Rotation270:
                    Orientation.Rotation = Rotation.Rotation270;
                    break;
            }
        }
    }
}

