using EAP.MAUI.ViewModels.LoginViewModels;
using EAP.MAUI.Views.BaseView;

namespace EAP.MAUI.Views.LoginView
{
	public partial class RegisterPage : BaseContentPage
	{
		public RegisterPage(RegisterViewModel registerViewModel) : base(registerViewModel)
		{
			InitializeComponent();
		}
	}
}