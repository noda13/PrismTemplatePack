using MainContent;
using Prism.Ioc;
using Prism.Modularity;
using System.Windows;
using TemplatePack.Views;

namespace TemplatePack
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }
        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MainContentModule>(InitializationMode.WhenAvailable);
        }
    }
}
