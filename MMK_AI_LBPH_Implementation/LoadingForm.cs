using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MMK_AI_LBPH_Implementation
{
    public partial class LoadingForm : Form
    {
        public bool CancelClosing { get; private set; }

        private readonly BackgroundWorker worker;

        public LoadingForm(BackgroundWorker worker)
        {
            InitializeComponent();

            this.worker = worker;
            progressBarProgress.Style = worker.WorkerReportsProgress ? ProgressBarStyle.Continuous : ProgressBarStyle.Marquee;
            ControlBox = worker.WorkerSupportsCancellation;
            CancelClosing = true;
        }

        public void ForceClose()
        {
            CancelClosing = false;
            Close();
        }

        private void LoadingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = CancelClosing;
            
            if(e.Cancel)
            {
                if (worker.WorkerSupportsCancellation)
                    worker.CancelAsync();
            }
        }
    }
}
