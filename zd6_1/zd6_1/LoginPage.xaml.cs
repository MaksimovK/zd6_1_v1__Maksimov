using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace zd6_1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        string login;
        string password;
        public LoginPage()
        {
            InitializeComponent();
        }
        private bool CheckFields(string _login, string _password)
        {
            if (string.IsNullOrWhiteSpace(_login))
            {
                DisplayAlert("Ошибка", "Поле логина пустое", "OK");
                return false;
            }
            if (string.IsNullOrWhiteSpace(_password))
            {
                DisplayAlert("Ошибка", "Поле пароля пустое", "OK");
                return false;
            }
            if (_login.Length <= 4)
            {
                DisplayAlert("Ошибка", "Длина логина должна быть больше 4 символов", "OK");
                return false;
            }
            if (_password.Length <= 4)
            {
                DisplayAlert("Ошибка", "Длина пароля должна быть больше 4 символов", "OK");
                return false;
            }
            login = _login;
            password = _password;
            return true;
        }

        private async void LogButton_Clicked(object sender, EventArgs e)
        {
            if (CheckFields(loginEntry.Text, passwordEntry.Text))
            {
                await Navigation.PushAsync(new MainPage(login, password));
            }
        }

    }
}