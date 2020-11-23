using Prism.Modularity;
using Prism.Mvvm;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.WpfDomain.Services;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        protected readonly IRegionManager _regionManager;
        protected readonly IModuleManager _moduleManager;
        protected readonly IDialogService _dialogService;
        protected readonly ICleaner _cleaner;

        public BaseViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner)
        {
            _regionManager = regionManager;
            _moduleManager = moduleManager;
            _dialogService = dialogService;
            _cleaner = cleaner;
        }

        public void UpdateProperty(string propertyName)
        {
            base.RaisePropertyChanged(propertyName);
        }
    }
}
