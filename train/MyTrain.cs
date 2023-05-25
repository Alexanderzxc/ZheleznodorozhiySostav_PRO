using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace train
{
    class MyTrain
    {
        protected int x, y, l, n; 

        List<MyVagon> vagons = new List<MyVagon>(); 
        Random rnd = new Random();

        public MyTrain(int x, int y, int l, int n) 
        {
            this.x = x;
            this.y = y;
            this.l = l;
            this.n = n;

            int random;
            for (int i = 0; i < n; i++)
            {
                random = rnd.Next(3);  
                                                            
                if (random == 0)      
                    vagons.Add(new MyVagon(x, y, l));
                else if (random == 1) 
                {
                    vagons.Add(new MyVagonCoal(x, y, l));
                    Weight_Load(vagons[i]);                              
                }
                else if (random == 2) 
                {
                    vagons.Add(new MyVagonSand(x, y, l));
                    Weight_Load(vagons[i]);                           
                }
                x = x + l + 10; 
            }
        }

        public void Weight_Load(MyVagon vagon) 
        {
            vagon.Weight = rnd.Next(50);
        }

        public int Weight_Count() 
        {
            int count = 0;

            foreach (MyVagon vagon1 in vagons)
            {
                count += vagon1.Weight;
            }
            return count;
        }


        public void Draw(Graphics gr) 
        {
            for (int i = 0; i < n; i++)
            {
                vagons[i].Draw(gr);
            }
        }
    }
}

