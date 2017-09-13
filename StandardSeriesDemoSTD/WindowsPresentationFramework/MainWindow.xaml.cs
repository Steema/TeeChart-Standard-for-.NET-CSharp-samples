using Steema.TeeChart.WPF;
using Steema.TeeChart.WPF.Styles;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StandardSeriesWPFDemo
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();
      this.MenuPanel2.Children.RemoveRange(1, 3);
      this.MenuPanel3.Children.RemoveRange(1, 1);
      this.MenuPanel4.Children.RemoveRange(1, 4);
      this.MenuPanel5.Children.RemoveRange(1, 1);
      this.MenuPanel6.Children.RemoveRange(1, 1);
      this.MenuPanel7.Children.RemoveRange(1, 1);

      ChartGrid.Width = 600;
      ChartGrid.Height = 400;
      AddUserControl<StartForm>();

      this.SizeChanged += MainWindow_SizeChanged;
    }

    private void MainWindow_SizeChanged(object sender, SizeChangedEventArgs e)
    {
      ChartGrid.Height = e.NewSize.Height;
      ChartGrid.Width = e.NewSize.Width - 300;
    }


    private void Lines_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Lines.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if(image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel1.Children.RemoveRange(1, 2);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel1.Children.Add(this.StockM);
        this.MenuPanel1.Children.Add(this.WebA);
      }
    }

    private void Bars_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Bars.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if (image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel2.Children.RemoveRange(1, 3);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel2.Children.Add(this.SalesF);
        this.MenuPanel2.Children.Add(this.StackedB);
        this.MenuPanel2.Children.Add(this.ServerS);
      }
    }

    private void Areas_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Areas.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if (image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel3.Children.RemoveRange(1, 1);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel3.Children.Add(this.VegG);
      }
    }

    private void Pie_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Pie.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if (image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel4.Children.RemoveRange(1, 4);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel4.Children.Add(this.SalesFi);
        this.MenuPanel4.Children.Add(this.MultipleP);
        this.MenuPanel4.Children.Add(this.Donut);
        this.MenuPanel4.Children.Add(this.MultiD);
      }
    }

    private void Points_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Points.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if (image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel5.Children.RemoveRange(1, 1);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel5.Children.Add(this.ProductS);
      }
    }

    private void Gantt_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Gantt.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if (image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel6.Children.RemoveRange(1, 1);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel6.Children.Add(this.ProjectP);
      }
    }

    private void Bubbles_Click(object sender, RoutedEventArgs e)
    {
      StackPanel stack = Bubbles.Content as StackPanel;
      Image image = stack.Children[1] as Image;
      if (image.Name == "Up")
      {
        image.Name = "Down";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/down.png"));
        this.MenuPanel7.Children.RemoveRange(1, 1);
      }
      else
      {
        image.Name = "Up";
        image.Source = new BitmapImage(new Uri("pack://application:,,,/StandardSeriesWPFDemo;component/Resources/up.png"));
        this.MenuPanel7.Children.Add(this.PopularC);
      }
    }

    private void StockM_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<StockMonitoring>();
    }

    private void Label_MouseDown(object sender, MouseButtonEventArgs e)
    {
      AddUserControl<StartForm>();
    }

    private void WebA_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<WebAnalytics>();
    }

    private void AddUserControl<T>() where T : UserControl, new()
    {
      this.ChartGrid.Children.Clear();
      T cntrl = new T();
      cntrl.Margin = new Thickness(1, 0, 15, 40);
      this.ChartGrid.Children.Add(cntrl);

    }

    private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
    {
      Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
      e.Handled = true;
    }

    private void SalesF_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<SalesFigures>();
    }

    private void StackedB_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<StackedBars>();
    }

    private void ServerS_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<ServerStatus>();
    }

    private void VegG_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<VegetationGrowth>();
    }

    private void SalesFi_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<PieSalesFigures>();
    }

    private void MultipleP_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<MultiPies>();
    }

    private void Donut_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<DonutChart>();
    }

    private void MultiD_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<MultiDonut>();
    }

    private void ProductS_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<ProductShipments>();
    }

    private void ProjectP_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<ProjectPlanner>();
    }

    private void PopularC_Click(object sender, RoutedEventArgs e)
    {
      AddUserControl<PopularLanguages>();
    }
  }
}
