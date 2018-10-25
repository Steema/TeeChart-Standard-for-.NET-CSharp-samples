using Steema.TeeChart.WPF;
using Steema.TeeChart.WPF.Animations;
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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace StandardSeriesWPFDemo
{
  /// <summary>
  /// Interaction logic for SalesFigures.xaml
  /// </summary>
  public partial class SalesFigures : UserControl
  {
    public SalesFigures()
    {
      InitializeComponent();
      InitializeChart();
    }

    Bar bar1 = new Bar();
    Bar bar2 = new Bar();
    ChartPartAnimation chartPartAnimation1;
    QuadraticEase quadraticEase1 = new QuadraticEase();

    private void InitializeChart()
    {
      chartPartAnimation1 = new ChartPartAnimation(tChart1.Chart);
      this.tChart1.Animations.Add(this.chartPartAnimation1);
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
      this.tChart1.Axes.Right.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Right.Labels.Font.Size = 9;
      this.tChart1.Axes.Top.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Axes.Top.Labels.Font.Size = 9;
      this.tChart1.CurrentTheme = ThemeType.Lookout;
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Size = 12;
      this.tChart1.Header.Lines = new string[] {
        "Sales Figures"};
      this.tChart1.Legend.Alignment = LegendAlignments.Bottom;
      this.tChart1.Legend.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.tChart1.Legend.Font.Size = 9;
      this.tChart1.Legend.Pen.Visible = false;
      this.tChart1.Legend.Shadow.Visible = false;
      this.tChart1.Legend.Transparent = true;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.bar1);
      this.tChart1.Series.Add(this.bar2);
      this.tChart1.TabIndex = 0;
      //this.tChart1.Tools.Add(this.seriesAnimation1);
      this.tChart1.Walls.Back.Brush.Visible = false;
      this.tChart1.Walls.Back.Transparent = true;
      this.tChart1.Walls.Back.Visible = false;
      this.bar1.BarRound = BarRounding.AtValue;
      this.bar1.BarStyle = BarStyles.RoundRectangle;
      this.bar1.BarWidthPercent = 80;
      this.bar1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.Color = Color.FromArgb(255, ((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.ColorEach = false;
      this.bar1.Marks.Arrow.Visible = false;
      this.bar1.Marks.ArrowLength = 8;
      this.bar1.Marks.Brush.Color = Color.FromArgb(255, ((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.Marks.FollowSeriesColor = true;
      this.bar1.Marks.Font.Brush.Color = Colors.White;
      this.bar1.Marks.Font.Name = "Segoe UI";
      this.bar1.Marks.Pen.Color = Color.FromArgb(255, ((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.bar1.Marks.Pen.Visible = false;
      this.bar1.Marks.Shadow.Visible = false;
      this.bar1.Marks.Style = MarksStyles.LabelValue;
      this.bar1.OffsetPercent = -10;
      this.bar1.OriginalCursor = null;
      this.bar1.Pen.Color = Color.FromArgb(255, ((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      this.bar1.Pen.Visible = false;
      this.bar1.Title = "Series0";
      this.bar1.XValues.Order = ValueListOrder.Ascending;
      this.bar1.YValues.DataMember = "Bar";
      this.bar2.BarRound = BarRounding.AtValue;
      this.bar2.BarStyle = BarStyles.RoundRectangle;
      this.bar2.BarWidthPercent = 80;
      this.bar2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.ColorEach = false;
      this.bar2.Marks.Arrow.Visible = false;
      this.bar2.Marks.ArrowLength = 8;
      this.bar2.Marks.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.Marks.FollowSeriesColor = true;
      this.bar2.Marks.Font.Brush.Color = Colors.White;
      this.bar2.Marks.Font.Name = "Segoe UI";
      this.bar2.Marks.Pen.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.bar2.Marks.Pen.Visible = false;
      this.bar2.Marks.Shadow.Visible = false;
      this.bar2.Marks.Style = MarksStyles.LabelValue;
      this.bar2.Marks.Symbol.Shadow.Visible = false;
      this.bar2.OffsetPercent = 10;
      this.bar2.OriginalCursor = null;
      this.bar2.Pen.Color = Color.FromArgb(255, ((int)(((byte)(153)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
      this.bar2.Pen.Visible = false;
      this.bar2.Title = "Series1";
      this.bar2.XValues.Order = ValueListOrder.Ascending;
      this.bar2.YValues.DataMember = "Bar";
      //this.seriesAnimation1.StartValue = 0D;
      this.chartPartAnimation1.Axis = null;
      quadraticEase1.EasingMode = EasingMode.EaseIn;
      this.chartPartAnimation1.Fade = TransformFade.In;
      this.chartPartAnimation1.RotateMax = 0F;
      this.chartPartAnimation1.RotateMin = 0F;
      //this.chartPartAnimation1.Series = this.bar1;
      this.chartPartAnimation1.Speed = 3000;
      this.chartPartAnimation1.Target = ChartClickedPartStyle.Series;
      this.chartPartAnimation1.TranslateStyle = TransformTranslate.None;
      this.chartPartAnimation1.ZoomStyle = TransformZoom.None;

      tChart1.Panel.Gradient.Visible = false;
      tChart1.Series.Add(bar1);
      tChart1.Series.Add(bar2);

      //add series and data
      bar1.Title = "Apples";
      bar1.Clear();
      bar1.Add(5, "jan");
      bar1.Add(2, "feb");
      bar1.Add(1, "mar");
      bar1.Add(4, "apr");
      bar1.Add(10, "may");
      bar1.Add(11, "jun");
      bar1.Add(15, "jul");

      bar2.Title = "Pears";
      bar2.Clear();
      bar2.Add(7);
      bar2.Add(5);
      bar2.Add(1);
      bar2.Add(6);
      bar2.Add(2);
      bar2.Add(11);
      bar2.Add(5);

      tChart1.Axes.Bottom.Labels.Style = AxisLabelStyle.Text;
      tChart1.Axes.Left.Increment = 3;

      tChart1.Axes.Left.SetMinMax(0, 15);

      chartPartAnimation1.Trigger = AnimationTrigger.MouseOver;

    }
  }
}
