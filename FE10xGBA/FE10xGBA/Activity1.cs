﻿using Android.App;
using Android.Content.PM;
using Android.OS;
using Android.Views;

namespace Android_MonoGame_Test
{
    [Activity(Label = "FE10xGBA"
        , MainLauncher = true
        , Icon = "@drawable/icon"
        , Theme = "@style/Theme.Splash"
        , AlwaysRetainTaskState = true
        , LaunchMode = Android.Content.PM.LaunchMode.SingleInstance
        , ScreenOrientation = ScreenOrientation.Landscape //ScreenOrientation.SensorLandscape
        , ConfigurationChanges = ConfigChanges.Orientation | ConfigChanges.Keyboard | ConfigChanges.KeyboardHidden | ConfigChanges.ScreenSize)]
    public class Activity1 : Microsoft.Xna.Framework.AndroidGameActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            var g = new FE10xGBA.Game1(new string[0]);
            SetContentView((View)g.Services.GetService(typeof(View)));
            g.Run();
        }
    }
}

