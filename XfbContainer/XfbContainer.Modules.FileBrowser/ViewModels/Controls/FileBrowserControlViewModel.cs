using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.Modules.FileBrowser.Presenters;
using XfbContainer.WpfDomain.Commands;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FileBrowserControlViewModel : ServiceProviderViewModel
    {
        private readonly FolderTreePresenter _folderTreePresenter;

        public string FolderPath
        {
            get => _folderTreePresenter.GetRootFolderPath();
        }
        public DelegateCommand OpenFolderCommand { get; }

        public FileBrowserControlViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider,
            IApplicationCommands applicationCommands
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider, applicationCommands)
        {
            _folderTreePresenter = new FolderTreePresenter(_regionManager, _dialogService, _viewProvider);

            OpenFolderCommand = new DelegateCommand(this.OpenFolderCommandExecute);
        }

        private void OpenFolderCommandExecute()
        {
            _folderTreePresenter.OpenFolderExecute(() => base.RaisePropertyChanged(nameof(FolderPath)));
        }
    }
}
