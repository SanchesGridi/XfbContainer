using Prism.Modularity;
using Prism.Regions;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.UI.ViewModels.Windows
{
    public class MainWindowViewModel : BaseViewModel
    {
        public MainWindowViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager
            ) : base(regionManager, moduleManager)
        {

        }
    }
}
