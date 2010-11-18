using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using RegisNet;
using ZedGraph;

namespace Regis2008
{
    class Pirometer
    {
        private const string filepath = @"c:\RegisDATA\";
        private readonly RS232 port;
        public RollingPointPairList points = new RollingPointPairList(5000, true);
        public Curve curve;
        public float epsilon = 1f;
        public float Tmin = float.MaxValue;
        public float Tmax = float.MinValue;
        public float T = 1999f;
        private StreamWriter sw;
        private string filename_old;
        public bool epsMustBeChanged;
        private bool ShowError;

        public Pirometer(RS232 port)
        {
            this.port = port;
            if (!Directory.Exists(filepath)) Directory.CreateDirectory(filepath);
        }

        public RS232 Port
        {
            get { return port; }
        }

        public void CloseFile()
        {
            filename_old = null;
            sw.Flush();
            sw.Close();
        }

        public void SaveToFile(float t, float eps, string portName)
        {
            try
            {
                string filename = filepath + DateTime.Now.ToShortDateString() + "_" + portName + ".csv";
                if (filename != filename_old)
                {
                    if (sw != null) sw.Close();
                    sw = new StreamWriter(filename, true, Encoding.ASCII);
                    filename_old = filename;
                }
                sw.WriteLine("{0};{1};{2};{3}",
                              DateTime.Now.ToShortDateString(),
                              DateTime.Now.ToLongTimeString(),
                              t.ToString("f1"),
                              eps.ToString("f2")
                     );
                sw.Flush();
            }
            catch (IOException)
            {
                if (ShowError) return;
                ShowError = true;
                MessageBox.Show("Лог-файл используется другим пользователем или программой." + "\nЗакройте программу, которая открыла лог-файл и нажмите ОК", "Ошибка записи лог-файла!", MessageBoxButtons.OK);
                ShowError = false;
            }
        }
        public void SaveMemoryToFileNew(string memory, string portName)
        {
            try
            {
                string filename = filepath + "P_" + DateTime.Now.ToShortDateString() + "_" + portName + ".csv";
                if (filename != filename_old)
                {
                    if (sw != null) sw.Close();
                    sw = new StreamWriter(filename, true, Encoding.ASCII);
                    filename_old = filename;
                }
                sw.WriteLine(memory);

                sw.Flush();
            }
            catch (IOException)
            {
                if (ShowError) return;
                ShowError = true;
                MessageBox.Show("Лог-файл используется другим пользователем или программой." + "\nЗакройте программу, которая открыла лог-файл и нажмите ОК", "Ошибка записи лог-файла!", MessageBoxButtons.OK);
                ShowError = false;
            }
        }
        public void SaveMemoryToFileOld(string memory, string portName)
        {
            try
            {
                string filename = filepath + "M_" + DateTime.Now.ToShortDateString() + "_" + portName + ".csv";
                if (filename != filename_old)
                {
                    if (sw != null) sw.Close();
                    sw = new StreamWriter(filename, true, Encoding.ASCII);
                    filename_old = filename;
                }
                sw.WriteLine(memory);

                sw.Flush();
            }
            catch (IOException)
            {
                if (ShowError) return;
                ShowError = true;
                MessageBox.Show("Лог-файл используется другим пользователем или программой." + "\nЗакройте программу, которая открыла лог-файл и нажмите ОК", "Ошибка записи лог-файла!", MessageBoxButtons.OK);
                ShowError = false;
            }
        }
    }
}