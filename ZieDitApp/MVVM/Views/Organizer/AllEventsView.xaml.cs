using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Organizer;

public partial class AllEventsView : ContentPage
{
	private readonly AllEventsViewModel viewModel;
	public AllEventsView()
	{
		InitializeComponent();
		viewModel = new AllEventsViewModel();	
		BindingContext = viewModel;
	}



    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        viewModel.GetAllEmployees();
    }
}