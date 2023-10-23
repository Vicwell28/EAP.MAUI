using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.ViewModels.ViewModelBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.Views.BaseView
{
	public class BaseContentPage : ContentPage
	{
		#region Fields
		private readonly IViewModelBase _viewModelBase;
		#endregion


		#region Properties
		#endregion


		#region Constructors
		public BaseContentPage(IViewModelBase viewModelBase)
		{
			_viewModelBase = viewModelBase ?? throw new ArgumentException(nameof(ViewModelBase));

			this.BindingContext = _viewModelBase;
		}
		#endregion


		#region Methods
		protected override void OnAppearing()
		{
			base.OnAppearing();
			_viewModelBase.OnAppearing();
			Log.Info("BasePage - OnAppearing");

		}

		protected override void OnDisappearing()
		{
			base.OnDisappearing();
			_viewModelBase.OnDisappearing();
			Log.Info("BasePage - OnDisappearing");

		}
		#endregion


		#region Eventos
		#endregion
	}
}