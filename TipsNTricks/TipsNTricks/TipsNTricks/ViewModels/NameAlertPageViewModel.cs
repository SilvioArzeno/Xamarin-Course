using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TipsNTricks.Views;
using Xamarin.Forms;

namespace TipsNTricks.ViewModels
{

    class NameAlertPageViewModel : INotifyPropertyChanged
    {
        public string EnteredName { get; set; }
        public ICommand ChangeLabelCommand { get; set; }
        public bool IsLabelVisible { get; set; }

        public NameAlertPageViewModel()
        {
            IsLabelVisible = false;

            ChangeLabelCommand = new Command(async () =>
            {
                await App.Current.MainPage.DisplayAlert("Hello There!", $"Hello there {EnteredName}!!", "How do you know my name?");
                IsLabelVisible = true;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
