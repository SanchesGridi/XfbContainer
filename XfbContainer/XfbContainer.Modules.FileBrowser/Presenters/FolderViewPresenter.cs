using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using Prism.Regions;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.Modules.FileBrowser.ViewModels.Controls;
using XfbContainer.Modules.FileBrowser.Views.Controls;
using XfbContainer.WpfDomain.Models;
using XfbContainer.WpfDomain.Services;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.Presenters
{
    public class FolderViewPresenter
    {
        private readonly IRegionManager _regionManager;
        private readonly IViewProvider _viewProvider;

        private bool _isFolderViewLoaded;
        private IRegion _region;

        public FolderViewPresenter(IRegionManager regionManager, IViewProvider viewProvider)
        {
            _regionManager = regionManager;
            _viewProvider = viewProvider;
        }

        public void ExpandFolderExecute(TreeViewItem item, UiMarshalingViewModel viewModel)
        {
            var model = (DirectoryModel)item.DataContext;

            if (!item.IsExpanded)
            {
                model.Expand();

                if (model.Directories.Count > 0)
                {
                    item.IsExpanded = true;
                }
                else
                {
                    if (item.ToolTip == null)
                    {
                        item.ToolTip = new ToolTip
                        {
                            Background = Brushes.Black,
                            Foreground = Brushes.Firebrick,
                            BorderBrush = Brushes.Firebrick,
                            BorderThickness = new Thickness(1.5),
                            Content = "No subfolders"
                        };

                        viewModel.MarshalAction(async (t) =>
                        {
                            t.IsOpen = true;
                            await Task.Delay(500);
                            t.IsOpen = false;
                        }, (ToolTip)item.ToolTip);
                    }
                }
            }
            else
            {
                item.IsExpanded = false;
            }

            if (!_isFolderViewLoaded)
            {
                this.InitializeFolderView(model);
            }
            else
            {
                this.LoadFolderView(model);
            }
        }

        private void InitializeFolderView(DirectoryModel model)
        {
            _region = _regionManager
                .RegisterViewWithRegion("FolderViewRegion", typeof(FolderViewControl))
                .Regions["FolderViewRegion"]
                .VerifyReferenceAndSet();

            this.LoadFolderView(model);

            _isFolderViewLoaded = true;
        }
        private void LoadFolderView(DirectoryModel model)
        {
            var view = ((FolderViewControl)_region.Views.FirstOrDefault()).VerifyReferenceAndSet();
            var viewModel = ((FolderViewControlViewModel)view.DataContext).VerifyReferenceAndSet();
            viewModel.DirectoryModel = model;

            var folderItems = _viewProvider.GetView<ListBox>(Application.Current.MainWindow, "Folder_View_ListBox").Items;
            if (folderItems.Count > 0)
            {
                folderItems.Clear();
                viewModel.ClearMemory();
            }

            foreach (var directory in viewModel.DirectoryModel.Directories)
            {
                var ListBoxItem = new ListBoxItem
                {
                    Content = new FolderItemControl
                    {
                        DataContext = new FolderItemControlViewModel(directory)
                    }
                };

                folderItems.Add(ListBoxItem);
            }
            foreach (var file in viewModel.DirectoryModel.Files)
            {
                var ListBoxItem = new ListBoxItem
                {
                    Content = new FolderItemControl
                    {
                        DataContext = new FolderItemControlViewModel(file)
                    }
                };

                folderItems.Add(ListBoxItem);
            }
        }
    }
}
