using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading;

namespace XfbContainer.WpfDomain.Models.Base
{
    public abstract class NotificationModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void SetProperty<TAny>(ref TAny field, TAny value, [CallerMemberName]string propertyName = null)
        {
            field = value;
            this.OnPropertyChanged(propertyName);
        }

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            Volatile.Read(ref PropertyChanged)?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
