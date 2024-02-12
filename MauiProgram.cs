using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using AplicatieProiectMobil.Services;
using AplicatieProiectMobil.ViewModels;

namespace AplicatieProiectMobil
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                })
             .UseMauiCommunityToolkit();

            builder.Services.AddSingleton<CategoryService>();
            builder.Services.AddSingleton<PachetViewModel>();
            builder.Services.AddSingleton<Pachet>();



#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}