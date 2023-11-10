using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Models;
using EAP.MAUI.ViewModels.LoginViewModels;
using EAP.MAUI.Views.BaseView;

namespace EAP.MAUI.Views.LoginView
{
	public partial class LoginPage : ContentPage
	{
		LoginModel _loginModel;

		public LoginPage(LoginViewModel loginViewModel, LoginModel loginModel)
		{
			InitializeComponent();
			this.BindingContext = loginViewModel;
			_loginModel = loginModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			Log.Info(_loginModel.ToString());
			Log.Info(_loginModel.Id);
			Log.Info(_loginModel.Name);
			Log.Info(_loginModel.Email);
			Log.Info(_loginModel.EmailConfirmed);
		}
	}
}