using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.UI.Infrastructure.Presenters;
using XfbContainer.WpfDomain.Commands;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.UI.ViewModels.Windows
{
    public class MainWindowViewModel : ServiceProviderViewModel
    {
        private readonly FileBrowserPresenter _fileBrowserPresenter;

        public DelegateCommand SwitchFileBrowserCommand { get; }
        public DelegateCommand SwitchOperationPanelCommand { get; } // todo

        public MainWindowViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider,
            IApplicationCommands applicationCommands
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider, applicationCommands)
        {
            _fileBrowserPresenter = new FileBrowserPresenter(_moduleManager, _regionManager);

            SwitchFileBrowserCommand = new DelegateCommand(this.SwitchFileBrowserCommandExecute);
            SwitchOperationPanelCommand = new DelegateCommand(this.SwitchOperationPanelCommandExecute);
        }

        private void SwitchFileBrowserCommandExecute()
        {
            _fileBrowserPresenter.SwitchView();
        }
        private void SwitchOperationPanelCommandExecute()
        {
            // TODO : Operation Panel Module
        }
    }
}
