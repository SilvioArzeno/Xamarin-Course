using LoginPractice.Models;
using LoginPractice.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPractice.ViewModels
{
    public class UserViewModel : INotifyPropertyChanged
    {
        public ICommand LoginCommand { get; set; }
        public ICommand TappedRegisterCommand { get; set; }
        public ICommand RegisterCommand { get; set; }
        public User MyUser { get; set; }

        public string ErrorMessage { get; set; }

        public bool ShowErrorMessage { get; set; }
        public UserViewModel()  
        {
            MyUser = new User();

            
            LoginCommand = new Command(async() =>
            {
                if(String.IsNullOrEmpty(MyUser.UserName) || String.IsNullOrEmpty(MyUser.UserName))
                {
                    ErrorMessage = "Email or Password cannot be empty";
                    ShowErrorMessage = true;
                    
                }

                else
                {
                    ShowErrorMessage = false;
                  await  App.Current.MainPage.Navigation.PushAsync(new HomePage());
                }

            });

            TappedRegisterCommand = new Command(OnTappedRegister);
        }

        public event PropertyChangedEventHandler PropertyChanged;

       async void OnTappedRegister()
        {
            await App.Current.MainPage.Navigation.PushAsync(new RegisterPage());
        }

    }
}
