using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization
{
    class Map
    {
        public Cell[,] map;

        public Map(int width, int height)
        {
            map = new Cell[width,height];
        }
    }
}
