using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        protected readonly IRegionManager _regionManager;
        protected readonly IModuleManager _moduleManager;
        protected readonly IDialogService _dialogService;

        public BaseViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService)
        {
            _regionManager = regionManager;
            _moduleManager = moduleManager;
            _dialogService = dialogService;
        }
    }
}
