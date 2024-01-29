using ZieDitApp.MVVM.Views.Guest;

namespace ZieDitApp;

public partial class GuestHomeView : ContentPage
{
	public GuestHomeView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GuestRegistrations());
    }

    private void AllEventsBtn_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync( new GuestAllEventView());
    }
}