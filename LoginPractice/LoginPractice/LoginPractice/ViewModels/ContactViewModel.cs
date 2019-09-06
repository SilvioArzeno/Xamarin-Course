using LoginPractice.Models;
using LoginPractice.Views;
using SQLite;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace LoginPractice.ViewModels
{
    class ContactViewModel :INotifyPropertyChanged
    {
        public Contact CurrentContact { get; set; }
        public ObservableCollection<Contact> ContactList { get; set; }

        public ICommand NewContactCommand { get; set; }
        public ICommand AddContactCommand { get; set; }
        public ICommand OnMoreCommand { get; set; }
        public ICommand DeleteContactCommand { get; set; }
        public Contact TappedContact
        {
            get
            {
                return CurrentContact;
            }
            set
            {
                CurrentContact = value;

                if (CurrentContact != null)
                    OnSelectItem(CurrentContact);

            }
        }

        private void OnSelectItem(Contact tappedContact)
        {
            App.Current.MainPage.DisplayAlert($"{tappedContact.FirstName} {tappedContact.LastName}",
                $"Phone number: {tappedContact.PhoneNumber}", "Ok");
        }

        public ContactViewModel()
        {

            ContactList = new ObservableCollection<Contact>();
            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Contact>();
            ContactList = new ObservableCollection<Contact>(connection.Table<Contact>().ToList());
            connection.Close();

            AddContactCommand = new Command(AddNewContact);
            NewContactCommand = new Command(CreateNewContact);
            OnMoreCommand = new Command(DisplayMoreMenu);
            DeleteContactCommand = new Command(DeleteContact);
            MessagingCenter.Subscribe<Contact>(this,"AddNewContact",AddNewContact);

        }

        private void DeleteContact(object sender)
        {
            Contact SelectedContact = sender as Contact;
            ContactList.Remove(SelectedContact);
        }

        async private void  DisplayMoreMenu(object sender)
        {
            Contact SelectedContact = sender as Contact;
            string Action = await App.Current.MainPage.DisplayActionSheet("Options", "Cancel", null,$"Call {SelectedContact.PhoneNumber}", "Edit Contact");

            if(Action == "Edit Contact")
            {
                ContactList.Remove(SelectedContact); 
               await App.Current.MainPage.Navigation.PushModalAsync(new EditContactForm(SelectedContact));
            }
            else if (Action == $"Call {SelectedContact.PhoneNumber}")
            {
                Device.OpenUri(new Uri(String.Format($"tel:{SelectedContact.PhoneNumber}")));
            }
          
        }

        private void CreateNewContact(object sender)
        {
            App.Current.MainPage.Navigation.PushModalAsync(new ContactForm());
        }

        public event PropertyChangedEventHandler PropertyChanged;
      
        private void AddNewContact(object sender)
        {
            CurrentContact = sender as Contact;

            ContactList.Add(CurrentContact);
            App.Current.MainPage.Navigation.PopModalAsync();
        }

    }
}
