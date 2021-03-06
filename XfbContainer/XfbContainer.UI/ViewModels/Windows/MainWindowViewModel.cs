﻿using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.UI.Infrastructure.Presenters;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.UI.ViewModels.Windows
{
    public class MainWindowViewModel : ServiceProviderViewModel
    {
        private readonly FileBrowserPresenter _fileBrowserPresenter;

        public DelegateCommand SwitchFileBrowserCommand { get; }

        public MainWindowViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider)
        {
            _fileBrowserPresenter = new FileBrowserPresenter(_moduleManager, _regionManager);

            SwitchFileBrowserCommand = new DelegateCommand(this.SwitchFileBrowserCommandExecute);
        }

        private void SwitchFileBrowserCommandExecute()
        {
            _fileBrowserPresenter.SwitchView();
        }
    }
}
