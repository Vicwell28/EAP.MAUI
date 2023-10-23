using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Services.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EAP.MAUI.ViewModels.LoginViewModels
{
	public class IntroViewModel : ViewModelBase.ViewModelBase
	{
		#region Fields
		private readonly INavigationService _navigationService;
		#endregion


		#region Properties
		#endregion


		#region Constructors
		public IntroViewModel(INavigationService navigationService) : base()
		{
			_navigationService = navigationService ?? throw new ArgumentException(nameof(navigationService));

			this.RegisterCommands();
		}
		#endregion


		#region Methods
		public override void OnAppearing()
		{
			base.OnAppearing();
			Log.Info("IntroViewModel - OnAppearing");
		}

		public override void OnDisappearing()
		{
			base.OnDisappearing();
			Log.Info("IntroViewModel - OnDisappearing");
		}

		private void NextPage()
		{
			_navigationService.NavigateToAsync("TempView");
		}
		#endregion


		#region Command
		public ICommand NextCommand { get; private set; }

		private void RegisterCommands()
		{
			this.NextCommand = new Command(NextPage, () => !IsLoading);
		}
		#endregion


		#region Eventos
		#endregion
	}
}
