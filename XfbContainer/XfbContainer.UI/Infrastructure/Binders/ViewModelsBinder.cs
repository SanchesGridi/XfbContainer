using Prism.Mvvm;
using XfbContainer.Modules.FileBrowser.ViewModels.Controls;
using XfbContainer.Modules.FileBrowser.Views.Controls;
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
        public void BindFileBrowserModuleViewModels()
        {
            ViewModelLocationProvider.Register<FileBrowserControl, FileBrowserControlViewModel>();
            ViewModelLocationProvider.Register<FolderTreeControl, FolderTreeControlViewModel>();
            ViewModelLocationProvider.Register<FolderViewControl, FolderViewControlViewModel>();
        }
        public void BindOperationPanelModuleViewModels()
        {
            // todo ...
        }
    }
}
