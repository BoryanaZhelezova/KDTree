using System.Drawing;

namespace KdTreeLib.UserControls
{
    // Line structure to hold points, pen and additional IsVertical parameter for KdTreeBuilder
    internal struct DrawingLine
    {
        public PointF Start { get; private set; }
        public PointF End { get; private set; }
        // TopLeft and BottomRight and used only by KdTreeNodesView
        private PointF TopLeft { get; set; }
        private PointF BottomRight { get; set; }
        public RectangleF ContainingRectangle
        {
            get
            {
                return new RectangleF(TopLeft.X, TopLeft.Y, BottomRight.X - TopLeft.X, BottomRight.Y - TopLeft.Y);
            }
        }
        public bool IsVertical { get; private set; }
        public Pen Pen { get; private set; }

        public DrawingLine(PointF Start, PointF End, Pen Pen, bool IsVertical = false)
            : this()
        {
            this.Start = Start;
            this.End = End;
            this.Pen = Pen;

            PointF _topLeft = new PointF();
            PointF _bottomRight = new PointF();

            // calculate TopLeft and BottomRight
            if (Start.X > End.X)
            {
                _topLeft.X = End.X;
                _bottomRight.X = Start.X;
            }
            else
            {
                _topLeft.X = Start.X;
                _bottomRight.X = End.X;
            }
            if (Start.Y > End.Y)
            {
                _topLeft.Y = End.Y;
                _bottomRight.Y = Start.Y;
            }
            else
            {
                _topLeft.Y = Start.Y;
                _bottomRight.Y = End.Y;
            }

            TopLeft = _topLeft;
            BottomRight = _bottomRight;
            this.IsVertical = IsVertical;
        }
        // multiply the start and end position of the line by w (for width) and h (for height)
        public DrawingLine Scale(float w, float h)
        {
            PointF _start = new PointF();
            PointF _end = new PointF();

            _start.X = Start.X * w;
            _start.Y = Start.Y * h;

            _end.X = End.X * w;
            _end.Y = End.Y * h;

            return new DrawingLine(_start, _end, Pen, IsVertical);
        }
        // adds x and/or y to start and end positions of the line
        public DrawingLine AddXY(float? x, float? y)
        {
            PointF _start = new PointF();
            PointF _end = new PointF();

            if (x.HasValue)
            {
                _start.X = Start.X + x.Value;
                _end.X = End.X + x.Value;
            }
            else
            {
                _start.X = Start.X;
                _end.X = End.X;
            }

            if (y.HasValue)
            {
                _start.Y = Start.Y + y.Value;
                _end.Y = End.Y + y.Value;
            }
            else
            {
                _start.Y = Start.Y;
                _end.Y = End.Y;
            }

            return new DrawingLine(_start, _end, Pen, IsVertical);
        }
    }
}
