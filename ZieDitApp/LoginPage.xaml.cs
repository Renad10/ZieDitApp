﻿using ZieDitApp.MVVM.Models;
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
                    Navigation.PushAsync(new GuestHomepage());
                }
            }
            else
            {
                DisplayAlert("Error", "incorrect email and password", "Ok");
            }
        }

        private void makeAccountButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MakeAccountPage());
        }
    }
}