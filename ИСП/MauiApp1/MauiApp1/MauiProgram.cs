using MauiApp1.Services;
using System;
using Microsoft.Extensions.Logging;
using MauiApp1.Entites;
using MauiApp1.Services;
using Microsoft.Maui.Controls;
using MauiApp1.Pages;

namespace MauiApp1;

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

        
        builder.Services.AddTransient<IDbService, SQLiteService>();
		builder.Services.AddSingleton<Lab3>();


        builder.Logging.AddDebug();

		return builder.Build();
	}
}
