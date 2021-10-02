using System;
using System.ComponentModel;

namespace Week3Project
{
    public class Contact : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        private string _name; // backing field
        private string _number;

        public string name {
            get { return _name; }
            set
            {
                if (value == _name) // Jone Jone
                    return;

                _name = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(name)));

            }
        }
        public string number {
            get { return _number; }
            set
            {
                if (value == _number)
                    return;

                _number = value;
                if (PropertyChanged != null)
                    PropertyChanged(this, new PropertyChangedEventArgs(nameof(number)));


            }

        }
        public string imageURL { get; set; }



        public Contact()
        {
        }

        public Contact(string n, string number, string image)
        {
            name = n;
            this.number = number;
            imageURL = image;
        }

    }
}
