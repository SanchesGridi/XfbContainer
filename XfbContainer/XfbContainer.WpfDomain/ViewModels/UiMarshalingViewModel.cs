using System;
using System.Windows;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.WpfDomain.Services;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class UiMarshalingViewModel : ServiceProviderViewModel
    {
        protected readonly Application _application;

        protected UiMarshalingViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider)
        {
            _application = Application.Current;
        }

        public virtual void MarshalAction<TAny>(Action<TAny> action, TAny argument = default)
        {
            _application.Dispatcher.Invoke(() => action.VerifyReferenceAndSet().Invoke(argument));
        }
        public virtual void MarshalAction(Action action)
        {
            _application.Dispatcher.Invoke(action.VerifyReferenceAndSet());
        }
    }
}
