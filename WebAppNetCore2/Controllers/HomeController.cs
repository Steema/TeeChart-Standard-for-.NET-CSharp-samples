﻿using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Steema.TeeChart.Themes;
using WebAppNetCore2.Models;

namespace WebAppNetCore2.Controllers
{
    public class HomeController : Controller
    {
        private static readonly object s_renderLock = new object();
        private MemoryStream _tempStream1;
        private MemoryStream _tempStream2;

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult GetChartTitle()
        {
            var myChart = new Chart();
            return Content(myChart.Header.Text);
        }

        public void GetChartImage()
        {
            lock (s_renderLock)
            {
                var wChart = new Chart();

                var xpTheme = new AndrosTheme(wChart);
                xpTheme.Apply();


                wChart.Aspect.View3D = false;

                wChart.Chart.Series.Add(new Line());
                wChart.Chart.Series[0].FillSampleValues();

                _tempStream1 = new MemoryStream();
                wChart.Chart.Export.Image.PNG.Save(_tempStream1);
                _tempStream1.Flush();
                Response.ContentType = "Image/PNG";
                Response.Body.Write(_tempStream1.ToArray(), 0, (int)_tempStream1.Length);

                _tempStream1.Close();
            }
        }

        public void GetHTML5Chart(int? type)
        {
            lock (s_renderLock)
            {
                var wChart3 = new Chart();
                var customCode = new List<string>();

                /*string[] customCode = new string[] {
                        " chart1.applyTheme(\"minimal\");" };*/

                //********* enhance view, client code ***********

                var customCodeS = new string[] {
              " ",
              " ",

              "//tooltip",
              "tip=new Tee.ToolTip(chart1);",
              "tip.render=\"dom\";",
              "tip.autoHide=true;",
              "tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:2px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
              "tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
              "tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:1; z-index:1000;\";",
              "chart1.tools.add(tip);",
              "tip.onhide=function() { scaling=0; poindex=-1; }",

              "tip.ongettext=function( tool, text, series, index) { ",
              "  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
              "	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
              "      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
              "   return s;",
              "}"
        };
                //********* end client code *********************

                customCode.AddRange(customCodeS);

                customCode.Add(wChart3.Export.Image.JScript.ChartName + ".applyTheme(\"minimal\");");

                if (type == 0)
                {
                    wChart3.Series.Add(new Pie());
                }
                else if (type == 1)
                {
                    wChart3.Series.Add(new Bar());

                    var extFunc = new List<string>
                        {
                            "var animation;",
                            "var loopCounter = 0;",

                            "function manualLoop()",
                            "{",
                            "animation.animate(" + wChart3.Export.Image.JScript.ChartName + ");",
                            "loopCounter++;",
                            "if (loopCounter < 10)",
                            "  setTimeout(manualLoop, 9000);",
                            "}"
                        };

                    wChart3.Export.Image.JScript.ExternalCode = extFunc.ToArray();

                    wChart3.Export.Image.JScript.SourceUnits.Add("teechart-animations.js");

                    customCode.Add("   //animation");
                    customCode.Add("   animation = new Tee.SeriesAnimation();");
                    customCode.Add("   animation.duration = 3900;");
                    customCode.Add("   animation.kind = \"each\";");
                    customCode.Add("   fadeAnimation = new Tee.FadeAnimation();");
                    customCode.Add("   fadeAnimation.duration = 5000;");
                    customCode.Add("   fadeAnimation.fade.series = true;");
                    customCode.Add("   fadeAnimation.fade.marks = true;");
                    customCode.Add("   animation.mode = \"linear\"; ");
                    customCode.Add("   fadeAnimation.mode = \"linear\";");
                    customCode.Add("   animation.items.push(fadeAnimation);");
                    customCode.Add("   ");
                    customCode.Add("   animation.animate(chart1);");

                    customCode.Add("  setTimeout(manualLoop, 6000); ");

                    customCode.Add(wChart3.Export.Image.JScript.ChartName + ".axes.bottom.labels.format.font.fill = \"rgba(0,0,0,0.6)\";");
                    customCode.Add(wChart3.Export.Image.JScript.ChartName + ".axes.bottom.labels.format.font.setSize(\"10px\");");
                    customCode.Add(wChart3.Export.Image.JScript.ChartName + ".series.items[0].marks.transparent = true;");
                }
                else
                {
                    var line = new Line();
                    wChart3.Series.Add(line);
                }

                if (wChart3.Series[0] is Line)
                {
                    wChart3.Series[0].FillSampleValues(100);
                }
                else
                {
                    wChart3.Series[0].FillSampleValues();
                }

                wChart3.Export.Image.JScript.CustomCode = customCode.ToArray();

                _tempStream2 = new MemoryStream();
                wChart3.Export.Image.JScript.Width = 740;
                wChart3.Export.Image.JScript.Height = 300;
                wChart3.Export.Image.JScript.Save(_tempStream2);

                _tempStream2.Position = 0;

                var output = ReadFully(_tempStream2);

                Response.ContentType = "text/html";
                Response.Body.Write(output, 0, output.Length);
            }
        }

        public static byte[] ReadFully(MemoryStream input)
        {
            var buffer = new byte[16 * 1024];
            using (var ms = new MemoryStream())
            {
                int read;
                while ((read = input.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public void GetInterpolatedChart()
        {
            lock (s_renderLock)
            {
                var wChart3 = new Chart();

                var customCode = new List<string>();
                var externalCode = new List<string>();
                var externalHTML = new List<string>();

                var externalHTMLS = new string[] {
          "<font face=\"verdana\" size=1><span id=\"xpos\"></span><br/>",
          "<span id=\"yposBar\"></span></font><br>"
        };

                var externalCodeS = new string[] {
          " ",
          " var posXLabel, posYLabel;",
          " ",
          " function interpolateLineSeries(s, xval) {",
          "  var yValues=s.data.values;",
          "  var len=yValues.length;",
          "  var xValues=[];",
          "",
          "  if (s.data.x)",
          "    xValues=s.data.x;",
          "  else {",
          "    for (i=0;i<len;i++)",
          "      xValues[i]=i;",
          "  }",
          "",
          "  var index;",
          "  for (index=0;index<len;index++) {",
          "    if (xValues[index]>xval)",
          "      break;",
          "  }",
          "",
          "  if (index<1)",
          "    index=1;",
          "  else",
          "    if (index>=len)",
          "      index=len-1;",
          "",
          "  var dx=xValues[index] - xValues[index-1];",
          "  var dy=yValues[index] - yValues[index-1];",
          "",
          "  if (dx!=0)",
          "    return dy*(xval - xValues[index-1])/dx + yValues[index-1];",
          "  else",
          "    return 0;",
          "}",

        };

                var customCodeS = new string[] {
              " ",
              " ",

              "  var ypos=document.getElementById('yposBar'); ",
              "  for (i=0;i<3;i++) {",
              "    if (i>0) {",
              "	  var br = document.createElement('br');",
              "      ypos.appendChild(br);",
              "	}",
              "	posYLabel=document.createElement('span');",
              "	posYLabel.id='ypos'+i;",
              "	ypos.appendChild(posYLabel);",
              "  }",

              "  ",
              "//tooltip",
              "tip=new Tee.ToolTip(chart1);",
              "tip.render=\"dom\";",
              "tip.domStyle = \"padding-left:8px; padding-right:8px; padding-top:2px; padding-bottom:4px; margin-left:5px; margin-top:0px; \";",
              "tip.domStyle = tip.domStyle + \"background-color:#FCFCFC; border-radius:4px 4px; color:#FFF; \";",
              "tip.domStyle = tip.domStyle + \"border-style:solid;border-color:#A3A3AF;border-width:1; z-index:1000;\";",
              "chart1.tools.add(tip);",
              "tip.onhide=function() { scaling=0; poindex=-1; }",

              "tip.ongettext=function( tool, text, series, index) { ",
              "  var s = '<font face=\"verdana\" color=\"black\" size=\"1\"><strong>'+ series.title+'</strong></font>';",
              "	    s = s + '<br/><font face=\"verdana\" color=\"darkblue\" size=\"1\">Series point: <strong>'+ index.toFixed(0)+'</strong></font>';",
              "      s =	s +'<br/><font face=\"verdana\" color=\"red\" size=\"1\">Value: '+series.data.values[index].toFixed(2)+'</font>';  ",
              "   return s;",
              "}",
              "  ",

              "  var t=new Tee.CursorTool(chart1); ",
              "  t.direction='vertical';",
              "  t.format.stroke.size=1;",
              "  t.format.stroke.fill='gray';",
              "  chart1.tools.add(t);",
              "  var xValue;",
              "  ",
              "  posXLabel=document.getElementById('xpos');  ",
              "  t.onchange=function(p) {",
              "    xValue=chart1.axes.bottom.fromPos(p.x);",
              "	   posXLabel.textContent='X Value = '+xValue.toFixed(2);",
              "	   for (var i=0; i<chart1.series.items.length; i++){",
              "	     posYLabel=document.getElementById('ypos'+i);",
              "	     posYLabel.textContent=chart1.series.items[i].title+' Y Value = '+interpolateLineSeries(chart1.series.items[i],xValue).toFixed(2);",
              "	   }",
              "",
              "	   // changeTheme(chart1, 'minimal');",
              "	   chart1.draw();",
              "  };",
              "",

              "chart1.ondraw=function() {",
              "    var xs=this.axes.bottom.calc(xValue);",
              "",
              "    for (var i=0;i<this.series.items.length;i++) {",
              "      var ys=this.axes.left.calc(interpolateLineSeries(this.series.items[i],xValue));",
              "      var f=new Tee.Format(this);",
              "      f.fill=this.series.items[i].format.fill;",
              "      f.ellipse(xs,ys,8,8);",
              "    }",
              "  }",
              "  "

        };
                //********* end client code *********************

                customCode.AddRange(customCodeS);

                customCode.Add(" chart1.applyTheme(\"minimal\");");

                var line1 = new Line();
                var line2 = new Line();
                var p3 = new Points();

                line1.Pointer.Visible = true;
                line2.Pointer.Visible = true;

                p3.Pointer.Style = PointerStyles.Circle;

                wChart3.Series.Add(line1);
                wChart3.Series.Add(line2);
                wChart3.Series.Add(p3);

                wChart3.Legend.Visible = false;

                for (var i = 0; i < 3; i++)
                {
                    wChart3.Series[i].FillSampleValues(50);
                }

                wChart3.Export.Image.JScript.CustomCode = customCode.ToArray();
                wChart3.Export.Image.JScript.ExternalCode = externalCodeS.ToArray();
                wChart3.Export.Image.JScript.BodyHTML = externalHTMLS.ToArray();

                _tempStream2 = new MemoryStream();
                wChart3.Export.Image.JScript.Width = 950;
                wChart3.Export.Image.JScript.Height = 300;
                wChart3.Export.Image.JScript.Save(_tempStream2);

                _tempStream2.Position = 0;

                var output = ReadFully(_tempStream2);

                Response.ContentType = "text/html";
                Response.Body.Write(output, 0, output.Length);
            }
        }

        public void GetPieChartx()
        {
            var wChart2 = new Chart();

            wChart2.Series.Add(new Pie());
            wChart2.Series[0].FillSampleValues();

            _tempStream2 = new MemoryStream();
            wChart2.Export.Image.PNG.Save(_tempStream2);
            _tempStream2.Flush();

            Response.ContentType = "Image/png";
            Response.Body.Write(_tempStream2.ToArray(), 0, (int)_tempStream2.Length);

            _tempStream2.Close();
        }

        public ActionResult GetScatterChart(int? w, int? h)
        {
            lock (s_renderLock)
            {
                var width = (w > 0) ? (int)w : 400;
                var height = (h > 0) ? (int)h : 300;

                var wChart2 = new Chart();

                wChart2.Series.Add(new Points());
                wChart2.Series[0].FillSampleValues();

                wChart2.Draw();

                wChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
                wChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

                _tempStream2 = new MemoryStream();
                wChart2.Export.Image.PNG.Width = width;
                wChart2.Export.Image.PNG.Height = height;

                wChart2.Export.Image.PNG.Save(_tempStream2);

                _tempStream2.Position = 0;

                return base.File(_tempStream2, "image/png");
            }
        }

        public ActionResult GetGanttGauge(int? w, int? h)
        {
            lock (s_renderLock)
            {
                var width = (w > 0) ? (int)w : 400;
                var height = (h > 0) ? (int)h : 300;

                var wChart2 = new Chart();

                //Steema.TeeChart.Utils.UseCaches = false;
                wChart2.Header.Text = "Circular Gauge";

                wChart2.Aspect.View3D = false;
                wChart2.Series.Add(new Gantt());
                wChart2.Series[0].FillSampleValues(30);

                wChart2.Draw();

                wChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
                wChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

                _tempStream2 = new MemoryStream();
                wChart2.Export.Image.PNG.Width = width;
                wChart2.Export.Image.PNG.Height = height;

                wChart2.Export.Image.PNG.Save(_tempStream2);

                _tempStream2.Position = 0;

                return base.File(_tempStream2, "image/png");
            }
        }

        public ActionResult GetEqualizerChart(int? w, int? h)
        {
            lock (s_renderLock)
            {
                var width = (w > 0) ? (int)w : 400;
                var height = (h > 0) ? (int)h : 300;

                var wChart2 = new Chart();

                Utils.UseCaches = false;
                wChart2.Header.Text = "Equalizer Gauge";

                var rpTheme = new BlackIsBackTheme(wChart2);
                rpTheme.Apply();

                wChart2.Aspect.View3D = false;
                wChart2.Series.Add(new Equalizer());
                wChart2.Series[0].FillSampleValues(40);

                wChart2.Panel.Bevel.Inner = Steema.TeeChart.Drawing.BevelStyles.None;
                wChart2.Panel.Bevel.Outer = Steema.TeeChart.Drawing.BevelStyles.None;

                _tempStream2 = new MemoryStream();
                wChart2.Export.Image.PNG.Width = width;
                wChart2.Export.Image.PNG.Height = height;

                wChart2.Export.Image.PNG.Save(_tempStream2);

                _tempStream2.Position = 0;

                return base.File(_tempStream2, "image/png");
            }
        }
    }
}
