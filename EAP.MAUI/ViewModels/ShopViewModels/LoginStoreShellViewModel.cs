using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Services.ApiService;
using EAP.MAUI.Views.ShellPages;
using System.Windows.Input;

namespace EAP.MAUI.ViewModels.ShopViewModels
{
	public class LoginStoreShellViewModel : ShopViewModelBase
	{
		#region Fields
		private string email;
		private string password;
		#endregion

		#region Properties
		public string Email
		{
			get => email;
			set
			{
				email = value;
				OnPropertyChanged();
			}
		}

		public string Password
		{
			get => password;
			set
			{
				password = value;
				OnPropertyChanged();
			}
		}
		#endregion

		#region Services
		private readonly IApiService apiService;
		#endregion

		#region Commands
		public ICommand LoginCommand { get; }
		#endregion

		#region View
		public HomeStorePageShell HomeStorePageShell { get; set; }
		#endregion

		#region Constructor
		public LoginStoreShellViewModel(IApiService apiService, HomeStorePageShell HomeStorePageShell)
		{
			this.apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
			this.HomeStorePageShell = HomeStorePageShell ?? throw new ArgumentNullException(nameof(HomeStorePageShell));
			LoginCommand = new Command(OnLogin);
		}
		#endregion

		#region Lifecycle Methods
		public override void Initialize()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("LoginStoreShellViewModel OnAppearing");
		}

		public override void SubscribeEvents()
		{
			// Implementar suscripción a eventos aquí
			Log.Info("LoginStoreShellViewModel SubscribeEvents");
		}

		public override void UnSubscribeEvents()
		{
			// Implementar anulación de suscripción a eventos aquí
			Log.Info("LoginStoreShellViewModel UnSubscribeEvents");
		}

		public override void OnAppearing()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("LoginStoreShellViewModel OnAppearing");
		}

		public override void OnDisappearing()
		{
			// Implementar lógica de limpieza aquí
			Log.Info("LoginStoreShellViewModel OnDisappearing");
		}
		#endregion

		#region Private Methods
		private async void OnLogin()
		{
			var response = await this.apiService.StoreAsync("http://192.168.1.14:8000/api/login", new Dictionary<string, string> { { "email", Email }, { "password", Password } });
			this.Token = response["token"];
			Log.Info(this.Token);

			this.apiService.AddAuthorizationHeader(this.Token);

			App.Current.MainPage = this.HomeStorePageShell;
		}
		#endregion
	}
}
