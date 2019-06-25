using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;
using Benchmark2019;
using Steema.TeeChart.WPF;

namespace BenchmarkWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Benchmark _benchmark;
        DispatcherTimer _timer = new DispatcherTimer();
        public MainWindow()
        {
            Utils.CalcFramesPerSecond = true;
            _timer.Tick += _timer_Tick;
            _timer.Interval = new TimeSpan(0, 0, 0, 0, 100);

            InitializeComponent();

            _benchmark = new Benchmark(tChart1);
        }

        private void _timer_Tick(object sender, EventArgs e)
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
