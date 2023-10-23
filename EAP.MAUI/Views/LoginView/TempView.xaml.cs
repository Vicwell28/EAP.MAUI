using EAP.MAUI.ViewModels.HomeViewModels;

namespace EAP.MAUI.Views.LoginView;

public partial class TempView : Shell
{
	public TempView(TemViewModel temViewModel)
	{
		InitializeComponent();
		this.BindingContext = temViewModel;
	}
}