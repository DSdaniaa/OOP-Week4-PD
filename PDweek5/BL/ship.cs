using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDweek5.BL
{
    class ship
    {
        public string Number;
        public angle latitude = new angle(23, 81.1F, 'N');
        public angle longitude = new angle(83, 23.9F, 'S');

        public ship(string num, angle lati, angle longi)
        {
            this.Number = num;
            this.latitude = lati;
            this.longitude = longi;
        }
        public void PrintNumber()
        {
            Console.WriteLine("serial number: {0} ", Number);
            Console.ReadKey();
        }
        public void PrintPosition()
        {
            Console.Write("Latitude: ");
            latitude.DisplayAngle();
            Console.Write("Longitude: ");
            longitude.DisplayAngle();
            Console.ReadKey();
        }
    }
}