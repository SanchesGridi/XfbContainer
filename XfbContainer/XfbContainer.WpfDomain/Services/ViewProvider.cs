using System;
using System.Windows;

namespace XfbContainer.WpfDomain.Services
{
    public sealed class  ViewProvider : IViewProvider
    {
        public TView GetView<TView>(DependencyObject view, string viewName) where TView : DependencyObject
        {
            try
            {
                var childView = (TView)LogicalTreeHelper.FindLogicalNode(view, viewName);

                return childView;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
