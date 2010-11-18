using System.Drawing;
using ZedGraph;

namespace RegisNet
{
    public class Comment
    {
        public Color oldColor = Color.Black;
        private TextObj textObj_;
        private string text;
        public Comment(string s, double d, double d1, CoordType fraction)
        {
            textObj_ = new TextObj(s, d, d1, fraction);
        }

        public string Text
        {
            get { return text = textObj.Text; }
            set { text = textObj.Text = value; }
        }

        public TextObj textObj
        {
            get { return textObj_; }
        }

        public override string ToString()
        {
            //if (string.IsNullOrEmpty(Text)) return "Комментарий";
            return Text.Replace("\r\n", " ");
            //return Text;
        }
    }
}