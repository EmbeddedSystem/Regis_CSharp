using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Regis2008.Properties;
using RegisNet;
using ZedGraph;

namespace Regis2008
{
    public partial class FormControl : Form
    {
        #region Переменные

        private byte b;

        public static List<Comment> comments = new List<Comment>();
        private readonly List<Curve> curves = new List<Curve>();
        private readonly Random rnd = new Random();
        private readonly RS232 temp = new RS232();
        private bool doNotExecuteEventCheckItem;
        public static byte state = 1;
        static int byteCounter;

        private Color downColor;
        public bool epsMustBeChanged;

        public FormGraph formGraph;
        private bool ignoreCheck = true;

        private GraphPane myPane;
        private int numberOfCopy;

        public bool shiftComent;
        private FormSplashScreen splashScreen;
        private DownloadForm downloadForm;
        private Color upColor;

        #endregion

        #region Инициализация

        public FormControl(int numberOfCopy)
        {
            InitializeComponent();

            Init(numberOfCopy);
        }

        public float Epsilon { get; private set; }

        private void Init(int numberOfCopyP)
        {
            numberOfCopy = numberOfCopyP;
            splashScreen = new FormSplashScreen(this);
            downloadForm = new DownloadForm(this);
            downloadForm.Hide();
            splashScreen.Show();
            formGraph = new FormGraph(this);
            RefreshPorts();
            myPane = formGraph.zgc.GraphPane;
            formGraph.Text = "#" + numberOfCopy + " " + formGraph.Text;
            notifyIcon.Text = "#" + numberOfCopy + " " + notifyIcon.Text;
            myPane.XAxis.Type = AxisType.Date;
            formGraph.zgc.IsShowPointValues = true;
            formGraph.zgc.IsShowContextMenu = false;

            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MajorGrid.IsZeroLine = false;

            notifyIcon.Text = formGraph.Text = myPane.Title.Text = "#" + numberOfCopy + " " + textBoxTitle.Text;
            // ReSharper disable DoNotCallOverridableMethodsInConstructor
            Text = "#" + numberOfCopy + " " + textBoxTitle.Text + " Панель управления";
            // ReSharper restore DoNotCallOverridableMethodsInConstructor
            myPane.XAxis.Title.Text = textBoxXTitle.Text;
            myPane.YAxis.Title.Text = textBoxYTitle.Text;

            checkBoxAutoscroll.Checked = true;
            formGraph.zgc.PointValueEvent += MyPointValueHandler;
            RefreshGraph();
            Epsilon = (float)numericUpDownEpsilon.Value;

            dateTimePicker1.CustomFormat = "dd/MM HH:mm:ss";
            dateTimePicker2.CustomFormat = "dd/MM HH:mm:ss";
        }

        private void FormControl_Load(object sender, EventArgs e)
        {
            formGraph.Show();
            upColor = downColor = myPane.Fill.Color;
        }

        #endregion

        #region Коммуникации

        private void RefreshPorts()
        {
            // запрещаем действия при изменении галочек у портов
            doNotExecuteEventCheckItem = true;
            buttonRefresh.Enabled = false;
            Cursor oldCursor = Cursor.Current;
            Cursor.Current = Cursors.WaitCursor;
            checkedListBoxPorts.BeginUpdate();

            // удаляем неподключенные порты из списка
            var tempArray = new List<RS232>();
            foreach (object port in checkedListBoxPorts.Items)
            {
                if (temp.IsPortAvailable(((RS232)port).SystemName) != CommBase.PortStatus.absent)
                {
                    try
                    {
                        if (((RS232)port).Online) tempArray.Add(port as RS232);
                    }
                    // ReSharper disable EmptyGeneralCatchClause
                    catch
                    {
                    }
                    // ReSharper restore EmptyGeneralCatchClause
                }
            }
            checkedListBoxPorts.Items.Clear();
            checkedListBoxPorts.Items.AddRange(tempArray.ToArray());
            for (int i = 0; i < checkedListBoxPorts.Items.Count; i++)
            {
                checkedListBoxPorts.SetItemChecked(i, true);
            }


            for (int i = 0; (i <= 256); i++)
            {
                progressBar1.Value = i;
                if (temp.IsPortAvailable("COM" + i) == CommBase.PortStatus.available)
                {
                    var port = new RS232 { SystemName = ("COM" + i), VisibleName = ("COM" + i) };
                    checkedListBoxPorts.Items.Add(port);
                }
            }


            checkedListBoxPorts.EndUpdate();
            buttonRefresh.Enabled = true;
            progressBar1.Value = 0;
            Cursor.Current = oldCursor;

            doNotExecuteEventCheckItem = false;
        }

        private void checkedListBoxPorts_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (ignoreCheck)
            {
                e.NewValue = e.CurrentValue;
                return;
            }
            if (!doNotExecuteEventCheckItem)
            {
                if (e.CurrentValue == CheckState.Unchecked)
                {
                    var port = checkedListBoxPorts.Items[e.Index] as RS232;
                    if (port != null)
                    {
                        if (port.Online) return;
                        try
                        {
                            port.Connected += port_Connected;
                            port.Disconnected += port_Disconnected;
                            port.ByteReceived += port_ByteReceived;
                            port.ErrorReceived += new RS232.EventHandler(port_ErrorReceived);
                            port.Open();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Не удалось открыть порт " + port.SystemName, x.Message);
                            RefreshPorts();
                        }
                    }
                }
                else if (e.CurrentValue == CheckState.Checked)
                {
                    var port = (checkedListBoxPorts.Items[e.Index] as RS232);
                    if (port != null)
                    {
                        if (!port.Online) return;
                        try
                        {
                            port.Connected -= port_Connected;
                            port.ByteReceived -= port_ByteReceived;

                            port.Close();
                        }
                        catch (Exception x)
                        {
                            MessageBox.Show("Не удалось закрыть порт " + port.SystemName, x.Message);
                            RefreshPorts();
                        }
                    }
                }
            }
        }

        private void checkedListBoxPorts_MouseClick(object sender, MouseEventArgs e)
        {
            ignoreCheck = e.X > SystemInformation.MenuCheckSize.Width;
        }

        private void checkedListBoxPorts_MouseUp(object sender, MouseEventArgs e)
        {
            ignoreCheck = false;
        }

        private void checkedListBoxPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkedListBoxPorts.SelectedItem != null)
            {
                labelEps.Text = "ε = ....";
                labelT.Text = ".....°C";
                labelMinT.Text = "min....";
                labelMaxT.Text = "max....";
                labelComName.Text = ((RS232)checkedListBoxPorts.SelectedItem).SystemName + ":";
                ((RS232)checkedListBoxPorts.SelectedItem).pirometer.epsMustBeChanged = false;
            }
        }

        private void port_Connected(object sender, EventArgs e)
        {
            var port = (RS232)sender;
            LineItem line = myPane.AddCurve(port.SystemName, port.pirometer.points, Color.Red, SymbolType.None);
            port.pirometer.curve = new Curve(line, port.SystemName);
            curves.Add(port.pirometer.curve);
            port.pirometer.curve.LineItem.MakeUnique();
            port.pirometer.curve.LineItem.Symbol.Type = SymbolType.None;
            listBoxCurves.DataSource = null;
            listBoxCurves.DataSource = curves;
            port.pirometer.SaveToFile(7777, 7.77f, port.SystemName);
            RefreshGraph();
        }

        private void port_Disconnected(object sender, EventArgs e)
        {
            var port = (RS232)sender;
            port.Disconnected -= port_Disconnected;
            port.pirometer.curve.LineItem.Clear();
            myPane.CurveList.Remove(port.pirometer.curve.LineItem);
            curves.Remove(port.pirometer.curve);
            listBoxCurves.DataSource = null;
            listBoxCurves.DataSource = curves;
            RefreshGraph();
            textBoxCurveName.Text = "";
            port.pirometer.CloseFile();
        }

        private static void port_ErrorReceived(object sender, EventArgs e)
        {
            if (!((RS232)sender).Online)
            {
                MessageBox.Show("Произошло отключение порта: " + ((RS232)sender).SystemName);
            }
            else
            {
                MessageBox.Show("Ошибка порта: " + ((RS232)sender).SystemName);
                ((RS232)sender).Close();
                ((RS232)sender).Open();
            }
        }

        private void port_ByteReceived(object sender, EventArgs e)
        {
            BeginInvoke(new EventHandler(delegate
                                             {
                                                 ReceiveStringFSM((RS232)sender, ((RS232)sender).receivedChar);
                                             }
                            ));
        }




        private void ReceiveStringFSM(RS232 device, byte receivedByte)
        {
            switch (state)
            {
                // Исходное состояние: ждем '#' или '='
                case 1:
                    if (receivedByte == '=')
                    {
                        state = 2;
                        byteCounter = 0;
                        device.receivedTemp[byteCounter] = receivedByte;
                        byteCounter++;
                    }
                    else if (receivedByte == '#')
                    {
                        state = 3;
                        byteCounter = 0;
                        device.receivedMem[byteCounter] = receivedByte;
                        byteCounter++;
                    }
                    break;
                // Прием строки температуры
                case 2:
                    {
                        if (byteCounter <= 12)
                        {
                            if (receivedByte == 0)
                            {
                                device.receivedTemp[byteCounter] = 0x30;
                            }
                            else
                            {
                                device.receivedTemp[byteCounter] = receivedByte;
                            }
                            byteCounter++;
                        }
                        else
                        {
                            TemperatureReceived(device, Encoding.ASCII.GetString(device.receivedTemp));
                            byteCounter = 0;
                            state = 1;
                        }
                    }
                    break;
                case 3:
                    downloadForm.label1.Text = "Загрузка памяти замеров прибора...";
                    downloadForm.timerTimeoutByte.Enabled = true;
                    // Если второй байт - 7 то это новый прибор, если 0 - старый, иначе ошибка
                    if (receivedByte == '7')
                    {
                        state = 4;
                        // новый прибор - 32035 байт
                        downloadForm.progressBar1.Maximum = 32037;
                        downloadForm.progressBar1.Value = 2;
                        downloadForm.Show();
                        device.receivedMem[byteCounter] = receivedByte;
                        byteCounter++;
                    }
                    else
                    {
                        state = 5;
                        // старый прибор - 10035 байт
                        downloadForm.progressBar1.Maximum = 10037;
                        downloadForm.progressBar1.Value = 2;
                        downloadForm.Show();
                        device.receivedMem[byteCounter] = receivedByte;
                        byteCounter++;
                    }
                    break;
                case 4:
                    device.receivedMem[byteCounter] = receivedByte;
                    byteCounter++;
                    downloadForm.progressBar1.Value++;
                    downloadForm.timerTimeoutByte.Stop();
                    downloadForm.timerTimeoutByte.Start();
                    if (byteCounter >= 32037)
                    {
                        state = 1;
                        if ((CRC_HIGH_FOR_NEW(device) == device.receivedMem[32034]) && (CRC_LOW_FOR_NEW(device) == device.receivedMem[32033]))
                        {
                            downloadForm.timerTimeoutByte.Stop();
                            downloadForm.label1.Text = "Загрузка завершена!";

                        }
                        else
                        {
                            downloadForm.timerTimeoutByte.Stop();
                            downloadForm.label1.Text = "ОШИБКА ДАННЫХ CRC!";
                        }
                        downloadForm.timer1.Enabled = true;
                    }
                    break;
                case 5:
                    device.receivedMem[byteCounter] = receivedByte;
                    byteCounter++;
                    downloadForm.progressBar1.Value++;
                    downloadForm.timerTimeoutByte.Stop();
                    downloadForm.timerTimeoutByte.Start();
                    if (byteCounter >= 10037)
                    {
                        state = 1;
                        if ((CRC_HIGH_FOR_OLD(device) == device.receivedMem[10034]) && (CRC_LOW_FOR_OLD(device) == device.receivedMem[10033]))
                        {
                            downloadForm.timerTimeoutByte.Stop();
                            downloadForm.label1.Text = "Загрузка завершена!";
                            device.pirometer.SaveMemoryToFileOld(";;;" + DateTime.Now.Hour + ':'+ DateTime.Now.Minute + ':'+DateTime.Now.Second, device.pirometer.Port.SystemName);

                        }
                        else
                        {
                            downloadForm.timerTimeoutByte.Stop();
                            downloadForm.label1.Text = "ОШИБКА ДАННЫХ CRC!";

                            b = CRC_HIGH_FOR_OLD(device);
                            b = CRC_LOW_FOR_OLD(device);

                            b = device.receivedMem[10030];
                            b = device.receivedMem[10031];
                            b = device.receivedMem[10032];
                            b = device.receivedMem[10033];
                            b = device.receivedMem[10034];
                            b = device.receivedMem[10035];
                            b = device.receivedMem[10036];




                        }
                        downloadForm.timer1.Enabled = true;
                    }
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
                    break;
                case 9:
                    break;
                default:
                    return;

            }
        }

        private void TemperatureReceived(RS232 sender, string received)
        {
            float t;
            float eps;

            if (string.IsNullOrEmpty(received) || received.Length != 13)
            {
                return;
            }
            else if (!CheckCRC(received))
            {
                t = 1999f;
                eps = 1.00f;
            }
            else
            {
                t = GetTemperatureFromString(received);
                eps = GetEpsilonFromString(received);
            }

            SetIconDataOK(((RS232)sender).SystemName);

            foreach (Signal signal in signals)
            {
                if (signal.Enabled) signal.CheckValueForSignal(t);
            }

            ((RS232)sender).pirometer.SaveToFile(t, eps,
                                                  ((RS232)sender).SystemName);

            ((RS232)sender).pirometer.points.Add(new XDate(DateTime.Now), t);
            RefreshGraph();
            ((RS232)sender).pirometer.T = t;

            if (checkedListBoxPorts.SelectedItem == sender)
            {
                labelComName.Text = ((RS232)sender).SystemName + ":";
                labelEps.Text = "ε = " + eps.ToString("f2");

                // отображение температур без десятых
                if (!received.Substring(8, 4).Contains(".") ||
                    (received.Substring(8, 4)[0] == '-' &&
                     !char.IsNumber(received.Substring(8, 4), 3)))
                {
                    if (t == 2000f)
                    {
                        FindMaximum((RS232)sender, t);
                        labelT.Text = ">>>>";
                        labelMaxT.Text = "max " + ">>>>";
                    }
                    else if (t == -50f)
                    {
                        FindMinimum((RS232)sender, t);
                        labelT.Text = "<<<<";
                        labelMinT.Text = "min " + "<<<<";
                    }
                    else if (t == 1999f)
                    {
                        labelT.Text = "ERROR";
                    }
                    else
                    {
                        labelT.Text = t.ToString("f0") + "°C";
                        labelMinT.Text = "min " +
                                         FindMinimum((RS232)sender, t).ToString(
                                             "f0") + "°C";
                        labelMaxT.Text = "max " +
                                         FindMaximum((RS232)sender, t).ToString(
                                             "f0") + "°C";
                    }
                }

                    // отображение температур с десятыми
                else
                {
                    {
                        if (t == 2000f)
                        {
                            FindMaximum((RS232)sender, t);
                            labelT.Text = ">>>>";
                            labelMaxT.Text = "max " + ">>>>";
                        }
                        else if (t == -50f)
                        {
                            FindMinimum((RS232)sender, t);
                            labelT.Text = "<<<<";
                            labelMinT.Text = "min " + "<<<<";
                        }
                        else if (t == 1999f)
                        {
                            labelT.Text = "ERROR";
                        }
                        else
                        {
                            labelT.Text = t.ToString("f1") + "°C";
                            labelMinT.Text = "min " +
                                             FindMinimum((RS232)sender, t).
                                                 ToString("f1") + "°C";
                            labelMaxT.Text = "max " +
                                             FindMaximum((RS232)sender, t).
                                                 ToString("f1") + "°C";
                        }
                    }
                }
            }

            if (((RS232)sender).pirometer.epsMustBeChanged)
            {
                if (string.IsNullOrEmpty(received) || received.Length != 13)
                    return;

                if (eps != ((RS232)sender).pirometer.epsilon)
                {
                    byte[] transmitBuf = {
                                                                                  35,
                                                                                  (byte) received[1],
                                                                                  (byte) received[2],
                                                                                  (byte) received[3],
                                                                                  (byte) received[4],
                                                                                  65,
                                                                                  GetEHigh(
                                                                                      ((RS232) sender).pirometer.epsilon)
                                                                                  ,
                                                                                  GetELow(
                                                                                      ((RS232) sender).pirometer.epsilon)
                                                                                  ,
                                                                                  0,
                                                                                  13,
                                                                                  10
                                                                              };
                    transmitBuf[8] = GetC(transmitBuf, 0, 7);


                    ((RS232)sender).Write(transmitBuf);
                }
                else ((RS232)sender).pirometer.epsMustBeChanged = false;
            }
        }

        private static byte CRC_LOW_FOR_OLD(RS232 device)
        {
            byte CRC = 0;
            for (int i = 2; i <= 10030; i += 2)
            {
                CRC = (byte)(CRC ^ device.receivedMem[i]);
            }

            if ((CRC >= 0) && (CRC <= 9))
            {
                CRC += 0x30;
            }
            else if ((CRC >= 10) && (CRC <= 15))
            {
                CRC += 0x37;
            }
            return CRC;
        }

        private static byte CRC_HIGH_FOR_OLD(RS232 device)
        {
            byte CRC = 0;
            int i = 1;

            while ( i < 10033 )
            {
                CRC = (byte)(CRC ^ device.receivedMem[i]);
                i += 2;
            }
            if ((CRC >= 0) && (CRC <= 9))
            {
                CRC += 0x30;
            }
            else if ((CRC >= 10) && (CRC <= 15))
            {
                CRC += 0x37;
            }
            return CRC;
        }

        private static byte CRC_LOW_FOR_NEW(RS232 device)
        {
            byte CRC = 0;
            for (int i = 2; i <= 32030; i += 2)
            {
                CRC = (byte)(CRC ^ device.receivedMem[i]);
            }
            if ((CRC >= 0) && (CRC <= 9))
            {
                CRC += 0x30;
            }
            else if ((CRC >= 10) && (CRC <= 15))
            {
                CRC += 0x37;
            }
            return CRC;
        }

        private static byte CRC_HIGH_FOR_NEW(RS232 device)
        {
            byte CRC = 0;
            for (int i = 1; i <= 32029; i += 2)
            {
                CRC = (byte)(CRC ^ device.receivedMem[i]);
            }
            if ((CRC >= 0) && (CRC <= 9))
            {
                CRC += 0x30;
            }
            else if ((CRC >= 10) && (CRC <= 15))
            {
                CRC += 0x37;
            }
            return CRC;
        }

        public void ResetState()
        {
            state = 1;
        }

        private static bool CheckCRC(string s)
        {
            byte[] receiveBuf = Encoding.ASCII.GetBytes(s);
            return (receiveBuf[12] == GetC(receiveBuf, 0, 11));
        }

        private static byte GetC(byte[] arg, int begin, int end)
        {
            byte C = 0;
            for (int i = begin; i <= end; i++)
            {
                C = (byte)(arg[i] ^ C);
            }
            uint CRC1 = C;
            uint CRC2 = CRC1 >> 4;
            CRC1 = CRC1 & 0x000F;
            CRC1 = CRC1 ^ CRC2;
            if (CRC1 >= 0 && CRC1 <= 9) CRC1 = CRC1 + 48;
            else if (CRC1 >= 10 && CRC1 <= 15) CRC1 = CRC1 + 55;
            return (byte)CRC1;
        }

        private static byte GetEHigh(float arg)
        {
            if (arg < 0.01f) arg = 0.01f;
            else if (arg > 1.00f) arg = 1.00f;
            int temp = ((int)Math.Round(arg * 100)) - 1;
            temp = temp / 10;
            if (temp >= 0 && temp <= 9) temp = temp + 48;
            else if (temp >= 10 && temp <= 15) temp = temp + 55;
            return (byte)temp;
        }

        private static byte GetELow(float arg)
        {
            if (arg < 0.01f) arg = 0.01f;
            else if (arg > 1.00f) arg = 1.00f;
            int temp = ((int)Math.Round(arg * 100)) - 1;
            temp = temp % 10;
            if (temp >= 0 && temp <= 9) temp = temp + 48;
            else if (temp >= 10 && temp <= 15) temp = temp + 55;
            return (byte)temp;
        }

        private static float GetTemperatureFromString(string t)
        {
            try
            {
                string s = t.Substring(8, 4);
                if (s == ">>>>") return 2000f;
                if (s == "<<<<") return -50f;
                if (s == "-0.0") return 0f;
                s = s.Replace('F', ' ');

                if (s[0] == '-')
                {
                    s = s.Insert(3, ",");
                    s = s.Substring(1, 4);
                    return float.Parse(s) * -1.0f;
                }
                s = s.Replace('.', ',');
                return float.Parse(s);
            }
            catch
            {
                //MessageBox.Show("Не удалось распознать T, число " + t);
                return 1999f;
            }
        }

        private static float GetEpsilonFromString(string e)
        {
            try
            {
                return (Convert.ToSingle(e.Substring(6, 2)) + 1) / 100;
            }
            catch
            {
                //MessageBox.Show("Не удалось распознать E, число " + e);
                return 1.0f;
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            RefreshPorts();
        }

        private void buttonSetEpsilon_Click(object sender, EventArgs e)
        {
            if (checkedListBoxPorts.SelectedItem != null)
            {
                ((RS232)checkedListBoxPorts.SelectedItem).pirometer.epsilon = (float)numericUpDownEpsilon.Value;
                ((RS232)checkedListBoxPorts.SelectedItem).pirometer.epsMustBeChanged = true;
            }
        }

        private static float FindMinimum(RS232 port, float t)
        {
            if (port.pirometer.Tmin > t) port.pirometer.Tmin = t;
            return port.pirometer.Tmin;
        }

        private static float FindMaximum(RS232 port, float t)
        {
            if (port.pirometer.Tmax < t) port.pirometer.Tmax = t;
            return port.pirometer.Tmax;
        }

        private void labelMaxT_Click(object sender, EventArgs e)
        {
            if (labelT.Text != ".....°C")
            {
                if (checkedListBoxPorts.SelectedItem != null)
                {
                    ((RS232)checkedListBoxPorts.SelectedItem).pirometer.Tmax =
                        ((RS232)checkedListBoxPorts.SelectedItem).pirometer.T;

                    labelMaxT.Text = "max " + ((RS232)checkedListBoxPorts.SelectedItem).pirometer.Tmax.ToString("f1") +
                                     "°C";
                }
            }
        }

        private void labelMinT_Click(object sender, EventArgs e)
        {
            if (labelT.Text != ".....°C")
            {
                if (checkedListBoxPorts.SelectedItem != null)
                {
                    ((RS232)checkedListBoxPorts.SelectedItem).pirometer.Tmin =
                        ((RS232)checkedListBoxPorts.SelectedItem).pirometer.T;

                    labelMinT.Text = "min " + ((RS232)checkedListBoxPorts.SelectedItem).pirometer.Tmin.ToString("f1") +
                                     "°C";
                }
            }
        }

        #endregion

        #region График

        private void checkBoxFullScreen_CheckedChanged(object sender, EventArgs e)
        {
            if (formGraph.fullscreen)
            {
                formGraph.FormBorderStyle = FormBorderStyle.Sizable;
                formGraph.WindowState = FormWindowState.Normal;
                formGraph.fullscreen = false;
            }
            else
            {
                formGraph.FormBorderStyle = FormBorderStyle.None;
                formGraph.WindowState = FormWindowState.Maximized;
                formGraph.fullscreen = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (buttonShowGraph.Text == "Показать график")
            {
                formGraph.Show();
                buttonShowGraph.Text = "Скрыть график";
            }
            else
            {
                formGraph.Hide();
                buttonShowGraph.Text = "Показать график";
            }
        }

        public void RefreshGraph()
        {
            formGraph.zgc.AxisChange();
            formGraph.zgc.Invalidate();
            formGraph.zgc.Update();
        }

        private static string MyPointValueHandler(object sender, GraphPane pane, CurveItem curve, int iPt)
        {
            PointPair pt = curve[iPt];
            return "Время: " + ((XDate)pt.X).ToString("HH:mm:ss.fff") + "\r\n" + "Температура: " + pt.Y.ToString("f1") +
                   " °C";
        }

        private void labelDownColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                upColor =
                    labelDownColor.BackColor = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                myPane.Chart.Fill = new Fill(downColor, upColor, 90);
                RefreshGraph();
            }
            else
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    upColor = labelDownColor.BackColor = colorDialog.Color;
                    myPane.Chart.Fill = new Fill(downColor, upColor, 90);
                    RefreshGraph();
                }
            }
        }

        private void labelUpColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                downColor =
                    labelUpColor.BackColor = Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                myPane.Chart.Fill = new Fill(downColor, upColor, 90);
                RefreshGraph();
            }
            else
            {
                if (colorDialog.ShowDialog() == DialogResult.OK)
                {
                    downColor = labelUpColor.BackColor = colorDialog.Color;
                    myPane.Chart.Fill = new Fill(downColor, upColor, 90);
                    RefreshGraph();
                }
            }
        }

        private void checkBoxViewTitle_CheckedChanged(object sender, EventArgs e)
        {
            myPane.Title.IsVisible = checkBoxViewTitle.Checked;
            RefreshGraph();
        }

        private void textBoxTitle_TextChanged(object sender, EventArgs e)
        {
            notifyIcon.Text = formGraph.Text = myPane.Title.Text = "#" + numberOfCopy + " " + textBoxTitle.Text;
            Text = "#" + numberOfCopy + " " + textBoxTitle.Text + " Панель управления";
            RefreshGraph();
        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {
            myPane.Legend.IsVisible = checkBoxShowLegend.Checked;
            RefreshGraph();
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Title.IsVisible = myPane.YAxis.Title.IsVisible = checkBoxShowXYTitles.Checked;
            RefreshGraph();
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Title.Text = textBoxXTitle.Text;
            RefreshGraph();
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Title.Text = textBoxYTitle.Text;
            RefreshGraph();
        }

        #region Кривые

        private void listBoxCurves_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxCurves.SelectedIndex != -1)
            {
                textBoxCurveName.Text = listBoxCurves.SelectedItem.ToString();
                numericUpDownCurveWidth.Value = (decimal)((Curve)listBoxCurves.SelectedItem).LineItem.Line.Width;
                labelCurveColor.BackColor = ((Curve)listBoxCurves.SelectedItem).LineItem.Line.Color;
            }
        }

        private void textBoxCurveName_TextChanged(object sender, EventArgs e)
        {
            if (listBoxCurves.SelectedIndex != -1)
            {
                ((Curve)listBoxCurves.SelectedItem).LineItem.Label.Text = textBoxCurveName.Text;
                listBoxCurves.DataSource = null;
                listBoxCurves.DataSource = curves;
                RefreshGraph();
            }
        }

        private void numericUpDownCurveWidth_ValueChanged(object sender, EventArgs e)
        {
            if (listBoxCurves.SelectedIndex != -1)
            {
                ((Curve)listBoxCurves.SelectedItem).LineItem.Line.Width = (float)numericUpDownCurveWidth.Value;
                RefreshGraph();
            }
        }

        private void labelCurveColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (listBoxCurves.SelectedIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    labelCurveColor.BackColor =
                        ((Curve)listBoxCurves.SelectedItem).LineItem.Line.Color =
                        Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    RefreshGraph();
                }
                else
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        labelCurveColor.BackColor =
                            ((Curve)listBoxCurves.SelectedItem).LineItem.Line.Color = colorDialog.Color;
                        RefreshGraph();
                    }
                }
            }
        }

        private void buttonResetCurveData_Click(object sender, EventArgs e)
        {
            if (listBoxCurves.SelectedIndex != -1) ((Curve)listBoxCurves.SelectedItem).LineItem.Clear();
            RefreshGraph();
        }

        #endregion

        #endregion

        #region Вид

        private void button2_Click(object sender, EventArgs e)
        {
            checkBoxAutoscroll.Checked = false;
            double delta = (myPane.YAxis.Scale.Max - myPane.YAxis.Scale.Min) / 20;
            myPane.YAxis.Scale.Min -= delta;
            myPane.YAxis.Scale.Max -= delta;
            RefreshGraph();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            checkBoxAutoscroll.Checked = false;
            double delta = (myPane.YAxis.Scale.Max - myPane.YAxis.Scale.Min) / 20;
            myPane.YAxis.Scale.Min += delta;
            myPane.YAxis.Scale.Max += delta;
            RefreshGraph();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBoxAutoscroll.Checked = false;
            double delta = (myPane.XAxis.Scale.Max - myPane.XAxis.Scale.Min) / 20;
            myPane.XAxis.Scale.Min -= delta;
            myPane.XAxis.Scale.Max -= delta;
            RefreshGraph();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            checkBoxAutoscroll.Checked = false;
            double delta = (myPane.XAxis.Scale.Max - myPane.XAxis.Scale.Min) / 20;
            myPane.XAxis.Scale.Min += delta;
            myPane.XAxis.Scale.Max += delta;
            RefreshGraph();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            checkBoxAutoscroll.Checked = false;
            formGraph.zgc.ZoomPane(myPane, 1.1f, new PointF(), false);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            checkBoxAutoscroll.Checked = false;
            formGraph.zgc.ZoomPane(myPane, 0.9f, new PointF(), false);
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxAutoscroll.Checked)
            {
                checkBoxXMinAuto.Checked = true;
                checkBoxXMaxAuto.Checked = true;
                checkBoxYMinAuto.Checked = true;
                checkBoxYMaxAuto.Checked = true;
            }
            else
            {
                checkBoxXMinAuto.Checked = false;
                checkBoxXMaxAuto.Checked = false;
                checkBoxYMinAuto.Checked = false;
                checkBoxYMaxAuto.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            formGraph.zgc.IsEnableHZoom = checkBoxScrollX.Checked;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            formGraph.zgc.IsEnableVZoom = checkBoxScrollY.Checked;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            formGraph.zgc.ZoomOutAll(myPane);
        }

        private void button21_Click(object sender, EventArgs e)
        {
            formGraph.zgc.RestoreScale(myPane);
        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.FormatAuto = checkBoxXFormatAuto.Checked;
        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.MajorStepAuto = checkBoxXMajorGridAuto.Checked;
        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.MinAuto = checkBoxXMinAuto.Checked;
        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.MinorStepAuto = checkBoxXMinorGridAuto.Checked;
        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.MaxAuto = checkBoxXMaxAuto.Checked;
        }

        private void checkBox18_CheckedChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.FormatAuto = checkBoxYFormatAuto.Checked;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.MajorStepAuto = checkBoxYMajorGridAuto.Checked;
        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.MinAuto = checkBoxYMinAuto.Checked;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.MinorStepAuto = checkBoxYMinorGridAuto.Checked;
        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.MaxAuto = checkBoxYMaxAuto.Checked;
        }

        #endregion

        #region Сигнализация

        private readonly List<Signal> signals = new List<Signal>();

        private void buttonSignalAdd_Click(object sender, EventArgs e)
        {
            var item = new Signal(myPane, this);
            signals.Add(item);
            checkedListBoxSignals.DataSource = null;
            checkedListBoxSignals.DataSource = signals;
            CheckItemsSignals();
        }

        private void buttonSignalDelete_Click(object sender, EventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                var item = (Signal)checkedListBoxSignals.SelectedItem;
                item.DeleteFromGraph();
                signals.Remove(item);
                checkedListBoxSignals.DataSource = null;
                checkedListBoxSignals.DataSource = signals;
                RefreshGraph();
                CheckItemsSignals();
            }
            else
            {
                textBoxSignalName.Text = "";
                labelSound.Text = "";
                numericUpDownSignalMin.Value = 0;
                numericUpDownSignalMax.Value = 0;
                labelSignalColor.BackColor = Color.LightYellow;
            }
        }

        private void buttonSignalChangeSound_Click(object sender, EventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                    ((Signal)checkedListBoxSignals.SelectedItem).Sound = openFileDialog.FileName;

                labelSound.Text = string.IsNullOrEmpty(((Signal)checkedListBoxSignals.SelectedItem).Sound)
                                      ? "Звук: нет"
                                      : ((Signal)checkedListBoxSignals.SelectedItem).Sound;
            }
        }

        private void checkedListBoxSignals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (doNotExecuteEventCheckItem) return;
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                labelSignalColor.BackColor = ((Signal)checkedListBoxSignals.SelectedItem).Color;
                textBoxSignalName.Text = ((Signal)checkedListBoxSignals.SelectedItem).Name;
                numericUpDownSignalMin.Value = (decimal)((Signal)checkedListBoxSignals.SelectedItem).Min;
                numericUpDownSignalMax.Value = (decimal)((Signal)checkedListBoxSignals.SelectedItem).Max;
                labelSound.Text = string.IsNullOrEmpty(((Signal)checkedListBoxSignals.SelectedItem).Sound)
                                      ? "Звук: нет"
                                      : ((Signal)checkedListBoxSignals.SelectedItem).Sound;
            }
            else
            {
                if (checkedListBoxSignals.Items.Count == 0)
                {
                    textBoxSignalName.Text = "";
                    labelSound.Text = "";
                    labelSignalColor.BackColor = Color.LightYellow;
                    numericUpDownSignalMin.Value = 0;
                    numericUpDownSignalMax.Value = 0;
                }
            }
        }

        private void CheckItemsSignals()
        {
            if (checkedListBoxSignals != null) checkedListBoxSignals.ItemCheck -= checkedListBoxSignals_ItemCheck;
            for (int i = 0; i < signals.Count; i++)
            {
                if (signals[i].Enabled) checkedListBoxSignals.SetItemChecked(i, true);
            }
            checkedListBoxSignals.ItemCheck += checkedListBoxSignals_ItemCheck;
        }

        private void textBoxSignalName_TextChanged(object sender, EventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                ((Signal)checkedListBoxSignals.SelectedItem).Name = textBoxSignalName.Text;
                checkedListBoxSignals.DataSource = null;
                checkedListBoxSignals.DataSource = signals;
            }
        }

        #endregion

        #region Комментарии

        private void buttonCommentAdd_Click(object sender, EventArgs e)
        {
            buttonCommentAdd.Enabled = false;
            checkBoxCommentShift.Checked = true;
            var myText = new Comment("Новый комментарий", 0.5, 0.5, CoordType.PaneFraction);
            myText.textObj.IsClippedToChartRect = true;
            myText.textObj.FontSpec.Border.Color = Color.Blue;
            myText.textObj.FontSpec.FontColor = Color.Black;
            myText.textObj.Location.AlignH = AlignH.Center;
            myText.textObj.Location.AlignV = AlignV.Center;
            myPane.GraphObjList.Insert(0, myText.textObj);
            myPane.GraphObjList.Move(myPane.GraphObjList.IndexOf(myText.textObj), 0);
            RefreshGraph();
            comments.Add(myText);
            listBoxComments.DataSource = null;
            listBoxComments.DataSource = comments;
        }

        private void buttonCommentDelete_Click(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedItem != null)
            {
                textBoxComment.Text = "";
                myPane.GraphObjList.Remove(((Comment)listBoxComments.SelectedItem).textObj);
                comments.Remove((Comment)listBoxComments.SelectedItem);
                listBoxComments.DataSource = null;
                listBoxComments.DataSource = comments;
                RefreshGraph();
            }
        }

        private void checkBoxCommentShift_CheckedChanged(object sender, EventArgs e)
        {
            shiftComent = checkBoxCommentShift.Checked;
        }

        private void buttonCommentFont_Click(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedIndex != -1)
            {
                if (DialogResult.OK == fontDialog.ShowDialog())
                {
                    ((Comment)listBoxComments.SelectedItem).textObj.FontSpec.Size = fontDialog.Font.Size;
                    ((Comment)listBoxComments.SelectedItem).textObj.FontSpec.Family = fontDialog.Font.FontFamily.Name;
                    ((Comment)listBoxComments.SelectedItem).textObj.FontSpec.IsBold = fontDialog.Font.Bold;
                    ((Comment)listBoxComments.SelectedItem).textObj.FontSpec.IsItalic = fontDialog.Font.Italic;
                    ((Comment)listBoxComments.SelectedItem).textObj.FontSpec.IsUnderline = fontDialog.Font.Underline;
                    RefreshGraph();
                }
            }
        }

        private void buttonCommentSearch_Click(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedIndex != -1)
            {
                buttonCommentSearch.Enabled = false;

                checkBoxXMinAuto.Checked = false;
                checkBoxXMaxAuto.Checked = false;
                checkBoxYMinAuto.Checked = false;
                checkBoxYMaxAuto.Checked = false;

                ((Comment)listBoxComments.SelectedValue).oldColor =
                    ((Comment)listBoxComments.SelectedValue).textObj.FontSpec.Border.Color;
                ((Comment)listBoxComments.SelectedValue).textObj.FontSpec.Border.Color = Color.Red;
                ((Comment)listBoxComments.SelectedValue).textObj.ZOrder = ZOrder.A_InFront;
                myPane.GraphObjList.Move(
                    myPane.GraphObjList.IndexOf(((Comment)listBoxComments.SelectedValue).textObj), 0);
                double x = ((Comment)listBoxComments.SelectedValue).textObj.Location.X;
                double y = ((Comment)listBoxComments.SelectedValue).textObj.Location.Y;
                checkBoxAutoscroll.Checked = false;
                formGraph.zgc.ZoomPane(myPane, 1.0, ZedGraph.Location.Transform(myPane, x, y, CoordType.AxisXYScale),
                                       true);
                formGraph.timerSearchLighting.Enabled = true;
                formGraph.TopMost = true;
                formGraph.Show();
                formGraph.TopMost = false;
            }
        }

        #endregion

        #region Сохранить

        private void button7_Click(object sender, EventArgs e)
        {
            formGraph.zgc.DoPageSetup();
        }

        private void button22_Click(object sender, EventArgs e)
        {
            formGraph.zgc.DoPrintPreview();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            formGraph.zgc.DoPrint();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            formGraph.zgc.SaveAs();
        }

        #endregion

        #region О программе

        #endregion

        #region Значок в трее

        private void timerIcon_Tick(object sender, EventArgs e)
        {
            labelComName.BackColor = Color.White;
            notifyIcon.Icon = Resources.New;
            timerIcon.Enabled = false;
        }

        public void SetIconDataOK(string portName)
        {
            if (portName + ":" == labelComName.Text) labelComName.BackColor = Color.LightGreen;
            notifyIcon.Icon = Resources.eventlogInfo;
            timerIcon.Enabled = true;
        }

        public void SetIconWarning()
        {
            notifyIcon.Icon = Resources.warning;
            timerIcon.Enabled = true;
        }

        public void SetIconError()
        {
            notifyIcon.Icon = Resources.error;
            timerIcon.Enabled = true;
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            formGraph.Show();
            formGraph.WindowState = FormWindowState.Normal;
            Show();
            WindowState = FormWindowState.Normal;
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (object port in checkedListBoxPorts.Items)
            {
                ((RS232)port).Close();
            }
            Application.Exit();
        }

        private void развернутьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
            Show();
            WindowState = FormWindowState.Normal;
            TopMost = false;
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            switch (
                MessageBox.Show("Да - закрыть, Нет - свернуть в трей", "Вы хотите закрыть программу?",
                                MessageBoxButtons.YesNoCancel))
            {
                case DialogResult.Yes:
                    foreach (object port in checkedListBoxPorts.Items)
                    {
                        ((RS232)port).Close();
                    }
                    Application.Exit();
                    break;
                case DialogResult.No:
                    base.OnClosing(e);
                    e.Cancel = true;
                    Hide();
                    formGraph.Hide();
                    break;
                case DialogResult.Cancel:
                    base.OnClosing(e);
                    e.Cancel = true;
                    break;
            }
        }

        private void скрытьПанельУправленияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            WindowState = FormWindowState.Minimized;
        }

        private void развернутьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TopMost = true;
            formGraph.Show();
            formGraph.WindowState = FormWindowState.Normal;
            TopMost = false;
        }

        private void скрытьГрафикToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formGraph.Hide();
            formGraph.WindowState = FormWindowState.Minimized;
        }

        #endregion

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.Max = (float)numericUpDownMax.Value;
            RefreshGraph();
        }

        private void numericUpDownMin_ValueChanged(object sender, EventArgs e)
        {
            myPane.YAxis.Scale.Min = (float)numericUpDownMin.Value;
            RefreshGraph();
        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                if (numericUpDownSignalMin.Value >= numericUpDownSignalMax.Value)
                    numericUpDownSignalMax.Value = numericUpDownSignalMin.Value;
                ((Signal)checkedListBoxSignals.SelectedItem).Max = (float)numericUpDownSignalMax.Value;
                RefreshGraph();
            }
        }

        private void numericUpDownSignalMin_ValueChanged(object sender, EventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                if (numericUpDownSignalMin.Value >= numericUpDownSignalMax.Value)
                    numericUpDownSignalMin.Value = numericUpDownSignalMax.Value;
                ((Signal)checkedListBoxSignals.SelectedItem).Min = (float)numericUpDownSignalMin.Value;
                RefreshGraph();
            }
        }

        private void textBoxComment_TextChanged(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedIndex != -1)
            {
                ((Comment)listBoxComments.SelectedValue).Text = textBoxComment.Text;
                listBoxComments.DataSource = null;
                listBoxComments.DataSource = comments;
                RefreshGraph();
            }
        }

        private void listBoxComments_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxComments.SelectedIndex != -1)
                textBoxComment.Text = ((Comment)listBoxComments.SelectedValue).Text;
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                ((Signal)checkedListBoxSignals.SelectedItem).mute = false;
                ((Signal)checkedListBoxSignals.SelectedItem).Play();
            }
        }

        private void labelSignalColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (checkedListBoxSignals.SelectedIndex != -1)
            {
                if (e.Button == MouseButtons.Right)
                {
                    labelSignalColor.BackColor =
                        ((Signal)checkedListBoxSignals.SelectedItem).Color =
                        Color.FromArgb(255, rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                    RefreshGraph();
                }
                else
                {
                    if (colorDialog.ShowDialog() == DialogResult.OK)
                    {
                        labelSignalColor.BackColor =
                            ((Signal)checkedListBoxSignals.SelectedItem).Color = colorDialog.Color;
                        RefreshGraph();
                    }
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.Min = new XDate(dateTimePicker1.Value);
            RefreshGraph();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            myPane.XAxis.Scale.Max = new XDate(dateTimePicker2.Value);
            RefreshGraph();
        }

        private void checkedListBoxSignals_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            ((Signal)checkedListBoxSignals.Items[e.Index]).Enabled = (e.NewValue == CheckState.Checked);
            RefreshGraph();
        }

        private void checkedListBoxSignals_MouseUp(object sender, MouseEventArgs e)
        {
            ignoreCheck = false;
        }

        private void checkedListBoxSignals_MouseClick(object sender, MouseEventArgs e)
        {
            ignoreCheck = e.X > SystemInformation.MenuCheckSize.Width;
        }

        private void checkBoxMuteAllSounds_CheckedChanged(object sender, EventArgs e)
        {
            Signal.muteAllSounds = checkBoxMuteAllSounds.Checked;
        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, Application.StartupPath + @"\Regis2008.chm");
        }
    }
}