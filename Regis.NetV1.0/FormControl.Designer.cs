namespace Regis2008
{
    public partial class FormControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormControl));
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.checkBoxAutoscroll = new System.Windows.Forms.CheckBox();
            this.buttonResetCurveData = new System.Windows.Forms.Button();
            this.labelDownColor = new System.Windows.Forms.Label();
            this.labelUpColor = new System.Windows.Forms.Label();
            this.buttonShowGraph = new System.Windows.Forms.Button();
            this.checkBoxFullScreen = new System.Windows.Forms.CheckBox();
            this.buttonRefresh = new System.Windows.Forms.Button();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.развернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьПанельУправленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.развернутьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скрытьГрафикToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.выходToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timerIcon = new System.Windows.Forms.Timer(this.components);
            this.tabPageHelp = new System.Windows.Forms.TabPage();
            this.textBoxHelp = new System.Windows.Forms.TextBox();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.groupBox14 = new System.Windows.Forms.GroupBox();
            this.checkBoxYFormatAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxYMinorGridAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxYMaxAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxYMinAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxYMajorGridAuto = new System.Windows.Forms.CheckBox();
            this.buttonUndoLastZoom = new System.Windows.Forms.Button();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.numericUpDownMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownMax = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox13 = new System.Windows.Forms.GroupBox();
            this.checkBoxXMinAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxXMajorGridAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxXMaxAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxXFormatAuto = new System.Windows.Forms.CheckBox();
            this.checkBoxXMinorGridAuto = new System.Windows.Forms.CheckBox();
            this.buttonZoomDefault = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.checkBoxScrollY = new System.Windows.Forms.CheckBox();
            this.checkBoxScrollX = new System.Windows.Forms.CheckBox();
            this.buttonZoomIn = new System.Windows.Forms.Button();
            this.buttonZoomOut = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.buttonScrollLeft = new System.Windows.Forms.Button();
            this.buttonScrollUp = new System.Windows.Forms.Button();
            this.buttonScrollRight = new System.Windows.Forms.Button();
            this.buttonScrollDown = new System.Windows.Forms.Button();
            this.tabPageSignal = new System.Windows.Forms.TabPage();
            this.checkBoxMuteAllSounds = new System.Windows.Forms.CheckBox();
            this.checkedListBoxSignals = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownMuteTime = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDownSignalMin = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSignalMax = new System.Windows.Forms.NumericUpDown();
            this.label22 = new System.Windows.Forms.Label();
            this.labelSound = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.textBoxSignalName = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.buttonSignalChangeSound = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.labelSignalColor = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.buttonSignalDelete = new System.Windows.Forms.Button();
            this.buttonSignalAdd = new System.Windows.Forms.Button();
            this.tabPageOther = new System.Windows.Forms.TabPage();
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.buttonCommentSearch = new System.Windows.Forms.Button();
            this.buttonCommentSave = new System.Windows.Forms.Button();
            this.listBoxComments = new System.Windows.Forms.ListBox();
            this.checkBoxCommentShift = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.buttonCommentDelete = new System.Windows.Forms.Button();
            this.buttonCommentAdd = new System.Windows.Forms.Button();
            this.tabPageSave = new System.Windows.Forms.TabPage();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.buttonSaveAs = new System.Windows.Forms.Button();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            this.buttonPrint = new System.Windows.Forms.Button();
            this.buttonPrintSetup = new System.Windows.Forms.Button();
            this.tabPageGraph = new System.Windows.Forms.TabPage();
            this.label29 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.textBoxYTitle = new System.Windows.Forms.TextBox();
            this.textBoxXTitle = new System.Windows.Forms.TextBox();
            this.textBoxTitle = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.listBoxCurves = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.numericUpDownCurveWidth = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.labelCurveColor = new System.Windows.Forms.Label();
            this.textBoxCurveName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.checkBoxShowLegend = new System.Windows.Forms.CheckBox();
            this.checkBoxShowXYTitles = new System.Windows.Forms.CheckBox();
            this.checkBoxViewTitle = new System.Windows.Forms.CheckBox();
            this.label27 = new System.Windows.Forms.Label();
            this.tabPageCommunications = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.numericUpDownEpsilon = new System.Windows.Forms.NumericUpDown();
            this.buttonSetEpsilon = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.labelMinT = new System.Windows.Forms.Label();
            this.labelMaxT = new System.Windows.Forms.Label();
            this.labelT = new System.Windows.Forms.Label();
            this.labelEps = new System.Windows.Forms.Label();
            this.labelComName = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.checkedListBoxPorts = new System.Windows.Forms.CheckedListBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog = new System.Windows.Forms.FontDialog();
            this.helpProvider = new System.Windows.Forms.HelpProvider();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.debugLabel = new System.Windows.Forms.Label();
            this.contextMenuStrip.SuspendLayout();
            this.tabPageHelp.SuspendLayout();
            this.tabPageView.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox14.SuspendLayout();
            this.groupBox6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).BeginInit();
            this.groupBox13.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabPageSignal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMuteTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSignalMin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSignalMax)).BeginInit();
            this.tabPageOther.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.tabPageSave.SuspendLayout();
            this.groupBox10.SuspendLayout();
            this.tabPageGraph.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurveWidth)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.tabPageCommunications.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpsilon)).BeginInit();
            this.groupBox5.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolTip
            // 
            this.toolTip.UseAnimation = false;
            this.toolTip.UseFading = false;
            // 
            // checkBoxAutoscroll
            // 
            this.checkBoxAutoscroll.Checked = true;
            this.checkBoxAutoscroll.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxAutoscroll.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxAutoscroll.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxAutoscroll.Location = new System.Drawing.Point(520, 143);
            this.checkBoxAutoscroll.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxAutoscroll.Name = "checkBoxAutoscroll";
            this.checkBoxAutoscroll.Size = new System.Drawing.Size(136, 28);
            this.checkBoxAutoscroll.TabIndex = 3;
            this.checkBoxAutoscroll.Text = "Автоскроллинг";
            this.checkBoxAutoscroll.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.checkBoxAutoscroll, "Нажмите для включения/отключения автоматического скроллинга графика");
            this.checkBoxAutoscroll.UseVisualStyleBackColor = true;
            this.checkBoxAutoscroll.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // buttonResetCurveData
            // 
            this.buttonResetCurveData.AutoSize = true;
            this.buttonResetCurveData.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonResetCurveData.Location = new System.Drawing.Point(151, 145);
            this.buttonResetCurveData.Margin = new System.Windows.Forms.Padding(4);
            this.buttonResetCurveData.Name = "buttonResetCurveData";
            this.buttonResetCurveData.Size = new System.Drawing.Size(147, 33);
            this.buttonResetCurveData.TabIndex = 23;
            this.buttonResetCurveData.Text = "Сброс данных";
            this.toolTip.SetToolTip(this.buttonResetCurveData, "Нажмите для того чтобы показать/скрыть график температуры");
            this.buttonResetCurveData.UseVisualStyleBackColor = true;
            this.buttonResetCurveData.Click += new System.EventHandler(this.buttonResetCurveData_Click);
            // 
            // labelDownColor
            // 
            this.labelDownColor.BackColor = System.Drawing.Color.White;
            this.labelDownColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDownColor.ForeColor = System.Drawing.Color.White;
            this.labelDownColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelDownColor.Location = new System.Drawing.Point(519, 50);
            this.labelDownColor.Margin = new System.Windows.Forms.Padding(4);
            this.labelDownColor.Name = "labelDownColor";
            this.labelDownColor.Size = new System.Drawing.Size(21, 20);
            this.labelDownColor.TabIndex = 14;
            this.toolTip.SetToolTip(this.labelDownColor, "Нажмите чтобы выбрать цвет низа графика: левая кнопка мыши - выбор, правая - случ" +
                    "айный цвет");
            this.labelDownColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelDownColor_MouseDown);
            // 
            // labelUpColor
            // 
            this.labelUpColor.BackColor = System.Drawing.Color.White;
            this.labelUpColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelUpColor.ForeColor = System.Drawing.Color.White;
            this.labelUpColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelUpColor.Location = new System.Drawing.Point(519, 117);
            this.labelUpColor.Margin = new System.Windows.Forms.Padding(4);
            this.labelUpColor.Name = "labelUpColor";
            this.labelUpColor.Size = new System.Drawing.Size(21, 20);
            this.labelUpColor.TabIndex = 12;
            this.toolTip.SetToolTip(this.labelUpColor, "Нажмите чтобы выбрать цвет верха графика: левая кнопка мыши - выбор, правая - слу" +
                    "чайный цвет");
            this.labelUpColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelUpColor_MouseDown);
            // 
            // buttonShowGraph
            // 
            this.buttonShowGraph.AutoSize = true;
            this.buttonShowGraph.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonShowGraph.Location = new System.Drawing.Point(8, 193);
            this.buttonShowGraph.Margin = new System.Windows.Forms.Padding(4);
            this.buttonShowGraph.Name = "buttonShowGraph";
            this.buttonShowGraph.Size = new System.Drawing.Size(156, 33);
            this.buttonShowGraph.TabIndex = 0;
            this.buttonShowGraph.Text = "Скрыть график";
            this.toolTip.SetToolTip(this.buttonShowGraph, "Нажмите для того чтобы показать/скрыть график температуры");
            this.buttonShowGraph.UseVisualStyleBackColor = true;
            this.buttonShowGraph.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBoxFullScreen
            // 
            this.checkBoxFullScreen.AutoSize = true;
            this.checkBoxFullScreen.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxFullScreen.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxFullScreen.Location = new System.Drawing.Point(159, 197);
            this.checkBoxFullScreen.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxFullScreen.Name = "checkBoxFullScreen";
            this.checkBoxFullScreen.Size = new System.Drawing.Size(126, 22);
            this.checkBoxFullScreen.TabIndex = 15;
            this.checkBoxFullScreen.Text = "На весь экран";
            this.checkBoxFullScreen.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.toolTip.SetToolTip(this.checkBoxFullScreen, "Нажмите, чтобы отобразить график на полном экране");
            this.checkBoxFullScreen.UseVisualStyleBackColor = true;
            this.checkBoxFullScreen.CheckedChanged += new System.EventHandler(this.checkBoxFullScreen_CheckedChanged);
            // 
            // buttonRefresh
            // 
            this.buttonRefresh.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonRefresh.Location = new System.Drawing.Point(8, 194);
            this.buttonRefresh.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRefresh.Name = "buttonRefresh";
            this.buttonRefresh.Size = new System.Drawing.Size(109, 28);
            this.buttonRefresh.TabIndex = 7;
            this.buttonRefresh.Text = "&Обновить";
            this.toolTip.SetToolTip(this.buttonRefresh, "Нажмите, чтобы обновить список свободных портов");
            this.buttonRefresh.UseVisualStyleBackColor = true;
            this.buttonRefresh.Click += new System.EventHandler(this.buttonRefresh_Click);
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon.BalloonTipText = "REGIS.NET V1.0";
            this.notifyIcon.BalloonTipTitle = "REGIS.NET V1.0";
            this.notifyIcon.ContextMenuStrip = this.contextMenuStrip;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "REGIS.NET V1.0";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // contextMenuStrip
            // 
            this.contextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.развернутьToolStripMenuItem,
            this.скрытьПанельУправленияToolStripMenuItem,
            this.toolStripSeparator2,
            this.развернутьГрафикToolStripMenuItem,
            this.скрытьГрафикToolStripMenuItem,
            this.toolStripSeparator1,
            this.выходToolStripMenuItem});
            this.contextMenuStrip.Name = "contextMenuStrip1";
            this.contextMenuStrip.ShowItemToolTips = false;
            this.contextMenuStrip.Size = new System.Drawing.Size(278, 136);
            this.contextMenuStrip.Text = "Regis.NETv1.0";
            // 
            // развернутьToolStripMenuItem
            // 
            this.развернутьToolStripMenuItem.Name = "развернутьToolStripMenuItem";
            this.развернутьToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.развернутьToolStripMenuItem.Text = "Открыть панель управления";
            this.развернутьToolStripMenuItem.Click += new System.EventHandler(this.развернутьToolStripMenuItem_Click);
            // 
            // скрытьПанельУправленияToolStripMenuItem
            // 
            this.скрытьПанельУправленияToolStripMenuItem.Name = "скрытьПанельУправленияToolStripMenuItem";
            this.скрытьПанельУправленияToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.скрытьПанельУправленияToolStripMenuItem.Text = "Закрыть панель управления";
            this.скрытьПанельУправленияToolStripMenuItem.Click += new System.EventHandler(this.скрытьПанельУправленияToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(274, 6);
            // 
            // развернутьГрафикToolStripMenuItem
            // 
            this.развернутьГрафикToolStripMenuItem.Name = "развернутьГрафикToolStripMenuItem";
            this.развернутьГрафикToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.развернутьГрафикToolStripMenuItem.Text = "Открыть график";
            this.развернутьГрафикToolStripMenuItem.Click += new System.EventHandler(this.развернутьГрафикToolStripMenuItem_Click);
            // 
            // скрытьГрафикToolStripMenuItem
            // 
            this.скрытьГрафикToolStripMenuItem.Name = "скрытьГрафикToolStripMenuItem";
            this.скрытьГрафикToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.скрытьГрафикToolStripMenuItem.Text = "Закрыть график";
            this.скрытьГрафикToolStripMenuItem.Click += new System.EventHandler(this.скрытьГрафикToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(274, 6);
            // 
            // выходToolStripMenuItem
            // 
            this.выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            this.выходToolStripMenuItem.Size = new System.Drawing.Size(277, 24);
            this.выходToolStripMenuItem.Text = "Выход";
            this.выходToolStripMenuItem.Click += new System.EventHandler(this.выходToolStripMenuItem_Click);
            // 
            // timerIcon
            // 
            this.timerIcon.Enabled = true;
            this.timerIcon.Interval = 300;
            this.timerIcon.Tick += new System.EventHandler(this.timerIcon_Tick);
            // 
            // tabPageHelp
            // 
            this.tabPageHelp.Controls.Add(this.textBoxHelp);
            this.helpProvider.SetHelpKeyword(this.tabPageHelp, "1. Введение");
            this.helpProvider.SetHelpNavigator(this.tabPageHelp, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageHelp.Location = new System.Drawing.Point(4, 4);
            this.tabPageHelp.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageHelp.Name = "tabPageHelp";
            this.tabPageHelp.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider.SetShowHelp(this.tabPageHelp, true);
            this.tabPageHelp.Size = new System.Drawing.Size(667, 249);
            this.tabPageHelp.TabIndex = 7;
            this.tabPageHelp.Text = "О программе";
            this.tabPageHelp.UseVisualStyleBackColor = true;
            // 
            // textBoxHelp
            // 
            this.textBoxHelp.BackColor = System.Drawing.Color.LightGray;
            this.textBoxHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHelp.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxHelp.Location = new System.Drawing.Point(4, 4);
            this.textBoxHelp.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxHelp.Multiline = true;
            this.textBoxHelp.Name = "textBoxHelp";
            this.textBoxHelp.Size = new System.Drawing.Size(659, 241);
            this.textBoxHelp.TabIndex = 0;
            this.textBoxHelp.Text = "ЗАО \"Евромикс\",  Regis2008 V1.1\r\nНовые возможности:\r\n- номера портов могут быть о" +
                "т COM1 до COM256;\r\n- добавлена возможность сохранения в файл памяти замеров пиро" +
                "метра;";
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.groupBox8);
            this.tabPageView.Controls.Add(this.groupBox14);
            this.tabPageView.Controls.Add(this.buttonUndoLastZoom);
            this.tabPageView.Controls.Add(this.checkBoxAutoscroll);
            this.tabPageView.Controls.Add(this.groupBox6);
            this.tabPageView.Controls.Add(this.groupBox13);
            this.tabPageView.Controls.Add(this.buttonZoomDefault);
            this.tabPageView.Controls.Add(this.groupBox4);
            this.tabPageView.Controls.Add(this.groupBox3);
            this.helpProvider.SetHelpKeyword(this.tabPageView, "2.3. Вид");
            this.helpProvider.SetHelpNavigator(this.tabPageView, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageView.Location = new System.Drawing.Point(4, 4);
            this.tabPageView.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider.SetShowHelp(this.tabPageView, true);
            this.tabPageView.Size = new System.Drawing.Size(667, 249);
            this.tabPageView.TabIndex = 3;
            this.tabPageView.Text = "Вид";
            this.tabPageView.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.dateTimePicker1);
            this.groupBox8.Controls.Add(this.label3);
            this.groupBox8.Controls.Add(this.label4);
            this.groupBox8.Controls.Add(this.dateTimePicker2);
            this.groupBox8.Location = new System.Drawing.Point(445, 7);
            this.groupBox8.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox8.Size = new System.Drawing.Size(211, 127);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Время";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(71, 39);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(95, 22);
            this.dateTimePicker1.TabIndex = 12;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(45, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "С:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(37, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "ПО:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(71, 69);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(95, 22);
            this.dateTimePicker2.TabIndex = 11;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // groupBox14
            // 
            this.groupBox14.Controls.Add(this.checkBoxYFormatAuto);
            this.groupBox14.Controls.Add(this.checkBoxYMinorGridAuto);
            this.groupBox14.Controls.Add(this.checkBoxYMaxAuto);
            this.groupBox14.Controls.Add(this.checkBoxYMinAuto);
            this.groupBox14.Controls.Add(this.checkBoxYMajorGridAuto);
            this.groupBox14.Location = new System.Drawing.Point(11, 142);
            this.groupBox14.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox14.Name = "groupBox14";
            this.groupBox14.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox14.Size = new System.Drawing.Size(247, 92);
            this.groupBox14.TabIndex = 31;
            this.groupBox14.TabStop = false;
            this.groupBox14.Text = "Температура (автонастройка)";
            // 
            // checkBoxYFormatAuto
            // 
            this.checkBoxYFormatAuto.AutoSize = true;
            this.checkBoxYFormatAuto.Location = new System.Drawing.Point(8, 23);
            this.checkBoxYFormatAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxYFormatAuto.Name = "checkBoxYFormatAuto";
            this.checkBoxYFormatAuto.Size = new System.Drawing.Size(83, 21);
            this.checkBoxYFormatAuto.TabIndex = 24;
            this.checkBoxYFormatAuto.Text = "Формат";
            this.checkBoxYFormatAuto.UseVisualStyleBackColor = true;
            this.checkBoxYFormatAuto.CheckedChanged += new System.EventHandler(this.checkBox18_CheckedChanged);
            // 
            // checkBoxYMinorGridAuto
            // 
            this.checkBoxYMinorGridAuto.AutoSize = true;
            this.checkBoxYMinorGridAuto.Location = new System.Drawing.Point(128, 44);
            this.checkBoxYMinorGridAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxYMinorGridAuto.Name = "checkBoxYMinorGridAuto";
            this.checkBoxYMinorGridAuto.Size = new System.Drawing.Size(107, 21);
            this.checkBoxYMinorGridAuto.TabIndex = 28;
            this.checkBoxYMinorGridAuto.Text = "Доп. шкала";
            this.checkBoxYMinorGridAuto.UseVisualStyleBackColor = true;
            this.checkBoxYMinorGridAuto.CheckedChanged += new System.EventHandler(this.checkBox13_CheckedChanged);
            // 
            // checkBoxYMaxAuto
            // 
            this.checkBoxYMaxAuto.AutoSize = true;
            this.checkBoxYMaxAuto.Checked = true;
            this.checkBoxYMaxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxYMaxAuto.Location = new System.Drawing.Point(128, 65);
            this.checkBoxYMaxAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxYMaxAuto.Name = "checkBoxYMaxAuto";
            this.checkBoxYMaxAuto.Size = new System.Drawing.Size(96, 21);
            this.checkBoxYMaxAuto.TabIndex = 26;
            this.checkBoxYMaxAuto.Text = "Максимум";
            this.checkBoxYMaxAuto.UseVisualStyleBackColor = true;
            this.checkBoxYMaxAuto.CheckedChanged += new System.EventHandler(this.checkBox15_CheckedChanged);
            // 
            // checkBoxYMinAuto
            // 
            this.checkBoxYMinAuto.AutoSize = true;
            this.checkBoxYMinAuto.Checked = true;
            this.checkBoxYMinAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxYMinAuto.Location = new System.Drawing.Point(8, 65);
            this.checkBoxYMinAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxYMinAuto.Name = "checkBoxYMinAuto";
            this.checkBoxYMinAuto.Size = new System.Drawing.Size(90, 21);
            this.checkBoxYMinAuto.TabIndex = 27;
            this.checkBoxYMinAuto.Text = "Минимум";
            this.checkBoxYMinAuto.UseVisualStyleBackColor = true;
            this.checkBoxYMinAuto.CheckedChanged += new System.EventHandler(this.checkBox14_CheckedChanged);
            // 
            // checkBoxYMajorGridAuto
            // 
            this.checkBoxYMajorGridAuto.AutoSize = true;
            this.checkBoxYMajorGridAuto.Location = new System.Drawing.Point(8, 44);
            this.checkBoxYMajorGridAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxYMajorGridAuto.Name = "checkBoxYMajorGridAuto";
            this.checkBoxYMajorGridAuto.Size = new System.Drawing.Size(106, 21);
            this.checkBoxYMajorGridAuto.TabIndex = 25;
            this.checkBoxYMajorGridAuto.Text = "Осн. шкала";
            this.checkBoxYMajorGridAuto.UseVisualStyleBackColor = true;
            this.checkBoxYMajorGridAuto.CheckedChanged += new System.EventHandler(this.checkBox17_CheckedChanged);
            // 
            // buttonUndoLastZoom
            // 
            this.buttonUndoLastZoom.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonUndoLastZoom.Location = new System.Drawing.Point(517, 172);
            this.buttonUndoLastZoom.Margin = new System.Windows.Forms.Padding(4);
            this.buttonUndoLastZoom.Name = "buttonUndoLastZoom";
            this.buttonUndoLastZoom.Size = new System.Drawing.Size(136, 28);
            this.buttonUndoLastZoom.TabIndex = 3;
            this.buttonUndoLastZoom.Text = "Отменить зум/сдвиг";
            this.buttonUndoLastZoom.UseVisualStyleBackColor = true;
            this.buttonUndoLastZoom.Click += new System.EventHandler(this.button20_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.numericUpDownMin);
            this.groupBox6.Controls.Add(this.numericUpDownMax);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Location = new System.Drawing.Point(301, 7);
            this.groupBox6.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox6.Size = new System.Drawing.Size(136, 127);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Температура";
            // 
            // numericUpDownMin
            // 
            this.numericUpDownMin.DecimalPlaces = 1;
            this.numericUpDownMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMin.Location = new System.Drawing.Point(56, 66);
            this.numericUpDownMin.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMin.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownMin.Name = "numericUpDownMin";
            this.numericUpDownMin.Size = new System.Drawing.Size(72, 22);
            this.numericUpDownMin.TabIndex = 4;
            this.numericUpDownMin.ValueChanged += new System.EventHandler(this.numericUpDownMin_ValueChanged);
            // 
            // numericUpDownMax
            // 
            this.numericUpDownMax.DecimalPlaces = 1;
            this.numericUpDownMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownMax.Location = new System.Drawing.Point(56, 38);
            this.numericUpDownMax.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownMax.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownMax.Name = "numericUpDownMax";
            this.numericUpDownMax.Size = new System.Drawing.Size(72, 22);
            this.numericUpDownMax.TabIndex = 3;
            this.numericUpDownMax.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label6.Location = new System.Drawing.Point(12, 41);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "max:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label5.Location = new System.Drawing.Point(16, 69);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "min:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox13
            // 
            this.groupBox13.Controls.Add(this.checkBoxXMinAuto);
            this.groupBox13.Controls.Add(this.checkBoxXMajorGridAuto);
            this.groupBox13.Controls.Add(this.checkBoxXMaxAuto);
            this.groupBox13.Controls.Add(this.checkBoxXFormatAuto);
            this.groupBox13.Controls.Add(this.checkBoxXMinorGridAuto);
            this.groupBox13.Location = new System.Drawing.Point(265, 142);
            this.groupBox13.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox13.Name = "groupBox13";
            this.groupBox13.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox13.Size = new System.Drawing.Size(247, 92);
            this.groupBox13.TabIndex = 30;
            this.groupBox13.TabStop = false;
            this.groupBox13.Text = "Время (автонастройка)";
            // 
            // checkBoxXMinAuto
            // 
            this.checkBoxXMinAuto.AutoSize = true;
            this.checkBoxXMinAuto.Checked = true;
            this.checkBoxXMinAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxXMinAuto.Location = new System.Drawing.Point(8, 65);
            this.checkBoxXMinAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxXMinAuto.Name = "checkBoxXMinAuto";
            this.checkBoxXMinAuto.Size = new System.Drawing.Size(90, 21);
            this.checkBoxXMinAuto.TabIndex = 22;
            this.checkBoxXMinAuto.Text = "Минимум";
            this.checkBoxXMinAuto.UseVisualStyleBackColor = true;
            this.checkBoxXMinAuto.CheckedChanged += new System.EventHandler(this.checkBox11_CheckedChanged);
            // 
            // checkBoxXMajorGridAuto
            // 
            this.checkBoxXMajorGridAuto.AutoSize = true;
            this.checkBoxXMajorGridAuto.Location = new System.Drawing.Point(8, 44);
            this.checkBoxXMajorGridAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxXMajorGridAuto.Name = "checkBoxXMajorGridAuto";
            this.checkBoxXMajorGridAuto.Size = new System.Drawing.Size(106, 21);
            this.checkBoxXMajorGridAuto.TabIndex = 20;
            this.checkBoxXMajorGridAuto.Text = "Осн. шкала";
            this.checkBoxXMajorGridAuto.UseVisualStyleBackColor = true;
            this.checkBoxXMajorGridAuto.CheckedChanged += new System.EventHandler(this.checkBox10_CheckedChanged);
            // 
            // checkBoxXMaxAuto
            // 
            this.checkBoxXMaxAuto.AutoSize = true;
            this.checkBoxXMaxAuto.Checked = true;
            this.checkBoxXMaxAuto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxXMaxAuto.Location = new System.Drawing.Point(128, 65);
            this.checkBoxXMaxAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxXMaxAuto.Name = "checkBoxXMaxAuto";
            this.checkBoxXMaxAuto.Size = new System.Drawing.Size(96, 21);
            this.checkBoxXMaxAuto.TabIndex = 21;
            this.checkBoxXMaxAuto.Text = "Максимум";
            this.checkBoxXMaxAuto.UseVisualStyleBackColor = true;
            this.checkBoxXMaxAuto.CheckedChanged += new System.EventHandler(this.checkBox12_CheckedChanged);
            // 
            // checkBoxXFormatAuto
            // 
            this.checkBoxXFormatAuto.AutoSize = true;
            this.checkBoxXFormatAuto.Location = new System.Drawing.Point(8, 23);
            this.checkBoxXFormatAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxXFormatAuto.Name = "checkBoxXFormatAuto";
            this.checkBoxXFormatAuto.Size = new System.Drawing.Size(83, 21);
            this.checkBoxXFormatAuto.TabIndex = 19;
            this.checkBoxXFormatAuto.Text = "Формат";
            this.checkBoxXFormatAuto.UseVisualStyleBackColor = true;
            this.checkBoxXFormatAuto.CheckedChanged += new System.EventHandler(this.checkBox9_CheckedChanged);
            // 
            // checkBoxXMinorGridAuto
            // 
            this.checkBoxXMinorGridAuto.AutoSize = true;
            this.checkBoxXMinorGridAuto.Location = new System.Drawing.Point(128, 44);
            this.checkBoxXMinorGridAuto.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxXMinorGridAuto.Name = "checkBoxXMinorGridAuto";
            this.checkBoxXMinorGridAuto.Size = new System.Drawing.Size(107, 21);
            this.checkBoxXMinorGridAuto.TabIndex = 23;
            this.checkBoxXMinorGridAuto.Text = "Доп. шкала";
            this.checkBoxXMinorGridAuto.UseVisualStyleBackColor = true;
            this.checkBoxXMinorGridAuto.CheckedChanged += new System.EventHandler(this.checkBox16_CheckedChanged);
            // 
            // buttonZoomDefault
            // 
            this.buttonZoomDefault.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonZoomDefault.Location = new System.Drawing.Point(517, 206);
            this.buttonZoomDefault.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomDefault.Name = "buttonZoomDefault";
            this.buttonZoomDefault.Size = new System.Drawing.Size(136, 28);
            this.buttonZoomDefault.TabIndex = 4;
            this.buttonZoomDefault.Text = "По умолчанию";
            this.buttonZoomDefault.UseVisualStyleBackColor = true;
            this.buttonZoomDefault.Click += new System.EventHandler(this.button21_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.checkBoxScrollY);
            this.groupBox4.Controls.Add(this.checkBoxScrollX);
            this.groupBox4.Controls.Add(this.buttonZoomIn);
            this.groupBox4.Controls.Add(this.buttonZoomOut);
            this.groupBox4.Location = new System.Drawing.Point(155, 7);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(139, 127);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Зум";
            // 
            // checkBoxScrollY
            // 
            this.checkBoxScrollY.AutoSize = true;
            this.checkBoxScrollY.Checked = true;
            this.checkBoxScrollY.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScrollY.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxScrollY.Location = new System.Drawing.Point(8, 95);
            this.checkBoxScrollY.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxScrollY.Name = "checkBoxScrollY";
            this.checkBoxScrollY.Size = new System.Drawing.Size(118, 21);
            this.checkBoxScrollY.TabIndex = 4;
            this.checkBoxScrollY.Text = "Температура";
            this.checkBoxScrollY.UseVisualStyleBackColor = true;
            this.checkBoxScrollY.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // checkBoxScrollX
            // 
            this.checkBoxScrollX.AutoSize = true;
            this.checkBoxScrollX.Checked = true;
            this.checkBoxScrollX.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxScrollX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxScrollX.Location = new System.Drawing.Point(8, 71);
            this.checkBoxScrollX.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxScrollX.Name = "checkBoxScrollX";
            this.checkBoxScrollX.Size = new System.Drawing.Size(72, 21);
            this.checkBoxScrollX.TabIndex = 3;
            this.checkBoxScrollX.Text = "Время";
            this.checkBoxScrollX.UseVisualStyleBackColor = true;
            this.checkBoxScrollX.CheckedChanged += new System.EventHandler(this.checkBox3_CheckedChanged);
            // 
            // buttonZoomIn
            // 
            this.buttonZoomIn.Image = global::Regis2008.Properties.Resources.zoom_plus2;
            this.buttonZoomIn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonZoomIn.Location = new System.Drawing.Point(65, 17);
            this.buttonZoomIn.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomIn.Name = "buttonZoomIn";
            this.buttonZoomIn.Size = new System.Drawing.Size(51, 47);
            this.buttonZoomIn.TabIndex = 2;
            this.buttonZoomIn.UseVisualStyleBackColor = true;
            this.buttonZoomIn.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonZoomOut
            // 
            this.buttonZoomOut.Image = global::Regis2008.Properties.Resources.zoom_minus2;
            this.buttonZoomOut.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonZoomOut.Location = new System.Drawing.Point(7, 17);
            this.buttonZoomOut.Margin = new System.Windows.Forms.Padding(4);
            this.buttonZoomOut.Name = "buttonZoomOut";
            this.buttonZoomOut.Size = new System.Drawing.Size(51, 47);
            this.buttonZoomOut.TabIndex = 1;
            this.buttonZoomOut.UseVisualStyleBackColor = true;
            this.buttonZoomOut.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonScrollLeft);
            this.groupBox3.Controls.Add(this.buttonScrollUp);
            this.groupBox3.Controls.Add(this.buttonScrollRight);
            this.groupBox3.Controls.Add(this.buttonScrollDown);
            this.groupBox3.Location = new System.Drawing.Point(11, 7);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(136, 127);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Сдвиг";
            // 
            // buttonScrollLeft
            // 
            this.buttonScrollLeft.Image = global::Regis2008.Properties.Resources.arr_left1;
            this.buttonScrollLeft.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonScrollLeft.Location = new System.Drawing.Point(12, 46);
            this.buttonScrollLeft.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScrollLeft.Name = "buttonScrollLeft";
            this.buttonScrollLeft.Size = new System.Drawing.Size(31, 46);
            this.buttonScrollLeft.TabIndex = 2;
            this.buttonScrollLeft.UseVisualStyleBackColor = true;
            this.buttonScrollLeft.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonScrollUp
            // 
            this.buttonScrollUp.Image = global::Regis2008.Properties.Resources.arr_up;
            this.buttonScrollUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonScrollUp.Location = new System.Drawing.Point(41, 17);
            this.buttonScrollUp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScrollUp.Name = "buttonScrollUp";
            this.buttonScrollUp.Size = new System.Drawing.Size(48, 28);
            this.buttonScrollUp.TabIndex = 0;
            this.buttonScrollUp.UseVisualStyleBackColor = true;
            this.buttonScrollUp.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // buttonScrollRight
            // 
            this.buttonScrollRight.Image = global::Regis2008.Properties.Resources.arr_right;
            this.buttonScrollRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonScrollRight.Location = new System.Drawing.Point(89, 46);
            this.buttonScrollRight.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScrollRight.Name = "buttonScrollRight";
            this.buttonScrollRight.Size = new System.Drawing.Size(31, 46);
            this.buttonScrollRight.TabIndex = 3;
            this.buttonScrollRight.UseVisualStyleBackColor = true;
            this.buttonScrollRight.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonScrollDown
            // 
            this.buttonScrollDown.Image = global::Regis2008.Properties.Resources.arr_down;
            this.buttonScrollDown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonScrollDown.Location = new System.Drawing.Point(43, 90);
            this.buttonScrollDown.Margin = new System.Windows.Forms.Padding(4);
            this.buttonScrollDown.Name = "buttonScrollDown";
            this.buttonScrollDown.Size = new System.Drawing.Size(48, 28);
            this.buttonScrollDown.TabIndex = 1;
            this.buttonScrollDown.UseVisualStyleBackColor = true;
            this.buttonScrollDown.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabPageSignal
            // 
            this.tabPageSignal.Controls.Add(this.checkBoxMuteAllSounds);
            this.tabPageSignal.Controls.Add(this.checkedListBoxSignals);
            this.tabPageSignal.Controls.Add(this.label1);
            this.tabPageSignal.Controls.Add(this.numericUpDownMuteTime);
            this.tabPageSignal.Controls.Add(this.button1);
            this.tabPageSignal.Controls.Add(this.numericUpDownSignalMin);
            this.tabPageSignal.Controls.Add(this.numericUpDownSignalMax);
            this.tabPageSignal.Controls.Add(this.label22);
            this.tabPageSignal.Controls.Add(this.labelSound);
            this.tabPageSignal.Controls.Add(this.label20);
            this.tabPageSignal.Controls.Add(this.textBoxSignalName);
            this.tabPageSignal.Controls.Add(this.label19);
            this.tabPageSignal.Controls.Add(this.buttonSignalChangeSound);
            this.tabPageSignal.Controls.Add(this.label16);
            this.tabPageSignal.Controls.Add(this.labelSignalColor);
            this.tabPageSignal.Controls.Add(this.label18);
            this.tabPageSignal.Controls.Add(this.buttonSignalDelete);
            this.tabPageSignal.Controls.Add(this.buttonSignalAdd);
            this.helpProvider.SetHelpKeyword(this.tabPageSignal, "2.4. Сигнализация");
            this.helpProvider.SetHelpNavigator(this.tabPageSignal, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageSignal.Location = new System.Drawing.Point(4, 4);
            this.tabPageSignal.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSignal.Name = "tabPageSignal";
            this.tabPageSignal.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider.SetShowHelp(this.tabPageSignal, true);
            this.tabPageSignal.Size = new System.Drawing.Size(667, 249);
            this.tabPageSignal.TabIndex = 6;
            this.tabPageSignal.Text = "Сигнализация";
            this.tabPageSignal.UseVisualStyleBackColor = true;
            // 
            // checkBoxMuteAllSounds
            // 
            this.checkBoxMuteAllSounds.AutoSize = true;
            this.checkBoxMuteAllSounds.Location = new System.Drawing.Point(511, 7);
            this.checkBoxMuteAllSounds.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxMuteAllSounds.Name = "checkBoxMuteAllSounds";
            this.checkBoxMuteAllSounds.Size = new System.Drawing.Size(135, 21);
            this.checkBoxMuteAllSounds.TabIndex = 31;
            this.checkBoxMuteAllSounds.Text = "Отключить звук";
            this.checkBoxMuteAllSounds.UseVisualStyleBackColor = true;
            this.checkBoxMuteAllSounds.CheckedChanged += new System.EventHandler(this.checkBoxMuteAllSounds_CheckedChanged);
            // 
            // checkedListBoxSignals
            // 
            this.checkedListBoxSignals.FormattingEnabled = true;
            this.checkedListBoxSignals.Location = new System.Drawing.Point(8, 26);
            this.checkedListBoxSignals.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxSignals.Name = "checkedListBoxSignals";
            this.checkedListBoxSignals.Size = new System.Drawing.Size(145, 191);
            this.checkedListBoxSignals.TabIndex = 30;
            this.checkedListBoxSignals.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxSignals_MouseUp);
            this.checkedListBoxSignals.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxSignals_MouseClick);
            this.checkedListBoxSignals.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxSignals_SelectedIndexChanged);
            this.checkedListBoxSignals.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxSignals_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(285, 164);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 29;
            this.label1.Text = "Пауза (сек):";
            // 
            // numericUpDownMuteTime
            // 
            this.numericUpDownMuteTime.Location = new System.Drawing.Point(289, 183);
            this.numericUpDownMuteTime.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownMuteTime.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownMuteTime.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownMuteTime.Name = "numericUpDownMuteTime";
            this.numericUpDownMuteTime.Size = new System.Drawing.Size(93, 22);
            this.numericUpDownMuteTime.TabIndex = 28;
            this.numericUpDownMuteTime.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // button1
            // 
            this.button1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.button1.Location = new System.Drawing.Point(164, 183);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 28);
            this.button1.TabIndex = 26;
            this.button1.Text = "Проиграть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // numericUpDownSignalMin
            // 
            this.numericUpDownSignalMin.DecimalPlaces = 1;
            this.numericUpDownSignalMin.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSignalMin.Location = new System.Drawing.Point(289, 76);
            this.numericUpDownSignalMin.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSignalMin.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSignalMin.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownSignalMin.Name = "numericUpDownSignalMin";
            this.numericUpDownSignalMin.Size = new System.Drawing.Size(93, 22);
            this.numericUpDownSignalMin.TabIndex = 25;
            this.numericUpDownSignalMin.ValueChanged += new System.EventHandler(this.numericUpDownSignalMin_ValueChanged);
            // 
            // numericUpDownSignalMax
            // 
            this.numericUpDownSignalMax.DecimalPlaces = 1;
            this.numericUpDownSignalMax.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDownSignalMax.Location = new System.Drawing.Point(289, 25);
            this.numericUpDownSignalMax.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownSignalMax.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDownSignalMax.Minimum = new decimal(new int[] {
            300,
            0,
            0,
            -2147483648});
            this.numericUpDownSignalMax.Name = "numericUpDownSignalMax";
            this.numericUpDownSignalMax.Size = new System.Drawing.Size(93, 22);
            this.numericUpDownSignalMax.TabIndex = 24;
            this.numericUpDownSignalMax.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label22.Location = new System.Drawing.Point(11, 5);
            this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(136, 17);
            this.label22.TabIndex = 22;
            this.label22.Text = "Сигналы(вкл/выкл):";
            // 
            // labelSound
            // 
            this.labelSound.AutoSize = true;
            this.labelSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSound.Location = new System.Drawing.Point(164, 219);
            this.labelSound.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSound.Name = "labelSound";
            this.labelSound.Size = new System.Drawing.Size(69, 17);
            this.labelSound.TabIndex = 21;
            this.labelSound.Text = "Звук: нет";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label20.Location = new System.Drawing.Point(287, 5);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(124, 17);
            this.label20.TabIndex = 20;
            this.label20.Text = "Верхняя граница:";
            // 
            // textBoxSignalName
            // 
            this.textBoxSignalName.Location = new System.Drawing.Point(163, 25);
            this.textBoxSignalName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxSignalName.Name = "textBoxSignalName";
            this.textBoxSignalName.Size = new System.Drawing.Size(117, 22);
            this.textBoxSignalName.TabIndex = 13;
            this.textBoxSignalName.TextChanged += new System.EventHandler(this.textBoxSignalName_TextChanged);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label19.Location = new System.Drawing.Point(285, 57);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(120, 17);
            this.label19.TabIndex = 18;
            this.label19.Text = "Нижняя граница:";
            // 
            // buttonSignalChangeSound
            // 
            this.buttonSignalChangeSound.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSignalChangeSound.Location = new System.Drawing.Point(164, 148);
            this.buttonSignalChangeSound.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignalChangeSound.Name = "buttonSignalChangeSound";
            this.buttonSignalChangeSound.Size = new System.Drawing.Size(117, 28);
            this.buttonSignalChangeSound.TabIndex = 16;
            this.buttonSignalChangeSound.Text = "Звук...";
            this.buttonSignalChangeSound.UseVisualStyleBackColor = true;
            this.buttonSignalChangeSound.Click += new System.EventHandler(this.buttonSignalChangeSound_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label16.Location = new System.Drawing.Point(159, 5);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(39, 17);
            this.label16.TabIndex = 15;
            this.label16.Text = "Имя:";
            // 
            // labelSignalColor
            // 
            this.labelSignalColor.BackColor = System.Drawing.SystemColors.Info;
            this.labelSignalColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelSignalColor.ForeColor = System.Drawing.SystemColors.Info;
            this.labelSignalColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelSignalColor.Location = new System.Drawing.Point(219, 52);
            this.labelSignalColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSignalColor.Name = "labelSignalColor";
            this.labelSignalColor.Size = new System.Drawing.Size(21, 20);
            this.labelSignalColor.TabIndex = 14;
            this.labelSignalColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelSignalColor_MouseDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label18.Location = new System.Drawing.Point(164, 53);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(45, 17);
            this.label18.TabIndex = 12;
            this.label18.Text = "Цвет:";
            // 
            // buttonSignalDelete
            // 
            this.buttonSignalDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSignalDelete.Location = new System.Drawing.Point(164, 112);
            this.buttonSignalDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignalDelete.Name = "buttonSignalDelete";
            this.buttonSignalDelete.Size = new System.Drawing.Size(117, 28);
            this.buttonSignalDelete.TabIndex = 2;
            this.buttonSignalDelete.Text = "Удалить";
            this.buttonSignalDelete.UseVisualStyleBackColor = true;
            this.buttonSignalDelete.Click += new System.EventHandler(this.buttonSignalDelete_Click);
            // 
            // buttonSignalAdd
            // 
            this.buttonSignalAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSignalAdd.Location = new System.Drawing.Point(164, 76);
            this.buttonSignalAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSignalAdd.Name = "buttonSignalAdd";
            this.buttonSignalAdd.Size = new System.Drawing.Size(117, 28);
            this.buttonSignalAdd.TabIndex = 1;
            this.buttonSignalAdd.Text = "Добавить";
            this.buttonSignalAdd.UseVisualStyleBackColor = true;
            this.buttonSignalAdd.Click += new System.EventHandler(this.buttonSignalAdd_Click);
            // 
            // tabPageOther
            // 
            this.tabPageOther.Controls.Add(this.groupBox12);
            this.helpProvider.SetHelpKeyword(this.tabPageOther, "2.5. Комментарии");
            this.helpProvider.SetHelpNavigator(this.tabPageOther, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageOther.Location = new System.Drawing.Point(4, 4);
            this.tabPageOther.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageOther.Name = "tabPageOther";
            this.tabPageOther.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider.SetShowHelp(this.tabPageOther, true);
            this.tabPageOther.Size = new System.Drawing.Size(667, 249);
            this.tabPageOther.TabIndex = 5;
            this.tabPageOther.Text = "Комментарии";
            this.tabPageOther.UseVisualStyleBackColor = true;
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.buttonCommentSearch);
            this.groupBox12.Controls.Add(this.buttonCommentSave);
            this.groupBox12.Controls.Add(this.listBoxComments);
            this.groupBox12.Controls.Add(this.checkBoxCommentShift);
            this.groupBox12.Controls.Add(this.label2);
            this.groupBox12.Controls.Add(this.textBoxComment);
            this.groupBox12.Controls.Add(this.buttonCommentDelete);
            this.groupBox12.Controls.Add(this.buttonCommentAdd);
            this.groupBox12.Location = new System.Drawing.Point(4, 4);
            this.groupBox12.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox12.Size = new System.Drawing.Size(331, 235);
            this.groupBox12.TabIndex = 0;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "Комментарии";
            // 
            // buttonCommentSearch
            // 
            this.buttonCommentSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCommentSearch.Location = new System.Drawing.Point(193, 92);
            this.buttonCommentSearch.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCommentSearch.Name = "buttonCommentSearch";
            this.buttonCommentSearch.Size = new System.Drawing.Size(111, 28);
            this.buttonCommentSearch.TabIndex = 21;
            this.buttonCommentSearch.Text = "Найти";
            this.buttonCommentSearch.UseVisualStyleBackColor = true;
            this.buttonCommentSearch.Click += new System.EventHandler(this.buttonCommentSearch_Click);
            // 
            // buttonCommentSave
            // 
            this.buttonCommentSave.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCommentSave.Location = new System.Drawing.Point(193, 143);
            this.buttonCommentSave.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCommentSave.Name = "buttonCommentSave";
            this.buttonCommentSave.Size = new System.Drawing.Size(111, 28);
            this.buttonCommentSave.TabIndex = 20;
            this.buttonCommentSave.Text = "Шрифт...";
            this.buttonCommentSave.UseVisualStyleBackColor = true;
            this.buttonCommentSave.Click += new System.EventHandler(this.buttonCommentFont_Click);
            // 
            // listBoxComments
            // 
            this.listBoxComments.FormattingEnabled = true;
            this.listBoxComments.ItemHeight = 16;
            this.listBoxComments.Location = new System.Drawing.Point(8, 20);
            this.listBoxComments.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxComments.Name = "listBoxComments";
            this.listBoxComments.Size = new System.Drawing.Size(176, 100);
            this.listBoxComments.TabIndex = 19;
            this.listBoxComments.SelectedIndexChanged += new System.EventHandler(this.listBoxComments_SelectedIndexChanged);
            // 
            // checkBoxCommentShift
            // 
            this.checkBoxCommentShift.AutoSize = true;
            this.checkBoxCommentShift.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.checkBoxCommentShift.Location = new System.Drawing.Point(193, 203);
            this.checkBoxCommentShift.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxCommentShift.Name = "checkBoxCommentShift";
            this.checkBoxCommentShift.Size = new System.Drawing.Size(117, 22);
            this.checkBoxCommentShift.TabIndex = 18;
            this.checkBoxCommentShift.Text = "Перемещать";
            this.checkBoxCommentShift.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxCommentShift.UseVisualStyleBackColor = true;
            this.checkBoxCommentShift.CheckedChanged += new System.EventHandler(this.checkBoxCommentShift_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(4, 123);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 17);
            this.label2.TabIndex = 17;
            this.label2.Text = "Текст:";
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(8, 143);
            this.textBoxComment.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxComment.Multiline = true;
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(176, 82);
            this.textBoxComment.TabIndex = 16;
            this.textBoxComment.TextChanged += new System.EventHandler(this.textBoxComment_TextChanged);
            // 
            // buttonCommentDelete
            // 
            this.buttonCommentDelete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCommentDelete.Location = new System.Drawing.Point(193, 55);
            this.buttonCommentDelete.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCommentDelete.Name = "buttonCommentDelete";
            this.buttonCommentDelete.Size = new System.Drawing.Size(111, 28);
            this.buttonCommentDelete.TabIndex = 15;
            this.buttonCommentDelete.Text = "Удалить";
            this.buttonCommentDelete.UseVisualStyleBackColor = true;
            this.buttonCommentDelete.Click += new System.EventHandler(this.buttonCommentDelete_Click);
            // 
            // buttonCommentAdd
            // 
            this.buttonCommentAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonCommentAdd.Location = new System.Drawing.Point(193, 20);
            this.buttonCommentAdd.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCommentAdd.Name = "buttonCommentAdd";
            this.buttonCommentAdd.Size = new System.Drawing.Size(111, 28);
            this.buttonCommentAdd.TabIndex = 14;
            this.buttonCommentAdd.Text = "Добавить";
            this.buttonCommentAdd.UseVisualStyleBackColor = true;
            this.buttonCommentAdd.Click += new System.EventHandler(this.buttonCommentAdd_Click);
            // 
            // tabPageSave
            // 
            this.tabPageSave.Controls.Add(this.groupBox10);
            this.helpProvider.SetHelpKeyword(this.tabPageSave, "2.6. Сохранить");
            this.helpProvider.SetHelpNavigator(this.tabPageSave, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageSave.Location = new System.Drawing.Point(4, 4);
            this.tabPageSave.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSave.Name = "tabPageSave";
            this.helpProvider.SetShowHelp(this.tabPageSave, true);
            this.tabPageSave.Size = new System.Drawing.Size(667, 249);
            this.tabPageSave.TabIndex = 2;
            this.tabPageSave.Text = "Сохранить";
            this.tabPageSave.UseVisualStyleBackColor = true;
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.buttonSaveAs);
            this.groupBox10.Controls.Add(this.buttonPrintPreview);
            this.groupBox10.Controls.Add(this.buttonPrint);
            this.groupBox10.Controls.Add(this.buttonPrintSetup);
            this.groupBox10.Location = new System.Drawing.Point(11, 10);
            this.groupBox10.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox10.Size = new System.Drawing.Size(211, 171);
            this.groupBox10.TabIndex = 1;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Изображение";
            // 
            // buttonSaveAs
            // 
            this.buttonSaveAs.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonSaveAs.Location = new System.Drawing.Point(8, 130);
            this.buttonSaveAs.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSaveAs.Name = "buttonSaveAs";
            this.buttonSaveAs.Size = new System.Drawing.Size(169, 28);
            this.buttonSaveAs.TabIndex = 0;
            this.buttonSaveAs.Text = "Сохранить как...";
            this.buttonSaveAs.UseVisualStyleBackColor = true;
            this.buttonSaveAs.Click += new System.EventHandler(this.button19_Click);
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPrintPreview.Location = new System.Drawing.Point(8, 59);
            this.buttonPrintPreview.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(169, 28);
            this.buttonPrintPreview.TabIndex = 2;
            this.buttonPrintPreview.Text = "Предпросмотр";
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.button22_Click);
            // 
            // buttonPrint
            // 
            this.buttonPrint.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPrint.Location = new System.Drawing.Point(8, 95);
            this.buttonPrint.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrint.Name = "buttonPrint";
            this.buttonPrint.Size = new System.Drawing.Size(169, 28);
            this.buttonPrint.TabIndex = 1;
            this.buttonPrint.Text = "Печать";
            this.buttonPrint.UseVisualStyleBackColor = true;
            this.buttonPrint.Click += new System.EventHandler(this.button17_Click);
            // 
            // buttonPrintSetup
            // 
            this.buttonPrintSetup.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.buttonPrintSetup.Location = new System.Drawing.Point(8, 23);
            this.buttonPrintSetup.Margin = new System.Windows.Forms.Padding(4);
            this.buttonPrintSetup.Name = "buttonPrintSetup";
            this.buttonPrintSetup.Size = new System.Drawing.Size(169, 28);
            this.buttonPrintSetup.TabIndex = 0;
            this.buttonPrintSetup.Text = "Параметры печати...";
            this.buttonPrintSetup.UseVisualStyleBackColor = true;
            this.buttonPrintSetup.Click += new System.EventHandler(this.button7_Click);
            // 
            // tabPageGraph
            // 
            this.tabPageGraph.Controls.Add(this.checkBoxFullScreen);
            this.tabPageGraph.Controls.Add(this.buttonShowGraph);
            this.tabPageGraph.Controls.Add(this.label29);
            this.tabPageGraph.Controls.Add(this.label24);
            this.tabPageGraph.Controls.Add(this.labelUpColor);
            this.tabPageGraph.Controls.Add(this.label26);
            this.tabPageGraph.Controls.Add(this.labelDownColor);
            this.tabPageGraph.Controls.Add(this.textBoxYTitle);
            this.tabPageGraph.Controls.Add(this.textBoxXTitle);
            this.tabPageGraph.Controls.Add(this.textBoxTitle);
            this.tabPageGraph.Controls.Add(this.label28);
            this.tabPageGraph.Controls.Add(this.groupBox2);
            this.tabPageGraph.Controls.Add(this.flowLayoutPanel1);
            this.tabPageGraph.Controls.Add(this.label27);
            this.helpProvider.SetHelpKeyword(this.tabPageGraph, "2.2. График");
            this.helpProvider.SetHelpNavigator(this.tabPageGraph, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageGraph.Location = new System.Drawing.Point(4, 4);
            this.tabPageGraph.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageGraph.Name = "tabPageGraph";
            this.tabPageGraph.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider.SetShowHelp(this.tabPageGraph, true);
            this.tabPageGraph.Size = new System.Drawing.Size(667, 249);
            this.tabPageGraph.TabIndex = 1;
            this.tabPageGraph.Text = "График";
            this.tabPageGraph.UseVisualStyleBackColor = true;
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(317, 98);
            this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(129, 17);
            this.label29.TabIndex = 22;
            this.label29.Text = "Ось температуры:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label24.Location = new System.Drawing.Point(515, 97);
            this.label24.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(86, 17);
            this.label24.TabIndex = 11;
            this.label24.Text = "Цвет верха:";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label26.Location = new System.Drawing.Point(515, 30);
            this.label26.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(80, 17);
            this.label26.TabIndex = 13;
            this.label26.Text = "Цвет низа:";
            // 
            // textBoxYTitle
            // 
            this.textBoxYTitle.Location = new System.Drawing.Point(317, 114);
            this.textBoxYTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxYTitle.Name = "textBoxYTitle";
            this.textBoxYTitle.Size = new System.Drawing.Size(185, 22);
            this.textBoxYTitle.TabIndex = 21;
            this.textBoxYTitle.Text = "Температура, °C";
            this.textBoxYTitle.TextChanged += new System.EventHandler(this.textBox14_TextChanged);
            // 
            // textBoxXTitle
            // 
            this.textBoxXTitle.Location = new System.Drawing.Point(317, 70);
            this.textBoxXTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxXTitle.Name = "textBoxXTitle";
            this.textBoxXTitle.Size = new System.Drawing.Size(185, 22);
            this.textBoxXTitle.TabIndex = 19;
            this.textBoxXTitle.Text = "Время";
            this.textBoxXTitle.TextChanged += new System.EventHandler(this.textBox13_TextChanged);
            // 
            // textBoxTitle
            // 
            this.textBoxTitle.Location = new System.Drawing.Point(317, 26);
            this.textBoxTitle.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxTitle.Name = "textBoxTitle";
            this.textBoxTitle.Size = new System.Drawing.Size(185, 22);
            this.textBoxTitle.TabIndex = 17;
            this.textBoxTitle.Text = "Температура";
            this.textBoxTitle.TextChanged += new System.EventHandler(this.textBoxTitle_TextChanged);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(317, 54);
            this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(97, 17);
            this.label28.TabIndex = 20;
            this.label28.Text = "Ось времени:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.listBoxCurves);
            this.groupBox2.Controls.Add(this.buttonResetCurveData);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.numericUpDownCurveWidth);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.labelCurveColor);
            this.groupBox2.Controls.Add(this.textBoxCurveName);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(8, 4);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(301, 186);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Кривые";
            // 
            // listBoxCurves
            // 
            this.listBoxCurves.FormattingEnabled = true;
            this.listBoxCurves.ItemHeight = 16;
            this.listBoxCurves.Location = new System.Drawing.Point(12, 23);
            this.listBoxCurves.Margin = new System.Windows.Forms.Padding(4);
            this.listBoxCurves.Name = "listBoxCurves";
            this.listBoxCurves.Size = new System.Drawing.Size(129, 148);
            this.listBoxCurves.TabIndex = 24;
            this.listBoxCurves.SelectedIndexChanged += new System.EventHandler(this.listBoxCurves_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label15.Location = new System.Drawing.Point(151, 20);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(39, 17);
            this.label15.TabIndex = 11;
            this.label15.Text = "Имя:";
            // 
            // numericUpDownCurveWidth
            // 
            this.numericUpDownCurveWidth.Location = new System.Drawing.Point(233, 71);
            this.numericUpDownCurveWidth.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownCurveWidth.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCurveWidth.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCurveWidth.Name = "numericUpDownCurveWidth";
            this.numericUpDownCurveWidth.Size = new System.Drawing.Size(55, 22);
            this.numericUpDownCurveWidth.TabIndex = 10;
            this.numericUpDownCurveWidth.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownCurveWidth.ValueChanged += new System.EventHandler(this.numericUpDownCurveWidth_ValueChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label14.Location = new System.Drawing.Point(151, 75);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(72, 17);
            this.label14.TabIndex = 9;
            this.label14.Text = "Толщина:";
            // 
            // labelCurveColor
            // 
            this.labelCurveColor.BackColor = System.Drawing.Color.White;
            this.labelCurveColor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCurveColor.ForeColor = System.Drawing.SystemColors.Info;
            this.labelCurveColor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.labelCurveColor.Location = new System.Drawing.Point(233, 100);
            this.labelCurveColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCurveColor.Name = "labelCurveColor";
            this.labelCurveColor.Size = new System.Drawing.Size(21, 20);
            this.labelCurveColor.TabIndex = 6;
            this.labelCurveColor.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelCurveColor_MouseDown);
            // 
            // textBoxCurveName
            // 
            this.textBoxCurveName.Location = new System.Drawing.Point(151, 39);
            this.textBoxCurveName.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxCurveName.Name = "textBoxCurveName";
            this.textBoxCurveName.Size = new System.Drawing.Size(136, 22);
            this.textBoxCurveName.TabIndex = 4;
            this.textBoxCurveName.TextChanged += new System.EventHandler(this.textBoxCurveName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label9.Location = new System.Drawing.Point(179, 101);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 17);
            this.label9.TabIndex = 3;
            this.label9.Text = "Цвет:";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowLegend);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxShowXYTitles);
            this.flowLayoutPanel1.Controls.Add(this.checkBoxViewTitle);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(321, 149);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 91);
            this.flowLayoutPanel1.TabIndex = 16;
            // 
            // checkBoxShowLegend
            // 
            this.checkBoxShowLegend.AutoSize = true;
            this.checkBoxShowLegend.Checked = true;
            this.checkBoxShowLegend.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowLegend.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowLegend.Location = new System.Drawing.Point(4, 4);
            this.checkBoxShowLegend.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowLegend.Name = "checkBoxShowLegend";
            this.checkBoxShowLegend.Size = new System.Drawing.Size(165, 21);
            this.checkBoxShowLegend.TabIndex = 15;
            this.checkBoxShowLegend.Text = "Показывать легенду";
            this.checkBoxShowLegend.UseVisualStyleBackColor = true;
            this.checkBoxShowLegend.CheckedChanged += new System.EventHandler(this.checkBox8_CheckedChanged);
            // 
            // checkBoxShowXYTitles
            // 
            this.checkBoxShowXYTitles.AutoSize = true;
            this.checkBoxShowXYTitles.Checked = true;
            this.checkBoxShowXYTitles.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxShowXYTitles.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxShowXYTitles.Location = new System.Drawing.Point(4, 33);
            this.checkBoxShowXYTitles.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxShowXYTitles.Name = "checkBoxShowXYTitles";
            this.checkBoxShowXYTitles.Size = new System.Drawing.Size(210, 21);
            this.checkBoxShowXYTitles.TabIndex = 12;
            this.checkBoxShowXYTitles.Text = "Показывать названия осей";
            this.checkBoxShowXYTitles.UseVisualStyleBackColor = true;
            this.checkBoxShowXYTitles.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // checkBoxViewTitle
            // 
            this.checkBoxViewTitle.AutoSize = true;
            this.checkBoxViewTitle.Checked = true;
            this.checkBoxViewTitle.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxViewTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.checkBoxViewTitle.Location = new System.Drawing.Point(4, 62);
            this.checkBoxViewTitle.Margin = new System.Windows.Forms.Padding(4);
            this.checkBoxViewTitle.Name = "checkBoxViewTitle";
            this.checkBoxViewTitle.Size = new System.Drawing.Size(179, 21);
            this.checkBoxViewTitle.TabIndex = 16;
            this.checkBoxViewTitle.Text = "Показывать заголовок";
            this.checkBoxViewTitle.UseVisualStyleBackColor = true;
            this.checkBoxViewTitle.CheckedChanged += new System.EventHandler(this.checkBoxViewTitle_CheckedChanged);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(317, 10);
            this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(80, 17);
            this.label27.TabIndex = 18;
            this.label27.Text = "Заголовок:";
            // 
            // tabPageCommunications
            // 
            this.tabPageCommunications.Controls.Add(this.debugLabel);
            this.tabPageCommunications.Controls.Add(this.groupBox7);
            this.tabPageCommunications.Controls.Add(this.groupBox5);
            this.tabPageCommunications.Controls.Add(this.groupBox1);
            this.helpProvider.SetHelpKeyword(this.tabPageCommunications, "2.1. Коммуникации");
            this.helpProvider.SetHelpNavigator(this.tabPageCommunications, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.tabPageCommunications.Location = new System.Drawing.Point(4, 4);
            this.tabPageCommunications.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageCommunications.Name = "tabPageCommunications";
            this.tabPageCommunications.Padding = new System.Windows.Forms.Padding(4);
            this.helpProvider.SetShowHelp(this.tabPageCommunications, true);
            this.tabPageCommunications.Size = new System.Drawing.Size(667, 249);
            this.tabPageCommunications.TabIndex = 0;
            this.tabPageCommunications.Text = "Коммуникации";
            this.tabPageCommunications.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.numericUpDownEpsilon);
            this.groupBox7.Controls.Add(this.buttonSetEpsilon);
            this.groupBox7.Location = new System.Drawing.Point(145, 107);
            this.groupBox7.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox7.Size = new System.Drawing.Size(204, 58);
            this.groupBox7.TabIndex = 9;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Значение ε";
            // 
            // numericUpDownEpsilon
            // 
            this.numericUpDownEpsilon.DecimalPlaces = 2;
            this.numericUpDownEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEpsilon.Location = new System.Drawing.Point(11, 23);
            this.numericUpDownEpsilon.Margin = new System.Windows.Forms.Padding(4);
            this.numericUpDownEpsilon.Maximum = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            this.numericUpDownEpsilon.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownEpsilon.Name = "numericUpDownEpsilon";
            this.numericUpDownEpsilon.Size = new System.Drawing.Size(69, 22);
            this.numericUpDownEpsilon.TabIndex = 8;
            this.numericUpDownEpsilon.Value = new decimal(new int[] {
            100,
            0,
            0,
            131072});
            // 
            // buttonSetEpsilon
            // 
            this.buttonSetEpsilon.Location = new System.Drawing.Point(88, 20);
            this.buttonSetEpsilon.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetEpsilon.Name = "buttonSetEpsilon";
            this.buttonSetEpsilon.Size = new System.Drawing.Size(100, 28);
            this.buttonSetEpsilon.TabIndex = 7;
            this.buttonSetEpsilon.Text = "Установить";
            this.buttonSetEpsilon.UseVisualStyleBackColor = true;
            this.buttonSetEpsilon.Click += new System.EventHandler(this.buttonSetEpsilon_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.groupBox5.Controls.Add(this.labelMinT);
            this.groupBox5.Controls.Add(this.labelMaxT);
            this.groupBox5.Controls.Add(this.labelT);
            this.groupBox5.Controls.Add(this.labelEps);
            this.groupBox5.Controls.Add(this.labelComName);
            this.groupBox5.Location = new System.Drawing.Point(145, 7);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(440, 92);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Выбранный в списке \"Порты\" прибор:";
            // 
            // labelMinT
            // 
            this.labelMinT.BackColor = System.Drawing.SystemColors.Window;
            this.labelMinT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMinT.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMinT.Location = new System.Drawing.Point(315, 55);
            this.labelMinT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMinT.Name = "labelMinT";
            this.labelMinT.Size = new System.Drawing.Size(117, 30);
            this.labelMinT.TabIndex = 7;
            this.labelMinT.Text = "min....";
            this.labelMinT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMinT.Click += new System.EventHandler(this.labelMinT_Click);
            // 
            // labelMaxT
            // 
            this.labelMaxT.BackColor = System.Drawing.SystemColors.Window;
            this.labelMaxT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMaxT.Font = new System.Drawing.Font("Arial Black", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMaxT.Location = new System.Drawing.Point(315, 18);
            this.labelMaxT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaxT.Name = "labelMaxT";
            this.labelMaxT.Size = new System.Drawing.Size(117, 28);
            this.labelMaxT.TabIndex = 6;
            this.labelMaxT.Text = "max....";
            this.labelMaxT.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMaxT.Click += new System.EventHandler(this.labelMaxT_Click);
            // 
            // labelT
            // 
            this.labelT.BackColor = System.Drawing.SystemColors.Window;
            this.labelT.Font = new System.Drawing.Font("Arial Black", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelT.Location = new System.Drawing.Point(105, 18);
            this.labelT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelT.Name = "labelT";
            this.labelT.Size = new System.Drawing.Size(205, 66);
            this.labelT.TabIndex = 4;
            this.labelT.Text = ".....°C";
            this.labelT.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelEps
            // 
            this.labelEps.BackColor = System.Drawing.SystemColors.Window;
            this.labelEps.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelEps.Location = new System.Drawing.Point(8, 55);
            this.labelEps.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEps.Name = "labelEps";
            this.labelEps.Size = new System.Drawing.Size(93, 30);
            this.labelEps.TabIndex = 5;
            this.labelEps.Text = "ε = ....";
            this.labelEps.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelComName
            // 
            this.labelComName.BackColor = System.Drawing.SystemColors.Window;
            this.labelComName.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelComName.Location = new System.Drawing.Point(8, 18);
            this.labelComName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelComName.Name = "labelComName";
            this.labelComName.Size = new System.Drawing.Size(93, 28);
            this.labelComName.TabIndex = 3;
            this.labelComName.Text = "COM...";
            this.labelComName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkedListBoxPorts);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.buttonRefresh);
            this.groupBox1.Location = new System.Drawing.Point(11, 7);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(127, 233);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Порты";
            // 
            // checkedListBoxPorts
            // 
            this.checkedListBoxPorts.FormattingEnabled = true;
            this.checkedListBoxPorts.Location = new System.Drawing.Point(8, 23);
            this.checkedListBoxPorts.Margin = new System.Windows.Forms.Padding(4);
            this.checkedListBoxPorts.Name = "checkedListBoxPorts";
            this.checkedListBoxPorts.Size = new System.Drawing.Size(108, 123);
            this.checkedListBoxPorts.Sorted = true;
            this.checkedListBoxPorts.TabIndex = 3;
            this.checkedListBoxPorts.MouseUp += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxPorts_MouseUp);
            this.checkedListBoxPorts.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkedListBoxPorts_MouseClick);
            this.checkedListBoxPorts.SelectedIndexChanged += new System.EventHandler(this.checkedListBoxPorts_SelectedIndexChanged);
            this.checkedListBoxPorts.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBoxPorts_ItemCheck);
            // 
            // progressBar1
            // 
            this.progressBar1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.progressBar1.Location = new System.Drawing.Point(8, 165);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4);
            this.progressBar1.Maximum = 256;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(109, 22);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 8;
            // 
            // tabControl
            // 
            this.tabControl.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabControl.Controls.Add(this.tabPageCommunications);
            this.tabControl.Controls.Add(this.tabPageGraph);
            this.tabControl.Controls.Add(this.tabPageView);
            this.tabControl.Controls.Add(this.tabPageSignal);
            this.tabControl.Controls.Add(this.tabPageOther);
            this.tabControl.Controls.Add(this.tabPageSave);
            this.tabControl.Controls.Add(this.tabPageHelp);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl.Location = new System.Drawing.Point(0, 28);
            this.tabControl.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(675, 278);
            this.tabControl.TabIndex = 0;
            // 
            // openFileDialog
            // 
            this.openFileDialog.DefaultExt = "wav";
            this.openFileDialog.Filter = "Звуковые файлы WAV|*.wav";
            this.openFileDialog.InitialDirectory = "C:\\Program Files\\ЗАО Евромикс\\Regis.NETv1.0\\Sounds";
            this.openFileDialog.Title = "Выберите файл для проигрывания сигнала тревоги";
            // 
            // fontDialog
            // 
            this.fontDialog.ShowEffects = false;
            // 
            // helpProvider
            // 
            this.helpProvider.HelpNamespace = "Regis2008.chm";
            // 
            // buttonHelp
            // 
            this.buttonHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonHelp.Location = new System.Drawing.Point(0, 0);
            this.buttonHelp.Margin = new System.Windows.Forms.Padding(4);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(675, 28);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Вызвать справку (F1)";
            this.buttonHelp.UseVisualStyleBackColor = true;
            this.buttonHelp.Click += new System.EventHandler(this.buttonHelp_Click);
            // 
            // debugLabel
            // 
            this.debugLabel.AutoSize = true;
            this.debugLabel.Location = new System.Drawing.Point(145, 223);
            this.debugLabel.Name = "debugLabel";
            this.debugLabel.Size = new System.Drawing.Size(0, 17);
            this.debugLabel.TabIndex = 10;
            // 
            // FormControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 306);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.helpProvider.SetHelpKeyword(this, "2. Панель управления");
            this.helpProvider.SetHelpNavigator(this, System.Windows.Forms.HelpNavigator.KeywordIndex);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormControl";
            this.helpProvider.SetShowHelp(this, true);
            this.Text = "REGIS2008 V1.0 Панель управления";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.FormControl_Load);
            this.contextMenuStrip.ResumeLayout(false);
            this.tabPageHelp.ResumeLayout(false);
            this.tabPageHelp.PerformLayout();
            this.tabPageView.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox14.ResumeLayout(false);
            this.groupBox14.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMax)).EndInit();
            this.groupBox13.ResumeLayout(false);
            this.groupBox13.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabPageSignal.ResumeLayout(false);
            this.tabPageSignal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownMuteTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSignalMin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSignalMax)).EndInit();
            this.tabPageOther.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.tabPageSave.ResumeLayout(false);
            this.groupBox10.ResumeLayout(false);
            this.tabPageGraph.ResumeLayout(false);
            this.tabPageGraph.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCurveWidth)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tabPageCommunications.ResumeLayout(false);
            this.tabPageCommunications.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownEpsilon)).EndInit();
            this.groupBox5.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem развернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem выходToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьПанельУправленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem развернутьГрафикToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скрытьГрафикToolStripMenuItem;
        private System.Windows.Forms.Timer timerIcon;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.TabPage tabPageHelp;
        private System.Windows.Forms.TextBox textBoxHelp;
        private System.Windows.Forms.TabPage tabPageView;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox14;
        public System.Windows.Forms.CheckBox checkBoxYFormatAuto;
        public System.Windows.Forms.CheckBox checkBoxYMinorGridAuto;
        public System.Windows.Forms.CheckBox checkBoxYMaxAuto;
        public System.Windows.Forms.CheckBox checkBoxYMinAuto;
        public System.Windows.Forms.CheckBox checkBoxYMajorGridAuto;
        private System.Windows.Forms.GroupBox groupBox13;
        public System.Windows.Forms.CheckBox checkBoxXMinAuto;
        public System.Windows.Forms.CheckBox checkBoxXMajorGridAuto;
        public System.Windows.Forms.CheckBox checkBoxXMaxAuto;
        public System.Windows.Forms.CheckBox checkBoxXFormatAuto;
        public System.Windows.Forms.CheckBox checkBoxXMinorGridAuto;
        public System.Windows.Forms.CheckBox checkBoxAutoscroll;
        private System.Windows.Forms.Button buttonZoomDefault;
        private System.Windows.Forms.Button buttonUndoLastZoom;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.CheckBox checkBoxScrollY;
        private System.Windows.Forms.CheckBox checkBoxScrollX;
        private System.Windows.Forms.Button buttonZoomIn;
        private System.Windows.Forms.Button buttonZoomOut;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button buttonScrollLeft;
        private System.Windows.Forms.Button buttonScrollUp;
        private System.Windows.Forms.Button buttonScrollRight;
        private System.Windows.Forms.Button buttonScrollDown;
        private System.Windows.Forms.TabPage tabPageSignal;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label labelSound;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox textBoxSignalName;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Button buttonSignalChangeSound;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label labelSignalColor;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button buttonSignalDelete;
        private System.Windows.Forms.Button buttonSignalAdd;
        private System.Windows.Forms.TabPage tabPageOther;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.TabPage tabPageSave;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.Button buttonSaveAs;
        private System.Windows.Forms.Button buttonPrintPreview;
        private System.Windows.Forms.Button buttonPrint;
        private System.Windows.Forms.Button buttonPrintSetup;
        private System.Windows.Forms.TabPage tabPageGraph;
        public System.Windows.Forms.CheckBox checkBoxFullScreen;
        public System.Windows.Forms.Button buttonShowGraph;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label labelUpColor;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label labelDownColor;
        private System.Windows.Forms.TextBox textBoxYTitle;
        private System.Windows.Forms.TextBox textBoxXTitle;
        private System.Windows.Forms.TextBox textBoxTitle;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.Button buttonResetCurveData;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.NumericUpDown numericUpDownCurveWidth;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label labelCurveColor;
        private System.Windows.Forms.TextBox textBoxCurveName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.CheckBox checkBoxShowLegend;
        private System.Windows.Forms.CheckBox checkBoxShowXYTitles;
        private System.Windows.Forms.CheckBox checkBoxViewTitle;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TabPage tabPageCommunications;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button buttonRefresh;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.CheckedListBox checkedListBoxPorts;
        private System.Windows.Forms.Label labelT;
        private System.Windows.Forms.Label labelComName;
        private System.Windows.Forms.Label labelEps;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.NumericUpDown numericUpDownEpsilon;
        private System.Windows.Forms.Button buttonSetEpsilon;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Button buttonCommentDelete;
        public System.Windows.Forms.Button buttonCommentAdd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBoxComments;
        private System.Windows.Forms.CheckBox checkBoxCommentShift;
        private System.Windows.Forms.Button buttonCommentSave;
        private System.Windows.Forms.Label labelMinT;
        private System.Windows.Forms.Label labelMaxT;
        private System.Windows.Forms.ListBox listBoxCurves;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.NumericUpDown numericUpDownMin;
        private System.Windows.Forms.NumericUpDown numericUpDownMax;
        private System.Windows.Forms.NumericUpDown numericUpDownSignalMin;
        private System.Windows.Forms.NumericUpDown numericUpDownSignalMax;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FontDialog fontDialog;
        public System.Windows.Forms.Button buttonCommentSearch;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.NumericUpDown numericUpDownMuteTime;
        private System.Windows.Forms.CheckedListBox checkedListBoxSignals;
        private System.Windows.Forms.HelpProvider helpProvider;
        private System.Windows.Forms.CheckBox checkBoxMuteAllSounds;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label debugLabel;
    }
}