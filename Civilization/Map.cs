using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization
{
    class Map
    {
        readonly Pos3d[] deltas = new Pos3d[] {
                new Pos3d(1, -1, 0), //right
                new Pos3d(1, 0, -1), //bottom-right
                new Pos3d(0, 1, -1), //bottom-left
                new Pos3d(-1, 1, 0), //left
                new Pos3d(-1, 0, 1), //top-left
                new Pos3d(0, -1, 1), //top-right
            };

        public List<List<Cell>> map;        

        public Map(int width, int height)
        {
            map = new List<List<Cell>>();
            CreateMap(width, height);
        }

        private void CreateMap(int width, int height)
        {
            int left = 1;
            for (int b = 0; b < height; b++)
            {
                map.Add(new List<Cell>());
                List<Cell> row = map[map.Count - 1];
                left = Math.Abs(left - 1);
                int rdelta = b / 2;
                for (int r = 0; r < width; r++)                
                    row.Add(new Cell(new Pos3d(r+rdelta, -(r - left - rdelta), b)));                
            }
        }
    }
}
