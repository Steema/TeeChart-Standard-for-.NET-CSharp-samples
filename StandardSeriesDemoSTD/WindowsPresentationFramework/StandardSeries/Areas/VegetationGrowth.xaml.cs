using Steema.TeeChart.WPF;
using Steema.TeeChart.WPF.Drawing;
using Steema.TeeChart.WPF.Styles;
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
  /// Interaction logic for VegetationGrowth.xaml
  /// </summary>
  public partial class VegetationGrowth : UserControl
  {
    public VegetationGrowth()
    {
      InitializeComponent();

      InitializeChart();
    }

    Area area1 = new Area();
    Area area2 = new Area();
    Area area3 = new Area();

    private void InitializeChart()
    {
      this.tChart1.Aspect.Elevation = 350;
      this.tChart1.Aspect.ElevationFloat = 350D;
      this.tChart1.Aspect.Perspective = 55;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Bottom.Grid.Color = Color.FromArgb((byte)(255), (byte)(221), (byte)(221), (byte)(221));
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      this.tChart1.Axes.Bottom.MinorTicks.Visible = false;
      this.tChart1.Axes.Bottom.Ticks.Color = Color.FromArgb((byte)(255), (byte)(128), (byte)(128), (byte)(128));
      this.tChart1.Axes.Bottom.Title.Caption = "Days";
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = Colors.Gray;
      this.tChart1.Axes.Bottom.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "Days"};
      this.tChart1.Axes.Depth.Title.Font.Name = "Roboto Th";
      this.tChart1.Axes.DepthTop.Title.Font.Name = "Roboto Th";
      this.tChart1.Axes.Left.Grid.Color = Color.FromArgb((byte)(255), (byte)(221), (byte)(221), (byte)(221));
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      this.tChart1.Axes.Left.Ticks.Color = Color.FromArgb((byte)(255), (byte)(128), (byte)(128), (byte)(128));
      this.tChart1.Axes.Left.Ticks.Length = 7;
      this.tChart1.Axes.Left.Title.Font.Name = "Roboto Th";
      this.tChart1.Axes.Right.Grid.Visible = false;
      this.tChart1.Axes.Right.MinorTicks.Visible = false;
      this.tChart1.Axes.Right.Ticks.Visible = false;
      this.tChart1.Axes.Right.Title.Font.Name = "Roboto Th";
      this.tChart1.Axes.Top.Title.Font.Name = "Roboto Th";
      this.tChart1.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart1.Header.Alignment = TextAlignment.Left;
      this.tChart1.Header.Font.Bold = true;
      this.tChart1.Header.Font.Brush.Color = Colors.Black;
      this.tChart1.Header.Font.Italic = true;
      this.tChart1.Header.Font.Name = "Roboto Lt";
      this.tChart1.Header.Font.Shadow.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Shadow.SmoothBlur = 2;
      this.tChart1.Header.Font.Size = 14;
      this.tChart1.Header.Lines = new string[] {
        "Vegetation growth"};
      this.tChart1.Legend.Alignment = LegendAlignments.Top;
      this.tChart1.Legend.Font.Name = "Roboto Th";
      this.tChart1.Legend.Font.Size = 14;
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Panel.Bevel.Outer = BevelStyles.None;
      this.tChart1.Panel.Bevel.Width = 2;
      this.tChart1.Panel.BevelWidth = 2;
      this.tChart1.Panel.Brush.Color = Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Panel.Brush.Gradient.StartColor = Colors.White;
      this.tChart1.Panel.Brush.Gradient.UseMiddle = false;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Walls.Back.Pen.Visible = false;
      this.tChart1.Walls.Back.Visible = false;
      this.tChart1.Walls.Bottom.Brush.Gradient.EndColor = Colors.Silver;
      this.tChart1.Walls.Bottom.Brush.Gradient.StartColor = Colors.Gray;
      this.tChart1.Walls.Bottom.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Bottom.Pen.Color = Colors.Gray;
      this.tChart1.Walls.Bottom.Transparent = true;
      this.tChart1.Walls.Left.Brush.Color = Colors.White;
      this.tChart1.Walls.Left.Brush.Gradient.EndColor = Colors.Silver;
      this.tChart1.Walls.Left.Brush.Gradient.StartColor = Colors.Gray;
      this.tChart1.Walls.Left.Brush.Gradient.Visible = true;
      this.tChart1.Walls.Left.Pen.Color = Colors.Gray;
      this.tChart1.Walls.Left.Transparent = true;
      this.tChart1.Walls.Right.Transparent = true;

      this.tChart1.Series.Add(area1);
      //this.area1.AreaBrush.Color = Color.FromArgb((byte)(92), (byte)(255), (byte)(153), (byte)(102));
      //this.area1.Gradient.StartColor = Color.FromArgb((byte)(255), (byte)(68), (byte)(102), (byte)(163));
      //this.area1.AreaLines.Color = Color.FromArgb((byte)(255), (byte)(41), (byte)(61), (byte)(98));
      //this.area1.AreaLines.Transparency = 64;
      this.area1.AreaLines.Visible = false;
      //this.area1.Brush.Color = Color.FromArgb((byte)(92), (byte)(255), (byte)(153), (byte)(102));
      //this.area1.TopGradient.Transparency = 64;
      this.area1.Color = Color.FromArgb((byte)(175), (byte)(255), (byte)(153), (byte)(102));
      this.area1.ColorEach = false;
      //this.area1.LinePen.Color = Color.FromArgb((byte)(255), (byte)(0), (byte)(128), (byte)(255));
      //this.area1.LinePen.Transparency = 64;
      this.area1.LinePen.Visible = false;
      this.area1.Marks.Arrow.Transparency = 64;
      this.area1.Marks.Arrow.Visible = false;
      this.area1.Marks.ArrowLength = 0;
      this.area1.Marks.Brush.Color = Color.FromArgb((byte)(92), (byte)(255), (byte)(255), (byte)(255));
      this.area1.Marks.Brush.Gradient.Transparency = 64;
      this.area1.Marks.Clip = true;
      this.area1.Marks.Font.Brush.Color = Color.FromArgb((byte)(92), (byte)(0), (byte)(0), (byte)(0));
      this.area1.Marks.Font.Brush.Gradient.Transparency = 64;
      this.area1.Marks.Font.Name = "Roboto Th";
      this.area1.Marks.Pen.Transparency = 64;
      this.area1.Marks.Shadow.Brush.Color = Color.FromArgb((byte)(92), (byte)(255), (byte)(255), (byte)(255));
      this.area1.Marks.Shadow.Brush.Gradient.Transparency = 64;
      this.area1.Marks.Transparent = true;
      this.area1.OriginalCursor = null;
      //this.area1.Pointer.Brush.Color = Color.FromArgb((byte)(92), (byte)(255), (byte)(255), (byte)(255));
      //this.area1.Pointer.Brush.Gradient.Transparency = 64;
      //this.area1.Pointer.Pen.Transparency = 64;
      //this.area1.Pointer.SizeDouble = 0D;
      //this.area1.Pointer.SizeUnits = PointerSizeUnits.Pixels;
      this.area1.Title = "With nutrient";
      //this.area1.Transparency = 34;
      this.area1.XValues.Order = ValueListOrder.Ascending;

      this.tChart1.Series.Add(area2);
      //this.area2.AreaBrush.Color = Color.FromArgb((byte)(76), (byte)(128), (byte)(255), (byte)(255));
      //this.area2.Gradient.StartColor = Color.FromArgb((byte)(255), (byte)(68), (byte)(102), (byte)(163));
      //this.area2.AreaLines.Color = Color.FromArgb((byte)(255), (byte)(41), (byte)(61), (byte)(98));
      //this.area2.AreaLines.Transparency = 70;
      this.area2.AreaLines.Visible = false;
      //this.area2.Brush.Color = Color.FromArgb((byte)(76), (byte)(128), (byte)(255), (byte)(255));
      //this.area2.TopGradient.Transparency = 70;
      this.area2.Color = Color.FromArgb((byte)(175), (byte)(128), (byte)(255), (byte)(255));
      this.area2.ColorEach = false;
      //this.area2.LinePen.Color = Colors.Purple;
      //this.area2.LinePen.Transparency = 70;
      this.area2.LinePen.Visible = false;
      this.area2.Marks.Arrow.Transparency = 70;
      this.area2.Marks.Arrow.Visible = false;
      this.area2.Marks.ArrowLength = 0;
      this.area2.Marks.Brush.Color = Color.FromArgb((byte)(76), (byte)(255), (byte)(255), (byte)(255));
      this.area2.Marks.Brush.Gradient.Transparency = 70;
      this.area2.Marks.Font.Brush.Color = Color.FromArgb((byte)(76), (byte)(0), (byte)(0), (byte)(0));
      this.area2.Marks.Font.Brush.Gradient.Transparency = 70;
      this.area2.Marks.Font.Name = "Roboto Th";
      this.area2.Marks.Pen.Transparency = 70;
      this.area2.Marks.Shadow.Brush.Color = Color.FromArgb((byte)(76), (byte)(128), (byte)(128), (byte)(128));
      this.area2.Marks.Shadow.Brush.Gradient.Transparency = 70;
      this.area2.Marks.Transparent = true;
      this.area2.OriginalCursor = null;
      this.area2.Title = "No added nutrient";
      this.area2.XValues.Order = ValueListOrder.Ascending;

      this.tChart1.Series.Add(area3);
      this.area3.AreaLines.Visible = false;
      this.area3.Color = Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(255)))), ((int)(((byte)(153)))), ((int)(((byte)(102)))));
      this.area3.ColorEach = false;
      this.area3.LinePen.Visible = false;
      this.area3.Marks.Arrow.Transparency = 47;
      this.area3.Marks.Arrow.Visible = false;
      this.area3.Marks.ArrowLength = 0;
      this.area3.Marks.Brush.Color = Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(224)))));
      this.area3.Marks.Brush.Gradient.Transparency = 47;
      this.area3.Marks.Font.Brush.Color = Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
      this.area3.Marks.Font.Brush.Gradient.Transparency = 47;
      this.area3.Marks.Font.Name = "Roboto Th";
      this.area3.Marks.Pen.Transparency = 47;
      this.area3.Marks.Shadow.Brush.Color = Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.area3.Marks.Shadow.Brush.Gradient.Transparency = 47;
      this.area3.Marks.Transparent = true;
      this.area3.OriginalCursor = null;
      this.area3.Title = "Series2";
      this.area3.Visible = false;
      this.area3.XValues.Order = ValueListOrder.Ascending;


      Random rnd1 = new Random();
      Random rnd2 = new Random();
      Random rnd3 = new Random();

      for (int t = 0; t < 15; t++)
      {

        area1.Add(rnd1.Next(100));
        area2.Add(rnd1.Next(60));
        area3.Add(rnd1.Next(30));
      }

      area1.Smoothed = true;
      area2.Smoothed = true;
      area3.Smoothed = true;

      tChart1.Axes.Bottom.Increment = 3;
      tChart1.Panel.Gradient.Visible = false;
    }
  }
}
