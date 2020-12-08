using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.Modules.FileBrowser.Infrastructure.Presenters;
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
            IViewProvider viewProvider
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider)
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
