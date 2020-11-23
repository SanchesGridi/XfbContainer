using System;
using System.Windows;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using Prism.Unity;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.WpfDomain.Services;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class UiMarshalingViewModel : BaseViewModel
    {
        private readonly PrismApplication _prismApplication;

        protected UiMarshalingViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner
            ) : base(regionManager, moduleManager, dialogService, cleaner)
        {
            _prismApplication = (PrismApplication)Application.Current;
        }

        public virtual void MarshalAction<TAny>(Action<TAny> action, TAny argument)
        {
            action.VerifyReference();

            _prismApplication.Dispatcher.Invoke(() => action.Invoke(argument));
        }
    }
}
