using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Regis2008
{
    public partial class DownloadForm : Form
    {
        public bool byteTimeout = false;
        private FormControl formControl;

        public DownloadForm(FormControl form)
        {
            formControl = form;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            Hide();
            formControl.ResetState();
        }

        private void timerTimeoutByte_Tick(object sender, EventArgs e)
        {
            timerTimeoutByte.Enabled = false;
            label1.Text = "Таймаут передачи данных!";
            timer1.Enabled = true;
            formControl.ResetState();
        }
    }
}
