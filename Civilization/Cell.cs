using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization
{
    class Cell
    {        
        public int RoadLevel = 1;
        public Pos3d position;
        public List<Resource> Resources = new List<Resource>();
        public LuxuryResource luxRes;

        public Cell(Pos3d p)
        {
            position = p;
        }       
    }       

    struct Pos3d
    {
        public int R, G, B;
        public Pos3d(int r, int g, int b)
        {
            R = r;
            G = g;
            B = b;
        }

        public static Pos3d operator + (Pos3d p1, Pos3d p2)
        {
            return new Pos3d(p1.R + p2.R, p1.G + p2.G, p1.B + p1.B);
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}:{2}", R, G, B);
        }
    }
}
