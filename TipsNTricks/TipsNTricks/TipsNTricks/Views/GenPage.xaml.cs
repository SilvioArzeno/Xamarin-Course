using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TipsNTricks.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TipsNTricks.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class GenPage : ContentPage
    {
        public GenPage()
        {
            InitializeComponent();
            BindingContext = new GenPageViewModel();
        }
    }
}