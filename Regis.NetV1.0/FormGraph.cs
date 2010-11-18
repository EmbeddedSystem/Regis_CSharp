using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using ZedGraph;

namespace Regis2008
{
    public partial class FormGraph : Form
    {
        #region Переменные
        double startX, startY;
        bool isDragPoint;
        object dragObject;
        public bool fullscreen;
        private readonly FormControl formControl;
        #endregion

        #region Инициализация

        public FormGraph(FormControl form)
        {
            InitializeComponent();
            formControl = form;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            e.Cancel = true;
            Hide();
            formControl.buttonShowGraph.Text = "Показать график";
        }
        private void zedGraphControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Right)
            {
                zgc.RestoreScale(zgc.GraphPane);
                formControl.checkBoxAutoscroll.Checked = true;
            }
        }

        #endregion

        #region На весь экран

        private void zedGraphControl1_DoubleClick(object sender, System.EventArgs e)
        {
            formControl.checkBoxFullScreen.Checked = !formControl.checkBoxFullScreen.Checked;
        }
        private void FormGraph_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((Keys)e.KeyChar == Keys.Escape)
            {
                formControl.checkBoxFullScreen.Checked = false;
            }
        }

        #endregion

        #region Комментарии

        private void timer1_Tick(object sender, System.EventArgs e)
        {
            formControl.buttonCommentSearch.Enabled = true;
            foreach (var comment in FormControl.comments)
            {
                comment.textObj.FontSpec.Border.Color = comment.oldColor;
            }
            timerSearchLighting.Enabled = false;
            formControl.RefreshGraph();
        }
        private bool zgc_MouseDownEvent(ZedGraphControl sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Shift)
            {

            }

            if (ModifierKeys == Keys.Alt || formControl.shiftComent)
            {
                var myPane = sender.GraphPane;
                var mousePt = new PointF(e.X, e.Y);

                int dragIndex;
                if (myPane.FindNearestObject(mousePt, CreateGraphics(), out dragObject, out dragIndex) && dragObject.GetType() == typeof(TextObj))
                {
                    ((TextObj)dragObject).Location.CoordinateFrame = CoordType.AxisXYScale;
                    myPane.ReverseTransform(mousePt, out startX, out startY);
                    ((TextObj)dragObject).Location.X = startX;
                    ((TextObj)dragObject).Location.Y = startY;
                    ((TextObj)dragObject).FontSpec.Border.Color = Color.Black;
                    isDragPoint = true;
                    myPane.ReverseTransform(mousePt, out startX, out startY);
                    formControl.buttonCommentAdd.Enabled = true;
                    return true;
                }
            }

            return false;
        }
        private bool zgc_MouseUpEvent(ZedGraphControl sender, MouseEventArgs e)
        {

            if (isDragPoint)
            {
                isDragPoint = false;
            }

            return false;
        }
        private bool zgc_MouseMoveEvent(ZedGraphControl sender, MouseEventArgs e)
        {
            if (isDragPoint)
            {
                var myPane = sender.GraphPane;
                var mousePt = new PointF(e.X, e.Y);

                double curX, curY;
                myPane.ReverseTransform(mousePt, out curX, out curY);
                ((TextObj)dragObject).Location.CoordinateFrame = CoordType.AxisXYScale;
                //                ((Comment)dragObject).Location.X += curX - startX;
                ((TextObj)dragObject).Location.X += curX - startX;
                //                ((Comment)dragObject).Location.Y += curY - startY;
                ((TextObj)dragObject).Location.Y += curY - startY;
                startX = curX;
                startY = curY;
                sender.Refresh();
                return true;
            }
            return false;
        }


        #endregion

        #region Показать панель управления

        private void button1_Click(object sender, System.EventArgs e)
        {
            formControl.TopMost = true;
            formControl.Show();
            formControl.WindowState = FormWindowState.Normal;
            formControl.TopMost = false;
            button2.Visible = button1.Visible = false;
        }
        private void zgc_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Visible = button1.Visible = ((e.Y) <= button1.Height || (e.Y) >= zgc.Height - button2.Height);
        }

        #endregion

        private void button1_MouseLeave(object sender, System.EventArgs e)
        {
            button2.Visible = button1.Visible = false;
        }

        private void FormGraph_Load(object sender, System.EventArgs e)
        {

        }
    }
}



