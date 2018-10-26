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
using System.Windows.Threading;

namespace SubaruBRZWPF
{
  /// <summary>
  /// Interaction logic for MainWindow.xaml
  /// </summary>
  public partial class MainWindow : Window
  {
    public MainWindow()
    {
      InitializeComponent();

      InitializeChart();

      initVars();

    }

    private Steema.TeeChart.WPF.Styles.CircularGauge circularGauge1;
    private Steema.TeeChart.WPF.Styles.NumericGauge numericGauge1;
    private Steema.TeeChart.WPF.Styles.NumericGauge numericGauge2;
    private Steema.TeeChart.WPF.Styles.CircularGauge circularGauge2;

    private void InitializeChart()
    {
      this.circularGauge1 = new Steema.TeeChart.WPF.Styles.CircularGauge();
      this.numericGauge1 = new Steema.TeeChart.WPF.Styles.NumericGauge();
      this.numericGauge2 = new Steema.TeeChart.WPF.Styles.NumericGauge();
      this.circularGauge2 = new Steema.TeeChart.WPF.Styles.CircularGauge();
      this.revChart.Aspect.ColorPaletteIndex = 20;
      this.revChart.Aspect.Elevation = 315;
      this.revChart.Aspect.ElevationFloat = 315D;
      this.revChart.Aspect.Orthogonal = false;
      this.revChart.Aspect.Perspective = 0;
      this.revChart.Aspect.Rotation = 360;
      this.revChart.Aspect.RotationFloat = 360D;
      this.revChart.Aspect.View3D = false;
      this.revChart.Axes.Automatic = true;
      this.revChart.Axes.Bottom.Grid.DrawEvery = 2;
      this.revChart.Axes.Bottom.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.revChart.Axes.Bottom.Labels.Font.Size = 9;
      this.revChart.Axes.Bottom.MinorTicks.Length = 1;
      this.revChart.Axes.Bottom.Ticks.Length = 20;
      this.revChart.Axes.Bottom.Title.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Axes.Bottom.Title.Font.Size = 11;
      this.revChart.Axes.Bottom.Visible = false;
      this.revChart.Axes.Left.AxisPen.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.Axes.Left.AxisPen.Visible = true;
      this.revChart.Axes.Left.AxisPen.Width = 3;
      this.revChart.Axes.Left.Grid.DrawEvery = 2;
      this.revChart.Axes.Left.Increment = 1D;
      this.revChart.Axes.Left.Labels.Font.Bold = true;
      this.revChart.Axes.Left.Labels.Font.Brush.Color = Colors.Red;
      this.revChart.Axes.Left.Labels.Font.Name = "Gill Sans MT";
      this.revChart.Axes.Left.Labels.Font.Size = 36;
      this.revChart.Axes.Left.MinorTickCount = 9;
      this.revChart.Axes.Left.MinorTicks.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.Axes.Left.MinorTicks.Length = 1;
      this.revChart.Axes.Left.MinorTicks.Visible = true;
      this.revChart.Axes.Left.MinorTicks.Width = 4;
      this.revChart.Axes.Left.Ticks.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.revChart.Axes.Left.Ticks.Length = 20;
      this.revChart.Axes.Left.Ticks.Visible = true;
      this.revChart.Axes.Left.Ticks.Width = 2;
      this.revChart.Axes.Left.Title.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.revChart.Axes.Left.Title.Font.Size = 11;
      this.revChart.Axes.Right.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Axes.Right.Labels.Font.Size = 9;
      this.revChart.Axes.Right.Visible = false;
      this.revChart.Axes.Top.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Axes.Top.Labels.Font.Size = 9;
      this.revChart.Panel.Transparent = true;
      this.revChart.Header.Font.Brush.Color = Colors.Gray;
      this.revChart.Header.Font.Size = 12;
      this.revChart.Legend.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.revChart.Legend.Font.Size = 9;
      this.revChart.Legend.Shadow.Visible = false;
      this.revChart.Name = "revChart";
      this.revChart.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.revChart.Panel.Brush.Color = Utils.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.revChart.Panel.Brush.Gradient.Visible = false;
      this.revChart.Panel.MarginBottom = 3D;
      this.revChart.Panel.MarginLeft = 4D;
      this.revChart.Panel.MarginRight = 4D;
      this.revChart.Panel.MarginTop = 5D;
      this.revChart.Series.Add(this.circularGauge1);
      this.revChart.Series.Add(this.numericGauge1);
      this.revChart.Series.Add(this.numericGauge2);
      this.revChart.TabIndex = 0;
      this.revChart.Walls.Back.Brush.Visible = false;
      this.revChart.Walls.Back.Visible = false;
      this.revChart.BeforeDrawSeries += new Steema.TeeChart.WPF.PaintChartEventHandler(this.revChart_BeforeDrawSeries);
      this.circularGauge1.RedLine.Visible = false;
      this.circularGauge1.GreenLine.Visible = false;
      this.circularGauge1.Center.Brush.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.circularGauge1.Center.Brush.Gradient.EndColor = Utils.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.circularGauge1.Center.Brush.Gradient.StartColor = Utils.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      //this.circularGauge1.Center.Brush.Gradient.Style.Direction = Steema.TeeChart.WPF.Drawing.PathGradientMode.Radial;
      //this.circularGauge1.Center.Brush.Gradient.Style.Visible = true;
      //this.circularGauge1.Center.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.circularGauge1.Center.HorizSize = 45;
      this.circularGauge1.Center.Pen.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.circularGauge1.Center.Pen.Width = 2;
      this.circularGauge1.Center.Position = 0;
      this.circularGauge1.Center.SizeDouble = 0D;
      this.circularGauge1.Center.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.Center.Spiralled = false;
      this.circularGauge1.Center.VertSize = 45;
      this.circularGauge1.Center.Visible = true;
      this.circularGauge1.Circled = true;
      this.circularGauge1.Color = Utils.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.circularGauge1.ColorEach = false;
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(9D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineEndValues.Add(100D);
      this.circularGauge1.ColorLineEndValues.Add(70D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      this.circularGauge1.ColorLineStartValues.Add(80D);
      this.circularGauge1.ColorLineStartValues.Add(0D);
      //this.circularGauge1.FaceBrush.Gradient.Style.CenterXOffset = 96;
      //this.circularGauge1.FaceBrush.Gradient.Style.CenterYOffset = -96;
      //this.circularGauge1.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.WPF.Drawing.PathGradientMode.Radial;
      //this.circularGauge1.FaceBrush.Gradient.Style.Visible = true;
      this.circularGauge1.FaceBrush.Gradient.Visible = false;
      this.circularGauge1.FaceBrush.Visible = false;
      this.circularGauge1.Frame.Circled = true;
      this.circularGauge1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.circularGauge1.Frame.Visible = false;
      this.circularGauge1.GaugeColorPalette = new Color[] {
        Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        Utils.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        Utils.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandDistances.Add(80);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(12);
      this.circularGauge1.HandOffsets.Add(10);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.HandOffsets.Add(30);
      this.circularGauge1.Legend.Visible = false;
      this.circularGauge1.Marks.Brush.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.circularGauge1.Marks.Brush.Gradient.EndColor = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.circularGauge1.Marks.Brush.Gradient.MiddleColor = Utils.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.circularGauge1.Marks.Brush.Gradient.StartColor = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.circularGauge1.Marks.Brush.Gradient.UseMiddle = true;
      this.circularGauge1.Marks.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.circularGauge1.Marks.Pen.Color = Utils.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
      this.circularGauge1.Marks.Shadow.Visible = false;
      this.circularGauge1.Marks.TailParams.Align = Steema.TeeChart.WPF.Styles.TailAlignment.Auto;
      this.circularGauge1.Marks.TailParams.Margin = 0F;
      this.circularGauge1.Marks.TailParams.PointerHeight = 5D;
      this.circularGauge1.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge1.Marks.TailStyle = Steema.TeeChart.WPF.Styles.MarksTail.WithPointer;
      this.circularGauge1.Maximum = 9D;
      this.circularGauge1.Minimum = 0D;
      this.circularGauge1.MinorTickDistance = 10;
      this.circularGauge1.MinorTicks.Brush.Color = Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.circularGauge1.MinorTicks.Brush.Gradient.Transparency = 100;
      this.circularGauge1.MinorTicks.HorizSize = 1;
      this.circularGauge1.MinorTicks.Pen.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge1.MinorTicks.Pen.Width = 4;
      this.circularGauge1.MinorTicks.Position = 0;
      this.circularGauge1.MinorTicks.SizeDouble = 0D;
      this.circularGauge1.MinorTicks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.MinorTicks.Spiralled = false;
      this.circularGauge1.MinorTicks.VertSize = 1;
      this.circularGauge1.MinorTicks.Visible = true;
      this.circularGauge1.NumericGauge.Axis.Horizontal = true;
      this.circularGauge1.NumericGauge.Axis.MinorTicks.Length = 1;
      this.circularGauge1.NumericGauge.Axis.OtherSide = false;
      this.circularGauge1.NumericGauge.Axis.Ticks.Length = 20;
      this.circularGauge1.NumericGauge.Axis.Title.Visible = false;
      this.circularGauge1.NumericGauge.Color = Utils.EmptyColor;
      this.circularGauge1.NumericGauge.ColorEach = false;
      this.circularGauge1.NumericGauge.ColorLineEndValues.Add(100D);
      this.circularGauge1.NumericGauge.ColorLineEndValues.Add(70D);
      this.circularGauge1.NumericGauge.ColorLineStartValues.Add(80D);
      this.circularGauge1.NumericGauge.ColorLineStartValues.Add(0D);
      this.circularGauge1.NumericGauge.Frame.Circled = false;
      this.circularGauge1.NumericGauge.GaugeColorPalette = new Color[] {
        Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      this.circularGauge1.NumericGauge.GreenLine.Brush.Gradient.UseMiddle = false;
      this.circularGauge1.NumericGauge.GreenLine.Position = 0;
      this.circularGauge1.NumericGauge.GreenLine.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.GreenLine.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.GreenLine.Spiralled = false;
      this.circularGauge1.NumericGauge.GreenLine.Visible = true;
      this.circularGauge1.NumericGauge.GreenLineEndValue = 70D;
      this.circularGauge1.NumericGauge.GreenLineStartValue = 0D;
      this.circularGauge1.NumericGauge.Hand.Brush.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge1.NumericGauge.Hand.Position = 0;
      this.circularGauge1.NumericGauge.Hand.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.Hand.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.Hand.Spiralled = false;
      this.circularGauge1.NumericGauge.Hand.Visible = true;
      this.circularGauge1.NumericGauge.Marks.TailParams.Margin = 0F;
      this.circularGauge1.NumericGauge.Marks.TailParams.PointerHeight = 8D;
      this.circularGauge1.NumericGauge.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge1.NumericGauge.Maximum = double.PositiveInfinity;
      this.circularGauge1.NumericGauge.Minimum = 0D;
      this.circularGauge1.NumericGauge.MinorTicks.Brush.Color = Colors.Transparent;
      this.circularGauge1.NumericGauge.MinorTicks.Position = 0;
      this.circularGauge1.NumericGauge.MinorTicks.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.MinorTicks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.MinorTicks.Spiralled = false;
      this.circularGauge1.NumericGauge.MinorTicks.Visible = true;
      this.circularGauge1.NumericGauge.OriginalCursor = null;
      this.circularGauge1.NumericGauge.RedLine.Position = 0;
      this.circularGauge1.NumericGauge.RedLine.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.RedLine.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.RedLine.Spiralled = false;
      this.circularGauge1.NumericGauge.RedLine.Visible = true;
      this.circularGauge1.NumericGauge.RedLineEndValue = 100D;
      this.circularGauge1.NumericGauge.RedLineStartValue = 80D;
      this.circularGauge1.NumericGauge.TextMarker.AutoSize = true;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ArrowHeadSize = 8;
      this.circularGauge1.NumericGauge.TextMarker.Callout.Brush.Color = Colors.Black;
      this.circularGauge1.NumericGauge.TextMarker.Callout.Distance = 0;
      this.circularGauge1.NumericGauge.TextMarker.Callout.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.TextMarker.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.TextMarker.Callout.XPosition = 0;
      this.circularGauge1.NumericGauge.TextMarker.Callout.YPosition = 0;
      this.circularGauge1.NumericGauge.TextMarker.Callout.ZPosition = 0;
      this.circularGauge1.NumericGauge.TextMarker.Centered = false;
      this.circularGauge1.NumericGauge.TextMarker.Shape.Brush.Color = Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.circularGauge1.NumericGauge.TextMarker.Shape.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      this.circularGauge1.NumericGauge.TextMarker.Shape.Pen.Visible = false;
      this.circularGauge1.NumericGauge.TextMarker.Shape.Shadow.Visible = false;
      this.circularGauge1.NumericGauge.TextMarker.UsePalette = true;
      this.circularGauge1.NumericGauge.Ticks.Position = 0;
      this.circularGauge1.NumericGauge.Ticks.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.Ticks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.Ticks.Spiralled = false;
      this.circularGauge1.NumericGauge.Ticks.Visible = true;
      this.circularGauge1.NumericGauge.UnitsMarker.AutoSize = true;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ArrowHeadSize = 8;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.Brush.Color = Colors.Black;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.Distance = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.XPosition = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.YPosition = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Callout.ZPosition = 0;
      this.circularGauge1.NumericGauge.UnitsMarker.Centered = false;
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Brush.Color = Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Pen.Visible = false;
      this.circularGauge1.NumericGauge.UnitsMarker.Shape.Shadow.Visible = false;
      this.circularGauge1.NumericGauge.UnitsMarker.UsePalette = true;
      this.circularGauge1.NumericGauge.UseExtendedNumRange = false;
      this.circularGauge1.NumericGauge.Value = 0D;
      this.circularGauge1.NumericGauge.ValueMarker.AutoSize = true;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ArrowHeadSize = 8;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.Brush.Color = Colors.Black;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.Distance = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.SizeDouble = 0D;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.XPosition = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.YPosition = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Callout.ZPosition = 0;
      this.circularGauge1.NumericGauge.ValueMarker.Centered = false;
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Brush.Color = Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Pen.Visible = false;
      this.circularGauge1.NumericGauge.ValueMarker.Shape.Shadow.Visible = false;
      this.circularGauge1.NumericGauge.ValueMarker.UsePalette = true;
      this.circularGauge1.OriginalCursor = null;
      this.circularGauge1.RotateLabels = false;
      this.circularGauge1.RotationAngle = 326;
      this.circularGauge1.ShowInLegend = false;
      this.circularGauge1.Ticks.Brush.Color = Colors.Transparent;
      this.circularGauge1.Ticks.Brush.Gradient.Transparency = 100;
      this.circularGauge1.Ticks.Pen.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge1.Ticks.Pen.Width = 2;
      this.circularGauge1.Ticks.Position = 0;
      this.circularGauge1.Ticks.SizeDouble = 0D;
      this.circularGauge1.Ticks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge1.Ticks.Spiralled = false;
      this.circularGauge1.Ticks.VertSize = 20;
      this.circularGauge1.Ticks.Visible = true;
      this.circularGauge1.Title = "circularGauge1";
      this.circularGauge1.TotalAngle = 209D;
      this.circularGauge1.UniqueCustomRadius = true;
      this.circularGauge1.UseExtendedNumRange = false;
      this.circularGauge1.Value = 4.24302631534777D;
      this.circularGauge1.XValues.DataMember = "Angle";
      this.circularGauge1.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.circularGauge1.YValues.DataMember = "Y";
      this.numericGauge1.ValueMarker.Shape.Transparent = true;
      this.numericGauge1.Frame.Visible = false;
      this.numericGauge1.TextMarker.Active = false;
      this.numericGauge1.UnitsMarker.Active = false;
      this.numericGauge1.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(207)))), ((int)(((byte)(104)))));
      this.numericGauge1.ColorEach = false;
      this.numericGauge1.ColorLineEndValues.Add(0D);
      this.numericGauge1.ColorLineEndValues.Add(0D);
      this.numericGauge1.ColorLineStartValues.Add(0D);
      this.numericGauge1.ColorLineStartValues.Add(0D);
      this.numericGauge1.CustomBounds = new Rect(400, 320, 169, 107);
      this.numericGauge1.GaugeColorPalette = new Color[] {
        Utils.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(55)))), ((int)(((byte)(125))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(200))))),
        Utils.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(160))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Colors.Transparent,
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Colors.Transparent,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Colors.Transparent,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      this.numericGauge1.FaceBrush.Visible = false;
      this.numericGauge1.Value = 25D;
      this.numericGauge1.ValueFormat = "N0";
      this.numericGauge1.ValueMarker.Shape.Font.Italic = true;

      this.numericGauge2.ValueMarker.Shape.Transparent = true;
      this.numericGauge2.Frame.Visible = false;
      this.numericGauge2.TextMarker.Position = Steema.TeeChart.WPF.Tools.AnnotationPositions.RightTop;
      this.numericGauge2.UnitsMarker.Active = false;
      this.numericGauge2.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(127)))), ((int)(((byte)(71)))));
      this.numericGauge2.ColorEach = false;
      this.numericGauge2.ColorLineEndValues.Add(0D);
      this.numericGauge2.ColorLineEndValues.Add(0D);
      this.numericGauge2.ColorLineStartValues.Add(0D);
      this.numericGauge2.ColorLineStartValues.Add(0D);
      this.numericGauge2.CustomBounds = new Rect(310, 497, 150, 135);
      this.numericGauge2.Frame.Circled = false;
      this.numericGauge2.GaugeColorPalette = new Color[] {
        Utils.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(55)))), ((int)(((byte)(125))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(120)))), ((int)(((byte)(200))))),
        Utils.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(90)))), ((int)(((byte)(160))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      this.numericGauge2.FaceBrush.Visible = false;
      this.numericGauge2.Value = 415.80661498746213D;
      this.numericGauge2.ValueFormat = "N0";
      this.numericGauge2.TextMarker.Shape.Brush.Transparency = 100;
      this.numericGauge2.TextMarker.UsePalette = false;
      this.numericGauge2.TextMarker.Text = "1";
      this.numericGauge2.TextMarker.Shape.Font.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
      this.numericGauge2.TextMarker.Shape.Font.Size = 20;
      this.numericGauge2.TextMarker.Shape.Font.Italic = true;
      this.numericGauge2.ValueMarker.Shape.Font.Size = 20;
      this.numericGauge2.ValueMarker.Shape.Font.Italic = true;
      this.numericGauge2.ValueMarker.TextAlign = TextAlignment.Left;
      this.speedChart.Aspect.ColorPaletteIndex = 20;
      this.speedChart.Aspect.Elevation = 315;
      this.speedChart.Aspect.ElevationFloat = 315D;
      this.speedChart.Aspect.Orthogonal = false;
      this.speedChart.Aspect.Perspective = 0;
      this.speedChart.Aspect.Rotation = 360;
      this.speedChart.Aspect.RotationFloat = 360D;
      this.speedChart.Aspect.View3D = false;
      this.speedChart.Axes.Automatic = true;
      this.speedChart.Axes.Bottom.Grid.DrawEvery = 2;
      this.speedChart.Axes.Bottom.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.speedChart.Axes.Bottom.Labels.Font.Size = 9;
      this.speedChart.Axes.Bottom.Title.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Axes.Bottom.Title.Font.Size = 11;
      this.speedChart.Axes.Left.AxisPen.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.speedChart.Axes.Left.AxisPen.Visible = true;
      this.speedChart.Axes.Left.AxisPen.Width = 5;
      this.speedChart.Axes.Left.Grid.DrawEvery = 2;
      this.speedChart.Axes.Left.Labels.Font.Bold = true;
      this.speedChart.Axes.Left.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.speedChart.Axes.Left.Labels.Font.Name = "Arial";
      this.speedChart.Axes.Left.Labels.Font.Size = 12;
      this.speedChart.Axes.Left.Labels.Visible = false;
      this.speedChart.Axes.Left.MinorTicks.Length = 1;
      this.speedChart.Axes.Left.Ticks.Color = Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
      this.speedChart.Axes.Left.Ticks.Length = 12;
      this.speedChart.Axes.Left.Ticks.Visible = true;
      this.speedChart.Axes.Left.Title.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.speedChart.Axes.Left.Title.Font.Size = 11;
      this.speedChart.Axes.Left.Visible = false;
      this.speedChart.Axes.Right.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Axes.Right.Labels.Font.Size = 9;
      this.speedChart.Axes.Top.Labels.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Axes.Top.Labels.Font.Size = 9;
      this.speedChart.Panel.Transparent = true;
      this.speedChart.Header.Font.Brush.Color = Colors.Gray;
      this.speedChart.Header.Font.Size = 12;
      this.speedChart.Legend.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.speedChart.Legend.Font.Size = 9;
      this.speedChart.Legend.Shadow.Visible = false;
      this.speedChart.Name = "speedChart";
      this.speedChart.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.speedChart.Panel.Brush.Color = Utils.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.speedChart.Panel.Brush.Gradient.Visible = false;
      this.speedChart.Series.Add(this.circularGauge2);
      this.speedChart.TabIndex = 1;
      this.speedChart.Walls.Back.Brush.Visible = false;
      this.speedChart.Walls.Back.Visible = false;
      // circularGauge2
      this.circularGauge2.RedLine.Visible = false;
      this.circularGauge2.GreenLine.Visible = false;
      this.circularGauge2.Center.Brush.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.circularGauge2.Center.Brush.Gradient.EndColor = Utils.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(89)))), ((int)(((byte)(89)))));
      this.circularGauge2.Center.Brush.Gradient.StartColor = Utils.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      //this.circularGauge2.Center.Brush.Gradient.Style.Direction = Steema.TeeChart.WPF.Drawing.PathGradientMode.Radial;
      //this.circularGauge2.Center.Brush.Gradient.Style.Visible = true;
      //this.circularGauge2.Center.Brush.Style = System.Drawing.Drawing2D.HatchStyle.BackwardDiagonal;
      this.circularGauge2.Center.HorizSize = 45;
      this.circularGauge2.Center.Pen.Color = Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
      this.circularGauge2.Center.Pen.Width = 2;
      this.circularGauge2.Center.Position = 0;
      this.circularGauge2.Center.SizeDouble = 0D;
      this.circularGauge2.Center.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.Center.Spiralled = false;
      this.circularGauge2.Center.VertSize = 45;
      this.circularGauge2.Center.Visible = true;
      this.circularGauge2.Circled = true;
      this.circularGauge2.Color = Utils.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(153)))), ((int)(((byte)(214)))));
      this.circularGauge2.ColorEach = false;
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineEndValues.Add(100D);
      this.circularGauge2.ColorLineEndValues.Add(70D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.ColorLineStartValues.Add(80D);
      this.circularGauge2.ColorLineStartValues.Add(0D);
      this.circularGauge2.FaceBrush.Color = Utils.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
      //this.circularGauge2.FaceBrush.Gradient.Style.CenterXOffset = 86;
      //this.circularGauge2.FaceBrush.Gradient.Style.CenterYOffset = -86;
      //this.circularGauge2.FaceBrush.Gradient.Style.Direction = Steema.TeeChart.WPF.Drawing.PathGradientMode.Radial;
      //this.circularGauge2.FaceBrush.Gradient.Style.Visible = true;
      this.circularGauge2.FaceBrush.Gradient.Visible = false;
      this.circularGauge2.FaceBrush.Visible = false;
      this.circularGauge2.Frame.Circled = true;
      this.circularGauge2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.circularGauge2.Frame.Visible = false;
      this.circularGauge2.GaugeColorPalette = new Color[] {
        Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128))))),
        Utils.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192))))),
        Utils.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))))};
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandDistances.Add(80);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.HandOffsets.Add(30);
      this.circularGauge2.Legend.Visible = false;
      this.circularGauge2.Marks.Brush.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.circularGauge2.Marks.Brush.Gradient.EndColor = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.circularGauge2.Marks.Brush.Gradient.MiddleColor = Utils.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.circularGauge2.Marks.Brush.Gradient.StartColor = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(215)))), ((int)(((byte)(0)))));
      this.circularGauge2.Marks.Brush.Gradient.UseMiddle = true;
      this.circularGauge2.Marks.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      this.circularGauge2.Marks.Pen.Color = Utils.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(138)))), ((int)(((byte)(193)))));
      this.circularGauge2.Marks.Shadow.Visible = false;
      this.circularGauge2.Marks.TailParams.Align = Steema.TeeChart.WPF.Styles.TailAlignment.Auto;
      this.circularGauge2.Marks.TailParams.Margin = 0F;
      this.circularGauge2.Marks.TailParams.PointerHeight = 5D;
      this.circularGauge2.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge2.Marks.TailStyle = Steema.TeeChart.WPF.Styles.MarksTail.WithPointer;
      this.circularGauge2.Maximum = 160D;
      this.circularGauge2.Minimum = 0D;
      this.circularGauge2.MinorTicks.Brush.Color = Colors.Transparent;
      this.circularGauge2.MinorTicks.HorizSize = 1;
      this.circularGauge2.MinorTicks.Position = 0;
      this.circularGauge2.MinorTicks.SizeDouble = 0D;
      this.circularGauge2.MinorTicks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.MinorTicks.Spiralled = false;
      this.circularGauge2.MinorTicks.VertSize = 1;
      this.circularGauge2.MinorTicks.Visible = true;
      this.circularGauge2.NumericGauge.Axis.Horizontal = true;
      this.circularGauge2.NumericGauge.Axis.MinorTicks.Length = 1;
      this.circularGauge2.NumericGauge.Axis.OtherSide = false;
      this.circularGauge2.NumericGauge.Axis.Ticks.Length = 20;
      this.circularGauge2.NumericGauge.Axis.Title.Visible = false;
      this.circularGauge2.NumericGauge.Color = Utils.EmptyColor;
      this.circularGauge2.NumericGauge.ColorEach = false;
      this.circularGauge2.NumericGauge.ColorLineEndValues.Add(100D);
      this.circularGauge2.NumericGauge.ColorLineEndValues.Add(70D);
      this.circularGauge2.NumericGauge.ColorLineStartValues.Add(80D);
      this.circularGauge2.NumericGauge.ColorLineStartValues.Add(0D);
      this.circularGauge2.NumericGauge.Frame.Circled = false;
      this.circularGauge2.NumericGauge.GaugeColorPalette = new Color[] {
        Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(115)))), ((int)(((byte)(60))))),
        Utils.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(50)))), ((int)(((byte)(10))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130))))),
        Utils.EmptyColor,
        Utils.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))),
        Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100))))),
        Utils.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))))};
      this.circularGauge2.NumericGauge.GreenLine.Brush.Gradient.UseMiddle = false;
      this.circularGauge2.NumericGauge.GreenLine.Position = 0;
      this.circularGauge2.NumericGauge.GreenLine.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.GreenLine.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.GreenLine.Spiralled = false;
      this.circularGauge2.NumericGauge.GreenLine.Visible = true;
      this.circularGauge2.NumericGauge.GreenLineEndValue = 70D;
      this.circularGauge2.NumericGauge.GreenLineStartValue = 0D;
      this.circularGauge2.NumericGauge.Hand.Brush.Color = Utils.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.circularGauge2.NumericGauge.Hand.Position = 0;
      this.circularGauge2.NumericGauge.Hand.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.Hand.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.Hand.Spiralled = false;
      this.circularGauge2.NumericGauge.Hand.Visible = true;
      this.circularGauge2.NumericGauge.Marks.TailParams.Margin = 0F;
      this.circularGauge2.NumericGauge.Marks.TailParams.PointerHeight = 8D;
      this.circularGauge2.NumericGauge.Marks.TailParams.PointerWidth = 8D;
      this.circularGauge2.NumericGauge.Maximum = double.PositiveInfinity;
      this.circularGauge2.NumericGauge.Minimum = 0D;
      this.circularGauge2.NumericGauge.MinorTicks.Brush.Color = Colors.Transparent;
      this.circularGauge2.NumericGauge.MinorTicks.Position = 0;
      this.circularGauge2.NumericGauge.MinorTicks.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.MinorTicks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.MinorTicks.Spiralled = false;
      this.circularGauge2.NumericGauge.MinorTicks.Visible = true;
      this.circularGauge2.NumericGauge.OriginalCursor = null;
      this.circularGauge2.NumericGauge.RedLine.Position = 0;
      this.circularGauge2.NumericGauge.RedLine.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.RedLine.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.RedLine.Spiralled = false;
      this.circularGauge2.NumericGauge.RedLine.Visible = true;
      this.circularGauge2.NumericGauge.RedLineEndValue = 100D;
      this.circularGauge2.NumericGauge.RedLineStartValue = 80D;
      this.circularGauge2.NumericGauge.TextMarker.AutoSize = true;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ArrowHeadSize = 8;
      this.circularGauge2.NumericGauge.TextMarker.Callout.Brush.Color = Colors.Black;
      this.circularGauge2.NumericGauge.TextMarker.Callout.Distance = 0;
      this.circularGauge2.NumericGauge.TextMarker.Callout.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.TextMarker.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.TextMarker.Callout.XPosition = 0;
      this.circularGauge2.NumericGauge.TextMarker.Callout.YPosition = 0;
      this.circularGauge2.NumericGauge.TextMarker.Callout.ZPosition = 0;
      this.circularGauge2.NumericGauge.TextMarker.Centered = false;
      this.circularGauge2.NumericGauge.TextMarker.Shape.Brush.Color = Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.circularGauge2.NumericGauge.TextMarker.Shape.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      this.circularGauge2.NumericGauge.TextMarker.Shape.Pen.Visible = false;
      this.circularGauge2.NumericGauge.TextMarker.Shape.Shadow.Visible = false;
      this.circularGauge2.NumericGauge.TextMarker.UsePalette = true;
      this.circularGauge2.NumericGauge.Ticks.Position = 0;
      this.circularGauge2.NumericGauge.Ticks.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.Ticks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.Ticks.Spiralled = false;
      this.circularGauge2.NumericGauge.Ticks.Visible = true;
      this.circularGauge2.NumericGauge.UnitsMarker.AutoSize = true;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ArrowHeadSize = 8;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.Brush.Color = Colors.Black;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.Distance = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.XPosition = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.YPosition = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Callout.ZPosition = 0;
      this.circularGauge2.NumericGauge.UnitsMarker.Centered = false;
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Brush.Color = Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Pen.Visible = false;
      this.circularGauge2.NumericGauge.UnitsMarker.Shape.Shadow.Visible = false;
      this.circularGauge2.NumericGauge.UnitsMarker.UsePalette = true;
      this.circularGauge2.NumericGauge.UseExtendedNumRange = false;
      this.circularGauge2.NumericGauge.Value = 0D;
      this.circularGauge2.NumericGauge.ValueMarker.AutoSize = true;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ArrowHead = Steema.TeeChart.WPF.Styles.ArrowHeadStyles.None;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ArrowHeadDirection = Steema.TeeChart.WPF.Styles.ArrowHeadDirection.FromPoint;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ArrowHeadSize = 8;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.Brush.Color = Colors.Black;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.Distance = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.SizeDouble = 0D;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.XPosition = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.YPosition = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Callout.ZPosition = 0;
      this.circularGauge2.NumericGauge.ValueMarker.Centered = false;
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Brush.Color = Utils.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(130)))));
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Font.Brush.Color = Utils.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Pen.Visible = false;
      this.circularGauge2.NumericGauge.ValueMarker.Shape.Shadow.Visible = false;
      this.circularGauge2.NumericGauge.ValueMarker.UsePalette = true;
      this.circularGauge2.OriginalCursor = null;
      this.circularGauge2.RotationAngle = 259;
      this.circularGauge2.ShowInLegend = false;
      this.circularGauge2.Ticks.Brush.Color = Colors.Transparent;
      this.circularGauge2.Ticks.Brush.Gradient.Transparency = 100;
      this.circularGauge2.Ticks.Position = 0;
      this.circularGauge2.Ticks.SizeDouble = 0D;
      this.circularGauge2.Ticks.SizeUnits = Steema.TeeChart.WPF.Styles.PointerSizeUnits.Pixels;
      this.circularGauge2.Ticks.Spiralled = false;
      this.circularGauge2.Ticks.VertSize = 12;
      this.circularGauge2.Ticks.Visible = true;
      this.circularGauge2.Title = "circularGauge1";
      this.circularGauge2.TotalAngle = 242D;
      this.circularGauge2.UniqueCustomRadius = true;
      this.circularGauge2.UseExtendedNumRange = false;
      this.circularGauge2.Value = 132.31206758521128D;
      this.circularGauge2.XValues.DataMember = "Angle";
      this.circularGauge2.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.circularGauge2.YValues.DataMember = "Y";
    }

    private double[] speedRevChgUp;
    private int[] secsToChange;
    private double[] speedRevDropStart;
    private int currentGear;
    private TimeSpan interval = new TimeSpan(0);
    private DateTime changeTime;
    private double stepRevs = 0;
    private double stepSpeed = 0;
    private double distance = 0;
    DateTime lastTime = DateTime.Now;
    int longerInterval = 0;
    int redWarningInterval = 0;
    int deltaWarning = 1;
    bool warningOn = false;
    private DispatcherTimer timer1 = new DispatcherTimer();

    private void goingThroughGears()
    {
      //not used
      double[] gearRatios = new double[] { 2.992, 2.080, 1.541, 1.213, 1.000, 0.861 };

      speedRevChgUp = new double[] { 39, 57, 86, 110, 133, 143 };
      secsToChange = new int[] { 3, 3, 4, 6, 6, 10, 20 };
      //gearchanges made at approx 7500rpm
      //137(ish) is a top speed at 7500rpm
      speedRevDropStart = new double[] { 800, 4700, 5400, 5700, 6100, 5600 };

      //perf 1/4 mile 	6.4 sec 0-60mph &	14.9 sec @ 95.5 mph 	Motor Trend
    }

    public void runCar()
    {
      timer1.Interval = new TimeSpan(0, 0, 0, 0, 50);

      currentGear = 1;
      circularGauge1.Value = speedRevDropStart[currentGear - 1] / 1000;
      circularGauge2.Value = 0;
      numericGauge2.TextMarker.Text = currentGear.ToString();
      distance = 10; //10 miles on ODO
      numericGauge2.Value = distance;
      stepRevs = (7600) / (20 * secsToChange[0]);
      stepSpeed = (speedRevChgUp[0]) / (20 * secsToChange[0]);
      interval = new TimeSpan(0, 0, secsToChange[0]);

      changeTime = DateTime.Now;
      timer1.Start();
    }

    public void initVars()
    {
      timer1.Tick += timer1_Tick;

      goingThroughGears(); //setup gear/speed arrays

      runCar();

    }

    private void timer1_Tick(object sender, EventArgs e)
    {
      DateTime currentTime = DateTime.Now;

      double newSpeed = circularGauge1.Value;

      if ((currentTime - changeTime) > interval)
      {
        currentGear++;
        if (currentGear == 7)
        {
          //pull up in 9 seconds
          stepRevs = -(8100) / (20 * 9); //increase the descent params
          stepSpeed = -(220) / (20 * 9);
          changeTime = DateTime.Now;
          interval = new TimeSpan(0, 0, 9);
        }
        else
        {
          numericGauge2.TextMarker.Text = currentGear.ToString();
          circularGauge1.Value = speedRevDropStart[currentGear - 1] / 1000;
          double topRevs = 7600;
          if (currentGear == 6)
            topRevs = 6500;
          stepRevs = (topRevs - speedRevDropStart[currentGear - 1]) / (20 * secsToChange[currentGear - 1]);
          stepSpeed = (speedRevChgUp[currentGear - 1] - speedRevChgUp[currentGear - 2]) / (20 * secsToChange[currentGear - 1]);  //speedrange/timer_entries/sec * secs
          circularGauge2.Value = speedRevChgUp[currentGear - 2];
          numericGauge1.Value = circularGauge2.Value;
          changeTime = DateTime.Now;
          interval = new TimeSpan(0, 0, secsToChange[currentGear - 1]);
        }
      }
      else
      {
        circularGauge1.Value = circularGauge1.Value + (stepRevs / 1000);
        circularGauge2.Value = circularGauge2.Value + stepSpeed;
        numericGauge1.Value = circularGauge2.Value;

        if (currentGear == 7)
        {
          if (circularGauge2.Value < 2)
          {
            circularGauge1.Value = 0;
            numericGauge1.Value = 0;
            numericGauge2.TextMarker.Text = "1";
            timer1.Stop();
          }
        }

        longerInterval++;

        //if (circularGauge1.Value > 6.9)
        if (circularGauge1.Value > 5.9)
        {
          //control rev warning light
          if (redWarningInterval >= 8)
          {
            warningOn = true;
            deltaWarning = -1;
          }
          else if (redWarningInterval <= 3)
          {
            redWarningInterval++;
            deltaWarning = 1;
            warningOn = false;
          }

          redWarningInterval = redWarningInterval + deltaWarning;
        }
        else
          warningOn = false;

        if (longerInterval == 50)
        {

          //run down only, down-gear arbitrarily
          if (currentGear == 7)
          {
            if (Convert.ToInt16(numericGauge2.TextMarker.Text) > 1)
              numericGauge2.TextMarker.Text = (Convert.ToInt16(numericGauge2.TextMarker.Text) - 1).ToString();
          }

          //set odometer
          TimeSpan deltaTime = currentTime - lastTime;
          distance = distance + (circularGauge2.Value / 3600 * deltaTime.Seconds);
          numericGauge2.Value = distance;
          longerInterval = 0;
          lastTime = DateTime.Now;
        }
      }

      revChart.Invalidate();
      speedChart.Invalidate();
    }

    BitmapImage image = new BitmapImage(new Uri("pack://application:,,,/SubaruBRZWPF;component/Resources/redline_warning.png"));

    private void revChart_BeforeDrawSeries(object sender, Steema.TeeChart.WPF.Drawing.Graphics3D g)
    {
      if (warningOn) //display rev warning light
      {
        g.Draw(306, 198, image);
      }
    }
  }
}
