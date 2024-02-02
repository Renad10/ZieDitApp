using System.Windows.Input;
using ZieDitApp.MVVM.Models;
using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Guest;

public partial class EventDetailsView : ContentPage
{
	private readonly RegisterToEventViewModel viewModel;
	
	public EventDetailsView(Event Event)
	{
		InitializeComponent();
		viewModel = new RegisterToEventViewModel();
		BindingContext = viewModel;
		viewModel.Event = Event;	
	}

    private async void Register_Clicked(object sender, EventArgs e)
    {
        bool userResponse = await DisplayAlert("Bevestiging", string.Format("Je gaat inschrijven voor {0} evnet", viewModel.Event.name), "Bevistigen", "Aanularen");

        if (userResponse)
        {
			viewModel.RegisterGuestForEvent.Execute(null);
		}
    }
}