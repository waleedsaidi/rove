using Microsoft.Maui.Controls.Hosting;
using Microsoft.Maui.Hosting;

namespace Rova.Mobile
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
                    // Add custom fonts here if needed
                });

            // Register services here
            // e.g., builder.Services.AddSingleton<IAuthService, AuthService>();

            return builder.Build();
        }
    }
}