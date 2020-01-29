using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TravelRecordApp.Model;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TravelRecordApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        // private async void RegisterButton_Clicked(object sender, EventArgs e)
        private void RegisterButton_Clicked(object sender, EventArgs e)
        {
            if (passwordEntry.Text == confirmPasswordEntry.Text)
            {
                Users user = new Users()
                {
                    Email = emailEntry.Text,
                    Password = passwordEntry.Text
                };
                Navigation.PushAsync(new HomePage());
                // await App.MobileService.GetTable<Users>().InsertAsync(user);
            }
            else
            {
                DisplayAlert("Error", "Passwords don't match", "Ok");
            }
        }
    }
}