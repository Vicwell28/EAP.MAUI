using EAP.MAUI.ViewModels.MovieViewModel;

namespace EAP.MAUI.Views.MovieView
{
	public partial class MovieView : ContentPage
	{
		private readonly MovieViewModel movieViewModel;

		public MovieView(MovieViewModel movieViewModel)
		{
			InitializeComponent();
			this.movieViewModel = movieViewModel ?? throw new ArgumentNullException(nameof(movieViewModel));
			this.BindingContext = this.movieViewModel;
		}
	}
}
