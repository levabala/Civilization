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
        public int altitude;
        Random rnd = new Random;
        public Cell(Pos3d p; int alt)
        {
            altitude = alt;
            position = p;
        }       
        //посчитаю влажность
        //(-1 * position.B) -- получаю вниз направленную вертикальную координату
        //(-1 * position.B) + 5 -- получаю значения не от -5 до 5, а от 0 до 10
        //((-1 * position.B) + 5) * 10 -- получаю значение в процентах
        //(((-1 * position.B) + 5) * 10) - 20 -- отнимаю 20 для реалистичности(средней влажности 100 % никогда не бывает)
        //((rnd.Next(30) / 10) -- псевдорандомное значение, которое является числом от 0.1 до 3.0
        //humidity = (((-1 * position.B) + 5) * 10) - 20 / ((rnd.Next(1, 30) / 10) -- влажность в процентах
        public float humidity = (((-1 * position.B) + 5) * 10) - 20 / ((rnd.Next(1, 30) / 10); 
        if(humidity < 0)humidity*=-1; // влажность не бывает отрицательной
        if(humidity < 5 && humidity >= 0)himidity +=10 //редко бывает ниже 10
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
