using ZieDitApp.MVVM.Models;
using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp;

public partial class AccesProofView : ContentPage
{
    private readonly RegisterToEventViewModel viewModel;
	public AccesProofView(Event Event)
	{
		InitializeComponent();
        viewModel = new RegisterToEventViewModel();
        BindingContext = viewModel;
        viewModel.Event = Event;       
    }

    private void ShowQRcode_Clicked(object sender, EventArgs e)
    {
        viewModel.SetAccesCode();
        QrCodeImage.IsVisible = true;
    }
}