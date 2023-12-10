using EAP.MAUI.Helpers.LogHelper;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EAP.MAUI.ViewModels.ShopViewModels
{
	public class ShopViewModelBase : INotifyPropertyChanged, IQueryAttributable, IViewModelBase
    {
		public event PropertyChangedEventHandler PropertyChanged;
		public string Token { get; set; }

		private bool _isBusy;

		/// <summary>
		/// Indica si el ViewModel está ocupado, por ejemplo, realizando una operación asincrónica.
		/// </summary>
		public bool IsBusy
		{
			get => _isBusy;
			set
			{
				_isBusy = value;
				OnPropertyChanged();
			}
		}

		/// <summary>
		/// Se ejecuta cuando el ViewModel está a punto de aparecer en la vista.
		/// </summary>
		public virtual void Initialize()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("BaseViewModel OnAppearing");
		}

		/// <summary>
		/// Suscribe a los eventos necesarios cuando el ViewModel está a punto de mostrarse.
		/// </summary>
		public virtual void SubscribeEvents()
		{
			// Implementar suscripción a eventos aquí
			Log.Info("BaseViewModel SubscribeEvents");
		}

		/// <summary>
		/// Anula la suscripción de eventos cuando el ViewModel está a punto de ocultarse.
		/// </summary>
		public virtual void UnSubscribeEvents()
		{
			// Implementar anulación de suscripción a eventos aquí
			Log.Info("BaseViewModel UnSubscribeEvents");
		}

		/// <summary>
		/// Se ejecuta cuando el ViewModel está a punto de aparecer en la vista.
		/// </summary>
		public virtual void OnAppearing()
		{
			// Implementar lógica de inicialización aquí
			Log.Info("BaseViewModel OnAppearing");
		}

		/// <summary>
		/// Se ejecuta cuando el ViewModel está a punto de desaparecer de la vista.
		/// </summary>
		public virtual void OnDisappearing()
		{
			// Implementar lógica de limpieza aquí
			Log.Info("BaseViewModel OnDisappearing");
		}

		/// <summary>
		/// Notifica a las vistas sobre los cambios en las propiedades del ViewModel.
		/// </summary>
		/// <param name="propertyName">Nombre de la propiedad que cambió.</param>
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}

		/// <summary>
		/// Aplica los atributos de consulta obtenidos durante la navegación.
		/// </summary>
		/// <param name="query">Diccionario con los parámetros de consulta.</param>
		public virtual void ApplyQueryAttributes(IDictionary<string, object> query)
		{
			// Implementar lógica para manejar los atributos de consulta aquí
			Log.Info("BaseViewModel ApplyQueryAttributes");
		}
	}
}
