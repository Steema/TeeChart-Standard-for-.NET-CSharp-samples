using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Lines
{
    public partial class WebAnalytics : Form
    {
        public WebAnalytics()
        {
            InitializeComponent();
        }

        private void WebAnalytics_Load(object sender, EventArgs e)
        {
          tChart1.Panel.Gradient.Visible = false;
          tChart2.Panel.Gradient.Visible = false;
          tChart3.Panel.Gradient.Visible = false;
          tChart4.Panel.Gradient.Visible = false;

          donut1.Clear();
          donut1.Add(750, Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(102)))), ((int)(((byte)(163))))));
          donut1.Add(250, Color.Transparent);

          donut2.Clear();
          donut2.Add(3390, Color.Green);
          donut2.Add(2510, Color.Transparent);

          donut3.Clear();
          donut3.Add(1500, Color.Red);
          donut3.Add(500, Color.Transparent);

          double[] vals1 = new double[] { 220, 150, 135, 190, 210, 200 };
          double[] vals2 = new double[] { 100, 70, 100, 150, 110, 24 };
          double[] vals3 = new double[] { 100, 130, 80, 130, 126, 240 };

          line1.Smoothed = true;
          line2.Smoothed = true;
          line3.Smoothed = true;
          line1.Add(vals1);
          line2.Add(vals2);
          line3.Add(vals3);
        }

        private double xVal;

        private double InterpolateLineSeries(Steema.TeeChart.Styles.Custom series, double xvalue)
        {
          return InterpolateLineSeries(series, series.FirstVisibleIndex, series.LastVisibleIndex, xvalue);
        }

        /// <summary>
        /// Calculate y=y(x) for arbitrary x. Works fine only for line series with ordered x values.
        /// </summary>
        /// <param name="series"></param>
        /// <param name="firstindex"></param>
        /// <param name="lastindex"></param>
        /// <param name="xvalue"></param>
        /// <returns>y=y(xvalue) where xvalue is arbitrary x value.</returns>
        private double InterpolateLineSeries(Steema.TeeChart.Styles.Custom series, int firstindex, int lastindex, double xvalue)
        {
          int index;
          for (index = firstindex; index <= lastindex; index++)
          {
            if (index == -1 || series.XValues.Value[index] > xvalue) break;
          }
          // safeguard
          if (index < 1) index = 1;
          else if (index >= series.Count) index = series.Count - 1;
          // y=(y2-y1)/(x2-x1)*(x-x1)+y1
          double dx = series.XValues[index] - series.XValues[index - 1];
          double dy = series.YValues[index] - series.YValues[index - 1];
          if (dx != 0.0) return dy * (xvalue - series.XValues[index - 1]) / dx + series.YValues[index - 1];
          else return 0.0;
        }

        private void chartdoubleclick(object sender, EventArgs e)
        {
          (sender as Steema.TeeChart.TChart).Zoom.Active = false;
          (sender as Steema.TeeChart.TChart).ShowEditor();
          (sender as Steema.TeeChart.TChart).Chart.CancelMouse = true;
          (sender as Steema.TeeChart.TChart).Zoom.Active = true;
        }

        int posRepainted = 0;
        private void tChart4_AfterDraw(object sender, Steema.TeeChart.Drawing.Graphics3D g)
        {
          if (posRepainted == 0)
          {
            posRepainted = 1;
            tChart4.Refresh();
            
          }
          //setup centre positions of titles on chart
          //relative to their text lengths
          tChart1.Refresh();
          tChart2.Refresh();
          tChart3.Refresh(); 
          posRepainted = 2;

          {
            int xs = tChart4.Axes.Bottom.CalcXPosValue(xVal);
            int ys;
            g.Brush.Visible = true;
            g.Brush.Solid = true;
            for (int i = 0; i < tChart4.Series.Count; i++)
              if (tChart4.Series[i] is Steema.TeeChart.Styles.Custom)
              {
                ys = tChart4.Series[i].GetVertAxis.CalcYPosValue(InterpolateLineSeries(tChart4.Series[i] as Steema.TeeChart.Styles.Custom, xVal));
                g.Brush.Color = tChart4.Series[i].Color;
                g.Ellipse(new Rectangle(xs - 4, ys - 4, 8, 8));
              }
          }
        }
    }
}
