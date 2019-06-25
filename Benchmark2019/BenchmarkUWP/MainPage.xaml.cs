using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Benchmark2019;
using Steema.TeeChart.Store;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace BenchmarkUWP
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
    {
        Benchmark _benchmark;
        DispatcherTimer _timer = new DispatcherTimer();
        public MainPage()
        {
            Utils.CalcFramesPerSecond = true;
            _timer.Tick += _timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 100);

            this.InitializeComponent();

            _benchmark = new Benchmark(tChart1);
        }

        private void _timer_Tick(object sender, object e)
        {
            _benchmark.Fill();
        }

        private void BRun_Click(object sender, RoutedEventArgs e)
        {
            if (BRun.Content as string == _benchmark.Labels[0])
            {
                BRun.Content = _benchmark.Labels[1];
                _timer.Start();
            }
            else
            {
                BRun.Content = _benchmark.Labels[0];
                _timer.Stop();
            }
        }
    }
}
