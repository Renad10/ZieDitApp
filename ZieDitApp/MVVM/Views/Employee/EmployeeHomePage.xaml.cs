namespace ZieDitApp.MVVM.Views.Employee;

public partial class EmployeeHomePage : ContentPage
{
	public EmployeeHomePage()
	{
		InitializeComponent();
	}

    private void ControlAccessProofBtn_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new ControlProofAccessView());	
    }
}