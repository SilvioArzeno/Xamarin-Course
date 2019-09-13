using LoginPractice.Models;
using LoginPractice.Services;
using Refit;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace LoginPractice.ViewModels
{
    class StudentSearchViewModel : INotifyPropertyChanged
    {
        public ICommand SearchAllStudentsCommand { get; set; }

        public ICommand SearchStudent { get; set; }
        public List<Student> AllStudents { get; set; }

        public Student MatchStudent { get; set; }

        public string matriculasearch { get; set; }


        public StudentSearchViewModel()
        {
            SearchAllStudentsCommand = new Command(async () => { AllStudents = await GetAllStudents(); });

            SearchStudent = new Command(async () => await GetStudentByMatricula(matriculasearch));
        }

        public event PropertyChangedEventHandler PropertyChanged;

        async Task<List<Student>> GetAllStudents() // A WORK IN PROGRESS
        {
            try
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    var AllStudentsAPI = RestService.For<INewbeeAPI>("https://api-newbee.herokuapp.com");
                    var Response = await AllStudentsAPI.GetAllStudents();
                    return Response;
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "You don't have internet connection", "Ok");
                    return null;
                }
            }
            catch (Exception)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Unable to connect to the server", "Ok");
                return null;
            }
        }

        async Task GetStudentByMatricula(string matricula)
        {
            try
            {
                var current = Connectivity.NetworkAccess;
                if (current == NetworkAccess.Internet)
                {
                    var StudentSearchAPI = RestService.For<INewbeeAPI>("https://api-newbee.herokuapp.com");
                    var response = await StudentSearchAPI.GetStudent(matricula);
                    MatchStudent = response;
                }
                else
                {
                    await App.Current.MainPage.DisplayAlert("Error", "You don't have internet connection", "Ok");

                }
            }
            catch (Exception)
            {
                await App.Current.MainPage.DisplayAlert("Error", "Unable to connect to the server", "Ok");

            }
        }
    }
}
