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
  public sealed partial class PieSalesFiguresSubPage : Windows.UI.Xaml.Controls.Page
  {

    private Steema.TeeChart.Store.Styles.NumericGauge numericGauge1;
    private Steema.TeeChart.Store.Styles.Pie pie1;
    private Steema.TeeChart.Store.Styles.NumericGauge numericGauge2;

    public PieSalesFiguresSubPage()
    {
      this.InitializeComponent();
      InitializeChart();

      pie1.Add(19, "Facebook");
      pie1.Add(14, "Tencent");
      pie1.Add(9, "WhatsApp");
      pie1.Add(5, "LinkedIn");
      pie1.Add(4, "Twitter");

      pie1.MarksPie.LegSize = 20;
      pie1.Marks.FontSeriesColor = true;

      tChart2.Panel.Gradient.Visible = false;
      tChart3.Panel.Gradient.Visible = false;

      //numericGauges
      setGauge(numericGauge1);
      numericGauge1.Markers[1].Text = "Highest";
      numericGauge1.Markers[2].Text = "Facebook";

      setGauge(numericGauge2);
      numericGauge2.Markers[1].Text = "Lowest";
      numericGauge2.Markers[2].Text = "Twitter";
    }

    private void setGauge(Steema.TeeChart.Store.Styles.NumericGauge nGauge)
    {

      nGauge.FaceBrush.Transparency = 100;

      foreach (Steema.TeeChart.Store.Tools.Marker mark in nGauge.Markers)
      {
        mark.UsePalette = false;
        mark.Shape.Font.Name = "Segoe UI";
      }

      nGauge.Markers[0].Shape.Font.Color = Windows.UI.Colors.White;
      nGauge.Markers[0].Shape.Transparent = true;
      nGauge.Markers[0].Shape.Font.Bold = false;
      nGauge.Markers[0].Shape.Font.Size = 55;
      nGauge.Markers[0].Left = 35;
      nGauge.Markers[0].Top = 5;

      nGauge.Markers[1].Shape.Font.Color = Windows.UI.Color.FromArgb(255, 70, 95, 152);
      nGauge.Markers[1].Shape.Font.Bold = false;
      nGauge.Markers[1].Shape.Font.Size = 11;
      nGauge.Markers[1].Left = 5;
      nGauge.Markers[1].Top = 5;

      nGauge.Markers[2].Shape.Color = Windows.UI.Colors.White;
      nGauge.Markers[2].Shape.Font.Color = Windows.UI.Colors.White;
      nGauge.Markers[2].Shape.Font.Brush.Color = Windows.UI.Colors.White;
      nGauge.Markers[2].Shape.Transparent = true;
      nGauge.Markers[2].Shape.Font.Size = 16;
      nGauge.Markers[2].Left = 186;
      nGauge.Markers[2].Top = 80;
    }

    private void InitializeChart()
    {
      this.numericGauge2 = new Steema.TeeChart.Store.Styles.NumericGauge();
      this.numericGauge1 = new Steema.TeeChart.Store.Styles.NumericGauge();
      this.pie1 = new Steema.TeeChart.Store.Styles.Pie();


      this.tChart3.Aspect.ColorPaletteIndex = 19;
      this.tChart3.Aspect.Elevation = 350;
      this.tChart3.Aspect.ElevationFloat = 350D;
      this.tChart3.Aspect.Perspective = 55;
      this.tChart3.Aspect.View3D = false;
      this.tChart3.Axes.Bottom.AxisPen.Visible = false;
      this.tChart3.Axes.Bottom.AxisPen.Width = 0;
      this.tChart3.Axes.Bottom.Grid.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart3.Axes.Bottom.Grid.Visible = false;
      this.tChart3.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Axes.Bottom.Labels.Font.Name = "Roboto";
      this.tChart3.Axes.Bottom.Labels.Font.Size = 24;
      this.tChart3.Axes.Bottom.MinorTicks.Length = 1;
      this.tChart3.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart3.Axes.Bottom.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart3.Axes.Bottom.Ticks.Length = 20;
      this.tChart3.Axes.Bottom.Title.Font.Name = "Roboto";
      this.tChart3.Axes.Depth.Title.Font.Name = "Roboto";
      this.tChart3.Axes.Depth.Title.Font.Size = 13;
      this.tChart3.Axes.DepthTop.Title.Font.Name = "Roboto";
      this.tChart3.Axes.DepthTop.Title.Font.Size = 13;
      this.tChart3.Axes.Left.AxisPen.Visible = false;
      this.tChart3.Axes.Left.AxisPen.Width = 0;
      this.tChart3.Axes.Left.Grid.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart3.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Axes.Left.Labels.Font.Name = "Roboto";
      this.tChart3.Axes.Left.Labels.Font.Size = 24;
      this.tChart3.Axes.Left.MinorTicks.Visible = false;
      this.tChart3.Axes.Left.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart3.Axes.Left.Ticks.Length = 7;
      this.tChart3.Axes.Left.Title.Font.Name = "Roboto";
      this.tChart3.Axes.Right.AxisPen.Width = 0;
      this.tChart3.Axes.Right.Grid.Visible = false;
      this.tChart3.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Axes.Right.Labels.Font.Name = "Roboto";
      this.tChart3.Axes.Right.Labels.Font.Size = 31;
      this.tChart3.Axes.Right.MinorTicks.Visible = false;
      this.tChart3.Axes.Right.Ticks.Visible = false;
      this.tChart3.Axes.Right.Title.Font.Name = "Roboto";
      this.tChart3.Axes.Top.Title.Font.Name = "Roboto";
      this.tChart3.Footer.Font.Brush.Color = Windows.UI.Colors.Blue;
      this.tChart3.Header.Alignment = TextAlignment.Left;
      this.tChart3.Header.Font.Bold = true;
      this.tChart3.Header.Font.Brush.Color = Windows.UI.Colors.Black;
      this.tChart3.Header.Font.Shadow.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart3.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart3.Header.Font.Size = 47;
      this.tChart3.Header.Lines = new string[] {
        ""};
      this.tChart3.Header.Visible = false;
      this.tChart3.Legend.Font.Name = "Roboto";
      this.tChart3.Legend.Font.Size = 19;
      this.tChart3.Legend.Pen.Visible = false;
      this.tChart3.Legend.Shadow.Visible = false;
      this.tChart3.Legend.Visible = false;
      this.tChart3.Name = "tChart3";
      this.tChart3.Panel.Bevel.Outer = Steema.TeeChart.Store.Drawing.BevelStyles.None;
      this.tChart3.Panel.Bevel.Width = 2;
      this.tChart3.Panel.BevelWidth = 2;
      this.tChart3.Panel.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
      this.tChart3.Panel.Brush.Gradient.Direction = Steema.TeeChart.Store.Drawing.GradientDirection.DiagonalUp;
      this.tChart3.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart3.Panel.Brush.Gradient.StartColor = Windows.UI.Colors.Silver;
      this.tChart3.Panel.Brush.Gradient.Visible = false;
      this.tChart3.Series.Add(this.numericGauge2);
      this.tChart3.TabIndex = 2;
      this.tChart3.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart3.Walls.Back.Pen.Visible = false;
      this.tChart3.Walls.Bottom.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart3.Walls.Bottom.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart3.Walls.Bottom.Brush.Gradient.Visible = true;
      this.tChart3.Walls.Bottom.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart3.Walls.Bottom.Transparent = true;
      this.tChart3.Walls.Left.Brush.Color = Windows.UI.Colors.White;
      this.tChart3.Walls.Left.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart3.Walls.Left.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart3.Walls.Left.Brush.Gradient.Visible = true;
      this.tChart3.Walls.Left.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart3.Walls.Left.Transparent = true;
      this.tChart3.Walls.Right.Transparent = true;
      this.numericGauge2.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(51)))));
      this.numericGauge2.ColorEach = false;
      this.numericGauge2.ColorLineEndValues.Add(0D);
      this.numericGauge2.ColorLineEndValues.Add(0D);
      this.numericGauge2.ColorLineStartValues.Add(0D);
      this.numericGauge2.ColorLineStartValues.Add(0D);
      this.numericGauge2.Frame.Circled = false;
      this.numericGauge2.GaugeColorPalette = new Windows.UI.Color[] {
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      this.numericGauge2.GreenLine.Brush.Gradient.UseMiddle = false;
      this.numericGauge2.GreenLine.Position = 0;
      this.numericGauge2.GreenLine.SizeDouble = 0D;
      this.numericGauge2.GreenLine.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.GreenLine.Spiralled = false;
      this.numericGauge2.GreenLine.VertSize = 5;
      this.numericGauge2.GreenLine.Visible = true;
      this.numericGauge2.GreenLineEndValue = 0D;
      this.numericGauge2.GreenLineStartValue = 0D;
      this.numericGauge2.Hand.Brush.Color = Windows.UI.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.numericGauge2.Hand.Position = 0;
      this.numericGauge2.Hand.SizeDouble = 0D;
      this.numericGauge2.Hand.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.Hand.Spiralled = false;
      this.numericGauge2.Hand.Visible = true;
      this.numericGauge2.Legend.Visible = false;
      this.numericGauge2.Maximum = double.PositiveInfinity;
      this.numericGauge2.Minimum = 0D;
      this.numericGauge2.MinorTicks.Brush.Color = Windows.UI.Colors.Transparent;
      this.numericGauge2.MinorTicks.HorizSize = 1;
      this.numericGauge2.MinorTicks.Position = 0;
      this.numericGauge2.MinorTicks.SizeDouble = 0D;
      this.numericGauge2.MinorTicks.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.MinorTicks.Spiralled = false;
      this.numericGauge2.MinorTicks.VertSize = 1;
      this.numericGauge2.MinorTicks.Visible = true;
      this.numericGauge2.OriginalCursor = null;
      this.numericGauge2.RedLine.Position = 0;
      this.numericGauge2.RedLine.SizeDouble = 0D;
      this.numericGauge2.RedLine.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.RedLine.Spiralled = false;
      this.numericGauge2.RedLine.VertSize = 5;
      this.numericGauge2.RedLine.Visible = true;
      this.numericGauge2.RedLineEndValue = 0D;
      this.numericGauge2.RedLineStartValue = 0D;
      this.numericGauge2.ShowInLegend = false;
      this.numericGauge2.Ticks.Brush.Color = Windows.UI.Colors.Transparent;
      this.numericGauge2.Ticks.Position = 0;
      this.numericGauge2.Ticks.SizeDouble = 0D;
      this.numericGauge2.Ticks.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge2.Ticks.Spiralled = false;
      this.numericGauge2.Ticks.VertSize = 20;
      this.numericGauge2.Ticks.Visible = true;
      this.numericGauge2.Title = "numericGauge1";
      this.numericGauge2.Value = 980.18847917215362D;
      this.numericGauge2.ValueFormat = "N";
      this.numericGauge2.XValues.DataMember = "X";
      this.numericGauge2.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.numericGauge2.YValues.DataMember = "Y";
      this.tChart2.Aspect.Chart3DPercent = 0;
      this.tChart2.Aspect.ClipPoints = false;
      this.tChart2.Aspect.ColorPaletteIndex = 19;
      this.tChart2.Aspect.Elevation = 350;
      this.tChart2.Aspect.ElevationFloat = 350D;
      this.tChart2.Aspect.Orthogonal = false;
      this.tChart2.Aspect.Perspective = 55;
      this.tChart2.Aspect.View3D = false;
      this.tChart2.Aspect.Zoom = 293;
      this.tChart2.Aspect.ZoomFloat = 293D;
      this.tChart2.Axes.Bottom.AxisPen.Visible = false;
      this.tChart2.Axes.Bottom.AxisPen.Width = 0;
      this.tChart2.Axes.Bottom.Grid.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart2.Axes.Bottom.Grid.Visible = false;
      this.tChart2.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Axes.Bottom.Labels.Font.Name = "Roboto";
      this.tChart2.Axes.Bottom.Labels.Font.Size = 24;
      this.tChart2.Axes.Bottom.MinorTicks.Length = 1;
      this.tChart2.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart2.Axes.Bottom.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart2.Axes.Bottom.Ticks.Length = 20;
      this.tChart2.Axes.Bottom.Title.Font.Name = "Roboto";
      this.tChart2.Axes.Depth.Title.Font.Name = "Roboto";
      this.tChart2.Axes.Depth.Title.Font.Size = 13;
      this.tChart2.Axes.DepthTop.Title.Font.Name = "Roboto";
      this.tChart2.Axes.DepthTop.Title.Font.Size = 13;
      this.tChart2.Axes.Left.AxisPen.Visible = false;
      this.tChart2.Axes.Left.AxisPen.Width = 0;
      this.tChart2.Axes.Left.Grid.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart2.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Axes.Left.Labels.Font.Name = "Roboto";
      this.tChart2.Axes.Left.Labels.Font.Size = 24;
      this.tChart2.Axes.Left.MinorTicks.Visible = false;
      this.tChart2.Axes.Left.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart2.Axes.Left.Ticks.Length = 7;
      this.tChart2.Axes.Left.Title.Font.Name = "Roboto";
      this.tChart2.Axes.Right.AxisPen.Width = 0;
      this.tChart2.Axes.Right.Grid.Visible = false;
      this.tChart2.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Axes.Right.Labels.Font.Name = "Roboto";
      this.tChart2.Axes.Right.Labels.Font.Size = 31;
      this.tChart2.Axes.Right.MinorTicks.Visible = false;
      this.tChart2.Axes.Right.Ticks.Visible = false;
      this.tChart2.Axes.Right.Title.Font.Name = "Roboto";
      this.tChart2.Axes.Top.Title.Font.Name = "Roboto";
      this.tChart2.Axes.Visible = false;
      this.tChart2.Footer.Font.Brush.Color = Windows.UI.Colors.Blue;
      this.tChart2.Header.Alignment = TextAlignment.Left;
      this.tChart2.Header.Font.Bold = true;
      this.tChart2.Header.Font.Brush.Color = Windows.UI.Colors.Black;
      this.tChart2.Header.Font.Name = "Roboto";
      this.tChart2.Header.Font.Shadow.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart2.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart2.Header.Font.Size = 47;
      this.tChart2.Header.Lines = new string[] {
        ""};
      this.tChart2.Header.Visible = false;
      this.tChart2.Legend.Font.Name = "Roboto";
      this.tChart2.Legend.Font.Size = 19;
      this.tChart2.Legend.Pen.Visible = false;
      this.tChart2.Legend.Shadow.Visible = false;
      this.tChart2.Legend.Visible = false;
      this.tChart2.Name = "tChart2";
      this.tChart2.Panel.Bevel.Outer = Steema.TeeChart.Store.Drawing.BevelStyles.None;
      this.tChart2.Panel.Bevel.Width = 2;
      this.tChart2.Panel.BevelWidth = 2;
      this.tChart2.Panel.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(51)))), ((int)(((byte)(181)))), ((int)(((byte)(229)))));
      this.tChart2.Panel.Brush.Gradient.Direction = Steema.TeeChart.Store.Drawing.GradientDirection.DiagonalUp;
      this.tChart2.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart2.Panel.Brush.Gradient.StartColor = Windows.UI.Colors.Silver;
      this.tChart2.Panel.Brush.Gradient.Visible = false;
      this.tChart2.Panel.MarginBottom = 0D;
      this.tChart2.Panel.MarginLeft = 0D;
      this.tChart2.Panel.MarginRight = 0D;
      this.tChart2.Panel.MarginTop = 0D;
      this.tChart2.Series.Add(this.numericGauge1);
      this.tChart2.TabIndex = 1;
      this.tChart2.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart2.Walls.Back.Pen.Visible = false;
      this.tChart2.Walls.Bottom.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart2.Walls.Bottom.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart2.Walls.Bottom.Brush.Gradient.Visible = true;
      this.tChart2.Walls.Bottom.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart2.Walls.Bottom.Transparent = true;
      this.tChart2.Walls.Left.Brush.Color = Windows.UI.Colors.White;
      this.tChart2.Walls.Left.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart2.Walls.Left.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart2.Walls.Left.Brush.Gradient.Visible = true;
      this.tChart2.Walls.Left.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart2.Walls.Left.Transparent = true;
      this.tChart2.Walls.Right.Transparent = true;
      this.tChart2.Walls.Visible = false;
      this.numericGauge1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(51)))));
      this.numericGauge1.ColorEach = false;
      this.numericGauge1.ColorLineEndValues.Add(0D);
      this.numericGauge1.ColorLineEndValues.Add(0D);
      this.numericGauge1.ColorLineStartValues.Add(0D);
      this.numericGauge1.ColorLineStartValues.Add(0D);
      this.numericGauge1.Frame.Circled = false;
      this.numericGauge1.GaugeColorPalette = new Windows.UI.Color[] {
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Windows.UI.Color.FromArgb(255, ((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      this.numericGauge1.GreenLine.Brush.Gradient.UseMiddle = false;
      this.numericGauge1.GreenLine.Position = 0;
      this.numericGauge1.GreenLine.SizeDouble = 0D;
      this.numericGauge1.GreenLine.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.GreenLine.Spiralled = false;
      this.numericGauge1.GreenLine.VertSize = 5;
      this.numericGauge1.GreenLine.Visible = true;
      this.numericGauge1.GreenLineEndValue = 0D;
      this.numericGauge1.GreenLineStartValue = 0D;
      this.numericGauge1.Hand.Brush.Color = Windows.UI.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.numericGauge1.Hand.Position = 0;
      this.numericGauge1.Hand.SizeDouble = 0D;
      this.numericGauge1.Hand.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.Hand.Spiralled = false;
      this.numericGauge1.Hand.Visible = true;
      this.numericGauge1.Legend.Visible = false;
      this.numericGauge1.Maximum = double.PositiveInfinity;
      this.numericGauge1.Minimum = 0D;
      this.numericGauge1.MinorTicks.Brush.Color = Windows.UI.Colors.Transparent;
      this.numericGauge1.MinorTicks.HorizSize = 1;
      this.numericGauge1.MinorTicks.Position = 0;
      this.numericGauge1.MinorTicks.SizeDouble = 0D;
      this.numericGauge1.MinorTicks.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.MinorTicks.Spiralled = false;
      this.numericGauge1.MinorTicks.VertSize = 1;
      this.numericGauge1.MinorTicks.Visible = true;
      this.numericGauge1.RedLine.Position = 0;
      this.numericGauge1.RedLine.SizeDouble = 0D;
      this.numericGauge1.RedLine.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.RedLine.Spiralled = false;
      this.numericGauge1.RedLine.VertSize = 5;
      this.numericGauge1.RedLine.Visible = true;
      this.numericGauge1.RedLineEndValue = 0D;
      this.numericGauge1.RedLineStartValue = 0D;
      this.numericGauge1.ShowInLegend = false;
      this.numericGauge1.Ticks.Brush.Color = Windows.UI.Colors.Transparent;
      this.numericGauge1.Ticks.Position = 0;
      this.numericGauge1.Ticks.SizeDouble = 0D;
      this.numericGauge1.Ticks.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.numericGauge1.Ticks.Spiralled = false;
      this.numericGauge1.Ticks.VertSize = 20;
      this.numericGauge1.Ticks.Visible = true;
      this.numericGauge1.Title = "numericGauge1";
      this.numericGauge1.Value = 478.53749267688835D;
      this.numericGauge1.ValueFormat = "N";
      this.numericGauge1.XValues.DataMember = "X";
      this.numericGauge1.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.numericGauge1.YValues.DataMember = "Y";
      this.tChart1.Panel.Image = new Windows.UI.Xaml.Media.Imaging.BitmapImage(new Uri("ms-appx:///Assets/worldimage.png"));
      this.tChart1.Aspect.ColorPaletteIndex = 19;
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Bottom.AxisPen.Visible = false;
      this.tChart1.Axes.Bottom.AxisPen.Width = 0;
      this.tChart1.Axes.Bottom.Grid.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Bottom.Labels.Font.Name = "Roboto";
      this.tChart1.Axes.Bottom.Labels.Font.Size = 24;
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart1.Axes.Bottom.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Title.Font.Name = "Roboto";
      this.tChart1.Axes.Depth.Title.Font.Name = "Roboto";
      this.tChart1.Axes.Depth.Title.Font.Size = 13;
      this.tChart1.Axes.DepthTop.Title.Font.Name = "Roboto";
      this.tChart1.Axes.DepthTop.Title.Font.Size = 13;
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.AxisPen.Width = 0;
      this.tChart1.Axes.Left.Grid.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Left.Labels.Font.Name = "Roboto";
      this.tChart1.Axes.Left.Labels.Font.Size = 24;
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      this.tChart1.Axes.Left.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Ticks.Length = 7;
      this.tChart1.Axes.Left.Title.Font.Name = "Roboto";
      this.tChart1.Axes.Right.AxisPen.Width = 0;
      this.tChart1.Axes.Right.Grid.Visible = false;
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Right.Labels.Font.Name = "Roboto";
      this.tChart1.Axes.Right.Labels.Font.Size = 31;
      this.tChart1.Axes.Right.MinorTicks.Visible = false;
      this.tChart1.Axes.Right.Ticks.Visible = false;
      this.tChart1.Axes.Right.Title.Font.Name = "Roboto";
      this.tChart1.Axes.Top.Title.Font.Name = "Roboto";
      this.tChart1.Footer.Font.Brush.Color = Windows.UI.Colors.Blue;
      this.tChart1.Header.Font.Brush.Color = Windows.UI.Colors.Silver;
      this.tChart1.Header.Font.Name = "Segoe UI";
      this.tChart1.Header.Font.Shadow.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(131)))), ((int)(((byte)(131)))), ((int)(((byte)(131)))));
      this.tChart1.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart1.Header.Font.Size = 23;
      this.tChart1.Header.Lines = new string[] {
        "Percentage of world population"};
      this.tChart1.Legend.Alignment = Steema.TeeChart.Store.LegendAlignments.Bottom;
      this.tChart1.Legend.Font.Brush.Color = Windows.UI.Colors.Silver;
      this.tChart1.Legend.Font.Name = "Segoe UI";
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.Pen.Visible = false;
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Store.Drawing.BevelStyles.None;
      this.tChart1.Panel.Bevel.Width = 2;
      this.tChart1.Panel.BevelWidth = 2;
      this.tChart1.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.Direction = Steema.TeeChart.Store.Drawing.GradientDirection.DiagonalUp;
      this.tChart1.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.StartColor = Windows.UI.Colors.Silver;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Panel.MarginRight = 18D;
      this.tChart1.Series.Add(this.pie1);
      this.tChart1.SubHeader.Font.Brush.Color = Windows.UI.Colors.Silver;
      this.tChart1.SubHeader.Font.Name = "Segoe UI";
      this.tChart1.SubHeader.Font.Shadow.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.SubHeader.Font.Size = 14;
      this.tChart1.SubHeader.Lines = new string[] {
        "actively using social media"};
      this.tChart1.SubHeader.Visible = true;
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Walls.Back.Pen.Visible = false;
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Bottom.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Bottom.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Bottom.Transparent = true;
      this.tChart1.Walls.Left.Brush.Color = Windows.UI.Colors.White;
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Left.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Left.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Left.Transparent = true;
      this.tChart1.Walls.Right.Transparent = true;
      this.pie1.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.pie1.Circled = true;
      this.pie1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(229)))), ((int)(((byte)(181)))), ((int)(((byte)(51)))));
      this.pie1.Frame.Circled = true;
      this.pie1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.pie1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.pie1.LabelMember = "Labels";
      this.pie1.Marks.Arrow.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.pie1.Marks.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(128)))));
      this.pie1.Marks.Font.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(0)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.pie1.Marks.Font.Name = "Segoe UI";
      this.pie1.Marks.Font.Size = 14;
      this.pie1.Marks.FontSeriesColor = true;
      this.pie1.Marks.Pen.Visible = false;
      this.pie1.Marks.Shadow.Visible = false;
      this.pie1.Marks.ShapeStyle = Steema.TeeChart.Store.Drawing.TextShapeStyle.RoundRectangle;
      this.pie1.MarksPie.LegSize = 0;
      this.pie1.MarksPie.VertCenter = false;
      this.pie1.MultiPie = Steema.TeeChart.Store.Styles.MultiPies.Automatic;
      this.pie1.OriginalCursor = null;
      this.pie1.OtherSlice.Color = Utils.EmptyColor;
      this.pie1.OtherSlice.Style = Steema.TeeChart.Store.Styles.PieOtherStyles.None;
      this.pie1.OtherSlice.Text = "";
      this.pie1.OtherSlice.Value = 0D;
      this.pie1.Title = "pie1";
      this.pie1.UniqueCustomRadius = true;
      this.pie1.XValues.DataMember = "Angle";
      this.pie1.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.pie1.YValues.DataMember = "Pie";
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
