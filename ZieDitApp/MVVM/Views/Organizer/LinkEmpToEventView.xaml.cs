using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Organizer;

public partial class LinkEmpToEventView : ContentPage
{
	private readonly LinkEmpToEventViewModel _viewModel;
	public LinkEmpToEventView()
	{
		InitializeComponent();
		_viewModel = new LinkEmpToEventViewModel();
		BindingContext = _viewModel;	
	}
}