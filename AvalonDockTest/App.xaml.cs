using System.Windows;
using AvalonDockTest.Views;
using CommonServiceLocator;
using Prism.Ioc;
using Prism.Regions;
using PT.ALC.Infrastructure;
using Xceed.Wpf.AvalonDock;

namespace AvalonDockTest
{
  /// <summary>
  ///   Interaction logic for App.xaml
  /// </summary>
  public partial class App
  {
    protected override void ConfigureRegionAdapterMappings(RegionAdapterMappings regionAdapterMappings)
    {
      base.ConfigureRegionAdapterMappings(regionAdapterMappings);
      regionAdapterMappings.RegisterMapping(typeof(DockingManager),
        new DockingManagerRegionAdapter(ServiceLocator.Current.GetInstance<RegionBehaviorFactory>()));
    }

    protected override Window CreateShell()
    {
      return Container.Resolve<MainWindow>();
    }

    protected override void RegisterTypes(IContainerRegistry containerRegistry)
    {
      //containerRegistry.GetContainer().RegisterType<ContentView>();
    }
  }
}