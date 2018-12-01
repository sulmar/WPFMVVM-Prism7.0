using CommonServiceLocator;
using Prism.Hello.IServices;
using Prism.Hello.Services;
using Prism.Hello.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Unity;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Prism.Hello
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : PrismApplication
    {
        // http://donovanbrown.com/post/Getting-started-with-Prism-70

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            containerRegistry.RegisterForNavigation<ViewA>();
            containerRegistry.RegisterForNavigation<ViewB>();

            containerRegistry.Register<ICustomersService, CustomersService>();
        }

        protected override Window CreateShell()
        {
            return ServiceLocator.Current.GetInstance<ShellView>();
        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
             return new ConfigurationModuleCatalog();
          //  return  new DirectoryModuleCatalog() {  ModulePath = Environment.CurrentDirectory };
        }
    }
}
