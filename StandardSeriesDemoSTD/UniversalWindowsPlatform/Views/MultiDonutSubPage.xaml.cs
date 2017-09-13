using Steema.TeeChart.Store;
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
  public sealed partial class MultiDonutSubPage : Windows.UI.Xaml.Controls.Page
  {

    private Steema.TeeChart.Store.Styles.Donut donut4;
    private Steema.TeeChart.Store.Styles.Donut donut3;
    private Steema.TeeChart.Store.Styles.Donut donut2;
    private Steema.TeeChart.Store.Styles.Donut donut1;
    private Steema.TeeChart.Store.Styles.HorizBar horizBar1;
    private Steema.TeeChart.Store.Animations.ChartPartAnimation chartPartAnimation1;
    private Steema.TeeChart.Store.Animations.ChartPartAnimation chartPartAnimation2;

    public MultiDonutSubPage()
    {
      InitializeComponent();
      InitializeChart();

      tChart1.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;
      tChart2.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;
      tChart3.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;
      tChart4.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;
      tChart5.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;

      tChart1.Panel.Gradient.Visible = false;
      tChart2.Panel.Gradient.Visible = false;
      tChart3.Panel.Gradient.Visible = false;
      tChart4.Panel.Gradient.Visible = false;
      tChart5.Panel.Gradient.Visible = false;

      initChart();
    }

    private void initChart()
    {
      donut1.Clear();
      donut1.Add(60, Color.FromArgb(255, 215, 215, 215));
      donut1.Add(40, Color.FromArgb(255, 249, 205, 32));

      donut2.Clear();
      donut2.Add(75, Color.FromArgb(255, 215, 215, 215));
      donut2.Add(25, Color.FromArgb(255, 243, 146, 37));

      donut3.Clear();
      donut3.Add(77, Color.FromArgb(255, 215, 215, 215));
      donut3.Add(23, Color.FromArgb(255, 249, 205, 32));

      donut4.Clear();
      donut4.Add(80, Color.FromArgb(255, 215, 215, 215));
      donut4.Add(20, Color.FromArgb(255, 243, 146, 37));

      horizBar1.Clear();
      horizBar1.Add(0.4, "Late at night in bed", Color.FromArgb(255, 249, 205, 32));
      horizBar1.Add(0.25, "While commuting", Color.FromArgb(255, 243, 146, 37));
      horizBar1.Add(0.23, "While having dinner", Color.FromArgb(255, 249, 205, 32));
      horizBar1.Add(0.20, "While shopping", Color.FromArgb(255, 243, 146, 37));
    }

    private void InitializeChart()
    {
      this.donut4 = new Steema.TeeChart.Store.Styles.Donut();
      this.donut3 = new Steema.TeeChart.Store.Styles.Donut();
      this.donut2 = new Steema.TeeChart.Store.Styles.Donut();
      this.donut1 = new Steema.TeeChart.Store.Styles.Donut();
      this.horizBar1 = new Steema.TeeChart.Store.Styles.HorizBar();
      this.chartPartAnimation1 = new Steema.TeeChart.Store.Animations.ChartPartAnimation(tChart5.Chart);
      this.chartPartAnimation2 = new Steema.TeeChart.Store.Animations.ChartPartAnimation(tChart1.Chart);

      this.tChart4.Aspect.ColorPaletteIndex = 14;
      this.tChart4.Aspect.Elevation = 315;
      this.tChart4.Aspect.ElevationFloat = 315D;
      this.tChart4.Aspect.Orthogonal = false;
      this.tChart4.Aspect.Perspective = 0;
      this.tChart4.Aspect.Rotation = 360;
      this.tChart4.Aspect.RotationFloat = 360D;
      this.tChart4.Aspect.View3D = false;
      this.tChart4.Axes.Automatic = true;
      this.tChart4.Axes.Bottom.Grid.Visible = false;
      this.tChart4.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart4.Axes.Bottom.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Left.AxisPen.Visible = false;
      this.tChart4.Axes.Left.Grid.Style = Steema.TeeChart.Store.Drawing.DashStyles.Solid;
      this.tChart4.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart4.Axes.Left.MinorTicks.Visible = false;
      this.tChart4.Axes.Left.Ticks.Visible = false;
      this.tChart4.Axes.Left.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Right.AxisPen.Visible = false;
      this.tChart4.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.Axes.Top.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart4.CurrentTheme = Steema.TeeChart.Store.ThemeType.Report;
      this.tChart4.Footer.Font.Bold = true;
      this.tChart4.Footer.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart4.Footer.Lines = new string[] {
        "WHILE SHOPPING"};
      this.tChart4.Footer.Visible = true;
      this.tChart4.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart4.Header.Visible = false;
      this.tChart4.Legend.Alignment = Steema.TeeChart.Store.LegendAlignments.Bottom;
      this.tChart4.Legend.Font.Bold = true;
      this.tChart4.Legend.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart4.Legend.Font.Name = "Segoe UI";
      this.tChart4.Legend.Font.Size = 24;
      this.tChart4.Legend.FontSeriesColor = true;
      this.tChart4.Legend.LegendStyle = Steema.TeeChart.Store.LegendStyles.LastValues;
      this.tChart4.Legend.Pen.Visible = false;
      this.tChart4.Legend.Shadow.Visible = false;
      this.tChart4.Legend.Symbol.Visible = false;
      this.tChart4.Legend.TopLeftPos = 5;
      this.tChart4.Legend.Transparent = true;
      this.tChart4.Legend.VertSpacing = -10;
      this.tChart4.Name = "tChart4";
      this.tChart4.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart4.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart4.Panel.Brush.Gradient.Visible = false;
      this.tChart4.Panel.Brush.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart4.Panel.Brush.Style = Steema.TeeChart.Store.Drawing.HatchStyle.BackwardDiagonal;
      this.tChart4.Panel.Image = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/label.png"));
      this.tChart4.Panel.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart4.Panel.MarginBottom = 2D;
      this.tChart4.Series.Add(this.donut4);
      this.tChart4.SubFooter.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart4.TabIndex = 3;
      this.tChart4.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart4.Walls.Back.Brush.Visible = false;
      this.tChart4.Walls.Back.Transparent = true;
      this.tChart4.Walls.Back.Visible = false;
      this.donut4.AutoPenColor = false;
      this.donut4.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
      this.donut4.Circled = true;
      this.donut4.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut4.DonutPercent = 60;
      this.donut4.Frame.Circled = true;
      this.donut4.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut4.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut4.Frame.Width = 4;
      this.donut4.LabelMember = "Labels";
      this.donut4.Marks.Arrow.Visible = false;
      this.donut4.Marks.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut4.Marks.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.donut4.Marks.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
      this.donut4.Marks.Shadow.Visible = false;
      this.donut4.Marks.Visible = false;
      this.donut4.MarksPie.LegSize = 0;
      this.donut4.MarksPie.VertCenter = false;
      this.donut4.MultiPie = Steema.TeeChart.Store.Styles.MultiPies.Automatic;
      this.donut4.OriginalCursor = null;
      this.donut4.OtherSlice.Color = Utils.EmptyColor;
      this.donut4.OtherSlice.Style = Steema.TeeChart.Store.Styles.PieOtherStyles.None;
      this.donut4.OtherSlice.Text = "";
      this.donut4.OtherSlice.Value = 0D;
      this.donut4.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut4.Pen.Width = 3;
      this.donut4.RotationAngle = 91;
      this.donut4.Title = "donut1";
      this.donut4.UniqueCustomRadius = true;
      this.donut4.XValues.DataMember = "Angle";
      this.donut4.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.donut4.YValues.DataMember = "Pie";
      // tChart3
      this.tChart3.Aspect.ColorPaletteIndex = 14;
      this.tChart3.Aspect.Elevation = 315;
      this.tChart3.Aspect.ElevationFloat = 315D;
      this.tChart3.Aspect.Orthogonal = false;
      this.tChart3.Aspect.Perspective = 0;
      this.tChart3.Aspect.Rotation = 360;
      this.tChart3.Aspect.RotationFloat = 360D;
      this.tChart3.Aspect.View3D = false;
      this.tChart3.Axes.Automatic = true;
      this.tChart3.Axes.Bottom.Grid.Visible = false;
      this.tChart3.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart3.Axes.Bottom.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Left.AxisPen.Visible = false;
      this.tChart3.Axes.Left.Grid.Style = Steema.TeeChart.Store.Drawing.DashStyles.Solid;
      this.tChart3.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Axes.Left.MinorTicks.Visible = false;
      this.tChart3.Axes.Left.Ticks.Visible = false;
      this.tChart3.Axes.Left.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Right.AxisPen.Visible = false;
      this.tChart3.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.Axes.Top.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart3.CurrentTheme = Steema.TeeChart.Store.ThemeType.Report;
      this.tChart3.Footer.Font.Bold = true;
      this.tChart3.Footer.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Footer.Lines = new string[] {
        "WHILE HAVING DINNER"};
      this.tChart3.Footer.Visible = true;
      this.tChart3.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Header.Visible = false;
      this.tChart3.Legend.Alignment = Steema.TeeChart.Store.LegendAlignments.Bottom;
      this.tChart3.Legend.Font.Bold = true;
      this.tChart3.Legend.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart3.Legend.Font.Name = "Segoe UI";
      this.tChart3.Legend.Font.Size = 24;
      this.tChart3.Legend.FontSeriesColor = true;
      this.tChart3.Legend.LegendStyle = Steema.TeeChart.Store.LegendStyles.LastValues;
      this.tChart3.Legend.Pen.Visible = false;
      this.tChart3.Legend.Shadow.Visible = false;
      this.tChart3.Legend.Symbol.Visible = false;
      this.tChart3.Legend.TopLeftPos = 5;
      this.tChart3.Legend.Transparent = true;
      this.tChart3.Legend.VertSpacing = -10;
      this.tChart3.Name = "tChart3";
      this.tChart3.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart3.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart3.Panel.Brush.Gradient.Visible = false;
      //this.tChart3.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
      this.tChart3.Panel.Brush.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart3.Panel.Brush.Style = Steema.TeeChart.Store.Drawing.HatchStyle.BackwardDiagonal;
      this.tChart3.Panel.Image = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/knifefork.png"));
      this.tChart3.Panel.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart3.Panel.MarginBottom = 2D;
      this.tChart3.Series.Add(this.donut3);
      this.tChart3.SubFooter.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.TabIndex = 2;
      this.tChart3.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart3.Walls.Back.Brush.Visible = false;
      this.tChart3.Walls.Back.Transparent = true;
      this.tChart3.Walls.Back.Visible = false;
      this.donut3.AutoPenColor = false;
      this.donut3.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
      this.donut3.Circled = true;
      this.donut3.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut3.DonutPercent = 60;
      this.donut3.Frame.Circled = true;
      this.donut3.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut3.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut3.Frame.Width = 4;
      this.donut3.LabelMember = "Labels";
      this.donut3.Marks.Arrow.Visible = false;
      this.donut3.Marks.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut3.Marks.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.donut3.Marks.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
      this.donut3.Marks.Shadow.Visible = false;
      this.donut3.Marks.Visible = false;
      this.donut3.MarksPie.LegSize = 0;
      this.donut3.MarksPie.VertCenter = false;
      this.donut3.MultiPie = Steema.TeeChart.Store.Styles.MultiPies.Automatic;
      this.donut3.OriginalCursor = null;
      this.donut3.OtherSlice.Color = Utils.EmptyColor;
      this.donut3.OtherSlice.Style = Steema.TeeChart.Store.Styles.PieOtherStyles.None;
      this.donut3.OtherSlice.Text = "";
      this.donut3.OtherSlice.Value = 0D;
      this.donut3.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut3.Pen.Width = 3;
      this.donut3.RotationAngle = 91;
      this.donut3.Title = "donut1";
      this.donut3.UniqueCustomRadius = true;
      this.donut3.XValues.DataMember = "Angle";
      this.donut3.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.donut3.YValues.DataMember = "Pie";
      this.tChart2.Aspect.ColorPaletteIndex = 14;
      this.tChart2.Aspect.Elevation = 315;
      this.tChart2.Aspect.ElevationFloat = 315D;
      this.tChart2.Aspect.Orthogonal = false;
      this.tChart2.Aspect.Perspective = 0;
      this.tChart2.Aspect.Rotation = 360;
      this.tChart2.Aspect.RotationFloat = 360D;
      this.tChart2.Aspect.View3D = false;
      this.tChart2.Axes.Automatic = true;
      this.tChart2.Axes.Bottom.Grid.Visible = false;
      this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart2.Axes.Bottom.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Left.AxisPen.Visible = false;
      this.tChart2.Axes.Left.Grid.Style = Steema.TeeChart.Store.Drawing.DashStyles.Solid;
      this.tChart2.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Axes.Left.MinorTicks.Visible = false;
      this.tChart2.Axes.Left.Ticks.Visible = false;
      this.tChart2.Axes.Left.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Right.AxisPen.Visible = false;
      this.tChart2.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.Axes.Top.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart2.CurrentTheme = Steema.TeeChart.Store.ThemeType.Report;
      this.tChart2.Footer.Font.Bold = true;
      this.tChart2.Footer.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Footer.Lines = new string[] {
        "WHILE COMMUTING"};
      this.tChart2.Footer.Visible = true;
      this.tChart2.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Header.Visible = false;
      this.tChart2.Legend.Alignment = Steema.TeeChart.Store.LegendAlignments.Bottom;
      this.tChart2.Legend.Font.Bold = true;
      this.tChart2.Legend.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart2.Legend.Font.Name = "Segoe UI";
      this.tChart2.Legend.Font.Size = 24;
      this.tChart2.Legend.FontSeriesColor = true;
      this.tChart2.Legend.LegendStyle = Steema.TeeChart.Store.LegendStyles.LastValues;
      this.tChart2.Legend.Pen.Visible = false;
      this.tChart2.Legend.Shadow.Visible = false;
      this.tChart2.Legend.Symbol.Visible = false;
      this.tChart2.Legend.TopLeftPos = 5;
      this.tChart2.Legend.Transparent = true;
      this.tChart2.Legend.VertSpacing = -10;
      this.tChart2.Name = "tChart2";
      this.tChart2.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart2.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart2.Panel.Brush.Gradient.Visible = false;
      //this.tChart2.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
      this.tChart2.Panel.Brush.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart2.Panel.Brush.Style = Steema.TeeChart.Store.Drawing.HatchStyle.BackwardDiagonal;
      this.tChart2.Panel.Image = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/bus.png"));
      this.tChart2.Panel.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart2.Panel.MarginBottom = 2D;
      this.tChart2.Series.Add(this.donut2);
      this.tChart2.SubFooter.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.TabIndex = 1;
      this.tChart2.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart2.Walls.Back.Brush.Visible = false;
      this.tChart2.Walls.Back.Transparent = true;
      this.tChart2.Walls.Back.Visible = false;
      this.donut2.AutoPenColor = false;
      this.donut2.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(179)))), ((int)(((byte)(8)))), ((int)(((byte)(14)))));
      this.donut2.Circled = true;
      this.donut2.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut2.DonutPercent = 60;
      this.donut2.Frame.Circled = true;
      this.donut2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut2.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut2.Frame.Width = 4;
      this.donut2.LabelMember = "Labels";
      this.donut2.Marks.Arrow.Visible = false;
      this.donut2.Marks.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut2.Marks.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.donut2.Marks.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
      this.donut2.Marks.Shadow.Visible = false;
      this.donut2.Marks.Visible = false;
      this.donut2.MarksPie.LegSize = 0;
      this.donut2.MarksPie.VertCenter = false;
      this.donut2.MultiPie = Steema.TeeChart.Store.Styles.MultiPies.Automatic;
      this.donut2.OriginalCursor = null;
      this.donut2.OtherSlice.Color = Utils.EmptyColor;
      this.donut2.OtherSlice.Style = Steema.TeeChart.Store.Styles.PieOtherStyles.None;
      this.donut2.OtherSlice.Text = "";
      this.donut2.OtherSlice.Value = 0D;
      this.donut2.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut2.Pen.Width = 3;
      this.donut2.RotationAngle = 91;
      this.donut2.Title = "donut1";
      this.donut2.UniqueCustomRadius = true;
      this.donut2.XValues.DataMember = "Angle";
      this.donut2.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.donut2.YValues.DataMember = "Pie";
      this.tChart1.Aspect.ColorPaletteIndex = 21;
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Automatic = true;
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.Grid.Style = Steema.TeeChart.Store.Drawing.DashStyles.Solid;
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      this.tChart1.Axes.Left.Ticks.Visible = false;
      this.tChart1.Axes.Left.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Right.AxisPen.Visible = false;
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.CurrentTheme = Steema.TeeChart.Store.ThemeType.Report;
      this.tChart1.Footer.Font.Bold = true;
      this.tChart1.Footer.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Footer.Lines = new string[] {
        "LATE AT NIGHT IN BED"};
      this.tChart1.Footer.Visible = true;
      this.tChart1.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Header.Visible = false;
      this.tChart1.Legend.Alignment = Steema.TeeChart.Store.LegendAlignments.Bottom;
      this.tChart1.Legend.Font.Bold = true;
      this.tChart1.Legend.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 24;
      this.tChart1.Legend.FontSeriesColor = true;
      this.tChart1.Legend.LegendStyle = Steema.TeeChart.Store.LegendStyles.LastValues;
      this.tChart1.Legend.Pen.Visible = false;
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Symbol.Visible = false;
      this.tChart1.Legend.TopLeftPos = 5;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Legend.VertSpacing = -10;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      //this.tChart1.Panel.Brush.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
      this.tChart1.Panel.Brush.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart1.Panel.Brush.Style = Steema.TeeChart.Store.Drawing.HatchStyle.BackwardDiagonal;
      this.tChart1.Panel.Image = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/bed.png"));
      this.tChart1.Panel.ImageMode = Steema.TeeChart.Store.Drawing.ImageMode.Center;
      this.tChart1.Panel.MarginBottom = 2D;
      this.tChart1.Series.Add(this.donut1);
      this.tChart1.SubFooter.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Walls.Back.Brush.Visible = false;
      this.tChart1.Walls.Back.Transparent = true;
      this.tChart1.Walls.Back.Visible = false;
      this.donut1.AutoPenColor = false;
      this.donut1.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(201)))), ((int)(((byte)(159)))));
      this.donut1.Circled = true;
      this.donut1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.donut1.DonutPercent = 60;
      this.donut1.Frame.Circled = true;
      this.donut1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.donut1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.donut1.Frame.Width = 4;
      this.donut1.LabelMember = "Labels";
      this.donut1.Marks.Arrow.Visible = false;
      this.donut1.Marks.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut1.Marks.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.donut1.Marks.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
      this.donut1.Marks.Shadow.Visible = false;
      this.donut1.Marks.Visible = false;
      this.donut1.MarksPie.LegSize = 0;
      this.donut1.MarksPie.VertCenter = false;
      this.donut1.MultiPie = Steema.TeeChart.Store.Styles.MultiPies.Automatic;
      this.donut1.OriginalCursor = null;
      this.donut1.OtherSlice.Color = Utils.EmptyColor;
      this.donut1.OtherSlice.Style = Steema.TeeChart.Store.Styles.PieOtherStyles.None;
      this.donut1.OtherSlice.Text = "";
      this.donut1.OtherSlice.Value = 0D;
      this.donut1.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.donut1.Pen.Width = 3;
      this.donut1.RotationAngle = 91;
      this.donut1.Title = "donut1";
      this.donut1.UniqueCustomRadius = true;
      this.donut1.XValues.DataMember = "Angle";
      this.donut1.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.donut1.YValues.DataMember = "Pie";
      this.label1.Name = "label1";
      this.label1.Text = "Ericson consumerLab.   2014";
      this.label2.Name = "label2";
      this.label2.Text = "Where do customers watch mobile video content ?";
      this.tChart5.Aspect.ColorPaletteIndex = 14;
      this.tChart5.Aspect.View3D = false;
      this.tChart5.Axes.Automatic = true;
      this.tChart5.Axes.Bottom.AxisPen.Visible = false;
      this.tChart5.Axes.Bottom.Grid.Visible = false;
      this.tChart5.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart5.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart5.Axes.Bottom.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart5.Axes.Bottom.Visible = false;
      this.tChart5.Axes.Left.AxisPen.Color = Windows.UI.Colors.Gray;
      this.tChart5.Axes.Left.AxisPen.Visible = false;
      this.tChart5.Axes.Left.AxisPen.Width = 1;
      this.tChart5.Axes.Left.Grid.Style = Steema.TeeChart.Store.Drawing.DashStyles.Solid;
      this.tChart5.Axes.Left.Grid.Visible = false;
      this.tChart5.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart5.Axes.Left.Labels.Font.Name = "Segoe UI";
      this.tChart5.Axes.Left.Labels.Font.Size = 16;
      this.tChart5.Axes.Left.MinorTicks.Visible = false;
      this.tChart5.Axes.Left.Ticks.Visible = false;
      this.tChart5.Axes.Left.Title.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart5.Axes.Right.AxisPen.Visible = false;
      this.tChart5.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart5.Axes.Top.Labels.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart5.CurrentTheme = Steema.TeeChart.Store.ThemeType.Report;
      this.tChart5.Footer.Font.Brush.Color = Windows.UI.Colors.Blue;
      this.tChart5.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart5.Header.Visible = false;
      this.tChart5.Legend.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart5.Legend.Pen.Visible = false;
      this.tChart5.Legend.Shadow.Visible = false;
      this.tChart5.Legend.Transparent = true;
      this.tChart5.Legend.Visible = false;
      this.tChart5.Name = "tChart5";
      this.tChart5.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart5.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart5.Panel.Brush.Gradient.Visible = false;
      this.tChart5.Series.Add(this.horizBar1);
      this.tChart5.TabIndex = 3;
      this.tChart5.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart5.Walls.Back.Brush.Visible = false;
      this.tChart5.Walls.Back.Transparent = true;
      this.tChart5.Walls.Back.Visible = false;
      // horizBar1
      this.horizBar1.BarHeightPercent = 90;
      this.horizBar1.BarRound = Steema.TeeChart.Store.Styles.BarRounding.AtValue;
      this.horizBar1.BarStyle = Steema.TeeChart.Store.Styles.BarStyles.RoundRectangle;
      this.horizBar1.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.horizBar1.Brush.Gradient.Direction = Steema.TeeChart.Store.Drawing.GradientDirection.TopBottom;
      this.horizBar1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(234)))), ((int)(((byte)(141)))));
      this.horizBar1.ColorEach = false;
      this.horizBar1.Marks.Arrow.Visible = false;
      this.horizBar1.Marks.ArrowLength = 8;
      this.horizBar1.Marks.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.horizBar1.Marks.Brush.Visible = false;
      this.horizBar1.Marks.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.horizBar1.Marks.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(219)))), ((int)(((byte)(211)))), ((int)(((byte)(127)))));
      this.horizBar1.Marks.Shadow.Visible = false;
      this.horizBar1.Marks.Style = Steema.TeeChart.Store.Styles.MarksStyles.Value;
      this.horizBar1.OriginalCursor = null;
      this.horizBar1.Pen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(140)))), ((int)(((byte)(85)))));
      this.horizBar1.Pen.Visible = false;
      this.horizBar1.Title = "horizBar1";
      this.horizBar1.ValueFormat = "## %";
      this.horizBar1.XValues.DataMember = "X";
      this.horizBar1.YValues.DataMember = "Bar";
      this.horizBar1.YValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;

      this.chartPartAnimation1.Axis = null;
      this.chartPartAnimation1.EasingFunction = new Windows.UI.Xaml.Media.Animation.BounceEase();
      this.chartPartAnimation1.EasingMode = Windows.UI.Xaml.Media.Animation.EasingMode.EaseIn;
      this.chartPartAnimation1.Fade = Steema.TeeChart.Store.Animations.TransformFade.None;
      this.chartPartAnimation1.RotateMax = 0F;
      this.chartPartAnimation1.RotateMin = 0F;
      this.chartPartAnimation1.Series = null;
      this.chartPartAnimation1.Speed = 2000;
      this.chartPartAnimation1.Target = ChartClickedPartStyle.Series;
      this.chartPartAnimation1.ZoomStyle = Steema.TeeChart.Store.Animations.TransformZoom.None;
      this.chartPartAnimation1.Trigger = Steema.TeeChart.Store.Animations.AnimationTrigger.MouseOver;

      this.chartPartAnimation2.Axis = null;
      this.chartPartAnimation2.EasingFunction = new Windows.UI.Xaml.Media.Animation.CircleEase();
      this.chartPartAnimation2.EasingMode = Windows.UI.Xaml.Media.Animation.EasingMode.EaseIn;
      this.chartPartAnimation2.Fade = Steema.TeeChart.Store.Animations.TransformFade.In;
      this.chartPartAnimation2.RotateMax = 360F;
      this.chartPartAnimation2.RotateMin = 0F;
      this.chartPartAnimation2.Series = null;
      this.chartPartAnimation2.Speed = 2000;
      this.chartPartAnimation2.Target = ChartClickedPartStyle.Series;
      this.chartPartAnimation2.TranslateStyle = Steema.TeeChart.Store.Animations.TransformTranslate.None;
      this.chartPartAnimation2.ZoomStyle = Steema.TeeChart.Store.Animations.TransformZoom.None;
      this.chartPartAnimation1.Trigger = Steema.TeeChart.Store.Animations.AnimationTrigger.MouseOver;

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
