using Prism.Ioc;
using Prism.Modularity;
using Prism.ModuleA.Views;
using Prism.Regions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prism.ModuleA
{
    public class ModuleCModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public ModuleCModule(IRegionManager regionManager)
        {
            this._regionManager = regionManager;
        }

        public void OnInitialized(IContainerProvider containerProvider)
        {
            _regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewC));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            // throw new NotImplementedException();
        }
    }
}
