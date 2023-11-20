using EAP.MAUI.ViewModels.WelcomeViewModel;

namespace EAP.MAUI.Views.WelcomeView;

public partial class WelcomePage : ContentPage
{
	private readonly WelcomeViewModel welcomeViewModel;
	public WelcomePage(WelcomeViewModel welcomeViewModel)
	{
		InitializeComponent();
		this.welcomeViewModel = welcomeViewModel ?? throw new ArgumentNullException(nameof(welcomeViewModel));

		this.BindingContext = this.welcomeViewModel;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
	}
}