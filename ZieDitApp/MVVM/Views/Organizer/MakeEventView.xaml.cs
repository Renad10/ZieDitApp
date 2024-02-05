using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Organizer;

public partial class MakeEventView : ContentPage
{
    private readonly MakeEventViewModel _viewModel;
    public MakeEventView()
    {
        InitializeComponent();
        _viewModel = new MakeEventViewModel();
        BindingContext = _viewModel;
    }

    private void ShowActivityEntires_Clicked(object sender, EventArgs e)
    {
        ChangeActivityControlsVisibility();
    }

    private void ChangeActivityControlsVisibility()
    {
        if (ActivityNameLabel.IsVisible)
        {
            ActivityNameLabel.IsVisible = false;
            ActivityDescriptionLabel.IsVisible = false;

            ActivityNameEntry.IsVisible = false;
            ActivityDescriptionEntry.IsVisible = false;
            
            ActivityStartTimeLabel.IsVisible = false;   
            ActivityStartTimeEntry.IsVisible = false;

            ActivityEndTimeLabel.IsVisible = false;
            ActivityEndTimeEntry.IsVisible = false;

            AddActivityToEvent.IsVisible = false;
        }
        else
        {
            ActivityNameLabel.IsVisible = true;
            ActivityDescriptionLabel.IsVisible = true;

            ActivityNameEntry.IsVisible = true;
            ActivityDescriptionEntry.IsVisible = true;

            ActivityStartTimeLabel.IsVisible = true;
            ActivityStartTimeEntry.IsVisible = true;

            ActivityEndTimeLabel.IsVisible = true;
            ActivityEndTimeEntry.IsVisible = true;

            AddActivityToEvent.IsVisible = true;
        }
    }
    private void MakeActivityEntriesEmpty()
    {
        ActivityNameEntry.Text = string.Empty;
        ActivityDescriptionEntry.Text = string.Empty;
        ActivityStartTimeEntry.Text = string.Empty;
        ActivityEndTimeEntry.Text = string.Empty;

    }
    private void AddActivityToEvent_Clicked(object sender, EventArgs e)
    {
        ChangeActivityControlsVisibility();
        MakeActivityEntriesEmpty();
        ShowConfirmation("Activity added for event", " This activity is now part of event", "Alright");

    }

    public async Task ShowConfirmation(string title, string info, string aight)
    {
        await DisplayAlert(title, info, aight);
    }
}