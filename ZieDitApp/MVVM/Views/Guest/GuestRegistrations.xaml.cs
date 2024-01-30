using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp;

public partial class GuestRegistrations : ContentPage
{
    private readonly RegisterToEventViewModel _viewModel;
	public GuestRegistrations()
	{
		InitializeComponent();
        _viewModel = new RegisterToEventViewModel();
        BindingContext = _viewModel;
	}


    private void AccesProofBtn_Clicked(object sender, EventArgs e)
    {
        
        Navigation.PushAsync(new AccesProofView(_viewModel.SelectedEvent));
    }
}