using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace LoginPractice
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

        async private void LoginButton_Clicked(object sender, EventArgs e)
        {
            string User = Username.Text;
            string Pass = Password.Text;

            if(string.IsNullOrEmpty(User) || string.IsNullOrEmpty(Pass))
            {
                await DisplayAlert("Incomplete Login", "Username or Password incomplete, please try again", "OK");
            }
            else
            {
                await DisplayAlert("Welcome!", $"Hello {User} !", "OK");
            }
        }
    }
}
