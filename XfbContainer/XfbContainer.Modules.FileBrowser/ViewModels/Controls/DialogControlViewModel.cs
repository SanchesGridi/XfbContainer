using Prism.Commands;
using Prism.Services.Dialogs;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public sealed class DialogControlViewModel : BaseDialogViewModel
    {
        private bool _dontShowAgain;

        public bool DontShowAgain
        {
            get => _dontShowAgain;
            set => base.SetProperty(ref _dontShowAgain, value);
        }
        public DelegateCommand<string> CloseDialogCommand { get; }

        public DialogControlViewModel()
        {
            CloseDialogCommand = new DelegateCommand<string>(this.CloseDialogCommandExecute);
        }

        private void CloseDialogCommandExecute(string parameter)
        {
            var result = ButtonResult.None;
            var parameterResult = parameter?.ToLower();

            if (parameterResult.Equals("true"))
            {
                result = ButtonResult.OK;
            }
            else if (parameterResult.Equals("false"))
            {
                result = ButtonResult.Cancel;
            }

            Parameters.Add("dont_show_again", DontShowAgain);

            this.OnRequestClose(new DialogResult(result, Parameters));
        }
    }
}
