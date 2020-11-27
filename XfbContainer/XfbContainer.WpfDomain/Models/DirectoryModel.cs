using System;
using System.Collections.ObjectModel;
using System.IO;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.WpfDomain.Models.Base;

namespace XfbContainer.WpfDomain.Models
{
    public class DirectoryModel : NotificationModel, IFolderModel, IDisposable
    {
        private readonly DirectoryInfo _directory;

        private bool _isExpanded;
        private ObservableCollection<FileModel> _files;
        private ObservableCollection<DirectoryModel> _directories;

        public string Name
        {
            get => _directory.Name;
        }
        public string FullName
        {
            get => _directory.FullName;
        }
        public ObservableCollection<FileModel> Files
        {
            get => _files ?? (_files = new ObservableCollection<FileModel>());
            set => base.SetProperty(ref _files, value, nameof(FileModel));
        }
        public ObservableCollection<DirectoryModel> Directories
        {
            get => _directories ?? (_directories = new ObservableCollection<DirectoryModel>());
            set => base.SetProperty(ref _directories, value, nameof(Directories));
        }

        public DirectoryModel(string fullName)
        {
            fullName.VerifyReference(nameof(fullName), nameof(DirectoryModel), "Exception in \"constructor\" method");

            _directory = new DirectoryInfo(fullName);
            base.OnPropertyChanged("Name");
            base.OnPropertyChanged("FullName");
        }

        public void Expand()
        {
            if (!_isExpanded)
            {
                _isExpanded = true;

                var directories = _directory.GetDirectories();
                foreach (var directory in directories)
                {
                    Directories.Add(new DirectoryModel(directory.FullName));
                }

                var files = _directory.GetFiles();
                foreach (var file in files)
                {
                    Files.Add(new FileModel(file));
                }
            }
        }
        public void Dispose()
        {
            Files.Clear();
            Directories.Clear();
        }
    }
}
