using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Models;
using EAP.MAUI.ViewModels.LoginViewModels;
using EAP.MAUI.Views.BaseView;
using System.Windows.Input;

namespace EAP.MAUI.Views.LoginView
{
	public partial class SplashPage : BaseContentPage
	{
		private LoginModel _loginModel;

		public SplashPage(SplashViewModels splashViewModels, LoginModel loginModel) : base(splashViewModels)
		{
			InitializeComponent();
			_loginModel = loginModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			_loginModel.Id = 0;
			_loginModel.Name = "Victor";
			_loginModel.Password = "Password";
			_loginModel.Email = "vicwell.bj@gmail.com";
			Log.Info("ENTRO");
		}

		#region Fields
		#endregion


		#region Properties
		#endregion


		#region Constructors
		#endregion


		#region Methods
		#endregion


		#region Eventos
		#endregion
	}
}