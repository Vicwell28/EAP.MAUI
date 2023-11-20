using EAP.MAUI.ViewModels.MovieViewModel;

namespace EAP.MAUI.Views.MovieView
{
	public partial class MoviesListView : ContentPage
	{
		private readonly MoviesViewModel moviesViewModel;

		public MoviesListView(MoviesViewModel moviesViewModel)
		{
			InitializeComponent();
			this.moviesViewModel = moviesViewModel ?? throw new ArgumentNullException(nameof(moviesViewModel));
			this.BindingContext = this.moviesViewModel;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();
			this.moviesViewModel.RefreshViewCommand.Execute(this);
		}

	}
}