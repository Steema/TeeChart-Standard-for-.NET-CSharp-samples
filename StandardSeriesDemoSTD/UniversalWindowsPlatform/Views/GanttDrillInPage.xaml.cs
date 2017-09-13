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
  public sealed partial class GanttDrillInPage : Page
  {
    public GanttDrillInPage()
    {
      this.InitializeComponent();
    }

    private void ListView_ItemClick(object sender, ItemClickEventArgs e)
    {
      if (e.ClickedItem.ToString() == "Project Planner")
      {
        this.Frame.Navigate(
            typeof(ProjectPlannerSubPage),
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
