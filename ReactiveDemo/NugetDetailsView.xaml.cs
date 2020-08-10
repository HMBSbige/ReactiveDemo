﻿using ReactiveUI;
using System.Reactive.Disposables;
using System.Windows.Media.Imaging;

namespace ReactiveDemo
{
    public partial class NugetDetailsView
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
                                view => view.IconImage.Source,
                                url => url == null ? null : new BitmapImage(url))
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
                                view => view.OpenButton)
                        .DisposeWith(disposableRegistration);
            });
        }
    }
}
