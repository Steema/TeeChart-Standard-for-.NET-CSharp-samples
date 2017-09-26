using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Platform.UWP;
using Steema.TeeChart;
using StandardSeriesXFormsSTD;

[assembly: ExportRenderer(typeof(ChartView), typeof(StandardSeriesXFormsSTD.UWP.ChartViewRenderer))]
namespace StandardSeriesXFormsSTD.UWP
{
  public class ChartViewRenderer : ViewRenderer<ChartView, Steema.TeeChart.TChart>
  {      
    protected override void OnElementChanged(ElementChangedEventArgs<ChartView> e)
    {
      base.OnElementChanged(e);
      if (e.OldElement != null || this.Element == null)
        return;

      var chartView = new Steema.TeeChart.TChart();

      chartView.Chart = Element.Model;

      SetNativeControl(chartView);
    }

    protected override void OnElementPropertyChanged(object sender, PropertyChangedEventArgs e)
    {
      base.OnElementPropertyChanged(sender, e);
    }
  }
}
