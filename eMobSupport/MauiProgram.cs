using Microsoft.Extensions.Logging;

namespace eMobSupport
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
                    fonts.AddFont("ArialMdm.ttf", "ArialRegular");
                    fonts.AddFont("ArialCEBoldItalic.ttf", "ArialSemiboldItalic");
                });

#if DEBUG
    		builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
