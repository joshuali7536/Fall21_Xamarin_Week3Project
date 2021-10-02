using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Week3Project
{
    public partial class dateCell : ViewCell
    {
        public static readonly BindableProperty mylabelProperty =
            BindableProperty.Create("mylabel", typeof(string), typeof(dateCell));

        public string mylabel {
            get { return (string)GetValue(mylabelProperty); }
            set { SetValue(mylabelProperty, value); }
        }



        public static readonly BindableProperty mylabelColorProperty =
            BindableProperty.Create("mylabelColor", typeof(Color), typeof(dateCell));
            
        public Color mylabelColor
        {
            get { return (Color)GetValue(mylabelColorProperty); }
            set { SetValue(mylabelColorProperty, value); }
        }

        public dateCell()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
