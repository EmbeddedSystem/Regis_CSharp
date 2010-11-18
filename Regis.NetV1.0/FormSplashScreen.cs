using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Regis2008
{
    public partial class FormSplashScreen : Form
    {
        private float i;
        private FormControl formControl;
        public FormSplashScreen(FormControl form)
        {
            formControl = form;
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            i = i + 0.01f;
            if (Opacity > 0) Opacity -= i;
            else
            {
                formControl.formGraph.WindowState = FormWindowState.Normal;
                formControl.WindowState = FormWindowState.Normal;
                Close();
            }
        }
        protected override bool ShowWithoutActivation
        {
            get
            {
                return true;
            }
        }
    }
}
