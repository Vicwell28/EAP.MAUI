using EAP.MAUI.Helpers.LogHelper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.ViewModels.ViewModelBase
{
	public class ViewModelBase : INotifyPropertyChanged, IViewModelBase
	{
		#region Fields
		private bool _isLoading;
		private string _errorMessage;
		#endregion


		#region Properties
		public bool IsLoading
		{
			get { return _isLoading; }
			set { _isLoading = value; OnPropertyChanged(); }
		}

		public string ErrorMessage
		{
			get { return _errorMessage; }
			set { _errorMessage = value; OnPropertyChanged(); }
		}
		#endregion


		#region Constructors
		public ViewModelBase()
		{
			
		}
		#endregion


		#region Methods
		public virtual void OnAppearing()
		{			
			Log.Info("ViewModelBase - OnAppearing");
		}

		public virtual void OnDisappearing()
		{	
			Log.Info("ViewModelBase - OnDisappearing");
		}

		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		#endregion


		#region Eventos
		public event PropertyChangedEventHandler PropertyChanged;
		#endregion
	}
}