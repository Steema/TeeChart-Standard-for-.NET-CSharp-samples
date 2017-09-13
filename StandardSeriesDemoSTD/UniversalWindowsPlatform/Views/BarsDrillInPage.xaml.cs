using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace StandardSeries.Views
{
  public sealed partial class BarsDrillInPage : Page
  {
    public BarsDrillInPage()
    {
      this.InitializeComponent();
    }


    private void ListView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (e.ClickedItem.ToString() == "Sales Figures")
      {
        this.Frame.Navigate(
                typeof(SalesFiguresSubPage),
                e.ClickedItem
#if STORE
            );
#else
            , new Windows.UI.Xaml.Media.Animation.DrillInNavigationTransitionInfo());
#endif

      }
      else if (e.ClickedItem.ToString() == "Stacked Bars")
      {
        this.Frame.Navigate(
                typeof(StackedBarsSubPage),
                e.ClickedItem
#if STORE
            );
#else
            , new Windows.UI.Xaml.Media.Animation.DrillInNavigationTransitionInfo());
#endif

      }
      else if (e.ClickedItem.ToString() == "Server Status")
      {
        this.Frame.Navigate(
                typeof(ServerStatusSubPage),
                e.ClickedItem
#if STORE
            );
#else
            , new Windows.UI.Xaml.Media.Animation.DrillInNavigationTransitionInfo());
#endif

      }
    }
  }
}
