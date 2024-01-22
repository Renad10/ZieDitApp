namespace ZieDitApp;

public partial class GuestHomepage : ContentPage
{
	public GuestHomepage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GuestRegistrations());
    }
}