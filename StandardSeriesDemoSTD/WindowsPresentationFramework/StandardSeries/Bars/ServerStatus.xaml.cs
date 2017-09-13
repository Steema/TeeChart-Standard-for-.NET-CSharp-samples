using Steema.TeeChart.WPF;
using Steema.TeeChart.WPF.Drawing;
using Steema.TeeChart.WPF.Styles;
using Steema.TeeChart.WPF.Themes;
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
  /// Interaction logic for ServerStatus.xaml
  /// </summary>
  public partial class ServerStatus : UserControl
  {
    public ServerStatus()
    {
      InitializeComponent();

      InitializeChart();
    }

    HorizBar horizBar1 = new HorizBar();
    HorizBar horizBar2 = new HorizBar();
    HorizBar horizBar3 = new HorizBar();
    HorizBar horizBar4 = new HorizBar();
    HorizBar horizBar5 = new HorizBar();
    Steema.TeeChart.WPF.Styles.Calendar calendar1 = new Steema.TeeChart.WPF.Styles.Calendar();

    private void InitializeChart()
    {
      calendar1.NextMonthButton.Visible = false;
      calendar1.PreviousMonthButton.Visible = false;

      this.tChart1.Aspect.ColorPaletteIndex = 21;
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Visible = false;
      this.tChart1.Header.AdjustFrame = false;
      this.tChart1.Header.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Name = "Segoe UI";
      this.tChart1.Header.Font.Size = 18;
      this.tChart1.Header.Lines = new string[] {
        "Server Status"};
      this.tChart1.Header.Pen.Color = Color.FromArgb(255, ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.tChart1.Header.Transparent = false;
      this.tChart1.Legend.Visible = false;
      this.tChart1.Panel.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart1.Panel.Brush.Gradient.Visible = false;
      this.tChart1.Series.Add(this.horizBar1);
      this.tChart1.Series.Add(this.horizBar2);
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Visible = false;
      this.tChart1.AfterDraw += TChart1_AfterDraw;
      this.horizBar1.BarRound = BarRounding.AtValue;
      this.horizBar1.BarStyle = BarStyles.RoundRectangle;
      this.horizBar1.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.horizBar1.Brush.Gradient.Direction = Steema.TeeChart.WPF.Drawing.GradientDirection.BottomTop;
      this.horizBar1.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.horizBar1.ColorEach = false;
      this.horizBar1.Marks.Visible = false;
      this.horizBar1.MultiBar = MultiBars.None;
      this.horizBar1.OriginalCursor = null;
      this.horizBar1.Pen.Color = Color.FromArgb(255, ((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
      this.horizBar1.Title = "horizBar1";
      this.horizBar1.XValues.DataMember = "X";
      this.horizBar1.YValues.DataMember = "Bar";
      this.horizBar1.YValues.Order = ValueListOrder.Ascending;
      this.horizBar2.BarRound = BarRounding.AtValue;
      this.horizBar2.BarStyle = BarStyles.RoundRectangle;
      this.horizBar2.Brush.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.horizBar2.Brush.Gradient.Direction = Steema.TeeChart.WPF.Drawing.GradientDirection.BottomTop;
      this.horizBar2.Color = Color.FromArgb(255, ((int)(((byte)(243)))), ((int)(((byte)(156)))), ((int)(((byte)(53)))));
      this.horizBar2.ColorEach = true;
      this.horizBar2.Marks.Arrow.Visible = false;
      this.horizBar2.Marks.ArrowLength = -34;
      this.horizBar2.Marks.Brush.Visible = false;
      this.horizBar2.Marks.Font.Bold = true;
      this.horizBar2.Marks.Font.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.horizBar2.Marks.Style = MarksStyles.Percent;
      this.horizBar2.Marks.Transparent = true;
      this.horizBar2.MultiBar = MultiBars.None;
      this.horizBar2.OriginalCursor = null;
      this.horizBar2.Pen.Color = Color.FromArgb(255, ((int)(((byte)(146)))), ((int)(((byte)(94)))), ((int)(((byte)(32)))));
      this.horizBar2.Title = "horizBar2";
      this.horizBar2.YValues.Order = ValueListOrder.Ascending;
      this.tChart2.Aspect.ColorPaletteIndex = 21;
      this.tChart2.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart2.Header.Visible = false;
      this.tChart2.Legend.Visible = false;
      this.tChart2.Name = "tChart2";
      this.tChart2.Panel.Bevel.Outer = BevelStyles.None;
      this.tChart2.Panel.Brush.Color = Colors.White;
      this.tChart2.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart2.Series.Add(this.calendar1);
      this.tChart2.TabIndex = 1;
      this.tChart2.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.calendar1.Color = Utils.EmptyColor;
      this.calendar1.ColorEach = false;
      this.calendar1.ColorMember = "Colors";
      this.calendar1.Date = new System.DateTime(2015, 3, 9, 0, 0, 0, 0);
      this.calendar1.DayOneColumn = 7;
      this.calendar1.DayOneRow = 3;
      this.calendar1.Legend.Visible = false;
      this.calendar1.Marks.Brush.Color = Colors.Gold;
      this.calendar1.OriginalCursor = null;
      this.calendar1.Pen.Visible = false;
      this.calendar1.Title = "calendar1";
      this.calendar1.XValues.DataMember = "X";
      this.calendar1.XValues.Order = ValueListOrder.Ascending;
      this.calendar1.YValues.DataMember = "Y";
      this.calendar1.Change += Calendar1_Change;
      this.tChart3.Aspect.ColorPaletteIndex = 21;
      this.tChart3.Aspect.View3D = false;
      this.tChart3.Axes.Bottom.AxisPen.Width = 1;
      this.tChart3.Axes.Bottom.Labels.Font.Brush.Color = Colors.Gray;
      this.tChart3.Axes.Bottom.Labels.Font.Name = "Segoe UI";
      this.tChart3.Axes.Left.AxisPen.Visible = false;
      this.tChart3.Axes.Left.Grid.Visible = false;
      this.tChart3.Axes.Left.Labels.Font.Brush.Color = Colors.Gray;
      this.tChart3.Axes.Left.Labels.Font.Name = "Segoe UI";
      this.tChart3.Axes.Left.MinorTicks.Visible = false;
      this.tChart3.Axes.Left.Ticks.Color = Color.FromArgb(255, ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
      this.tChart3.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart3.Header.Alignment = TextAlignment.Left;
      this.tChart3.Header.Font.Brush.Color = Colors.Gray;
      this.tChart3.Header.Font.Size = 16;
      this.tChart3.Header.Lines = new string[] {
        "Active Servers"};
      this.tChart3.Legend.Alignment = LegendAlignments.Bottom;
      this.tChart3.Legend.Transparent = true;
      this.tChart3.Name = "tChart3";
      this.tChart3.Panel.Bevel.Outer = BevelStyles.None;
      this.tChart3.Panel.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.tChart3.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart3.Panel.Brush.Gradient.Visible = false;
      this.tChart3.Panel.MarginBottom = 1D;
      this.tChart3.Panel.MarginLeft = 2D;
      this.tChart3.Panel.MarginRight = 2D;
      this.tChart3.Panel.MarginTop = 2D;
      this.tChart3.Series.Add(this.horizBar3);
      this.tChart3.Series.Add(this.horizBar4);
      this.tChart3.Series.Add(this.horizBar5);
      this.tChart3.TabIndex = 0;
      this.tChart3.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart3.Walls.Back.Visible = false;
      this.horizBar3.BarRound = BarRounding.AtValue;
      this.horizBar3.RoundSize = 2;
      this.horizBar3.BarStyle = BarStyles.RoundRectangle;
      this.horizBar3.Brush.Color = Color.FromArgb(255, ((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.horizBar3.Brush.Gradient.Direction = Steema.TeeChart.WPF.Drawing.GradientDirection.BottomTop;
      this.horizBar3.Color = Color.FromArgb(255, ((int)(((byte)(220)))), ((int)(((byte)(92)))), ((int)(((byte)(5)))));
      this.horizBar3.ColorEach = false;
      this.horizBar3.Marks.Visible = false;
      this.horizBar3.OriginalCursor = null;
      this.horizBar3.Pen.Color = Color.FromArgb(255, ((int)(((byte)(132)))), ((int)(((byte)(55)))), ((int)(((byte)(3)))));
      this.horizBar3.Title = "Server 1";
      this.horizBar3.XValues.DataMember = "X";
      this.horizBar3.YValues.DataMember = "Bar";
      this.horizBar3.YValues.Order = ValueListOrder.Ascending;
      this.horizBar4.BarRound = BarRounding.AtValue;
      this.horizBar4.BarStyle = BarStyles.RoundRectangle;
      this.horizBar4.RoundSize = 2;
      this.horizBar4.Brush.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.horizBar4.Brush.Gradient.Direction = Steema.TeeChart.WPF.Drawing.GradientDirection.BottomTop;
      this.horizBar4.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
      this.horizBar4.ColorEach = false;
      this.horizBar4.Marks.Visible = false;
      this.horizBar4.OriginalCursor = null;
      this.horizBar4.Pen.Color = Color.FromArgb(255, ((int)(((byte)(153)))), ((int)(((byte)(103)))), ((int)(((byte)(0)))));
      this.horizBar4.Title = "Server 2";
      this.horizBar4.XValues.DataMember = "X";
      this.horizBar4.YValues.DataMember = "Bar";
      this.horizBar4.YValues.Order = ValueListOrder.Ascending;
      this.horizBar5.BarRound = BarRounding.AtValue;
      this.horizBar5.BarStyle = BarStyles.RoundRectangle;
      this.horizBar5.RoundSize = 2;
      this.horizBar5.Brush.Color = Color.FromArgb(255, ((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
      this.horizBar5.Brush.Gradient.Direction = Steema.TeeChart.WPF.Drawing.GradientDirection.BottomTop;
      this.horizBar5.Color = Color.FromArgb(255, ((int)(((byte)(110)))), ((int)(((byte)(197)))), ((int)(((byte)(184)))));
      this.horizBar5.ColorEach = false;
      this.horizBar5.Marks.Visible = false;
      this.horizBar5.OriginalCursor = null;
      this.horizBar5.Pen.Color = Color.FromArgb(255, ((int)(((byte)(66)))), ((int)(((byte)(118)))), ((int)(((byte)(110)))));
      this.horizBar5.Title = "Server 3";
      this.horizBar5.XValues.DataMember = "X";
      this.horizBar5.YValues.Order = ValueListOrder.Ascending;


      tChart1.Panel.Gradient.Visible = false;
      tChart2.Panel.Gradient.Visible = false;
      tChart3.Panel.Gradient.Visible = false;

      double[] h1Vals = new double[] { 100, 100, 100, 100, 100 };
      horizBar1.Add(h1Vals);
      double[] h2Vals = new double[] { 60, 85, 40, 55, 50 };
      horizBar2.Add(h2Vals);

      horizBar3.FillSampleValues(3);
      horizBar4.FillSampleValues(3);
      horizBar5.FillSampleValues(3);
      horizBar3.Labels[0] = "Speed";
      horizBar3.Labels[1] = "Time";
      horizBar3.Labels[2] = "Visitors";

      calendar1.FillSampleValues();
      calendar1.Date = DateTime.Now;
      calendar1.Today.Color = LookoutTheme.SeawashPalette[9];
      calendar1.Sunday.Color = LookoutTheme.SeawashPalette[10];
      calendar1.Sunday.Font.Color = Colors.Black;
    }

    Random rnd1 = new Random();

    private void Calendar1_Change(Steema.TeeChart.WPF.Styles.Calendar sender, Steema.TeeChart.WPF.Styles.Calendar.CalendarChangeEventArgs e)
    {
      Random rnd1 = new Random();
      // Random values for tChart1
      horizBar2.ValuesLists[0].Value[0] = rnd1.Next(100);
      horizBar2.ValuesLists[0].Value[1] = rnd1.Next(100);
      horizBar2.ValuesLists[0].Value[2] = rnd1.Next(100);
      horizBar2.ValuesLists[0].Value[3] = rnd1.Next(100);
      horizBar2.ValuesLists[0].Value[4] = rnd1.Next(100);

      // Random values for tChart3
      horizBar3.ValuesLists[0].Value[0] = rnd1.Next(1000);
      horizBar4.ValuesLists[0].Value[0] = rnd1.Next(1000);
      horizBar5.ValuesLists[0].Value[0] = rnd1.Next(1000);
      horizBar3.ValuesLists[0].Value[1] = rnd1.Next(1000);
      horizBar4.ValuesLists[0].Value[1] = rnd1.Next(1000);
      horizBar5.ValuesLists[0].Value[1] = rnd1.Next(1000);
      horizBar3.ValuesLists[0].Value[2] = rnd1.Next(1000);
      horizBar4.ValuesLists[0].Value[2] = rnd1.Next(1000);
      horizBar5.ValuesLists[0].Value[2] = rnd1.Next(1000);

      horizBar3.ValuesLists[0].Modified = true;
      horizBar4.ValuesLists[0].Modified = true;
      horizBar5.ValuesLists[0].Modified = true;

      tChart1.Invalidate();
      tChart3.Invalidate();
    }

    private void TChart1_AfterDraw(object sender, Steema.TeeChart.WPF.Drawing.Graphics3D g)
    {
      g.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(5) - 16, "Memory Usage");
      g.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(4) - 16, "CPU usage");
      g.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(3) - 16, "Storage space");
      g.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(2) - 16, "Apps installed");
      g.TextOut(tChart1.Axes.Bottom.CalcPosValue(0), horizBar1.CalcYPos(1) - 16, "Bandwidth");
    }

  }
}
