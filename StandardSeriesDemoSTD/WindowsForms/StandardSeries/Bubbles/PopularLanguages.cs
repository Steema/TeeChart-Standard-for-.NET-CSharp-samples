using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace StandardSeriesDemo.StandardSeries.Bubbles
{
  public partial class PopularLanguages : Form
  {
    public PopularLanguages()
    {
      InitializeComponent();
    }

    private void PopularLanguages_Load(object sender, EventArgs e)
    {
      tChart1.Panel.Gradient.Visible = false;

      Steema.TeeChart.Styles.Bubble bCloud = new Steema.TeeChart.Styles.Bubble(tChart1.Chart);

      //bCloud.UseColorRange = false;
      //bCloud.UsePalette = true;

      //bCloud.Rotation = 5;
      //bCloud.Separation = 51;
      //bCloud.SizeRatio = 1.44;

      tChart1.Axes.Bottom.MinimumOffset = 150;
      tChart1.Axes.Bottom.MaximumOffset = 50;

      bCloud.Add(1, 1175, 30.3, "Python");
      bCloud.Add(2, 1082.5, 22.2, "Java");
      bCloud.Add(3, 1077.5, 13, "C++");
      bCloud.Add(4, 1055, 10.6, "Ruby");
      bCloud.Add(5, 1042.5, 5.2, "JavaScript");
      bCloud.Add(6, 1035, 5, "C#");
      bCloud.Add(7, 1035, 4.1, "C");
      bCloud.Add(8, 1017.5, 3.3, "PHP");
      bCloud.Add(9, 1005, 1.6, "Perl");
      bCloud.Add(10, 975, 1.5, "Go");


      bCloud.Marks.Font.Color = Color.Black;

    }

    private void tChart1_GetLegendText(object sender, Steema.TeeChart.GetLegendTextEventArgs e)
    {
      switch (e.Index)
      {
        case 0:
          e.Text = e.Text + " 30,3 %";
          break;
        case 1:
          e.Text = e.Text + " 22,2 %";
          break;
        case 2:
          e.Text = e.Text + " 13 %";
          break;
        case 3:
          e.Text = e.Text + " 10,6 %";
          break;
        case 4:
          e.Text = e.Text + " 5,2 %";
          break;
        case 5:
          e.Text = e.Text + " 5 %";
          break;
        case 6:
          e.Text = e.Text + " 4,1 %";
          break;
        case 7:
          e.Text = e.Text + " 3,3 %";
          break;
        case 8:
          e.Text = e.Text + " 1,6 %";
          break;
        case 9:
          e.Text = e.Text + " 1,5 %";
          break;

      }
    }

    private void tChart1_DoubleClick(object sender, EventArgs e)
    {
      tChart1.Zoom.Active = false;
      tChart1.ShowEditor();
      tChart1.Chart.CancelMouse = true;
      tChart1.Zoom.Active = true;
    }
  }
}
