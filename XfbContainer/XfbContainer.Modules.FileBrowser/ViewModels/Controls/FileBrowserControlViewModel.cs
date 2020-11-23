using Prism.Modularity;
using Prism.Regions;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels
{
    public class FileBrowserControlViewModel : BaseViewModel
    {
        public FileBrowserControlViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager
            ) : base(regionManager, moduleManager)
        {

        }
    }
}
