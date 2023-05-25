using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class MyCircle
    {
        protected int x, y, r;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int R { get { return r; } }


        public MyCircle(int x_, int y_, int r_) 
        {
            x = x_;
            y = y_;
            r = r_;
        }

        public void Draw(Graphics gr) 
        {
            gr.FillEllipse(new SolidBrush(Color.Red), X - R, Y - R, 2 * R, 2 * R);
        }
    }
}
