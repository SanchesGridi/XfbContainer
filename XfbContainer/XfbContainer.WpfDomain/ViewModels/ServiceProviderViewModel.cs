using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.WpfDomain.Services;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class ServiceProviderViewModel : BaseViewModel
    {
        protected readonly IRegionManager _regionManager;
        protected readonly IModuleManager _moduleManager;
        protected readonly IDialogService _dialogService;
        protected readonly ICleaner _cleaner;
        protected readonly IViewProvider _viewProvider;

        public ServiceProviderViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider)
        {
            _regionManager = regionManager;
            _moduleManager = moduleManager;
            _dialogService = dialogService;
            _cleaner = cleaner;
            _viewProvider = viewProvider;
        }

        public void ClearMemory()
        {
            _cleaner.ClearMemory();
        }
    }
}
