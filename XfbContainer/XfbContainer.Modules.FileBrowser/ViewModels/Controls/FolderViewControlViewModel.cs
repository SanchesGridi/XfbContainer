using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using Prism.Commands;
using Prism.Modularity;
using Prism.Regions;
using Prism.Services.Dialogs;
using XfbContainer.Modules.FileBrowser.Infrastructure;
using XfbContainer.WpfDomain.Extensions;
using XfbContainer.WpfDomain.Models;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FolderViewControlViewModel : UiMarshalingViewModel
    {
        private readonly FolderCalculator _folderCalculator;

        private DirectoryModel _directoryModel;

        public DirectoryModel DirectoryModel
        {
            get => _directoryModel;
            set => base.SetProperty(ref _directoryModel, value);
        }

        public int? SelectedFolderFilesCount
        {
            get => _directoryModel?.Files.Count;
        }
        public int? SelectedFolderDirectoriesCount
        {
            get => _directoryModel?.Directories.Count;
        }
        public DelegateCommand ComputeFolderSizeCommand { get; }
        public DelegateCommand ComputeFolderSizeRecursiveCommand { get; }

        public FolderViewControlViewModel(
            IRegionManager regionManager,
            IModuleManager moduleManager,
            IDialogService dialogService,
            ICleaner cleaner,
            IViewProvider viewProvider
            ) : base(regionManager, moduleManager, dialogService, cleaner, viewProvider)
        {
            _folderCalculator = new FolderCalculator();

            ComputeFolderSizeCommand = new DelegateCommand(this.ComputeFolderSizeCommandExecute);
            ComputeFolderSizeRecursiveCommand = new DelegateCommand(this.ComputeFolderSizeRecursiveCommandExecute);
        }

        private void ComputeFolderSizeCommandExecute()
        {
            BigInteger totalSize = DirectoryModel.Files.Sum(x => x.Length);
            _dialogService.ShowDefaultDialogBox(
                dialogName: "FolderOptionsBox",
                isModal: true,
                parameters: new KeyValuePair<string, string>[]
                {
                    new KeyValuePair<string, string>("title", "Folder Info"),
                    new KeyValuePair<string, string>("message", $"Folder size: {totalSize} bytes"),
                    new KeyValuePair<string, string>("files_count_message", $"Files count: {DirectoryModel.Files.Count}"),
                    new KeyValuePair<string, string>("subfolders_count_message", $"Subfolders count: {DirectoryModel.Directories.Count}")
                }
            );
        }
        private void ComputeFolderSizeRecursiveCommandExecute()
        {
            base.MarshalAction(async () =>
            {
                var tuple = await this.CalculateAsync();

                _dialogService.ShowDefaultDialogBox(
                    dialogName: "FolderOptionsBox",
                    parameters: new KeyValuePair<string, string>[]
                    {
                        new KeyValuePair<string, string>("title", "Folder Info"),
                        new KeyValuePair<string, string>("message", $"Folder size: {tuple.TotalSize} bytes"),
                        new KeyValuePair<string, string>("files_count_message", $"Files count: {tuple.FilesCount}"),
                        new KeyValuePair<string, string>("subfolders_count_message", $"Subfolders count: {tuple.SubfoldersCount}")
                    }
                );
            });
        }

        private async Task<(BigInteger TotalSize, int FilesCount, int SubfoldersCount)> CalculateAsync()
        {
            return await Task.Factory.StartNew(() =>
                _folderCalculator.CalculateFromFolderPath(DirectoryModel.FullName),
                TaskCreationOptions.LongRunning
            );
        }
    }
}
