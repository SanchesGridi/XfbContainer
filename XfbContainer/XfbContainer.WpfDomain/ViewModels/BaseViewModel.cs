using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        protected readonly IRegionManager _regionManager;
        protected readonly IModuleManager _moduleManager;

        public BaseViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager)
        {
            _regionManager = regionManager;
            _moduleManager = moduleManager;
        }
    }
}
