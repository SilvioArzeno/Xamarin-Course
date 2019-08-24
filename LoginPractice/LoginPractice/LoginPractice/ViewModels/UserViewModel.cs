using LoginPractice.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPractice.ViewModels
{
    public class UserViewModel
    {
        public ICommand LoginCommand { get; set; }
        public User MyUser { get; set; }

        public UserViewModel()
        {
            MyUser = new User();
          
            LoginCommand = new Command(async () =>
            {
                if(String.IsNullOrEmpty(MyUser.UserName) || String.IsNullOrEmpty(MyUser.UserName))
                {
                    await App.Current.MainPage.DisplayAlert("Login failed!", "Username or password are incorrect", "Try Again");
                }

                else
                {
                    await App.Current.MainPage.DisplayAlert("Welcome!", $"Hello {MyUser.UserName} !", "OK");
                }

            });
        }
    }
}
