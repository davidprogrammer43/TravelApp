using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace TravelApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            bool IsEmailAddressEmpty = string.IsNullOrEmpty(EmailAddressEntry.Text);
            bool IsPasswordEmpty = string.IsNullOrEmpty(PasswordEntry.Text);

            if (IsEmailAddressEmpty == true || IsPasswordEmpty == true)
            {
                DisplayAlert(Title = " Invalid Entry.", "Login Failed", "Press OK");

            }
            else
            {
                DisplayAlert(Title = " User: Logged in", "Login Successfull", "Press OK");
                Navigation.PushAsync(new HomePage());
            }

        }
    }
}