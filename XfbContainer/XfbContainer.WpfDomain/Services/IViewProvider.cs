using System.Windows;

namespace XfbContainer.WpfDomain.Services
{
    public interface IViewProvider
    {
        TView GetView<TView>(DependencyObject view, string viewName) where TView : DependencyObject;
    }
}
