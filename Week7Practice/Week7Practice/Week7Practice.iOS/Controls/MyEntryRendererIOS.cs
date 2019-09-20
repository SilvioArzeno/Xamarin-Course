using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Week7Practice.Controls;
using Week7Practice.iOS.Controls;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;


[assembly: ExportRenderer(typeof(MyEntry), typeof(MyEntryRendererIOS))]
namespace Week7Practice.iOS.Controls
{
    class MyEntryRendererIOS : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Entry> e)
        {
            base.OnElementChanged(e);

            if (Control != null)
            {
                Control.BackgroundColor = UIColor.Blue;
            }
        }
       
    }
}