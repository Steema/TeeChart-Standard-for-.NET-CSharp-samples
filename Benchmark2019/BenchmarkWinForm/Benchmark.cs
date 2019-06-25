using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#if WPF
using Steema.TeeChart.WPF;
using Steema.TeeChart.WPF.Styles;
#elif WINDOWS_UWP
using Steema.TeeChart.Store;
using Steema.TeeChart.Store.Styles;
#else
using Steema.TeeChart;
using Steema.TeeChart.Styles;
#endif

namespace Benchmark2019
{
    public class Benchmark
    {
        TChart _tChart;

        public Benchmark(TChart tchart)
        {
            _tChart = tchart;

            for (int i = 0; i < 10; i++)
            {
                _tChart.Series.Add(typeof(Line));
            }
        }

        public string[] Labels { get; set; } = new string[] { "Run", "Stop" };

        Random _rnd = new Random();

        public void Fill()
        {
            var index = 0;

            for (var i = 0; i < _tChart.Series.Count; i++)
            {
                index = _tChart[i].Add(_rnd.Next(1000));
            }

            if (index >= 200)
            {
                for (var i = 0; i < _tChart.Series.Count; i++)
                {
                    _tChart[i].Delete(0, 100, true);
                }

                index = 100;
            }

            _tChart.Axes.Bottom.SetMinMax(index - 100, index);
            _tChart.Header.Text = "FPS: " + Utils.FramesPerSecond.ToString();
        }
    }
}
