using ZieDitApp.MVVM.Models;

namespace ZieDitApp.MVVM.Views.Organizer;

public partial class MakeEmpAccountView : ContentPage
{
	public MakeEmpAccountView()
	{
		InitializeComponent();
	}

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        string firstName = firstNameEntry.Text;
        string lastName = lastNameEntry.Text;
        string email = emailEntry.Text;
        string password = passwordEntry.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            await DisplayAlert("Fout", "Alle velden moeten ingevuld worden.", "Ok");
        }
        else
        {
            AppUser employee = new AppUser() { firstName = firstName, lastName = lastName, email = email, password = password, role = "employee" };
            App.AppUserRepo.SaveEntity(employee);
            await DisplayAlert("Melding", "Account is succesvol aangemaakt.", "Ok");
            
        }
    }
}