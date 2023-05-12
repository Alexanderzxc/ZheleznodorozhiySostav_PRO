using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class MyVagonCoal: MyVagon
    {
        PointF[] point; 

        public MyVagonCoal(int x, int y, int l) : base(x, y, l)
        {
            point = new PointF[3];
        }

        public override void Draw(Graphics gr) 
        {
            base.Draw(gr);

            point[0] = new PointF(x, y);
            point[1] = new PointF(x + l, y); 
            point[2] = new PointF(x + (l / 2), y - 15); 

            gr.FillPolygon(new SolidBrush(Color.DarkGray), point); 
        }
    }
}
