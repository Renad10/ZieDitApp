using System.Windows.Input;
using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Guest;

public partial class GuestAllEventView : ContentPage
{
	public readonly AllEventsViewModel _viewModel;
    
    public GuestAllEventView()
	{
		InitializeComponent();
		_viewModel = new AllEventsViewModel();
		BindingContext = _viewModel; 
    }
    

    private void DetailsSwipeItem_Clicked(object sender, EventArgs e)
    {
        Navigation.PushAsync(new EventDetailsView(_viewModel.SelectedEvent));
    }

}