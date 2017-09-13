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
  /// Interaction logic for MultiPies.xaml
  /// </summary>
  public partial class MultiPies : UserControl
  {
    private Steema.TeeChart.WPF.Styles.Bar bar3;
    private Steema.TeeChart.WPF.Styles.Bar bar2;
    private Steema.TeeChart.WPF.Styles.Pie pie3;
    private Steema.TeeChart.WPF.Styles.Pie pie2;
    private Steema.TeeChart.WPF.Styles.Pie pie1;
    private Steema.TeeChart.WPF.Styles.Bar bar4;
    private Steema.TeeChart.WPF.Styles.Bar bar5;
    private Steema.TeeChart.WPF.Styles.Bar bar1;

    public MultiPies()
    {
      InitializeComponent();

      InitializeChart();

      tChart1.Panel.Gradient.Visible = false;
      tChart2.Panel.Gradient.Visible = false;
      tChart3.Panel.Gradient.Visible = false;
      tChart4.Panel.Gradient.Visible = false;
      tChart5.Panel.Gradient.Visible = false;
      tChart6.Panel.Gradient.Visible = false;
      tChart7.Panel.Gradient.Visible = false;

      tChart7.Axes.Visible = false;

      tChart4[0].Marks.FontSeriesColor = true;
      tChart5[0].Marks.FontSeriesColor = true;
      tChart6[0].Marks.FontSeriesColor = true;

      pie1.Add(70);
      pie1.Add(25);
      bar1.Add(70);
      bar1.Add(25);

      pie2.Add(65);
      pie2.Add(30);
      bar2.Add(65);
      bar2.Add(30);

      pie3.Add(55);
      pie3.Add(40);
      bar3.Add(55);
      bar3.Add(40);

      label1.BorderThickness = new Thickness(0);
      label1.FontFamily = new FontFamily("Meiryo UI");
      label1.HorizontalContentAlignment = HorizontalAlignment.Center;
      label1.VerticalContentAlignment = VerticalAlignment.Center;
      label1.TextAlignment = TextAlignment.Center;
    }

    private void InitializeChart()
    {
      this.bar3 = new Steema.TeeChart.WPF.Styles.Bar();
      this.bar2 = new Steema.TeeChart.WPF.Styles.Bar();
      this.pie3 = new Steema.TeeChart.WPF.Styles.Pie();
      this.pie2 = new Steema.TeeChart.WPF.Styles.Pie();
      this.pie1 = new Steema.TeeChart.WPF.Styles.Pie();
      this.bar4 = new Steema.TeeChart.WPF.Styles.Bar();
      this.bar5 = new Steema.TeeChart.WPF.Styles.Bar();
      this.bar1 = new Steema.TeeChart.WPF.Styles.Bar();

      this.tChart6.Aspect.Elevation = 315;
      this.tChart6.Aspect.ElevationFloat = 315D;
      this.tChart6.Aspect.Orthogonal = false;
      this.tChart6.Aspect.Perspective = 0;
      this.tChart6.Aspect.Rotation = 360;
      this.tChart6.Aspect.RotationFloat = 360D;
      this.tChart6.Aspect.View3D = false;
      this.tChart6.Axes.Bottom.Visible = false;
      this.tChart6.Axes.Left.AxisPen.Color = Color.FromArgb(255, ((int)(((byte)(192)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
      this.tChart6.Axes.Left.AxisPen.Width = 1;
      this.tChart6.Axes.Left.Grid.Visible = false;
      this.tChart6.Axes.Left.Increment = 20D;
      this.tChart6.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
      this.tChart6.Axes.Left.MinorTicks.Visible = false;
      this.tChart6.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart6.Header.Font.Brush.Color = Colors.Gray;
      this.tChart6.Header.Lines = new string[] {
        "Evening Class"};
      this.tChart6.Header.Visible = false;
      this.tChart6.Legend.Visible = false;
      this.tChart6.Name = "tChart6";
      this.tChart6.Panel.Brush.Color = Colors.White;
      this.tChart6.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart6.Panel.MarginBottom = 6D;
      this.tChart6.Series.Add(this.bar3);
      this.tChart6.TabIndex = 5;
      this.tChart6.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart6.Walls.Visible = false;
      this.bar3.BarRound = Steema.TeeChart.WPF.Styles.BarRounding.AtValue;
      this.bar3.BarWidthPercent = 95;
      this.bar3.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar3.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar3.ColorEach = true;
      this.bar3.Marks.Arrow.Visible = false;
      this.bar3.Marks.ArrowLength = -24;
      this.bar3.Marks.Pen.Visible = false;
      this.bar3.Marks.Shadow.Visible = false;
      this.bar3.Marks.Style = Steema.TeeChart.WPF.Styles.MarksStyles.Value;
      this.bar3.OriginalCursor = null;
      this.bar3.Pen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar3.Title = "bar1";
      this.bar3.XValues.DataMember = "X";
      this.bar3.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.bar3.YValues.DataMember = "Bar";
      this.tChart5.Aspect.Elevation = 315;
      this.tChart5.Aspect.ElevationFloat = 315D;
      this.tChart5.Aspect.Orthogonal = false;
      this.tChart5.Aspect.Perspective = 0;
      this.tChart5.Aspect.Rotation = 360;
      this.tChart5.Aspect.RotationFloat = 360D;
      this.tChart5.Aspect.View3D = false;
      this.tChart5.Axes.Bottom.Visible = false;
      this.tChart5.Axes.Left.AxisPen.Color = Color.FromArgb(255, ((int)(((byte)(192)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
      this.tChart5.Axes.Left.AxisPen.Width = 1;
      this.tChart5.Axes.Left.Grid.Visible = false;
      this.tChart5.Axes.Left.Increment = 20D;
      this.tChart5.Axes.Left.Labels.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
      this.tChart5.Axes.Left.MinorTicks.Visible = false;
      this.tChart5.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart5.Header.Font.Brush.Color = Colors.Gray;
      this.tChart5.Header.Lines = new string[] {
        "Afternoon Class"};
      this.tChart5.Header.Visible = false;
      this.tChart5.Legend.Visible = false;
      this.tChart5.Name = "tChart5";
      this.tChart5.Panel.Brush.Color = Colors.White;
      this.tChart5.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart5.Panel.MarginBottom = 6D;
      this.tChart5.Series.Add(this.bar2);
      this.tChart5.TabIndex = 4;
      this.tChart5.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart5.Walls.Visible = false;
      this.bar2.BarRound = Steema.TeeChart.WPF.Styles.BarRounding.AtValue;
      this.bar2.BarWidthPercent = 95;
      this.bar2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar2.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar2.ColorEach = true;
      this.bar2.Marks.Arrow.Visible = false;
      this.bar2.Marks.ArrowLength = -24;
      this.bar2.Marks.Pen.Visible = false;
      this.bar2.Marks.Shadow.Visible = false;
      this.bar2.Marks.Style = Steema.TeeChart.WPF.Styles.MarksStyles.Value;
      this.bar2.OriginalCursor = null;
      this.bar2.Pen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar2.Title = "bar1";
      this.bar2.XValues.DataMember = "X";
      this.bar2.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.bar2.YValues.DataMember = "Bar";
      this.tChart4.Aspect.Elevation = 315;
      this.tChart4.Aspect.ElevationFloat = 315D;
      this.tChart4.Aspect.Orthogonal = false;
      this.tChart4.Aspect.Perspective = 0;
      this.tChart4.Aspect.Rotation = 360;
      this.tChart4.Aspect.RotationFloat = 360D;
      this.tChart4.Aspect.View3D = false;
      this.tChart4.Axes.Bottom.Visible = false;
      this.tChart4.Axes.Left.AxisPen.Width = 1;
      this.tChart4.Axes.Left.Grid.Visible = false;
      this.tChart4.Axes.Left.Increment = 20D;
      this.tChart4.Axes.Left.Labels.Font.Brush.Color = Colors.Gray;
      this.tChart4.Axes.Left.MinorTicks.Visible = false;
      this.tChart4.Footer.Font.Brush.Color = Colors.Gray;
      this.tChart4.Header.Font.Brush.Color = Colors.Gray;
      this.tChart4.Header.Lines = new string[] {
        "Morning Class"};
      this.tChart4.Header.Visible = false;
      this.tChart4.Legend.Visible = false;
      this.tChart4.Name = "tChart4";
      this.tChart4.Panel.Brush.Color = Colors.White;
      this.tChart4.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart4.Panel.MarginBottom = 6D;
      this.tChart4.Series.Add(this.bar1);
      this.tChart4.TabIndex = 3;
      this.tChart4.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart4.Walls.Visible = false;
      this.tChart3.Aspect.Elevation = 315;
      this.tChart3.Aspect.ElevationFloat = 315D;
      this.tChart3.Aspect.Orthogonal = false;
      this.tChart3.Aspect.Perspective = 0;
      this.tChart3.Aspect.Rotation = 360;
      this.tChart3.Aspect.RotationFloat = 360D;
      this.tChart3.Aspect.View3D = false;
      this.tChart3.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart3.Header.Font.Brush.Color = Colors.Gray;
      this.tChart3.Header.Lines = new string[] {
        "Evening Class"};
      this.tChart3.Legend.Visible = false;
      this.tChart3.Name = "tChart3";
      this.tChart3.Panel.Brush.Color = Colors.White;
      this.tChart3.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart3.Series.Add(this.pie3);
      this.tChart3.TabIndex = 2;
      this.tChart3.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.pie3.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.pie3.Circled = true;
      this.pie3.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.pie3.ExplodeBiggest = 5;
      this.pie3.ExplodedSlice.Add(0);
      this.pie3.ExplodedSlice.Add(5);
      this.pie3.Frame.Circled = true;
      this.pie3.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.pie3.Frame.OuterBand.Gradient.UseMiddle = false;
      this.pie3.LabelMember = "Labels";
      this.pie3.Marks.Visible = false;
      this.pie3.MarksPie.LegSize = 0;
      this.pie3.MarksPie.VertCenter = false;
      this.pie3.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.pie3.OriginalCursor = null;
      this.pie3.OtherSlice.Color = Utils.EmptyColor;
      this.pie3.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.pie3.OtherSlice.Text = "";
      this.pie3.OtherSlice.Value = 0D;
      this.pie3.RotationAngle = 91;
      this.pie3.Title = "pie1";
      this.pie3.UniqueCustomRadius = true;
      this.pie3.XValues.DataMember = "Angle";
      this.pie3.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.pie3.YValues.DataMember = "Pie";
      this.tChart2.Aspect.Elevation = 315;
      this.tChart2.Aspect.ElevationFloat = 315D;
      this.tChart2.Aspect.Orthogonal = false;
      this.tChart2.Aspect.Perspective = 0;
      this.tChart2.Aspect.Rotation = 360;
      this.tChart2.Aspect.RotationFloat = 360D;
      this.tChart2.Aspect.View3D = false;
      this.tChart2.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart2.Header.Font.Brush.Color = Colors.Gray;
      this.tChart2.Header.Lines = new string[] {
        "Afternoon Class"};
      this.tChart2.Legend.Visible = false;
      this.tChart2.Name = "tChart2";
      this.tChart2.Panel.Brush.Color = Colors.White;
      this.tChart2.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart2.Series.Add(this.pie2);
      this.tChart2.TabIndex = 1;
      this.tChart2.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.pie2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.pie2.Circled = true;
      this.pie2.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.pie2.ExplodeBiggest = 5;
      this.pie2.ExplodedSlice.Add(5);
      this.pie2.Frame.Circled = true;
      this.pie2.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.pie2.Frame.OuterBand.Gradient.UseMiddle = false;
      this.pie2.LabelMember = "Labels";
      this.pie2.Marks.Visible = false;
      this.pie2.MarksPie.LegSize = 0;
      this.pie2.MarksPie.VertCenter = false;
      this.pie2.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.pie2.OriginalCursor = null;
      this.pie2.OtherSlice.Color = Utils.EmptyColor;
      this.pie2.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.pie2.OtherSlice.Text = "";
      this.pie2.OtherSlice.Value = 0D;
      this.pie2.RotationAngle = 91;
      this.pie2.Title = "pie1";
      this.pie2.UniqueCustomRadius = true;
      this.pie2.XValues.DataMember = "Angle";
      this.pie2.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.pie2.YValues.DataMember = "Pie";
      this.tChart1.Aspect.Elevation = 315;
      this.tChart1.Aspect.ElevationFloat = 315D;
      this.tChart1.Aspect.Orthogonal = false;
      this.tChart1.Aspect.Perspective = 0;
      this.tChart1.Aspect.Rotation = 360;
      this.tChart1.Aspect.RotationFloat = 360D;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Lines = new string[] {
        "Morning Class"};
      this.tChart1.Legend.Visible = false;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Series.Add(this.pie1);
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.pie1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.pie1.Circled = true;
      this.pie1.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.pie1.ExplodeBiggest = 5;
      this.pie1.ExplodedSlice.Add(5);
      this.pie1.Frame.Circled = true;
      this.pie1.Frame.FrameElementPercents = new double[] {
        25D,
        60D,
        15D};
      this.pie1.Frame.OuterBand.Gradient.UseMiddle = false;
      this.pie1.LabelMember = "Labels";
      this.pie1.Marks.Visible = false;
      this.pie1.MarksPie.LegSize = 0;
      this.pie1.MarksPie.VertCenter = false;
      this.pie1.MultiPie = Steema.TeeChart.WPF.Styles.MultiPies.Automatic;
      this.pie1.OriginalCursor = null;
      this.pie1.OtherSlice.Color = Utils.EmptyColor;
      this.pie1.OtherSlice.Style = Steema.TeeChart.WPF.Styles.PieOtherStyles.None;
      this.pie1.OtherSlice.Text = "";
      this.pie1.OtherSlice.Value = 0D;
      this.pie1.RotationAngle = 91;
      this.pie1.Title = "pie1";
      this.pie1.UniqueCustomRadius = true;
      this.pie1.XValues.DataMember = "Angle";
      this.pie1.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.pie1.YValues.DataMember = "Pie";
      this.tChart7.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart7.Header.Visible = false;
      this.tChart7.Legend.Alignment = Steema.TeeChart.WPF.LegendAlignments.Top;
      this.tChart7.Legend.Font.Brush.Color = Colors.Gray;
      this.tChart7.Legend.Font.Name = "Segoe UI";
      this.tChart7.Legend.Font.Size = 14;
      this.tChart7.Legend.Pen.Visible = false;
      this.tChart7.Legend.Transparent = true;
      this.tChart7.Name = "tChart7";
      this.tChart7.Panel.Bevel.Outer = Steema.TeeChart.WPF.Drawing.BevelStyles.None;
      this.tChart7.Panel.Brush.Color = Colors.White;
      this.tChart7.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart7.Panel.MarginBottom = 0D;
      this.tChart7.Panel.MarginTop = 6D;
      this.tChart7.Series.Add(this.bar4);
      this.tChart7.Series.Add(this.bar5);
      this.tChart7.TabIndex = 1;
      this.tChart7.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.bar4.BarRound = Steema.TeeChart.WPF.Styles.BarRounding.AtValue;
      this.bar4.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar4.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar4.ColorEach = false;
      this.bar4.Marks.Visible = false;
      this.bar4.OriginalCursor = null;
      this.bar4.Pen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar4.Pen.Visible = false;
      this.bar4.Title = "Women";
      this.bar4.XValues.DataMember = "X";
      this.bar4.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.bar4.YValues.DataMember = "Bar";
      this.bar5.BarRound = Steema.TeeChart.WPF.Styles.BarRounding.AtValue;
      this.bar5.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar5.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.bar5.ColorEach = false;
      this.bar5.Marks.Visible = false;
      this.bar5.OriginalCursor = null;
      this.bar5.Pen.Color = Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.bar5.Pen.Visible = false;
      this.bar5.Title = "Men";
      this.bar5.XValues.DataMember = "X";
      this.bar5.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.bar5.YValues.DataMember = "Bar";
      //this.label1.Font = new System.Drawing.Font("Meiryo UI", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Name = "label1";
      this.label1.TabIndex = 0;
      this.label1.Text = "Women are more likely to attend the day classes while men are more commonly found" +
    " in the evening class";
      //this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.bar1.BarRound = Steema.TeeChart.WPF.Styles.BarRounding.AtValue;
      this.bar1.BarWidthPercent = 95;
      this.bar1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.Color = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.bar1.ColorEach = true;
      this.bar1.Marks.Arrow.Visible = false;
      this.bar1.Marks.ArrowLength = -24;
      this.bar1.Marks.Pen.Visible = false;
      this.bar1.Marks.Shadow.Visible = false;
      this.bar1.Marks.Style = Steema.TeeChart.WPF.Styles.MarksStyles.Value;
      this.bar1.OriginalCursor = null;
      this.bar1.Pen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.bar1.Title = "bar1";
      this.bar1.XValues.DataMember = "X";
      this.bar1.XValues.Order = Steema.TeeChart.WPF.Styles.ValueListOrder.Ascending;
      this.bar1.YValues.DataMember = "Bar";
    }
  }
}
