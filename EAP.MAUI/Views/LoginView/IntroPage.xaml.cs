using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Models;
using EAP.MAUI.ViewModels.LoginViewModels;
using EAP.MAUI.Views.BaseView;

namespace EAP.MAUI.Views.LoginView
{
	public partial class IntroPage : BaseContentPage
	{
		private LoginModel _loginModel;
		public IntroPage(IntroViewModel introViewModel, LoginModel loginModel) : base(introViewModel)
		{
			InitializeComponent();
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
			Log.Info("ENTRO");
		}
	}
}