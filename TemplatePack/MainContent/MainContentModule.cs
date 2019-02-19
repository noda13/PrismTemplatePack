using MainContent.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace MainContent
{
    public class MainContentModule : IModule
    {
        public void OnInitialized(IContainerProvider containerProvider)
        {
            var regionManager = containerProvider.Resolve<IRegionManager>();
            regionManager.RegisterViewWithRegion("ContentRegion", typeof(ViewA));
        }

        public void RegisterTypes(IContainerRegistry containerRegistry)
        {
            
        }
    }
}