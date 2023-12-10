using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EAP.MAUI.ViewModels.ShopViewModels
{
    public interface IViewModelBase
    {
		/// <summary>
		/// Suscribe a los eventos necesarios cuando el ViewModel está a punto de mostrarse.
		/// </summary>
		void SubscribeEvents();

		/// <summary>
		/// Anula la suscripción de eventos cuando el ViewModel está a punto de ocultarse.
		/// </summary>
		void UnSubscribeEvents();

		/// <summary>
		/// Se ejecuta cuando el ViewModel está a punto de aparecer en la vista.
		/// </summary>
		void OnAppearing();

		/// <summary>
		/// Se ejecuta cuando el ViewModel está a punto de desaparecer de la vista.
		/// </summary>
		void OnDisappearing();

		/// <summary>
		/// Se ejecuta cuando el ViewModel se crea.
		/// </summary>
		void Initialize();
	}
}
