using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Week1Example
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            var ThisButton = (sender as Button);
            BottomLabel.TextColor = ThisButton.BackgroundColor;
        }
        private void TextEntry_TextChanged(object sender, TextChangedEventArgs e)
        {
            BottomLabel.Text = TextEntry.Text;
        }
    }
}
