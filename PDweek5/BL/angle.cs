using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDweek5.BL
{
    class angle
    {
        public int Degrees;
        public float Minutes;
        public char Direction;

        public angle(int degree, float min, char direction)
        {
            Degrees = degree;
            Minutes = min;
            Direction = direction;
        }
        public void DisplayAngle()
        {
            Console.WriteLine(Degrees + "\u00b0" + Minutes + "' " + Direction);
            Console.ReadKey();
        }
        public void ChangeAngle(int degree,float min, char direction)
        {
            Degrees = degree;
            Minutes = min;
            Direction = direction;
        }
    }
}
