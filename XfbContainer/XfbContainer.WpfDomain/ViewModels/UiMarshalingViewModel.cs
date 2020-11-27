using System;
using System.Windows;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.WpfDomain.Commands;
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
            IViewProvider viewProvider,
            IApplicationCommands applicationCommands
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider, applicationCommands)
        {
            _application = Application.Current;
        }

        public virtual void MarshalAction<TAny>(Action<TAny> action, TAny argument)
        {
            action.VerifyReference();

            _application.Dispatcher.Invoke(() => action.Invoke(argument));
        }
    }
}
