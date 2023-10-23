using EAP.MAUI.Models;
using EAP.MAUI.Services.Navigation;
using EAP.MAUI.ViewModels.HomeViewModels;
using EAP.MAUI.ViewModels.LoginViewModels;
using EAP.MAUI.ViewModels.ViewModelBase;
using EAP.MAUI.Views.BaseView;
using EAP.MAUI.Views.HomeView;
using EAP.MAUI.Views.LoginView;
using Microsoft.Extensions.Logging;
using System.Net;

namespace EAP.MAUI
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
				.RegisterModels()
				.RegisterAppServices()
				.RegisterViewModels()
				.RegisterViews();

#if DEBUG
			builder.Logging.AddDebug();
#endif

			return builder.Build();
		}

		#region Models Registration
		/// <summary>
		/// Registra las vistas en el contenedor de inyección de dependencias.
		/// </summary>
		public static MauiAppBuilder RegisterModels(this MauiAppBuilder mauiAppBuilder)
		{
			// Registro de vistas.
			mauiAppBuilder.Services.AddSingleton<LoginModel>();

			return mauiAppBuilder;
		}
		#endregion

		#region View Registration
		/// <summary>
		/// Registra las vistas en el contenedor de inyección de dependencias.
		/// </summary>
		public static MauiAppBuilder RegisterViews(this MauiAppBuilder mauiAppBuilder)
		{
			// Registro de vistas.
			mauiAppBuilder.Services.AddTransient<BaseContentPage>();
			mauiAppBuilder.Services.AddTransient<Otra>();
			mauiAppBuilder.Services.AddTransient<Ultima>();
			
			mauiAppBuilder.Services.AddTransient<IntroPage>();
			mauiAppBuilder.Services.AddTransient<LoginPage>();
			mauiAppBuilder.Services.AddTransient<RegisterPage>();
			mauiAppBuilder.Services.AddTransient<SplashPage>();
			mauiAppBuilder.Services.AddTransient<HomeView>();
			mauiAppBuilder.Services.AddTransient<TempView>();

			return mauiAppBuilder;
		}
		#endregion

		#region ViewModel Registration
		/// <summary>
		/// Registra los ViewModels en el contenedor de inyección de dependencias.
		/// </summary>
		public static MauiAppBuilder RegisterViewModels(this MauiAppBuilder mauiAppBuilder)
		{
			// Registro de ViewModels.
			mauiAppBuilder.Services.AddTransient<ViewModelBase>();
			mauiAppBuilder.Services.AddTransient<IntroViewModel>();
			mauiAppBuilder.Services.AddTransient<LoginViewModel>();
			mauiAppBuilder.Services.AddTransient<RegisterViewModel>();
			mauiAppBuilder.Services.AddTransient<SplashViewModels>();
			mauiAppBuilder.Services.AddTransient<TemViewModel>();
			

			return mauiAppBuilder;
		}
		#endregion

		#region Service Registration
		/// <summary>
		/// Registra los servicios de la aplicación en el contenedor de inyección de dependencias.
		/// </summary>
		public static MauiAppBuilder RegisterAppServices(this MauiAppBuilder mauiAppBuilder)
		{
			// Configuración del cliente HTTP.
			var httpClientHandler = new HttpClientHandler();
			var httpClient = new HttpClient(httpClientHandler)
			{
				DefaultRequestVersion = HttpVersion.Version20,
				DefaultVersionPolicy = HttpVersionPolicy.RequestVersionOrLower,
				Timeout = TimeSpan.FromMinutes(4)
			};

			// Registro de servicios.
			mauiAppBuilder.Services.AddSingleton(httpClient);
			mauiAppBuilder.Services.AddSingleton<INavigationService, NavigationService>();

			return mauiAppBuilder;
		}
		#endregion
	}
}