using Prism.Mvvm;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class BaseViewModel : BindableBase
    {
        public virtual void UpdateFor(params string[] propertyNames)
        {
            foreach(var propertyName  in propertyNames)
            {
                base.RaisePropertyChanged(propertyName);
            }
        }
    }
}
