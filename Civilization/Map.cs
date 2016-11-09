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

        private void CreateMap(int width, int height)
        {
            for (int x = 0; x < width; x++)
                for (int y = 0; y < height; y++)
                    map[x, y] = new Cell(); 
        }
    }
}
