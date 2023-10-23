using EAP.MAUI.Views.LoginView;

namespace EAP.MAUI.Views.ShellPages
{
	public partial class LoginPageShell : Shell
	{
		public LoginPageShell()
		{
			InitializeComponent();
			Routing.RegisterRoute("IntroPage", typeof(IntroPage));
			Routing.RegisterRoute("LoginPage", typeof(LoginPage));
			Routing.RegisterRoute("RegisterPage", typeof(RegisterPage));
			Routing.RegisterRoute("TempView", typeof(TempView));
			Routing.RegisterRoute("Otra", typeof(Otra));
		}
	}
}