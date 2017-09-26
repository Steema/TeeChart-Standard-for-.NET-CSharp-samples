using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using Steema.TeeChart;

using Xamarin.Forms;

namespace StandardSeriesXFormsSTD.DashBoards
{
    public class Page2 : ContentPage
    {
        Chart dashBoard1;
        public ChartView DashView1;
        public Page2()
        {
            // NavigationPage.SetHasNavigationBar(this, false);            

            dashBoard1 = new Chart();
            dashBoard1.Aspect.View3D = false;

            Steema.TeeChart.Styles.NumericGauge numericGauge = new Steema.TeeChart.Styles.NumericGauge();
            dashBoard1.Series.Add(numericGauge);
            numericGauge.FillSampleValues();

            dashBoard1.Panel.Color = numericGauge.FaceBrush.Color;
            dashBoard1.Panel.Gradient.Visible = false;
            dashBoard1.Walls.Visible = false;
            dashBoard1.Title.Text = "Numeric Gauge";
            dashBoard1.Title.Alignment = TextAlignment.Start;
            dashBoard1.Title.Font.Size = 12;
            dashBoard1.Title.Font.Color = Color.White;
            dashBoard1.Axes.Visible = false;
            dashBoard1.Legend.Visible = false;

            DashView1 = new ChartView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand,
            };
            DashView1.Model = dashBoard1;

            Content = new StackLayout
            {
                Children = {
					DashView1
				}
            };
        }
    }
}
