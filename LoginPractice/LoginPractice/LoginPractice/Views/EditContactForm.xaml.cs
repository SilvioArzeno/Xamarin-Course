using LoginPractice.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginPractice.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EditContactForm : ContentPage
    {
        public EditContactForm(object EditContact)
        {
            InitializeComponent();
            BindingContext = EditContact as Contact;
        }

        private void SaveButton_Clicked(object sender, EventArgs e)
        {
            Contact AddedContact = BindingContext as Contact;

            MessagingCenter.Send(AddedContact, "AddNewContact");
            SQLiteConnection connection = new SQLiteConnection(App.DatabaseLocation);
            connection.CreateTable<Contact>();
            connection.Insert(AddedContact);
            connection.Close();
        }
    }
}