using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using TipsNTricks.Views;
using Xamarin.Forms;

namespace TipsNTricks.ViewModels
{
    class GenPageViewModel : INotifyPropertyChanged
    {
        public string EnteredYear { get; set; }
        public ICommand ChangeLabelCommand { get; set; }

        public string GenerationResult { get; set; }
        public bool IsLabelVisible { get; set; }

        public GenPageViewModel()
        {
            IsLabelVisible = false;

            ChangeLabelCommand = new Command(async () =>
            {
                int YearInputed = Convert.ToInt32(EnteredYear);

                if( YearInputed <= 1964)
                {
                    GenerationResult = "Baby boomer or older";
                    await App.Current.MainPage.DisplayAlert("You are old now", $"Turns out you are a {GenerationResult}!!", "I've seen 3 wars");

                   
                }
                else if (YearInputed <= 1984)
                {
                GenerationResult = "Generation X";
                await App.Current.MainPage.DisplayAlert("You are kinda old now", $"Turns out you are a {GenerationResult}!!", "I'm in the prime of my life");


                }
                else if (YearInputed <= 1994)
                {
                    GenerationResult = "Millenial";
                    await App.Current.MainPage.DisplayAlert("You are the present of this world", $"Turns out you are a {GenerationResult}!!", "I have to be eco friendly or we'll die");


                }
                else
                {
                    GenerationResult = "Generation Z";
                    await App.Current.MainPage.DisplayAlert("You are the Future of this world", $"Turns out you are a {GenerationResult}!!", "I'm either stressed or drunk no in between");

                }
                IsLabelVisible = true;
            });
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
