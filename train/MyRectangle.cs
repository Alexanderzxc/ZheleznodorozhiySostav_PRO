using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class MyRectangle
    {
        protected int x, y, h, w;

        public int X { get { return x; } }
        public int Y { get { return y; } }
        public int H { get { return h; } }
        public int W { get { return w; } }

        public MyRectangle(int x_, int y_, int l_) 
        {
            x = x_;
            y = y_;
            h = l_ / 2;
            w = l_;
        }

        public virtual void Draw(Graphics gr) 
        {
            gr.FillRectangle(new SolidBrush(Color.Blue), X, Y, W, H);
        }
    }
}
