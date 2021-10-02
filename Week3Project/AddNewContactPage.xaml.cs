using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Week3Project
{
    public partial class AddNewContactPage : ContentPage
    {
        ObservableCollection<Contact> sp_contacts;

        public AddNewContactPage(ObservableCollection<Contact> contacts)
        {
            InitializeComponent();
            sp_contacts = contacts;
            //number.Text = "The size is " + sp_contacts.Count;
        }

        void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
