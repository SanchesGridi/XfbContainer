using System.Windows;
using Prism.Ioc;
using XfbContainer.UI.Infrastructure.Binders;
using XfbContainer.UI.Views.Windows;

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

        }
        #endregion

        #region virtual methods
        protected override void ConfigureViewModelLocator()
        {
            base.ConfigureViewModelLocator();

            _viewModelsBinder.BindCommonViewModels();
        }
        #endregion
    }
}
