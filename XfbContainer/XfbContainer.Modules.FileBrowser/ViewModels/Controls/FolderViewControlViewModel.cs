using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.WpfDomain.Models;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FolderViewControlViewModel : BaseViewModel
    {
        private DirectoryModel _directoryModel;

        public DirectoryModel DirectoryModel
        {
            get => _directoryModel;
            set => base.SetProperty(ref _directoryModel, value);
        }

        public FolderViewControlViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner
            ) : base(regionManager, moduleManager, dialogService, cleaner)
        {

        }


    }
}
