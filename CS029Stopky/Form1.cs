using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CS029Stopky
{
    public partial class CS029Stopky : Form
    {
        public CS029Stopky()
        {
            InitializeComponent();
        }

        private DateTime stopkyCas;
        private DateTime stopkyCelkem;


        private void startStopButton_Click(object sender, EventArgs e)
        {
            if(stopkyTimer.Enabled)
            {
                startStopButton.Text = "Start";
                stopkyTimer.Stop();
            }
            else
            {
                startStopButton.Text = "Stop";
                stopkyTimer.Start();
                stopkyCas = DateTime.UtcNow;
                if (stopkyCelkem == null) stopkyCelkem = new DateTime(0);
            }
        }

        private void stopkyTimer_Tick(object sender, EventArgs e)
        {
            stopkyCelkem = stopkyCelkem.Add(DateTime.UtcNow - stopkyCas);
            stopkyCas = DateTime.UtcNow;
            casLabel.Text = string.Format("čas : {0}.{1}", stopkyCelkem, stopkyCelkem.Millisecond.ToString("D3"));
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            stopkyCelkem = new DateTime(0);
        }
    }
}
