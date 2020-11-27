using System.Windows;
using Prism.Ioc;
using Prism.Modularity;
using XfbContainer.Modules.FileBrowser;
using XfbContainer.UI.Infrastructure.Binders;
using XfbContainer.UI.Views.Windows;
using XfbContainer.WpfDomain.Commands;
using XfbContainer.WpfDomain.Services;

namespace XfbContainer.UI
{
    public partial class App
    {
        #region fields
        private readonly ViewModelsBinder _viewModelsBinder;
        #endregion

        #region ctors
        public App() : base()
        {
            _viewModelsBinder = new ViewModelsBinder();
        }
        #endregion

        #region abstract methods
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }
        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterSingleton<ICleaner, GcCleaner>();
            containerRegistry.RegisterSingleton<IViewProvider, ViewProvider>();
            containerRegistry.RegisterSingleton<IApplicationCommands, ApplicationCommands>();
        }
        #endregion

        #region virtual methods
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            _viewModelsBinder.BindCommonViewModels();
            _viewModelsBinder.BindFileBrowserModuleViewModels();
            _viewModelsBinder.BindOperationPanelModuleViewModels();
        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            base.ConfigureModuleCatalog(moduleCatalog);

            moduleCatalog.AddModule<FileBrowserModule>(InitializationMode.OnDemand);
            // todo operation panel ...
        }
        #endregion
    }
}
