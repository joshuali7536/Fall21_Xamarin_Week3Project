using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Week3Project
{
    public partial class ListPage : ContentPage
    {
        ObservableCollection<Contact> contacts =
    new ObservableCollection<Contact>
    {
                new Contact("Jone","4566","https://images.freeimages.com/images/small-previews/d1f/balloon-contest-1417733.jpg"),
                new Contact("Mary", "2222", "https://images.freeimages.com/images/small-previews/ffa/water-lilly-1368676.jpg")
    };
        public ListPage()
        {
            InitializeComponent();
            myList.ItemsSource = contacts;

        }

        void myList_ItemSelected(System.Object sender,
            Xamarin.Forms.SelectedItemChangedEventArgs e)
        {
            DisplayAlert("The selected contact", (e.SelectedItem as Contact).name, "OK");
        }

        void CallMenuItem_Clicked(System.Object sender,
            System.EventArgs e)
        {
           Contact selectedContact = ((sender as MenuItem).CommandParameter) as Contact;
            DisplayAlert("Calling ....", selectedContact.name,"OK");
        }

        void DeleteMenuItem_Clicked(System.Object sender, System.EventArgs e)
        {
            Contact selectedContact = ((sender as MenuItem).CommandParameter) as Contact;
            contacts.Remove(selectedContact);
        }
    }
}
