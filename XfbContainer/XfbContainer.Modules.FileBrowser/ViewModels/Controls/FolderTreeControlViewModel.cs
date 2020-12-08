using System.Collections.Generic;
using System.Windows.Controls;
using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.Modules.FileBrowser.Infrastructure.Presenters;
using XfbContainer.WpfDomain.Models;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FolderTreeControlViewModel : UiMarshalingViewModel
    {
        private readonly FolderViewPresenter _folderViewPresenter;

        private DirectoryModel _directoryModel;

        public DirectoryModel DirectoryModel
        {
            get => _directoryModel;
            set => base.SetProperty(ref _directoryModel, value);
        }
        public IEnumerable<DirectoryModel> RootDirectorySource
        {
            get { yield return DirectoryModel; }
        }
        public DelegateCommand<TreeViewItem> ExpandCommand { get; }

        public FolderTreeControlViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider)
        {
            _folderViewPresenter = new FolderViewPresenter(_regionManager, _viewProvider);

            ExpandCommand = new DelegateCommand<TreeViewItem>(this.ExpandCommandExecute);
        }

        private void ExpandCommandExecute(TreeViewItem item)
        {
            _folderViewPresenter.ExpandFolderExecute(item, this);
        }
    }
}
