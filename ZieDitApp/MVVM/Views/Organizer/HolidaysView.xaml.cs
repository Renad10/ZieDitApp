using ZieDitApp.MVVM.Models.ApiModels;
using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Organizer;

public partial class HolidaysView : ContentPage
{
	private readonly HolidaysViewModels _viewModel;
	public HolidaysView()
	{
		InitializeComponent();
		_viewModel = new HolidaysViewModels();
		BindingContext = _viewModel;
	}


}