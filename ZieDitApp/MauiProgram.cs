using Camera.MAUI;
using CommunityToolkit.Maui;
using Microsoft.Extensions.Logging;
using ZieDitApp.MVVM.Models;
using ZieDitApp.Repositories;
using ZXing.Net.Maui.Controls;

namespace ZieDitApp
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .UseMauiCameraView()
                .UseBarcodeReader()
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            builder.Services.AddSingleton<BaseRepository<AppUser>>();
            builder.Services.AddSingleton<BaseRepository<Event>>();
            builder.Services.AddSingleton<BaseRepository<Activity>>();
            builder.Services.AddSingleton<BaseRepository<EventAppUser>>();



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}