using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SwinGameSDK;

namespace MyGame
{
    class Circle : Shape
    {
        private int _radius;

        public Circle() : this(Color.Blue, 50)
        {

        }
        public Circle(Color color, int radius)
        {
            Color = color;
            _radius = radius;
        }
flkdsaflksnflknflkfndfnalsnfdlknflkdsnflknfalknlknflkdsa
        public int Radius
        {
            get
            {
                return _radius;
            }
            set
            {
                _radius = value;
            }
        }


        public override void Draw()
        {
            if (Selected)
            {
                DrawOutline();
            }
            SwinGame.FillCircle(Color, X, Y, _radius);
        }

        public override void DrawOutline()
        {
            SwinGame.DrawCircle(Color.Black, X, Y, _radius + 1);
        }

        public override bool IsAt(Point2D pt)
        {
            return SwinGame.PointInCircle(pt, X, Y, _radius);
        }
    }
}
