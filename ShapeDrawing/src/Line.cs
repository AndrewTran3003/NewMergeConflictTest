using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    class Line : Shape
    {
        private float _endX, _endY;
        public Line() : this(Color.Pink, 0, 0, 100, 100)
        {

        }sf;lsdm;flmas;lfmd;lsfmas;ldmf;lsd;flasfasf
        public Line(Color color, float startX, float startY, float endX, float endY)
        {
            Color = color;
            X = startX;
            Y = startY;
            EndX = endX;
            EndY = endY;

        }

        public float EndX
        {
            get
            {
                return _endX;
            }
            set
            {
                _endX = value;
            }
        }


        public float EndY
        {
            get
            {
                return _endY;
            }
            set
            {
                _endY = value;
            }
        }

        public override void Draw()
        {
            SwinGame.DrawLine(Color, X, Y, _endX, _endY);
        }

        public override void DrawOutline()
        {
            SwinGame.DrawLine(Color.Black, X, Y - 1, EndX, EndY - 1);
        }
        public override bool IsAt(Point2D pt)
        {
            return SwinGame.PointOnLine(pt, X, Y, EndX, EndY);
        }
    }
}