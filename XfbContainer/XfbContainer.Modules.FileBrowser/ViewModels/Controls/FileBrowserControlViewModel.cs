using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FileBrowserControlViewModel : BaseViewModel
    {
        public FileBrowserControlViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService
            ) : base(regionManager, moduleManager, dialogService)
        {

        }
    }
}
