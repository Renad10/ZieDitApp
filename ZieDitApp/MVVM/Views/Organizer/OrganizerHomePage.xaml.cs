namespace ZieDitApp.MVVM.Views.Organizer;

public partial class OrganizerHomePage : ContentPage
{
	public OrganizerHomePage()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new MakeEventView());
    }

    private void AllEventsButton_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new AllEventsView());
    }

    private void MakeEmployeeAccountPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new MakeEmpAccountView());
    }

    private void LinkEmpToEventPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new LinkEmpToEventView());
    }
}