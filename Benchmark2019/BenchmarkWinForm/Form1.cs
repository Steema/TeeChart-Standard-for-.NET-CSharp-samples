using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Steema.TeeChart;
using Steema.TeeChart.Styles;
using Benchmark2019;

namespace BenchmarkWinForm
{
    public partial class Form1 : Form
    {
        Benchmark _benchmark;
        public Form1()
        {
            Utils.CalcFramesPerSecond = true;
            InitializeComponent();

            _benchmark = new Benchmark(tChart1);
        }

        private void BRun_Click(object sender, EventArgs e)
        {
            if(bRun.Text == _benchmark.Labels[0])
            {
                bRun.Text = _benchmark.Labels[1];
                timer1.Start();
            }
            else
            {
                bRun.Text = _benchmark.Labels[0];
                timer1.Stop();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            _benchmark.Fill();
        }
    }
}
