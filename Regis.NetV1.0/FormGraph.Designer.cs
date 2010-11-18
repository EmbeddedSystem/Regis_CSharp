//using 

namespace Regis2008
{
    partial class FormGraph
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGraph));
            this.zgc = new ZedGraph.ZedGraphControl();
            this.timerSearchLighting = new System.Windows.Forms.Timer(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.SuspendLayout();
            // 
            // zgc
            // 
            this.zgc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zgc.EditButtons = System.Windows.Forms.MouseButtons.Left;
            this.zgc.IsShowPointValues = true;
            this.zgc.Location = new System.Drawing.Point(0, 0);
            this.zgc.Name = "zgc";
            this.zgc.ScrollGrace = 0;
            this.zgc.ScrollMaxX = 0;
            this.zgc.ScrollMaxY = 0;
            this.zgc.ScrollMaxY2 = 0;
            this.zgc.ScrollMinX = 0;
            this.zgc.ScrollMinY = 0;
            this.zgc.ScrollMinY2 = 0;
            this.zgc.Size = new System.Drawing.Size(523, 237);
            this.zgc.TabIndex = 0;
            this.zgc.MouseDownEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseDownEvent);
            this.zgc.MouseClick += new System.Windows.Forms.MouseEventHandler(this.zedGraphControl1_MouseClick);
            this.zgc.MouseUpEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseUpEvent);
            this.zgc.MouseMoveEvent += new ZedGraph.ZedGraphControl.ZedMouseEventHandler(this.zgc_MouseMoveEvent);
            this.zgc.DoubleClick += new System.EventHandler(this.zedGraphControl1_DoubleClick);
            this.zgc.MouseMove += new System.Windows.Forms.MouseEventHandler(this.zgc_MouseMove);
            // 
            // timerSearchLighting
            // 
            this.timerSearchLighting.Interval = 2000;
            this.timerSearchLighting.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Window;
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(0, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(523, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Показать панель управления";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.Window;
            this.button2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(0, 214);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(523, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Показать панель управления";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Visible = false;
            this.button2.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "Regis2008.chm";
            // 
            // FormGraph
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(523, 237);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.zgc);
            this.HelpButton = true;
            this.helpProvider.SetHelpKeyword(this, "3. Окно графика");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.helpProvider.SetHelpString(this, "3. Окно графика");
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "FormGraph";
            this.helpProvider.SetShowHelp(this, true);
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormGraph_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FormGraph_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        public ZedGraph.ZedGraphControl zgc;
        public System.Windows.Forms.Timer timerSearchLighting;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.HelpProvider helpProvider;

    }
}

