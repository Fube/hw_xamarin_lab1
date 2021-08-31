using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App1
{
    public partial class MainPage : ContentPage
    {
        private int count;
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnIncrease_Clicked(object sender, EventArgs e)
        {
            count++;
            lblValue.Text = count.ToString();
        }

        private void btnDecrease_Clicked(object sender, EventArgs e)
        {
            count--;
            lblValue.Text = count.ToString();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            display.Text = $"{e.NewTextValue}'s Counter";
        }
    }
}
