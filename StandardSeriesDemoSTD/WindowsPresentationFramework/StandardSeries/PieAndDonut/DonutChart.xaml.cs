using Steema.TeeChart.WPF;
using System;
using System.Collections.Generic;
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
  /// Interaction logic for DonutChart.xaml
  /// </summary>
  public partial class DonutChart : UserControl
  {
    public DonutChart()
    {
      InitializeComponent();
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

    private Steema.TeeChart.WPF.Styles.Donut donut1;

    private void InitializeChart()
    {
      this.donut1 = new Steema.TeeChart.WPF.Styles.Donut();
      this.tChart1.Aspect.ColorPaletteIndex = 17;
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart1.Header.Alignment = TextAlignment.Left;
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Size = 21;
      this.tChart1.Header.Lines = new string[] {
        "Countries by Area"};
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.TextStyle = Steema.TeeChart.WPF.LegendTextStyles.Plain;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      // donut1
      this.donut1.BevelPercent = 6;
      this.donut1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(184)))), ((int)(((byte)(113)))), ((int)(((byte)(230)))));
      this.donut1.Circled = true;
      this.donut1.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(162)))));
      this.donut1.Dark3D = false;
      this.donut1.Frame.Circled = true;
      this.donut1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut1.LabelMember = "Labels";
      this.donut1.Marks.Arrow.Color = Colors.Silver;
      this.donut1.Marks.Arrow.Width = 2;
      this.donut1.Marks.ArrowLength = 14;
      this.donut1.Marks.Brush.Visible = false;
      this.donut1.Marks.Style = Steema.TeeChart.WPF.Styles.MarksStyles.LabelPercent;
      this.donut1.Marks.Transparent = true;
      this.donut1.MarksPie.LegSize = 0;
      this.donut1.MarksPie.VertCenter = false;
      this.donut1.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.donut1.OriginalCursor = null;
      this.donut1.OtherSlice.Color = Utils.EmptyColor;
      this.donut1.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.donut1.OtherSlice.Text = "";
      this.donut1.OtherSlice.Value = 0D;
      this.donut1.Title = "donut1";
      this.donut1.UniqueCustomRadius = true;
      this.donut1.XValues.DataMember = "Angle";
      this.donut1.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.donut1.YValues.DataMember = "Pie";

    }
  }
}
