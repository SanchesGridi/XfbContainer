using System;
using System.Threading;
using Prism.Services.Dialogs;
using XfbContainer.CommonTypes;

namespace XfbContainer.WpfDomain.ViewModels
{
    public abstract class BaseDialogViewModel : BaseViewModel, IDialogAware
    {
        private string _title;
        private string _message;

        public string Title
        {
            get => _title;
            set => base.SetProperty(ref _title, value);
        }
        public string Message
        {
            get => _message;
            set => base.SetProperty(ref _message, value);
        }
        public DisposableSource DisposableSource { get; set; }
        public IDialogParameters Parameters { get; set; }

        public event Action<IDialogResult> RequestClose;

        public virtual void OnRequestClose(IDialogResult dialogResult)
        {
            Volatile.Read(ref RequestClose)?.Invoke(dialogResult);
        }
        public virtual void OnDialogOpened(IDialogParameters parameters)
        {
            Title = parameters.GetValue<string>("title");
            Message = parameters.GetValue<string>("message");
            DisposableSource = parameters.GetValue<DisposableSource>("disposable_source");

            Parameters = parameters;
        }
        public virtual bool CanCloseDialog()
        {
            return true;
        }
        public virtual void OnDialogClosed()
        {
            DisposableSource?.Dispose();
        }
    }
}
