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
  /// Interaction logic for StackedBars.xaml
  /// </summary>
  public partial class StackedBars : UserControl
  {
    public StackedBars()
    {
      InitializeComponent();

      InitializeChart();
    }

    Bar bar1 = new Bar();
    Bar bar2 = new Bar();
    Bar bar3 = new Bar();

    private void InitializeChart()
    {
      this.tChart1.Series.Add(bar1);
      this.tChart1.Series.Add(bar2);
      this.tChart1.Series.Add(bar3);
      this.tChart1.Aspect.ColorPaletteIndex = 20;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Bottom.Grid.DrawEvery = 2;
      this.tChart1.Axes.Bottom.Grid.Visible = false;
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart1.Axes.Bottom.Labels.Font.Size = 9;
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Bottom.Title.Font.Size = 11;
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.Grid.DrawEvery = 2;
      this.tChart1.Axes.Left.Grid.Style = DashStyles.Solid;
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = Colors.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 9;
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      this.tChart1.Axes.Left.Ticks.Visible = false;
      this.tChart1.Axes.Left.Title.Caption = "$ 000s";
      this.tChart1.Axes.Left.Title.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Left.Title.Font.Size = 11;
      this.tChart1.Axes.Left.Title.Lines = new string[] {
        "$ 000s"};
      this.tChart1.Axes.Right.AxisPen.Visible = false;
      this.tChart1.Axes.Right.Increment = 5D;
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Right.Title.Caption = "Billions";
      this.tChart1.Axes.Right.Title.Lines = new string[] {
        "Billions"};
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.CurrentTheme = ThemeType.Lookout;
      this.tChart1.Footer.Alignment = TextAlignment.Left;
      this.tChart1.Footer.Font.Brush.Color = Colors.Black;
      this.tChart1.Footer.Font.Italic = true;
      this.tChart1.Footer.Font.Name = "Segoe UI";
      this.tChart1.Footer.Lines = new string[] {
        "Source : BI Intelligence estimates, Interactive Advertising Bureau"};
      this.tChart1.Footer.Visible = true;
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Size = 12;
      this.tChart1.Header.Lines = new string[] {
        "Native Advertising Revenue"};
      this.tChart1.Legend.Alignment = LegendAlignments.Top;
      this.tChart1.Legend.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Pen.Visible = false;
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Bevel.Outer = BevelStyles.None;
      this.tChart1.Panel.Bevel.Width = 2;
      this.tChart1.Panel.BevelWidth = 2;
      this.tChart1.Panel.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.bar1);
      this.tChart1.Series.Add(this.bar2);
      this.tChart1.Series.Add(this.bar3);
      this.tChart1.SubHeader.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(157)))), ((int)(((byte)(157)))), ((int)(((byte)(157)))));
      this.tChart1.SubHeader.Lines = new string[] {
        "Desktop and Mobile"};
      this.tChart1.SubHeader.Visible = true;
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Visible = false;
      this.tChart1.Walls.Back.Transparent = true;
      this.tChart1.Walls.Back.Visible = false;
      this.tChart1.GetAxisLabel += TChart1_GetAxisLabel;
      this.bar1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.ColorEach = false;
      this.bar1.Marks.Arrow.Visible = false;
      this.bar1.Marks.ArrowLength = 8;
      this.bar1.Marks.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Marks.FollowSeriesColor = true;
      this.bar1.Marks.Font.Brush.Color = Colors.White;
      this.bar1.Marks.Pen.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Marks.Shadow.Visible = false;
      this.bar1.MultiBar = MultiBars.Stacked;
      this.bar1.OriginalCursor = null;
      this.bar1.Pen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar1.Title = "Native-Style Display";
      this.bar1.VertAxis = VerticalAxis.Right;
      this.bar1.XValues.Order = ValueListOrder.Ascending;
      this.bar1.GetSeriesMark += Bar1_GetSeriesMark;
      this.bar2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar2.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar2.ColorEach = false;
      this.bar2.Marks.Arrow.Visible = false;
      this.bar2.Marks.ArrowLength = 8;
      this.bar2.Marks.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar2.Marks.FollowSeriesColor = true;
      this.bar2.Marks.Font.Brush.Color = Colors.White;
      this.bar2.Marks.Pen.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar2.Marks.Shadow.Visible = false;
      this.bar2.MultiBar = MultiBars.Stacked;
      this.bar2.OriginalCursor = null;
      this.bar2.Pen.Color = Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.bar2.Title = "Sponsorship";
      this.bar2.VertAxis = VerticalAxis.Right;
      this.bar2.XValues.Order = ValueListOrder.Ascending;
      this.bar3.BarRound = BarRounding.AtValue;
      this.bar3.BarStyle = BarStyles.RoundRectangle;
      this.bar3.Brush.Color = Color.FromArgb(255, ((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.Color = Color.FromArgb(255, ((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.ColorEach = false;
      this.bar3.Marks.Arrow.Visible = false;
      this.bar3.Marks.ArrowLength = 8;
      this.bar3.Marks.Brush.Color = Color.FromArgb(255, ((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.Marks.FollowSeriesColor = true;
      this.bar3.Marks.Font.Brush.Color = Colors.White;
      this.bar3.Marks.Pen.Color = Color.FromArgb(255, ((int)(((byte)(241)))), ((int)(((byte)(76)))), ((int)(((byte)(20)))));
      this.bar3.Marks.Shadow.Visible = false;
      this.bar3.MultiBar = MultiBars.Stacked;
      this.bar3.OriginalCursor = null;
      this.bar3.Pen.Color = Color.FromArgb(255, ((int)(((byte)(145)))), ((int)(((byte)(46)))), ((int)(((byte)(12)))));
      this.bar3.Title = "Social";
      this.bar3.VertAxis = VerticalAxis.Right;
      this.bar3.XValues.Order = ValueListOrder.Ascending;

      tChart1.Panel.Gradient.Visible = false;

      bar1.Add(1);
      bar1.Add(1.3);
      bar1.Add(1.9);
      bar1.Add(2.7);
      bar1.Add(3.9);
      bar1.Add(5.7);

      bar2.Add(0.8);
      bar2.Add(1);
      bar2.Add(1.3);
      bar2.Add(2);
      bar2.Add(2.7);
      bar2.Add(3.4);

      bar3.Add(2.9);
      bar3.Add(5.6);
      bar3.Add(7.5);
      bar3.Add(9.2);
      bar3.Add(10.7);
      bar3.Add(11.9);
    }

    private void Bar1_GetSeriesMark(Series series, GetSeriesMarkEventArgs e)
    {
      e.MarkText = e.MarkText + " $";
    }

    private void TChart1_GetAxisLabel(object sender, GetAxisLabelEventArgs e)
    {
      if ((((Axis)(sender)).Horizontal == false) && (((Axis)(sender)).OtherSide == true))
        e.LabelText = e.LabelText + " $";
    }
  }
}
