using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamClassApp.ViewModel;

namespace XamClassApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AnimalsPage : ContentPage
    {
        public AnimalsPage()
        {
            InitializeComponent();
            BindingContext = new AnimalsViewModel();
        }
    }
}