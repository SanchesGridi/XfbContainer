﻿using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;
using XfbContainer.CommonTypes.Extensions;
using XfbContainer.Modules.FileBrowser.Views.Controls;

namespace XfbContainer.Modules.FileBrowser
{
    public class FileBrowserModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            containerProvider
                .Resolve<IRegionManager>()
                .VerifyReferenceAndSet("regionManager", "FileBrowserModule", "exception was thrown in method: [OnInitialized]")
                .RegisterViewWithRegion("FileBrowserRegion", typeof(FileBrowserControl));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
    }
}