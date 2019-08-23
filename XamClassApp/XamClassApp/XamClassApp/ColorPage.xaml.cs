using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XamClassApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ColorPage : ContentPage
    {
        public ColorPage(string ColorName, Color BGColor)
        {
            InitializeComponent();
           
            ColorLabel.Text = ColorName;
            BackgroundColor = BGColor;
        }
    }
}