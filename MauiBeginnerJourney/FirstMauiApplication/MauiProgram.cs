using FirstMauiApplication.ViewModels;
using Microsoft.Extensions.Logging;

namespace FirstMauiApplication
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            /* This builder is very similar to the one from ASP.NET applications. 
             * Other configurations include activity lifecycles and services in the dependency service. */

            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            builder.Services.AddSingleton<IConnectivity>(Connectivity.Current);

            builder.Services.AddSingleton<MainPage>();
            builder.Services.AddSingleton<MainViewModel>();

            builder.Services.AddTransient<DetailPage>();
            builder.Services.AddTransient<DetailViewModel>();

            return builder.Build();
        }
    }
}
