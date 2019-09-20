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
using Week7Practice.Controls;
using Week7Practice.Droid.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ExportRenderer(typeof(MyEntry),typeof(MyEntryRendererDroid))]
namespace Week7Practice.Droid.Controls
{
    
    class MyEntryRendererDroid : EntryRenderer
    {
        [Obsolete]
        public MyEntryRendererDroid()
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if(Control != null)
            {
                Control.SetBackgroundColor(global::Android.Graphics.Color.Red);
            }
        }
    }
}