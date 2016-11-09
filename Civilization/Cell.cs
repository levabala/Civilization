using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Civilization
{
    class Cell
    {
        int RoadLevel = 1;
        List<Resource> Resources = new List<Resource>();
        LuxuryResource luxRes;

        public Cell()
        {
            
        }

        public int GetUnit(Unit u)
        {
            return 0;
        }
    }       
}
