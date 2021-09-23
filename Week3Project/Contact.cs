using System;
namespace Week3Project
{
    public class Contact
    {
        public string name { get; set; }
        public string number { get; set; }
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
