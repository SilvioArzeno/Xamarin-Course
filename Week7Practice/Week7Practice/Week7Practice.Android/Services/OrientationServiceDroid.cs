using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms.Internals;
using Week7Practice.Services;
using Xamarin.Forms;
using Week7Practice.Droid.Services;

[assembly: Dependency(typeof(OrientationServiceDroid))]
namespace Week7Practice.Droid.Services
{
    class OrientationServiceDroid : IDetectOrientation
    {
        public DeviceOrientation DetectOrientation()
        {
            IWindowManager windowManager = Android.App.Application.Context.GetSystemService(Context.WindowService).JavaCast<IWindowManager>();

            SurfaceOrientation CurrentOritentation = windowManager.DefaultDisplay.Rotation;

            bool isPortrait = CurrentOritentation == SurfaceOrientation.Rotation0 || CurrentOritentation == SurfaceOrientation.Rotation180;

            return isPortrait ? DeviceOrientation.Portrait : DeviceOrientation.Landscape;
        }
    }
}