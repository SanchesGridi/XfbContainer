using System;
using System.IO;
using System.Linq;
using System.Numerics;

namespace XfbContainer.Modules.FileBrowser.Infrastructure
{
    public sealed class FolderCalculator
    {
        private BigInteger _totalSize;
        private int _filesCount;
        private int _dirsCount;

        public FolderCalculator()
        {
            this.OnReload();
        }

        public (BigInteger TotalSize, int FilesCount, int SubfoldersCount) CalculateFromFolderPath(string path)
        {
            try
            {
                this.CalculateInternal(new DirectoryInfo(path));

                return (_totalSize, _filesCount, _dirsCount);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                this.OnReload();
            }
        }

        private void CalculateInternal(DirectoryInfo info)
        {
            var files = info.GetFiles();
            _filesCount += files.Length;

            _totalSize += files.Sum(x => x.Length);

            var directories = info.GetDirectories();
            _dirsCount += directories.Length;

            foreach (var directory in directories)
            {
                this.CalculateInternal(directory);
            }
        }

        private void OnReload()
        {
            _totalSize = _filesCount = _dirsCount = 0;
        }
    }
}
