using Steema.TeeChart.Store;
using Steema.TeeChart.Store.Styles;
using Steema.TeeChart.Store.Themes;
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
  public sealed partial class ProjectPlannerSubPage : Windows.UI.Xaml.Controls.Page
  {
    public ProjectPlannerSubPage()
    {
      this.InitializeComponent();
      InitializeChart();
    }

    Gantt gantt1 = new Gantt();

    private void InitializeChart()
    {
      this.tChart1.Aspect.GestureOptions = Steema.TeeChart.Store.Drawing.Aspect.Gestures.None;
      this.tChart1.Series.Add(gantt1);
      this.tChart1.Aspect.View3D = false;
      this.tChart1.Axes.Bottom.Increment = 30D;
      this.tChart1.Axes.Bottom.Labels.Font.Brush.Color = Colors.Gray;
      this.tChart1.Axes.Bottom.Labels.Font.Size = 16;
      this.tChart1.Axes.Bottom.Title.Caption = "Time";
      this.tChart1.Axes.Bottom.Title.Font.Brush.Color = Colors.Gray;
      this.tChart1.Axes.Bottom.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Bottom.Title.Lines = new string[] {
        "Time"};
      this.tChart1.Axes.Left.AxisPen.Visible = false;
      this.tChart1.Axes.Left.Labels.Font.Brush.Color = Colors.Gray;
      this.tChart1.Axes.Left.Labels.Font.Size = 13;
      this.tChart1.Axes.Left.MinorTicks.Visible = false;
      this.tChart1.Axes.Left.Title.Caption = "Task";
      this.tChart1.Axes.Left.Title.Font.Brush.Color = Colors.Gray;
      this.tChart1.Axes.Left.Title.Font.Name = "Segoe UI";
      this.tChart1.Axes.Left.Title.Lines = new string[] {
        "Task"};
      this.tChart1.Footer.Font.Brush.Color = Colors.Blue;
      this.tChart1.Header.Font.Brush.Color = Colors.Gray;
      this.tChart1.Header.Font.Size = 21;
      this.tChart1.Header.Lines = new string[] {
        "Project Planner"};
      this.tChart1.Legend.Visible = false;
      this.tChart1.Name = "tChart1";
      this.tChart1.Panel.Brush.Color = Colors.White;
      this.tChart1.Panel.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Series.Add(this.gantt1);
      this.tChart1.TabIndex = 0;
      this.tChart1.Walls.Back.Brush.Gradient.EndColor = Colors.White;
      this.tChart1.Walls.Back.Visible = false;
      this.gantt1.Color = Color.FromArgb(255, ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.gantt1.ColorEach = true;
      this.gantt1.EndValues.DataMember = "End";
      this.gantt1.EndValues.DateTime = true;
      this.gantt1.LabelMember = "Labels";
      this.gantt1.LinePen.Color = Color.FromArgb(255, ((int)(((byte)(41)))), ((int)(((byte)(61)))), ((int)(((byte)(98)))));
      this.gantt1.Marks.Brush.Visible = false;
      this.gantt1.Marks.Transparent = true;
      this.gantt1.Marks.Visible = true;
      this.gantt1.OriginalCursor = null;
      this.gantt1.Pointer.Brush.ForegroundColor = Utils.EmptyColor;
      this.gantt1.Pointer.Brush.Gradient.StartColor = Color.FromArgb(255, ((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163)))));
      this.gantt1.Pointer.Pen.Visible = false;
      this.gantt1.Pointer.SizeDouble = 0D;
      this.gantt1.Pointer.SizeUnits = PointerSizeUnits.Pixels;
      this.gantt1.StartValues.DataMember = "Start";
      this.gantt1.StartValues.DateTime = true;
      this.gantt1.StartValues.Order = ValueListOrder.Ascending;
      this.gantt1.Title = "gantt1";
      this.gantt1.YValues.DataMember = "Y";

      tChart1.Panel.Gradient.Visible = false;

      gantt1.Add(new DateTime(2014, 6, 7), new DateTime(2014, 9, 23), 0, "Production");
      gantt1.Add(new DateTime(2014, 9, 3), new DateTime(2014, 11, 10), 1, "Marketing");
      gantt1.Add(new DateTime(2014, 3, 13), new DateTime(2014, 3, 31), 2, "Approve");
      gantt1.Add(new DateTime(2014, 5, 7), new DateTime(2014, 6, 5), 3, "Prototype");
      gantt1.Add(new DateTime(2014, 10, 11), new DateTime(2014, 11, 5), 4, "Evaluation");
      gantt1.Add(new DateTime(2014, 4, 2), new DateTime(2014, 4, 29), 5, "Design");

      gantt1.AddMultipleNextTasks(2, 4);
      gantt1.AddMultipleNextTasks(2, 3);

      gantt1.ConnectingPen.Color = Color.FromArgb(255, 49, 44, 59);
      gantt1.ConnectingPen.Width = 2;

      gantt1.Pointer.Style = PointerStyles.Rectangle;
      gantt1.Pointer.VertSize = 25;
      gantt1.GetSeriesMark += Gantt1_GetSeriesMark;

      ColorPalettes.ApplyPalette(tChart1.Chart, 21);
    }

    private void Gantt1_GetSeriesMark(Series series, GetSeriesMarkEventArgs e)
    {
      // Add custom data to display at each gantt bar, for example: "Completion %"
      switch (e.ValueIndex)
      {
        case 0:
          e.MarkText = "20 %";
          break;
        case 1:
          e.MarkText = "40 %";
          break;
        case 2:
          e.MarkText = "10 %";
          break;
        case 3:
          e.MarkText = "75 %";
          break;
        case 4:
          e.MarkText = "55 %";
          break;
        case 5:
          e.MarkText = "60 %";
          break;
        case 6:
          e.MarkText = "25 %";
          break;
      }
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
