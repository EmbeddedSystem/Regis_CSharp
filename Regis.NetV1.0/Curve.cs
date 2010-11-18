using ZedGraph;

namespace RegisNet
{
    class Curve
    {
        readonly LineItem lineItem_;
        public Curve(LineItem lineItem, string curveName)
        {
            lineItem_ = lineItem;
            lineItem_.Label.Text = curveName;
        }

        public LineItem LineItem
        {
            get { return lineItem_; }
        }

        public override string ToString()
        {
            return lineItem_.Label.Text;
        }
    }
}
