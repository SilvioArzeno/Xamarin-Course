using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Week7Practice.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace Week7Practice.ViewModel
{
    class MainPageViewModel: INotifyPropertyChanged
    {
        DeviceOrientation CurrentOrientation { get; set; }

        String Orientation { get; set; }

        Command GetOrientation { get; set; }

        public MainPageViewModel()  
        {
            GetOrientation = new Command(() =>
            {
                IDetectOrientation service = DependencyService.Get<IDetectOrientation>();
                CurrentOrientation = service.DetectOrientation();

                Orientation = CurrentOrientation == DeviceOrientation.Landscape ? "Landscape" : "Portrait";
                
            });
            Orientation = "Fail";
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
