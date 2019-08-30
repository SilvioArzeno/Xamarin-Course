using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamClassApp.Models;

namespace XamClassApp.ViewModel
{
    public class AnimalsViewModel
    {
        public ICommand LoginCommand { get; set; }
        public Animal MyAnimal { get; set; }

        public AnimalsViewModel() 
        {
            MyAnimal = new Animal();
            MyAnimal.Name = "Giraffa";

            LoginCommand = new Command(() =>
           {

               MyAnimal.Name = "Elefante";

           });
        }
    }
}
