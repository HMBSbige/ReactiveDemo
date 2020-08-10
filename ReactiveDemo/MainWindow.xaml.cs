using ReactiveDemo.ViewModels;
using ReactiveUI;
using System.Reactive.Disposables;

namespace ReactiveDemo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            ViewModel = new AppViewModel();

            // We create our bindings here. These are the code behind bindings which allow
            // type safety. The bindings will only become active when the Window is being shown.
            // We register our subscription in our disposableRegistration, this will cause
            // the binding subscription to become inactive when the Window is closed.
            // The disposableRegistration is a CompositeDisposable which is a container of
            // other Disposables. We use the DisposeWith() extension method which simply adds
            // the subscription disposable to the CompositeDisposable.
            this.WhenActivated(disposableRegistration =>
            {
                // Notice we don't have to provide a converter, on WPF a global converter is
                // registered which knows how to convert a boolean into visibility.
                this.OneWayBind(ViewModel,
                                viewModel => viewModel.IsAvailable,
                                view => view.SearchResultsListBox.Visibility)
                        .DisposeWith(disposableRegistration);

                this.OneWayBind(ViewModel,
                                viewModel => viewModel.SearchResults,
                                view => view.SearchResultsListBox.ItemsSource)
                        .DisposeWith(disposableRegistration);

                this.Bind(ViewModel,
                                viewModel => viewModel.SearchTerm,
                                view => view.SearchTextBox.Text)
                        .DisposeWith(disposableRegistration);
            });
        }
    }
}
