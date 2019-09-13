using LoginPractice.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPractice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class StudentSearch : ContentPage
    {
        public StudentSearch()
        {
            InitializeComponent();
            BindingContext = new StudentSearchViewModel();
        }
    }
}