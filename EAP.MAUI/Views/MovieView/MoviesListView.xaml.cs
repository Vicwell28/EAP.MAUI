using EAP.MAUI.Helpers.LogHelper;
using EAP.MAUI.ViewModels.MovieViewModel;

namespace EAP.MAUI.Views.MovieView
{
	public partial class MoviesListView : ContentPage
	{
		private readonly MoviesViewModel moviesViewModel;
		private bool IsOnAppearingView { get; set; }

		public MoviesListView(MoviesViewModel moviesViewModel)
		{
			InitializeComponent();
			this.moviesViewModel = moviesViewModel ?? throw new ArgumentNullException(nameof(moviesViewModel));
			this.BindingContext = this.moviesViewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			if (!IsOnAppearingView)
			{
				Log.Info("MoviesListView RefreshMovies");
				this.moviesViewModel.RefreshViewCommand.Execute(this);
				IsOnAppearingView = true;
			}

		}

	}
}