using System.Drawing;
using System.Media;
//using WMPLib;
using System.Windows.Forms;
using ZedGraph;

namespace Regis2008
{
    class Signal
    {
        static SoundPlayer player = new SoundPlayer();
        public string Name = "Новый сигнал";
        public string Sound = "";
        private BoxObj boxObj;
        private GraphPane pane;
        private FormControl formControl;
        private float min;
        private float max;
        Timer muteTimer = new Timer();
        public bool mute;
        public static bool muteAllSounds;

        public float Min
        {
            get { return min; }
            set
            {
                if (value <= max)
                {
                    min = value;
                    boxObj.Location.Y = max;
                    boxObj.Location.Height = max - min;
                    formControl.RefreshGraph();
                }
            }
        }

        public float Max
        {
            get { return max; }
            set
            {
                if (value >= min)
                {
                    max = value;
                    boxObj.Location.Y = max;
                    boxObj.Location.Height = max - min;
                    formControl.RefreshGraph();
                }
            }
        }

        public Color Color
        {
            get { return boxObj.Border.Color; }
            set { boxObj.Border.Color = boxObj.Fill.Color = value; }
        }

        public bool Enabled
        {
            get { return boxObj.IsVisible; }
            set { boxObj.IsVisible = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public Signal(GraphPane pane, FormControl formControl)
        {
            this.formControl = formControl;
            this.pane = pane;
            boxObj = new BoxObj(0, 0, 1, 0, Color.LightYellow, Color.LightYellow)
                         {
                             Location = { CoordinateFrame = CoordType.XChartFractionYScale },
                             IsClippedToChartRect = true,
                             ZOrder = ZOrder.F_BehindGrid,
                             IsVisible = false
                         };
            pane.GraphObjList.Insert(0, boxObj);
            formControl.RefreshGraph();
            muteTimer.Interval = 2000;
            muteTimer.Tick += muteTimer_Tick;
        }

        void muteTimer_Tick(object sender, System.EventArgs e)
        {
            mute = false;
            muteTimer.Enabled = false;
        }

        public void CheckValueForSignal(float t)
        {
            if (t < min || t > (float)boxObj.Location.Y)
            {
                formControl.SetIconWarning();
                Play();
            }
            else if (t == 1999)
            {
                formControl.SetIconError();
            }
        }
        public void DeleteFromGraph()
        {
            pane.GraphObjList.Remove(boxObj);
        }
        public void Play()
        {
            if (!mute)
            {
                if (!muteAllSounds)
                {
                    player.Stop();
                    if (string.IsNullOrEmpty(Sound)) return;
                    mute = true;
                    muteTimer.Interval = (int) (formControl.numericUpDownMuteTime.Value*1000);
                    muteTimer.Start();
                    muteTimer.Enabled = true;
                    player.SoundLocation = Sound;
                    player.Play();
                }
            }
        }
    }
}
