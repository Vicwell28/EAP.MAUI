namespace EAP.MAUI.Views.ShellPages;

public partial class LoginStorePageShell : Shell
{
	public IViewModelBase ViewModelBase { get; set; }
	public LoginStorePageShell(IViewModelBase StoreProducDetailtViewModel)
	{
		InitializeComponent();
		this.ViewModelBase = StoreProducDetailtViewModel;
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