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
  public sealed partial class ProductShipmentsSubPage : Page
  {

    private Steema.TeeChart.Store.Styles.Points points1;
    private Steema.TeeChart.Store.Styles.Points points2;
    private Steema.TeeChart.Store.Functions.Smoothing smoothing1;
    private Steema.TeeChart.Store.Styles.Line line1;
    private Steema.TeeChart.Store.Functions.Average average1;
    private Steema.TeeChart.Store.Styles.Line line2;

    public ProductShipmentsSubPage()
    {
      this.InitializeComponent();
      InitializeChart();

      int[] Yarr1 = new int[] { 5, 3, 2, 7, 1, 6, 4, 5, 1, 0, 10, 7, 11, 15, 12, 21, 17, 15, 19, 24, 21, 11, 15, 21, 19, 17, 20, 23 };
      int[] Yarr2 = new int[] { 7, 1, 5, 1, 0, 10, 6, 3, 2, 7, 11, 4, 5, 3, 4, 5, 1, 5, 11, 15, 16, 14, 14, 13, 12, 15, 17, 19 };

      DateTime[] Xarr = new DateTime[] {new DateTime(2012, 9, 1),new DateTime(2012, 9, 15),new DateTime(2012, 10, 1),new DateTime(2012, 10, 15),new DateTime(2012, 11, 1)
                  ,new DateTime(2012, 11, 15),new DateTime(2012, 12, 1),new DateTime(2012, 12, 15),new DateTime(2013, 1, 1),new DateTime(2013, 1, 15)
          ,new DateTime(2013, 2, 1),new DateTime(2013, 2, 15),new DateTime(2013, 3, 1),new DateTime(2013, 3, 15)
          ,new DateTime(2013, 4, 1),new DateTime(2013, 4, 15),new DateTime(2013, 5, 1),new DateTime(2013, 5, 15),new DateTime(2013, 6, 1)
                  ,new DateTime(2013, 6, 15),new DateTime(2013, 7, 1),new DateTime(2013, 7, 15),new DateTime(2013, 8, 1),new DateTime(2013, 8, 15)
          ,new DateTime(2013, 9, 1),new DateTime(2013, 9, 15),new DateTime(2013, 10, 1),new DateTime(2013, 10, 15)};

      tChart1.Panel.Gradient.Visible = false;
      tChart1.Walls.Back.Visible = false;

      tChart1[0].Title = "Apples";
      tChart1[1].Title = "Pears";
      tChart1[2].Title = "Average";
      tChart1[0].Add(Xarr, Yarr1);
      tChart1[1].Add(Xarr, Yarr2);

      tChart1[0].XValues.DateTime = true;
      tChart1[1].XValues.DateTime = true;

      points1.Pointer.Style = Steema.TeeChart.Store.Styles.PointerStyles.Circle;
      points2.Pointer.Style = Steema.TeeChart.Store.Styles.PointerStyles.Circle;
      points1.Pointer.Pen.Visible = false;
      points2.Pointer.Pen.Visible = false;

      line1.LinePen.Visible = false;
      line1.Legend.Visible = false;
      line1.CheckDataSource();

      line2.DataSource = line1;
      line2.Smoothed = true;
      line2.CheckDataSource();

      tChart1.Header.Font.Size = 16;
      tChart1.SubHeader.Font.Size = 10;
      tChart1.SubHeader.Alignment = TextAlignment.Left;
    }

    private void InitializeChart()
    {
      this.points1 = new Steema.TeeChart.Store.Styles.Points();
      this.points2 = new Steema.TeeChart.Store.Styles.Points();
      this.line1 = new Steema.TeeChart.Store.Styles.Line();
      this.average1 = new Steema.TeeChart.Store.Functions.Average();
      this.smoothing1 = new Steema.TeeChart.Store.Functions.Smoothing();
      this.line2 = new Steema.TeeChart.Store.Styles.Line();

      this.tChart1.Aspect.Elevation = 350;
      this.tChart1.Aspect.ElevationFloat = 350D;
      this.tChart1.Aspect.Perspective = 55;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Bottom.AxisPen.Visible = false;
      this.tChart1.Axes.Bottom.AxisPen.Width = 0;
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Bottom.Labels.Font.Size = 24;
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart1.Axes.Bottom.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Depth.Title.Font.Size = 13;
      this.tChart1.Axes.DepthTop.Title.Font.Size = 13;
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.AxisPen.Width = 0;
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 24;
      this.tChart1.Axes.Left.MinimumOffset = 10;
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      this.tChart1.Axes.Left.Ticks.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Left.Ticks.Length = 7;
      this.tChart1.Axes.Right.AxisPen.Width = 0;
      this.tChart1.Axes.Right.Grid.Visible = false;
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Axes.Right.Labels.Font.Size = 31;
      this.tChart1.Axes.Right.MinorTicks.Visible = false;
      this.tChart1.Axes.Right.Ticks.Visible = false;
      this.tChart1.Footer.Font.Brush.Color = Windows.UI.Colors.Blue;
      this.tChart1.Header.Alignment = TextAlignment.Left;
      this.tChart1.Header.Font.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Header.Font.Shadow.Brush.Color = Windows.UI.Colors.Gray;
      this.tChart1.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart1.Header.Font.Size = 33;
      this.tChart1.Header.Lines = new string[] {
        "Product shipments"};
      this.tChart1.Legend.Font.Size = 19;
      this.tChart1.Legend.Pen.Visible = false;
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Bevel.Outer = Steema.TeeChart.Store.Drawing.BevelStyles.None;
      this.tChart1.Panel.Bevel.Width = 2;
      this.tChart1.Panel.BevelWidth = 2;
      this.tChart1.Panel.Brush.Color = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.points1);
      this.tChart1.Series.Add(this.points2);
      this.tChart1.Series.Add(this.line1);
      this.tChart1.Series.Add(this.line2);
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Windows.UI.Colors.White;
      this.tChart1.Walls.Back.Pen.Visible = false;
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Bottom.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Bottom.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Bottom.Transparent = true;
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = Windows.UI.Colors.Silver;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Left.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Left.Pen.Color = Windows.UI.Colors.Gray;
      this.tChart1.Walls.Left.Transparent = true;
      this.tChart1.Walls.Right.Transparent = true;
      this.tChart1.Walls.Visible = false;
      this.points1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.points1.ColorEach = false;
      this.points1.LinePen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.points1.OriginalCursor = null;
      this.points1.Pointer.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.points1.Pointer.Brush.Gradient.StartColor = Windows.UI.Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.points1.Pointer.SizeDouble = 0D;
      this.points1.Pointer.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.points1.Title = "points1";
      this.points1.XValues.DataMember = "X";
      this.points1.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.points1.YValues.DataMember = "Y";
      this.points2.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.points2.ColorEach = false;
      this.points2.LinePen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.points2.OriginalCursor = null;
      this.points2.Pointer.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.points2.Pointer.Brush.Gradient.StartColor = Windows.UI.Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.points2.Pointer.SizeDouble = 0D;
      this.points2.Pointer.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.points2.Title = "points2";
      this.points2.XValues.DataMember = "X";
      this.points2.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.points2.YValues.DataMember = "Y";
      this.line1.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.line1.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.line1.ColorEach = false;
      this.line1.DataSource = new object[] {
        ((object)(this.points1)),
        ((object)(this.points2))};
      this.line1.Function = this.average1;
      this.line1.LinePen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
      this.line1.OriginalCursor = null;
      this.line1.Pointer.SizeDouble = 0D;
      this.line1.Pointer.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.line1.Title = "line1";
      this.line1.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
      this.average1.Period = 2D;
      this.smoothing1.Factor = 8;
      this.smoothing1.Period = 1D;
      this.line2.Brush.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
      this.line2.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(78)))), ((int)(((byte)(151)))), ((int)(((byte)(168)))));
      this.line2.ColorEach = false;
      this.line2.LinePen.Color = Windows.UI.Color.FromArgb(255, ((int)(((byte)(47)))), ((int)(((byte)(91)))), ((int)(((byte)(101)))));
      this.line2.LinePen.Width = 2;
      this.line2.OriginalCursor = null;
      this.line2.Pointer.SizeDouble = 0D;
      this.line2.Pointer.SizeUnits = Steema.TeeChart.Store.Styles.PointerSizeUnits.Pixels;
      this.line2.Title = "line2";
      this.line2.XValues.Order = Steema.TeeChart.Store.Styles.ValueListOrder.Ascending;
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
