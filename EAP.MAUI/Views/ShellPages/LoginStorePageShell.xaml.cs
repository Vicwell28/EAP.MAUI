using EAP.MAUI.ViewModels.ShopViewModels;

namespace EAP.MAUI.Views.ShellPages;

public partial class LoginStorePageShell : ContentPage
{
	public IViewModelBase ViewModelBase { get; set; }
	public LoginStorePageShell(LoginStoreShellViewModel LoginStoreShellViewModel)
	{
		InitializeComponent();
		this.ViewModelBase = LoginStoreShellViewModel;
		this.BindingContext = this.ViewModelBase;
	}

	protected override void OnAppearing()
	{
		base.OnAppearing();
		this.ViewModelBase.OnAppearing();
	}

	protected override void OnDisappearing()
	{
		base.OnDisappearing();
		this.ViewModelBase.OnDisappearing();
	}
}