using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace train
{
    class MyVagon : MyRectangle
    {
        protected MyCircle wheel1, wheel2;
        protected int x, y, l;
        protected int weight; 

        public int Weight 
        {
            get
            {
                return weight; 
            }
            set
            {
                if (value > 0)
                {
                    weight = value; 
                }
            }
        }
        
        public MyVagon(int X, int Y, int L) : base(X, Y, L) 
        {

            base.x = X;
            base.y = Y;
            w = L;

            x = X;
            y = Y;
            l = L;
            wheel1 = new MyCircle(X + L / 6, Y + L / 2, L / 6);
            wheel2 = new MyCircle(X + 5 * L / 6, Y + L / 2, L / 6);
        }

        public override void Draw(Graphics gr) 
        {
            base.Draw(gr);
            wheel1.Draw(gr);
            wheel2.Draw(gr);
        }
    }
}
