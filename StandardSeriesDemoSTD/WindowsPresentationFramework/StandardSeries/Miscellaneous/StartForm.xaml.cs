using Steema.TeeChart.WPF;
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
  /// Interaction logic for StartForm.xaml
  /// </summary>
  public partial class StartForm : UserControl
  {
    public StartForm()
    {
      InitializeComponent();

      InitializeChart();
    }

    List<TChart> Charts;

    private void InitializeChart()
    {
      Charts = new List<TChart>();
      Charts.Add(tChart1);
      Charts.Add(tChart2);
      Charts.Add(tChart3);
      Charts.Add(tChart4);
      Charts.Add(tChart5);
      Charts.Add(tChart6);
      Charts.Add(tChart7);

      foreach (var item in Charts)
      {
        item.Aspect.View3D = false;
        item.Header.Font.Color = Utils.HexToColor("FFFFFFFF");
        item.Header.Font.Size = 18;
        item.Header.Alignment = TextAlignment.Left;
        item.Panel.Gradient.Visible = false;
        item.Walls.Visible = false;
        item.Legend.Visible = false;
        item.Axes.Bottom.Visible = false;
        item.Axes.Left.AxisPen.Visible = false;
        item.Axes.Left.Labels.Font.Color = Utils.HexToColor("FFFFFFFF");
        item.Axes.Left.Grid.Color = Utils.HexToColor("FFFFFFFF");
        item.Axes.Left.Ticks.Visible = false;
        item.Axes.Left.MinorTicks.Visible = false;
      }

      tChart1.Panel.Color = Utils.HexToColor("FF66CDAA");
      tChart2.Panel.Color = Utils.HexToColor("FF0066CC");
      tChart3.Panel.Color = Utils.HexToColor("FFDC143C");
      tChart4.Panel.Color = Utils.HexToColor("FFFFA500");
      tChart5.Panel.Color = Utils.HexToColor("FFFF69B4");
      tChart6.Panel.Color = Utils.HexToColor("FFBA55D3");
      tChart7.Panel.Color = Utils.HexToColor("FF66CDAA");

      Bar bar = new Bar(tChart1.Chart);
      bar.Gradient.Visible = true;
      bar.Gradient.StartColor = Utils.HexToColor("FFFFFFFF");
      bar.Gradient.EndColor = Colors.Transparent;
      bar.Pen.Visible = false;
      bar.RoundSize = 8;
      bar.BarRound = BarRounding.AtValue;
      bar.BarStyle = BarStyles.RoundRectangle;
      bar.Marks.Arrow.Visible = false;
      bar.Marks.Brush.Color = bar.Gradient.StartColor;
      bar.Marks.Pen.Visible = false;
      bar.Marks.Font.Color = tChart1.Panel.Color;
      bar.Marks.Shadow.Visible = false;
      bar.Marks.ShapeStyle = Steema.TeeChart.WPF.Drawing.TextShapeStyle.RoundRectangle;
      bar.FillSampleValues();
      Steema.TeeChart.WPF.Styles.Line line = new Steema.TeeChart.WPF.Styles.Line(tChart1.Chart);
      line.Color = Utils.HexToColor("FFFFFFFF");
      line.FillSampleValues();
      line.Smoothed = true;

      tChart1.Header.Text = "Lines and Bars";

      ActivityGauge world = new ActivityGauge(tChart2.Chart);
      Random rnd = new Random();
      tChart2.Panel.Color = Colors.White;
      tChart2.Panel.Gradient.Visible = false;
      world.BackColor = Colors.White;
      world.Add(rnd.Next(100), Utils.FromArgb(135, 206, 250));
      world.Add(rnd.Next(100), Utils.FromArgb(102, 205, 170));
      world.Add(rnd.Next(100), Utils.FromArgb(220, 20, 60));
      world.Add(rnd.Next(100), Utils.FromArgb(255, 105, 180));
      world.Add(rnd.Next(100), Utils.FromArgb(186, 85, 211));

      tChart2.Header.Text = "Gauges";
      tChart2.Header.Font.Color = Utils.FromArgb(186, 85, 211);


      CircularGauge gauge = new CircularGauge(tChart4.Chart);
      gauge.Frame.Visible = false;
      gauge.FaceBrush.Gradient.Visible = false;
      gauge.FaceBrush.Color = tChart4.Panel.Color;
      gauge.GreenLine.Pen.Visible = false;
      gauge.GreenLine.Gradient.EndColor = Utils.HexToColor("FFFDFDFD");
      gauge.GreenLine.Gradient.StartColor = Utils.HexToColor("FFC4C4C4");
      gauge.RedLine.Gradient.StartColor = Utils.HexToColor("FFC4C4C4");
      gauge.RedLine.Gradient.EndColor = Utils.HexToColor("FF848484");
      gauge.RedLine.Pen.Visible = false;
      gauge.Ticks.Gradient.Visible = false;
      gauge.Ticks.Color = Utils.HexToColor("FFFFFFFF");
      gauge.Ticks.Pen.Color = Utils.HexToColor("FFFFFFFF");
      gauge.MinorTicks.Gradient.Visible = false;
      gauge.MinorTicks.Color = Utils.HexToColor("FFFFFFFF");
      gauge.MinorTicks.Pen.Color = Utils.HexToColor("FFFFFFFF");
      gauge.Hand.Gradient.Visible = false;
      gauge.Hand.Color = Utils.HexToColor("FFFDFDFD");
      gauge.Hand.Shadow.Visible = false;
      gauge.Center.Shadow.Visible = false;
      gauge.Axis.Labels.Font.Size = 8;
      gauge.Axis.Labels.Font.Color = Utils.HexToColor("FFFFFFFF");
      gauge.Axis.AxisPen.Visible = true;
      gauge.Axis.AxisPen.Color = Utils.HexToColor("FFFFFFFF");
      gauge.FillSampleValues();
      tChart4.Header.Text = "Gauges";

      Bubble bubble = new Bubble(tChart5.Chart);
      bubble.ColorEach = false;
      bubble.Pointer.Gradient.Visible = true;
      bubble.Pointer.Pen.Visible = false;
      bubble.Pointer.Gradient.StartColor = Utils.HexToColor("FFFFFFFF");
      bubble.Pointer.Gradient.EndColor = Colors.Transparent;
      tChart5.Axes.Left.Labels.Font.Color = Colors.Transparent;
      bubble.Add(1, 1, 1);
      bubble.Add(2, 2, 10);
      bubble.Add(3, 3, 5);
      bubble.Add(4, 4, 3);
      bubble.Add(5, 5, 7);
      tChart5.Header.Text = "Bubbles and Gantt";

      Area area = new Area(tChart6.Chart);
      area.LinePen.Color = Utils.HexToColor("FFFFFFFF");
      area.Gradient.Visible = true;
      area.Gradient.StartColor = Utils.HexToColor("FFFFFFFF");
      area.Gradient.EndColor = Colors.Transparent;
      area.Smoothed = true;
      area.FillSampleValues();
      Area area1 = new Area(tChart6.Chart);
      area1.LinePen.Color = Utils.HexToColor("FFFFFFFF");
      area1.Gradient.Visible = true;
      area1.Gradient.StartColor = Utils.HexToColor("FFFFFFFF");
      area1.Gradient.EndColor = Colors.Transparent;
      area1.Smoothed = true;
      area1.FillSampleValues();
      tChart6.Axes.Left.Visible = false;
      tChart6.Axes.Bottom.Visible = true;
      tChart6.Header.Text = "Areas and Points";
      tChart6.Axes.Bottom.AxisPen.Visible = false;
      tChart6.Axes.Bottom.Labels.Font.Color = Utils.HexToColor("FFFFFFFF");
      tChart6.Axes.Bottom.Grid.Color = Utils.HexToColor("FFFFFFFF");
      tChart6.Axes.Bottom.Ticks.Visible = false;
      tChart6.Axes.Bottom.MinorTicks.Visible = false;
      tChart6.Axes.Bottom.Increment = 10;
      tChart6.Axes.Bottom.Labels.Font.Size = 10;

      Pie pie = new Pie(tChart3.Chart);
      pie.ColorEach = false;
      pie.Add(2, "Tables", Utils.HexToColor("FFFFFFFF"));
      pie.Add(1, "Chairs", Utils.HexToColor("FFF2F2F2"));
      pie.Add(1, "Sofas", Utils.HexToColor("FFDFDFDF"));
      pie.Add(1, "Cupboards", Utils.HexToColor("FFD7D7D7"));
      pie.AutoPenColor = false;
      pie.Pen.Color = tChart3.Panel.Color;
      pie.Pen.Width = 3;
      pie.Circled = true;
      pie.Marks.Brush.Visible = false;
      pie.Marks.Pen.Visible = false;
      pie.Marks.Font.Color = tChart3.Panel.Color;
      pie.Marks.Font.Size = 6;
      pie.Marks.ArrowLength = -20;
      pie.Marks.Arrow.Visible = false;
      pie.AutoCircleResize = false;
      pie.BeforeDrawValues += Pie_BeforeDrawValues;

      Donut donut = new Donut(tChart3.Chart);
      donut.ColorEach = false;
      donut.Circled = true;
      donut.Add(2, "Tables", Utils.HexToColor("FFFFFFFF"));
      donut.Add(1, "Chairs", Utils.HexToColor("FFF2F2F2"));
      donut.Add(1, "Sofas", Utils.HexToColor("FFDFDFDF"));
      donut.Add(1, "Cupboards", Utils.HexToColor("FFD7D7D7"));
      donut.MarksPie.LegSize = 10;
      donut.Marks.Brush.Visible = false;
      donut.Marks.Pen.Visible = false;
      donut.Marks.Font.Color = Utils.HexToColor("FFFFFFFF");
      donut.Marks.Font.Size = 6;
      donut.Marks.Arrow.Color = Utils.HexToColor("FFFFFFFF");
      donut.AutoPenColor = false;
      donut.Pen.Color = tChart3.Panel.Color;
      donut.Pen.Width = 3;
      donut.AutoCircleResize = false;
      donut.BeforeDrawValues += Donut_BeforeDrawValues;
      tChart3.Header.Text = "Pies and Donuts";


      Steema.TeeChart.WPF.Styles.Calendar calendar = new Steema.TeeChart.WPF.Styles.Calendar(tChart7.Chart);
      calendar.NextMonthButton.Visible = false;
      calendar.PreviousMonthButton.Visible = false;
      tChart7.Header.Text = "Calendars";
    }

    private double buffer = 30;

    private void Pie_BeforeDrawValues(object sender, Steema.TeeChart.WPF.Drawing.Graphics3D g)
    {

      double width = g.ChartXCenter * 2;
      double height = g.ChartYCenter * 2;

      Rect rect = Utils.FromLTRB(buffer, buffer, width - buffer, (height / 2) - (buffer / 2));

      tChart3.Chart.ChartRect = rect;

    }

    private void Donut_BeforeDrawValues(object sender, Steema.TeeChart.WPF.Drawing.Graphics3D g)
    {
      double donutBuffer = 20;
      double width = g.ChartXCenter * 2;
      double height = g.ChartYCenter * 2;

      Rect rect = Utils.FromLTRB(buffer + donutBuffer, (height / 2) - (buffer / 2), width - buffer - donutBuffer, height - buffer);

      tChart3.Chart.ChartRect = rect;
    }
  }
}
