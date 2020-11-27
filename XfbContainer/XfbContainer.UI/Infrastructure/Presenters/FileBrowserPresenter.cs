using System.Linq;
using Prism.Modularity;
using Prism.Regions;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.Modules.FileBrowser;

namespace XfbContainer.UI.Infrastructure.Presenters
{
    public class FileBrowserPresenter
    {
        private readonly IModuleManager _moduleManager;
        private readonly IRegionManager _regionManager;

        private IRegion _region;
        private object _fileBrowserView;
        private bool _isFileBrowserVisible;
        private bool _isFileBrowserLoaded;

        public FileBrowserPresenter(IModuleManager moduleManager, IRegionManager regionManager)
        {
            _regionManager = regionManager;
            _moduleManager = moduleManager;
        }

        public void SwitchView()
        {
            if (!_isFileBrowserLoaded)
            {
                this.OnFirstSwitch();
            }
            else
            {
                if (_isFileBrowserVisible)
                {
                    _region.Remove(_fileBrowserView);
                }
                else
                {
                    _region.Add(_fileBrowserView);
                }

                _isFileBrowserVisible = !_isFileBrowserVisible;
            }
        }

        private void OnFirstSwitch()
        {
            _moduleManager.LoadModule(nameof(FileBrowserModule));

            _region = _regionManager.Regions["FileBrowserRegion"].VerifyReferenceAndSet();
            _fileBrowserView = _region.Views.FirstOrDefault().VerifyReferenceAndSet();

            _isFileBrowserLoaded = true;
            _isFileBrowserVisible = true;
        }
    }
}
