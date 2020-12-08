using Prism.Services.Dialogs;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FolderDialogControlViewModel : BaseDialogViewModel
    {
        private string _filesCountMessage;
        private string _subfoldersCountMessage;

        public string FilesCountMessage
        {
            get => _filesCountMessage;
            set => base.SetProperty(ref _filesCountMessage, value);
        }
        public string SubfoldersCountMessage
        {
            get => _subfoldersCountMessage;
            set => base.SetProperty(ref _subfoldersCountMessage, value);
        }

        public override void OnDialogOpened(IDialogParameters parameters)
        {
            base.OnDialogOpened(parameters);

            FilesCountMessage = parameters.GetValue<string>("files_count_message");
            SubfoldersCountMessage = parameters.GetValue<string>("subfolders_count_message");
        }
    }
}
