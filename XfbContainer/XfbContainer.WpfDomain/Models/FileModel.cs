using System.IO;
using XfbContainer.WpfDomain.Models.Base;

namespace XfbContainer.WpfDomain.Models
{
    public class FileModel : NotificationModel, IFolderModel
    {
        private readonly FileInfo _file;

        public string Name 
        {
            get => _file.Name;
        }
        public string FullName
        {
            get => _file.FullName;
        }
        public string Extension
        {
            get => _file.Extension;
        }
        public long Length
        {
            get => _file.Length;
        }

        public FileModel(FileInfo file)
        {
            _file = file;

            base.OnPropertyChanged("Name");
            base.OnPropertyChanged("FullName");
            base.OnPropertyChanged("Extension");
            base.OnPropertyChanged("Length");
        }
    }
}
