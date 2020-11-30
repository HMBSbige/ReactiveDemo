using ReactiveDemo.ViewModels;
using ReactiveUI;
using ReactiveUI.Winforms;
using System.Reactive.Disposables;

namespace ReactiveDemo.Views
{
	public partial class NugetDetailsView : ReactiveUserControl<NugetDetailsViewModel>
	{
		public NugetDetailsView()
		{
			InitializeComponent();

			this.WhenActivated(disposableRegistration =>
			{
				// Our 4th parameter we convert from Url into a BitmapImage. 
				// This is an easy way of doing value conversion using ReactiveUI binding.
				this.OneWayBind(ViewModel,
								viewModel => viewModel.IconUrl,
								view => view.IconImage.ImageLocation)
						.DisposeWith(disposableRegistration);

				this.OneWayBind(ViewModel,
								viewModel => viewModel.Title,
								view => view.TitleRun.Text)
						.DisposeWith(disposableRegistration);

				this.OneWayBind(ViewModel,
								viewModel => viewModel.Description,
								view => view.DescriptionRun.Text)
						.DisposeWith(disposableRegistration);

				this.BindCommand(ViewModel!,
								viewModel => viewModel.OpenPage,
								view => view.TitleRun)
						.DisposeWith(disposableRegistration);
			});
		}
	}
}
