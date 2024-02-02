
using ZieDitApp.MVVM.ViewModels;

namespace ZieDitApp.MVVM.Views.Employee;

public partial class ControlProofAccessView : ContentPage
{
    private readonly GuestInformationViewModel _viewModel;
	public ControlProofAccessView()
	{
		InitializeComponent();
        _viewModel = new GuestInformationViewModel();
        BindingContext = _viewModel;
    }



    private void cameraView_BarcodeDetected(object sender, Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            _viewModel.ScannedBarcode = args.Result[0].Text;
            _viewModel.GetEventAndGuest();
            
        });
    }

    private void cameraView_CamerasLoaded(object sender, EventArgs e)
    {
        if(cameraView.Cameras.Count > 0)
        {
            cameraView.Camera = cameraView.Cameras.First();
            MainThread.BeginInvokeOnMainThread(async () =>
            {

                await cameraView.StopCameraAsync();
                await cameraView.StartCameraAsync();
            });
        }
    }
}