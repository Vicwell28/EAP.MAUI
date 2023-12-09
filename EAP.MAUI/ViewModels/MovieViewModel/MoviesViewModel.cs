using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.Models;
using EAP.MAUI.Services.ApiService;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace EAP.MAUI.ViewModels.MovieViewModel
{
	public class MoviesViewModel : INotifyPropertyChanged
	{
		private readonly IApiService apiService;
		private bool isRefreshing;
		private ObservableCollection<Movie> observableMovies;
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

		public ObservableCollection<Movie> ObservableMovies
		{
			get { return observableMovies; }
			set
			{
				observableMovies = value;
				OnPropertyChanged();
			}
		}

		public bool IsRefreshing
		{
			get { return isRefreshing; }
			set
			{
				isRefreshing = value;
				OnPropertyChanged();
			}
		}

		public MoviesViewModel(IApiService apiService)
		{
			this.apiService = apiService ?? throw new ArgumentNullException(nameof(apiService));
			RefreshViewCommand = new Command(RefreshMovies);
			SelectionChangedCommand = new Command<object>(OnSelectionChanged);

		}

		public ICommand RefreshViewCommand { get; private set;  }
		public ICommand SelectionChangedCommand { get; private set; }


		private async void OnSelectionChanged(object parameter)
		{
			Movie selectedItem = parameter as Movie;

			var navigationParameter = new Dictionary<string, object>
			{
				{ "Movie", selectedItem }
			};

			await Shell.Current.GoToAsync($"paginaDetalle", navigationParameter);
		}

		private async void RefreshMovies()
		{
			Log.Info("MoviesViewModel RefreshMovies"); 

			IsRefreshing = true;

			var response = await this.apiService.IndexAsync<ObservableCollection<Movie>>("http://192.168.1.6:8000/api/peliculas");
			this.ObservableMovies = new ObservableCollection<Movie>(response.Select(movie =>
			{
				movie.Imagen = $"http://192.168.1.6:8000{movie.Imagen}";
				return movie;
			}));

			IsRefreshing = false;
		}

		public event PropertyChangedEventHandler PropertyChanged;
		protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}
