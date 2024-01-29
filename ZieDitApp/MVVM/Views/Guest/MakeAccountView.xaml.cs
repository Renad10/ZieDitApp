using ZieDitApp.MVVM.Models;

namespace ZieDitApp.MVVM.Views.Guest;

public partial class MakeAccountView : ContentPage
{
	public MakeAccountView()
	{
		InitializeComponent();
	}

    private async void RegisterButton_Clicked(object sender, EventArgs e)
    {
        string firstName= firstNameEntry.Text;
        string lastName= lastNameEntry.Text;
        string email = emailEntry.Text;
        string password = passwordEntry.Text;

        if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
        {
            await DisplayAlert("Fout", "Alle velden moeten ingevuld worden.", "Ok");
        }
        else
        {
            AppUser guest = new AppUser() { firstName = firstName, lastName = lastName, email = email, password = password, role = "guest" };
            App.AppUserRepo.SaveEntity(guest);
            await DisplayAlert("Melding", "Account is succesvol aangemaakt.", "Ga naar login pagina");
            await Navigation.PushAsync(new LoginPage());
        }
    }

    private void OnShowPasswordToggled(object sender, ToggledEventArgs e)
    {
        passwordEntry.IsPassword = !e.Value;
    }

}