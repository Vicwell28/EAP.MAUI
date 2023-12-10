using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Views.ShellPages;

namespace EAP.MAUI
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
			MainPage = new HomeStorePageShell();
		}

		protected override void OnStart()
		{
			base.OnStart();
			// Lógica al iniciar la app
			Log.Info("App : OnStart");
		}
		protected override void OnSleep()
		{
			base.OnSleep();
			// Lógica al entrar en estado de suspensión
			Log.Info("App : OnSleep");
		}

		protected override void OnResume()
		{
			base.OnResume();
			// Lógica al reanudar la app
			Log.Info("App : OnResume");
		}
	}
}