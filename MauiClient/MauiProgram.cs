using MauiClient.Pages;
using MauiClient.Services;
using MauiClient.ViewModels;

namespace MauiClient;

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
            });

        builder.Services
            .AddHttpClient<MonkeyService>();

        builder.Services
            .AddSingleton<MasterViewModel>()
            .AddSingleton<MasterPage>();

        builder.Services
            .AddTransient<DetailViewModel>()
            .AddTransient<DetailPage>();

        return builder.Build();
    }
}