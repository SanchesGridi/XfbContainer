using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.Modules.FileBrowser.ViewModels.Controls;
using XfbContainer.Modules.FileBrowser.Views.Controls;
using XfbContainer.WpfDomain.Extensions;
using XfbContainer.WpfDomain.Models;
using XfbContainer.WpfDomain.Services;

namespace XfbContainer.Modules.FileBrowser.Presenters
{
    public class FolderTreePresenter
    {
        private readonly IRegionManager _regionManager;
        private readonly IDialogService _dialogService;
        private readonly IViewProvider _viewProvider;

        private bool _showDilogOnNewRequest;
        private bool _isDirectoryOpened;
        private string _rootFolderPath;
        private IRegion _region;

        public FolderTreePresenter(IRegionManager regionManager, IDialogService dialogService, IViewProvider viewProvider)
        {
            _regionManager = regionManager;
            _dialogService = dialogService;
            _viewProvider = viewProvider;
        }

        public string GetRootFolderPath()
        {
            if (_isDirectoryOpened)
            {
                return _rootFolderPath;
            }
            else
            {
                return string.Empty;
            }
        }
        public void OpenFolderExecute(Action updateAction)
        {
            if (_showDilogOnNewRequest)
            {
                _dialogService.ShowDefaultDialogBox(
                    dialogName: "DialogBox",
                    isModal: true,
                    okAction: r =>
                    {
                        _showDilogOnNewRequest = !r.Parameters.GetValue<bool>("dont_show_again");
                        this.OpenFolder(updateAction);
                    },
                    cancelAction: r => _showDilogOnNewRequest = !r.Parameters.GetValue<bool>("dont_show_again"),
                    closeAction: r => _showDilogOnNewRequest = !r.Parameters.GetValue<bool>("dont_show_again"),
                    parameters: new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("title", "Question"),
                        new KeyValuePair<string, string>("message", "Open another folder?")
                    }
                );
            }
            else
            {
                this.OpenFolder(updateAction);
            }
        }

        private void OpenFolder(Action updateAction)
        {
            var result = _dialogService.OpenFolderDialog();

            if (result.Value)
            {
                var folderPath = result.SelectedPath;

                if (!_isDirectoryOpened)
                {
                    this.WhenFirstOpened(folderPath);
                }
                else
                {
                    if (!folderPath.Equals(_rootFolderPath))
                    {
                        this.LoadFolderTree(folderPath);
                    }
                }

                updateAction?.Invoke();
            }
        }
        private void WhenFirstOpened(string folderPath)
        {
            _region = _regionManager
                .RegisterViewWithRegion("FolderTreeRegion", typeof(FolderTreeControl))
                .Regions["FolderTreeRegion"]
                .VerifyReferenceAndSet();

            this.LoadFolderTree(folderPath);

            _isDirectoryOpened = true;
            _showDilogOnNewRequest = true;
        }
        private void LoadFolderTree(string folderPath)
        {
            _rootFolderPath = folderPath;

            var view = ((FolderTreeControl)_region.Views.FirstOrDefault()).VerifyReferenceAndSet();
            var viewModel = ((FolderTreeControlViewModel)view.DataContext).VerifyReferenceAndSet();

            if (viewModel.DirectoryModel != null)
            {
                viewModel.DirectoryModel.Dispose();

                var folderItems = _viewProvider.GetView<ListBox>(Application.Current.MainWindow, "Folder_View_ListBox").Items;
                folderItems.Clear();

                viewModel.ClearMemory();
            }

            viewModel.DirectoryModel = new DirectoryModel(_rootFolderPath);
            viewModel.UpdateFor("RootDirectorySource");
        }
    }
}
