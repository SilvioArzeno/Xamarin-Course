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
    class RegisterViewModel : INotifyPropertyChanged
    {
        public Registration CurrentRegistration { get; set; }

        public ICommand RegisterCommand { get; set; }
        public string ErrorMessage { get; set; }
        public bool ShowErrorMessage { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public RegisterViewModel()
        {
            CurrentRegistration = new Registration();

            RegisterCommand = new Command(ValidateRegistration); 

        }

        private void ValidateRegistration(object sender)
        {

            if(string.IsNullOrEmpty(CurrentRegistration.UserName) || string.IsNullOrEmpty(CurrentRegistration.Email) || string.IsNullOrEmpty(CurrentRegistration.Password) || string.IsNullOrEmpty(CurrentRegistration.ConfirmPassword))
            {
                ErrorMessage = "Please fill all the fields";
                ShowErrorMessage = true;
            }

            else if (!string.Equals(CurrentRegistration.ConfirmPassword, CurrentRegistration.Password))
            {
                ErrorMessage = "Confirm password invalid, please try again";
                ShowErrorMessage = true;
            }

            else
            {
                ShowErrorMessage = false;
                App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }
        }
    }
}
