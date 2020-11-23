using Prism.Mvvm;
using XfbContainer.UI.ViewModels.Windows;
using XfbContainer.UI.Views.Windows;

namespace XfbContainer.UI.Infrastructure.Binders
{
    public class ViewModelsBinder
    {
        public void BindCommonViewModels()
        {
            ViewModelLocationProvider.Register<MainWindow, MainWindowViewModel>();
        }
    }
}
