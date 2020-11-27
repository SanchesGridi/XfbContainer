using System.IO;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Prism.Commands;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.WpfDomain.Models;
using XfbContainer.WpfDomain.ViewModels;

namespace XfbContainer.Modules.FileBrowser.ViewModels.Controls
{
    public class FolderItemControlViewModel : BaseViewModel
    {
        private readonly IFolderModel _folderItem;

        #region Properties
        public string Name
        {
            get => _folderItem?.Name;
        }
        public string FullName
        {
            get => _folderItem?.FullName;
        }
        public string Extension
        {
            get
            {
                string extension = null;

                if (_folderItem is FileModel file)
                {
                    extension = file.Extension;
                }

                return extension;
            }
        }
        public long? BytesLength
        {
            get
            {
                long? bytesLegth = null;

                if (_folderItem is FileModel file)
                {
                    bytesLegth = file.Length;
                }

                return bytesLegth;
            }
        }
        public Color BackgroundColor
        {
            get
            {
                var backgroundColor = Colors.Yellow;

                if (_folderItem is FileModel)
                {
                    backgroundColor = Colors.DarkGray;
                }

                return backgroundColor;
            }
        }
        public ImageSource ImageSource
        {
            get
            {
                string imagePath = null;

                var currentDirectory = Directory.GetCurrentDirectory();
                var iconPath = $"{currentDirectory.Replace("UI", "Modules.FileBrowser")}\\Assets\\";
                if (_folderItem is DirectoryModel)
                {
                    imagePath = $"{iconPath}folder_item.png";
                }
                else if (_folderItem is FileModel)
                {
                    imagePath = $"{iconPath}file_item.png";
                }

                var bytes = File.ReadAllBytes(imagePath);
                using (var stream = new MemoryStream(bytes))
                {
                    var source = BitmapFrame.Create(stream, BitmapCreateOptions.None, BitmapCacheOption.OnLoad);
                    return source;
                }
            }
        }
        public DelegateCommand ClickCommand { get; }
        #endregion

        public FolderItemControlViewModel(IFolderModel folderItem)
        {
            _folderItem = folderItem.VerifyReferenceAndSet(nameof(folderItem), nameof(FolderItemControlViewModel), "Exception in \"constructor\" method");

            ClickCommand = new DelegateCommand(this.ClickCommandExecute);
        }

        private void ClickCommandExecute()
        {
            if (_folderItem is DirectoryModel model)
            {
                // ...
            }
        }
    }
}
