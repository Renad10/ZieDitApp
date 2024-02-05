using ZieDitApp.MVVM.Models;
using ZieDitApp.MVVM.Views.Employee;
using ZieDitApp.MVVM.Views.Guest;
using ZieDitApp.MVVM.Views.Organizer;

namespace ZieDitApp
{
    public partial class LoginPage : ContentPage
    {


        public LoginPage()
        {
            InitializeComponent();


        }
        
        private void logInButton_Clicked(object sender, EventArgs e)
        {
            string email = emailEntry.Text;
            string password = passwordEntry.Text;
            AppUser user = App.AppUserRepo.GetEntities().FirstOrDefault(u => u.email == email && u.password == password);
            if (user != null)
            {
                App.CurrentUserId = user.Id;
                if (user.role == "organizer")
                {
                    Navigation.PushAsync(new OrganizerHomePage());
                }
                if (user.role == "employee")
                {
                    Navigation.PushAsync(new EmployeeHomePage());
                }
                if (user.role == "guest")
                {
                    Navigation.PushAsync(new GuestHomeView());
                }
            }
            else
            {
                DisplayAlert("Error", "Onjuiste E-mailadres of Wachtwoord.", "Ok");
            }
        }
        private void OnShowPasswordToggled(object sender, ToggledEventArgs e)
        {
            passwordEntry.IsPassword = !e.Value;
        }

        private void makeAccountButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MakeAccountView());
        }

        private void forgotPasswordButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Melding", "Sorry deze feature is nog niet gerealiseerd", "OK");
        }

        private void CheckOrganisor_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (CheckOrganisor.IsChecked == true)
            {
                emailEntry.Text = "organizer@gmail.com";
                passwordEntry.Text = "1234";
            }
            if (CheckOrganisor.IsChecked == false) {
                emailEntry.Text = string.Empty;
                passwordEntry.Text = string.Empty;
            }
            
            
        }
    }
}