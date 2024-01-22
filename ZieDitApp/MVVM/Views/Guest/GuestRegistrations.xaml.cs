namespace ZieDitApp;

public partial class GuestRegistrations : ContentPage
{
	public GuestRegistrations()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {

        Navigation.PushAsync(new AccesProofPage());

    }


}