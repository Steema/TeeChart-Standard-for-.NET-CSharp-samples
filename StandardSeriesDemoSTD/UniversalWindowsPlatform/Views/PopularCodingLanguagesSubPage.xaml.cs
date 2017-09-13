using Steema.TeeChart.Store;
using Steema.TeeChart.Store.Styles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace StandardSeries.Views
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class PopularCodingLanguagesSubPage : Windows.UI.Xaml.Controls.Page
  {
    public PopularCodingLanguagesSubPage()
    {
      this.InitializeComponent();
      InitializeChart();
    }

    private void InitializeChart()
    {
      //this.tChart1.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Footer.Alignment = TextAlignment.Left;
      this.tChart1.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Size = 20;
      this.tChart1.Header.Lines = new string[] {
        "Most popular coding languages of 2014"};
      this.tChart1.Legend.Font.Brush.Color = Colors.Gray;
      this.tChart1.Legend.Font.Size = 16;
      this.tChart1.Legend.TextStyle = LegendTextStyles.Plain;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.TabIndex = 0;
      this.tChart1.GetLegendText += TChart1_GetLegendText;
      this.tChart1.Axes.Bottom.MinimumOffset = 250;
      this.tChart1.Axes.Bottom.MaximumOffset = 150;

      tChart1.Panel.Gradient.Visible = false;

      Bubble bCloud = new Bubble(tChart1.Chart);

      bCloud.Add(1, 1175, 30.3, "Python");
      bCloud.Add(2, 1082.5, 22.2, "Java");
      bCloud.Add(3, 1077.5, 13, "C++");
      bCloud.Add(4, 1055, 10.6, "Ruby");
      bCloud.Add(5, 1042.5, 5.2, "JavaScript");
      bCloud.Add(6, 1035, 5, "C#");
      bCloud.Add(7, 1035, 4.1, "C");
      bCloud.Add(8, 1017.5, 3.3, "PHP");
      bCloud.Add(9, 1005, 1.6, "Perl");
      bCloud.Add(10, 975, 1.5, "Go");

      bCloud.Marks.Font.Color = Colors.Black;
    }

    private void TChart1_GetLegendText(object sender, GetLegendTextEventArgs e)
    {
      switch (e.Index)
      {
        case 0:
          e.Text = e.Text + " 30,3 %";
          break;
        case 1:
          e.Text = e.Text + " 22,2 %";
          break;
        case 2:
          e.Text = e.Text + " 13 %";
          break;
        case 3:
          e.Text = e.Text + " 10,6 %";
          break;
        case 4:
          e.Text = e.Text + " 5,2 %";
          break;
        case 5:
          e.Text = e.Text + " 5 %";
          break;
        case 6:
          e.Text = e.Text + " 4,1 %";
          break;
        case 7:
          e.Text = e.Text + " 3,3 %";
          break;
        case 8:
          e.Text = e.Text + " 1,6 %";
          break;
        case 9:
          e.Text = e.Text + " 1,5 %";
          break;

      }
    }

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
      if (e.Parameter is string)
      {
        this.Message = String.Format("Clicked on {0}", e.Parameter);
      }
      else
      {
        this.Message = "Hi!";
      }

      base.OnNavigatedTo(e);
    }

    public string Message { get; set; }
  }
}
