using Steema.TeeChart.Store;
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
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class DonutSubPage : Windows.UI.Xaml.Controls.Page
  {
    private Steema.TeeChart.Store.Styles.Donut donut1;

    public DonutSubPage()
    {
      this.InitializeComponent();
      InitializeChart();

      tChart1.Panel.Gradient.Visible = false;
      tChart1.Legend.Transparent = true;
      donut1.MarksPie.LegSize = 24;
      donut1.Marks.Callout.Distance = 10;

      donut1.Add(17098242, "Russia");
      donut1.Add(9984670, "Canada");
      donut1.Add(9572900, "China");
      donut1.Add(9526468, "United States");
      donut1.Add(8515767, "Brazil");
      donut1.Add(7692024, "Australia");
    }

    private void InitializeChart()
    {
      this.donut1 = new Steema.TeeChart.Store.Styles.Donut();
      this.tChart1.Aspect.ColorPaletteIndex = 17;
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Footer.Font.Brush.Color = Windows.UI.Colors.Blue;
      this.tChart1.Header.Alignment = TextAlignment.Left;
      this.tChart1.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Header.Font.Size = 21;
      this.tChart1.Header.Lines = new string[] {
        "Countries by Area"};
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.TextStyle = Steema.TeeChart.Store.LegendTextStyles.Plain;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      // donut1
      this.donut1.BevelPercent = 6;
      this.donut1.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(184)))), ((int)(((byte)(113)))), ((int)(((byte)(230)))));
      this.donut1.Circled = true;
      this.donut1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(162)))));
      this.donut1.Dark3D = false;
      this.donut1.Frame.Circled = true;
      this.donut1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut1.LabelMember = "Labels";
      this.donut1.Marks.Arrow.Color = Windows.UI.Colors.Silver;
      this.donut1.Marks.Arrow.Width = 2;
      this.donut1.Marks.ArrowLength = 14;
      this.donut1.Marks.Brush.Visible = false;
      this.donut1.Marks.Style = Steema.TeeChart.Store.Styles.MarksStyles.LabelPercent;
      this.donut1.Marks.Transparent = true;
      this.donut1.MarksPie.LegSize = 0;
      this.donut1.MarksPie.VertCenter = false;
      this.donut1.MultiPie = Steema.TeeChart.Store.Styles.MultiPies.Automatic;
      this.donut1.OriginalCursor = null;
      this.donut1.OtherSlice.Color = Utils.EmptyColor;
      this.donut1.OtherSlice.Style = Steema.TeeChart.Store.Styles.PieOtherStyles.None;
      this.donut1.OtherSlice.Text = "";
      this.donut1.OtherSlice.Value = 0D;
      this.donut1.Title = "donut1";
      this.donut1.UniqueCustomRadius = true;
      this.donut1.XValues.DataMember = "Angle";
      this.donut1.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.donut1.YValues.DataMember = "Pie";

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
