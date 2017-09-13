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
  /// Interaction logic for WebAnalytics.xaml
  /// </summary>
  public partial class WebAnalytics : UserControl
  {
    public WebAnalytics()
    {
      InitializeComponent();

      InitializeChart();

      tChart1.Panel.Gradient.Visible = false;
      tChart2.Panel.Gradient.Visible = false;
      tChart3.Panel.Gradient.Visible = false;
      tChart4.Panel.Gradient.Visible = false;

      donut1.Clear();
      donut1.Add(750, Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163))))));
      donut1.Add(250, Colors.Transparent);

      donut2.Clear();
      donut2.Add(3390, Colors.Green);
      donut2.Add(2510, Colors.Transparent);

      donut3.Clear();
      donut3.Add(1500, Colors.Red);
      donut3.Add(500, Colors.Transparent);

      double[] vals1 = new double[] { 220, 150, 135, 190, 210, 200 };
      double[] vals2 = new double[] { 100, 70, 100, 150, 110, 24 };
      double[] vals3 = new double[] { 100, 130, 80, 130, 126, 240 };

      line1.Smoothed = true;
      line2.Smoothed = true;
      line3.Smoothed = true;
      line1.Add(vals1);
      line2.Add(vals2);
      line3.Add(vals3);
    }

    private Steema.TeeChart.WPF.Styles.Donut donut3;
    private Steema.TeeChart.WPF.Tools.Annotation annotation3;
    private Steema.TeeChart.WPF.Styles.Donut donut2;
    private Steema.TeeChart.WPF.Tools.Annotation annotation2;
    private Steema.TeeChart.WPF.Styles.Line line1;
    private Steema.TeeChart.WPF.Styles.Line line2;
    private Steema.TeeChart.WPF.Styles.Line line3;
    private Steema.TeeChart.WPF.Styles.Donut donut1;
    private Steema.TeeChart.WPF.Tools.Annotation annotation1;
    private Steema.TeeChart.WPF.Data.TextSource textSource1;

    private void InitializeChart()
    {
      this.donut3 = new Steema.TeeChart.WPF.Styles.Donut();
      this.annotation3 = new Steema.TeeChart.WPF.Tools.Annotation();
      this.donut2 = new Steema.TeeChart.WPF.Styles.Donut();
      this.annotation2 = new Steema.TeeChart.WPF.Tools.Annotation();
      this.line1 = new Steema.TeeChart.WPF.Styles.Line();
      this.line2 = new Steema.TeeChart.WPF.Styles.Line();
      this.line3 = new Steema.TeeChart.WPF.Styles.Line();
      this.donut1 = new Steema.TeeChart.WPF.Styles.Donut();
      this.annotation1 = new Steema.TeeChart.WPF.Tools.Annotation();
      this.tChart3.Aspect.Elevation = 315;
      this.tChart3.Aspect.ElevationFloat = 315D;
      this.tChart3.Aspect.Orthogonal = false;
      this.tChart3.Aspect.Perspective = 0;
      this.tChart3.Aspect.Rotation = 360;
      this.tChart3.Aspect.RotationFloat = 360D;
      this.tChart3.Aspect.View3D = false;
      this.tChart3.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart3.Header.Visible = false;
      this.tChart3.Legend.Visible = false;
      this.tChart3.Name = "tChart3";
      this.tChart3.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.tChart3.Panel.Brush.Color = Colors.White;
      this.tChart3.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart3.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart3.Series.Add(this.donut3);
      this.tChart3.TabIndex = 3;
      this.tChart3.Tools.Add(this.annotation3);
      this.tChart3.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.donut3.Brush.Color = Color.FromArgb(255, ((((byte)(243)))), ((((byte)(156)))), ((((byte)(53)))));
      this.donut3.Circled = true;
      this.donut3.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.donut3.DonutPercent = 95;
      this.donut3.Frame.Circled = true;
      this.donut3.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut3.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut3.LabelMember = "Labels";
      this.donut3.Marks.Visible = false;
      this.donut3.MarksPie.LegSize = 0;
      this.donut3.MarksPie.VertCenter = false;
      this.donut3.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.donut3.OriginalCursor = null;
      this.donut3.OtherSlice.Color = Utils.EmptyColor;
      this.donut3.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.donut3.OtherSlice.Text = "";
      this.donut3.OtherSlice.Value = 0D;
      this.donut3.RotationAngle = 180;
      this.donut3.Shadow.Height = 3;
      this.donut3.Shadow.Width = 3;
      this.donut3.Title = "Series0";
      this.donut3.UniqueCustomRadius = true;
      this.donut3.XValues.DataMember = "Angle";
      this.donut3.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.donut3.YValues.DataMember = "Pie";
      this.annotation3.AutoSize = true;
      this.annotation3.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.annotation3.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.annotation3.Callout.ArrowHeadSize = 8;
      this.annotation3.Callout.Brush.Color = Colors.Black;
      this.annotation3.Callout.Distance = 0;
      this.annotation3.Callout.Draw3D = false;
      this.annotation3.Callout.SizeDouble = 0D;
      this.annotation3.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.annotation3.Callout.XPosition = 0;
      this.annotation3.Callout.YPosition = 0;
      this.annotation3.Callout.ZPosition = 0;
      this.annotation3.Position = Steema.TeeChart.WPF.Tools.AnnotationPositions.Center;
      this.annotation3.Shape.Font.Name = "Segoe UI";
      this.annotation3.Shape.Font.Size = 29;
      this.annotation3.Shape.Lines = new string[] {
        "$1500"};
      this.annotation3.Shape.Transparent = true;
      this.annotation3.Text = "$1500";
      this.tChart2.Aspect.Elevation = 315;
      this.tChart2.Aspect.ElevationFloat = 315D;
      this.tChart2.Aspect.Orthogonal = false;
      this.tChart2.Aspect.Perspective = 0;
      this.tChart2.Aspect.Rotation = 360;
      this.tChart2.Aspect.RotationFloat = 360D;
      this.tChart2.Aspect.View3D = false;
      this.tChart2.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart2.Header.Visible = false;
      this.tChart2.Legend.Visible = false;
      this.tChart2.Name = "tChart2";
      this.tChart2.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.tChart2.Panel.Brush.Color = Colors.White;
      this.tChart2.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart2.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart2.Series.Add(this.donut2);
      this.tChart2.TabIndex = 2;
      this.tChart2.Tools.Add(this.annotation2);
      this.tChart2.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.donut2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.donut2.Circled = true;
      this.donut2.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.donut2.DonutPercent = 95;
      this.donut2.Frame.Circled = true;
      this.donut2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut2.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut2.LabelMember = "Labels";
      this.donut2.Marks.Visible = false;
      this.donut2.MarksPie.LegSize = 0;
      this.donut2.MarksPie.VertCenter = false;
      this.donut2.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.donut2.OriginalCursor = null;
      this.donut2.OtherSlice.Color = Utils.EmptyColor;
      this.donut2.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.donut2.OtherSlice.Text = "";
      this.donut2.OtherSlice.Value = 0D;
      this.donut2.RotationAngle = 247;
      this.donut2.Shadow.Height = 3;
      this.donut2.Shadow.Width = 3;
      this.donut2.Title = "Series0";
      this.donut2.UniqueCustomRadius = true;
      this.donut2.XValues.DataMember = "Angle";
      this.donut2.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.donut2.YValues.DataMember = "Pie";
      this.annotation2.AutoSize = true;
      this.annotation2.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.annotation2.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.annotation2.Callout.ArrowHeadSize = 8;
      this.annotation2.Callout.Brush.Color = Colors.Black;
      this.annotation2.Callout.Distance = 0;
      this.annotation2.Callout.Draw3D = false;
      this.annotation2.Callout.SizeDouble = 0D;
      this.annotation2.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.annotation2.Callout.XPosition = 0;
      this.annotation2.Callout.YPosition = 0;
      this.annotation2.Callout.ZPosition = 0;
      this.annotation2.Position = Steema.TeeChart.WPF.Tools.AnnotationPositions.Center;
      this.annotation2.Shape.Font.Name = "Segoe UI";
      this.annotation2.Shape.Font.Size = 29;
      this.annotation2.Shape.Lines = new string[] {
        "3390"};
      this.annotation2.Shape.Transparent = true;
      this.annotation2.Text = "3390";
      this.tChart4.Aspect.View3D = false;
      this.tChart4.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart4.Axes.Left.Grid.Visible = false;
      this.tChart4.Axes.Left.Increment = 20D;
      this.tChart4.Axes.Left.MinorTicks.Visible = false;
      this.tChart4.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart4.Header.Visible = false;
      this.tChart4.Legend.Alignment = Steema.TeeChart.WPF.LegendAlignments.Bottom;
      this.tChart4.Legend.Transparent = true;
      this.tChart4.Name = "tChart4";
      this.tChart4.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.tChart4.Panel.Brush.Color = Colors.White;
      this.tChart4.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart4.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart4.Series.Add(this.line1);
      this.tChart4.Series.Add(this.line2);
      this.tChart4.Series.Add(this.line3);
      this.tChart4.TabIndex = 0;
      this.tChart4.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart4.Walls.Back.Visible = false;
      this.tChart4.AfterDraw += new Steema.TeeChart.WPF.PaintChartEventHandler(this.tChart4_AfterDraw);
      this.line1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.line1.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.line1.ColorEach = false;
      this.line1.ColorMember = "Colors";
      this.line1.LinePen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.line1.LinePen.Width = 4;
      this.line1.OriginalCursor = null;
      this.line1.Pointer.Pen.Visible = false;
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.line1.Pointer.Style = Steema.TeeChart.WPF.Styles.PointerStyles.Circle;
      this.line1.Title = "Speed";
      this.line1.XValues.DataMember = "X";
      this.line1.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.line1.YValues.DataMember = "Y";
      this.line2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(6)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
      this.line2.Color = Color.FromArgb(255, ((int)(((byte)(6)))), ((int)(((byte)(191)))), ((int)(((byte)(89)))));
      this.line2.ColorEach = false;
      this.line2.LinePen.Color = Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.line2.LinePen.Width = 4;
      this.line2.OriginalCursor = null;
      this.line2.Pointer.Pen.Visible = false;
      this.line2.Pointer.SizeDouble = 0D;
      this.line2.Pointer.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.line2.Pointer.Style = Steema.TeeChart.WPF.Styles.PointerStyles.Circle;
      this.line2.Title = "Time";
      this.line2.XValues.DataMember = "X";
      this.line2.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.line2.YValues.DataMember = "Y";
      this.line3.Brush.Color = Color.FromArgb(255, ((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.line3.Color = Color.FromArgb(255, ((int)(((byte)(238)))), ((int)(((byte)(17)))), ((int)(((byte)(34)))));
      this.line3.ColorEach = false;
      this.line3.ColorMember = "Colors";
      this.line3.LinePen.Color = Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.line3.LinePen.Width = 4;
      this.line3.OriginalCursor = null;
      this.line3.Pointer.Pen.Visible = false;
      this.line3.Pointer.SizeDouble = 0D;
      this.line3.Pointer.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.line3.Pointer.Style = Steema.TeeChart.WPF.Styles.PointerStyles.Circle;
      this.line3.Title = "Visitors";
      this.line3.XValues.DataMember = "X";
      this.line3.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.line3.YValues.DataMember = "Y";
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Visible = false;
      this.tChart1.Legend.Visible = false;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.tChart1.Panel.Brush.Color = Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.TabIndex = 1;
      this.tChart1.Tools.Add(this.annotation1);
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.donut1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.donut1.Circled = true;
      this.donut1.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.donut1.DonutPercent = 95;
      this.donut1.Frame.Circled = true;
      this.donut1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut1.LabelMember = "Labels";
      this.donut1.Marks.Visible = false;
      this.donut1.MarksPie.LegSize = 0;
      this.donut1.MarksPie.VertCenter = false;
      this.donut1.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.donut1.OriginalCursor = null;
      this.donut1.OtherSlice.Color = Utils.EmptyColor;
      this.donut1.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.donut1.OtherSlice.Text = "";
      this.donut1.OtherSlice.Value = 0D;
      this.donut1.RotationAngle = 180;
      this.donut1.Shadow.Height = 3;
      this.donut1.Shadow.Width = 3;
      this.donut1.Title = "Series0";
      this.donut1.UniqueCustomRadius = true;
      this.donut1.XValues.DataMember = "Angle";
      this.donut1.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.donut1.YValues.DataMember = "Pie";
      this.annotation1.AutoSize = true;
      this.annotation1.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.annotation1.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.annotation1.Callout.ArrowHeadSize = 8;
      this.annotation1.Callout.Brush.Color = Colors.Black;
      this.annotation1.Callout.Distance = 0;
      this.annotation1.Callout.Draw3D = false;
      this.annotation1.Callout.SizeDouble = 0D;
      this.annotation1.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.annotation1.Callout.XPosition = 0;
      this.annotation1.Callout.YPosition = 0;
      this.annotation1.Callout.ZPosition = 0;
      this.annotation1.Position = Steema.TeeChart.WPF.Tools.AnnotationPositions.Center;
      this.annotation1.Shape.Font.Name = "Segoe UI";
      this.annotation1.Shape.Font.Size = 29;
      this.annotation1.Shape.Lines = new string[] {
        "$750"};
      this.annotation1.Shape.Transparent = true;
      this.annotation1.Text = "$750";

    }

    private double xVal;
    int posRepainted = 0;
    private void tChart4_AfterDraw(object sender, Steema.TeeChart.WPF.Drawing.Graphics3D g)
    {
      if (posRepainted == 0)
      {
        posRepainted = 1;
        tChart4.Invalidate();

      }
      //setup centre positions of titles on chart
      //relative to their text lengths
      tChart1.Invalidate();
      tChart2.Invalidate();
      tChart3.Invalidate();
      posRepainted = 2;

      {
        double xs = tChart4.Axes.Bottom.CalcXPosValue(xVal);
        double ys;
        g.Brush.Visible = true;
        g.Brush.Solid = true;
        for (int i = 0; i < tChart4.Series.Count; i++)
          if (tChart4.Series[i] is Steema.TeeChart.WPF.Styles.Custom)
          {
            ys = tChart4.Series[i].GetVertAxis.CalcYPosValue(InterpolateLineSeries(tChart4.Series[i] as Steema.TeeChart.WPF.Styles.Custom, xVal));
            g.Brush.Color = tChart4.Series[i].Color;
            g.Ellipse(new Rect(xs - 4, ys - 4, 8, 8));
          }
      }
    }

    private double InterpolateLineSeries(Steema.TeeChart.WPF.Styles.Custom series, double xvalue)
    {
      return InterpolateLineSeries(series, series.FirstVisibleIndex, series.LastVisibleIndex, xvalue);
    }

    /// <summary>
    /// Calculate y=y(x) for arbitrary x. Works fine only for line series with ordered x values.
    /// </summary>
    /// <param name="series"></param>
    /// <param name="firstindex"></param>
    /// <param name="lastindex"></param>
    /// <param name="xvalue"></param>
    /// <returns>y=y(xvalue) where xvalue is arbitrary x value.</returns>
    private double InterpolateLineSeries(Steema.TeeChart.WPF.Styles.Custom series, int firstindex, int lastindex, double xvalue)
    {
      int index;
      for (index = firstindex; index <= lastindex; index++)
      {
        if (index == -1 || series.XValues.Value[index] > xvalue) break;
      }
      // safeguard
      if (index < 1) index = 1;
      else if (index >= series.Count) index = series.Count - 1;
      // y=(y2-y1)/(x2-x1)*(x-x1)+y1
      double dx = series.XValues[index] - series.XValues[index - 1];
      double dy = series.YValues[index] - series.YValues[index - 1];
      if (dx != 0.0) return dy * (xvalue - series.XValues[index - 1]) / dx + series.YValues[index - 1];
      else return 0.0;
    }
  }
}
