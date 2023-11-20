using EAP.MAUI.Models;
using EAP.MAUI.Services.ApiService;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace EAP.MAUI.ViewModels.MovieViewModel
{
	public class MovieViewModel : IQueryAttributable, INotifyPropertyChanged
	{
		private readonly IApiService apiService;
		public event PropertyChangedEventHandler PropertyChanged;
		private Movie selectedItem;
		public Movie SelectedItem
		{
			get => selectedItem;
			set
			{
				selectedItem = value;
				OnPropertyChanged();
			}
		}

		public MovieViewModel(IApiService apiService)
		{
			this.apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
		}

		public void ApplyQueryAttributes(IDictionary<string, object> query)
		{
			Movie movie = query["Movie"] as Movie;
			this.SelectedItem = movie;
		}
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			this.PropertyChanged?.Invoke(
				this,
				new PropertyChangedEventArgs(propertyName)
				);
		}
	}
}
