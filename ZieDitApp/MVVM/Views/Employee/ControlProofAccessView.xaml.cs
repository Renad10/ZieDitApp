

namespace ZieDitApp.MVVM.Views.Employee;

public partial class ControlProofAccessView : ContentPage
{
	public ControlProofAccessView()
	{
		InitializeComponent();
       
    }



    private void cameraView_BarcodeDetected(object sender, Camera.MAUI.ZXingHelper.BarcodeEventArgs args)
    {
        MainThread.BeginInvokeOnMainThread(() =>
        {
            TestLbl.Text = args.Result[0].Text;
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