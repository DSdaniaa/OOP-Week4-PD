using PDweek5.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PDweek5
{
    class Program
    {
        static void Main(string[] args)
        {
            char choice='0';
            List<ship> ships = new List<ship>();
            while (choice != 5)
            {
                choice = menu();
                if (choice == '1')
                {
                    Console.Clear();
                    ships.Add(AddShip());
                }
                else if (choice == '2')
                {
                    Console.Clear();
                    PrintPosition(ships);
                }
                else if (choice == '3')
                {
                    Console.Clear();
                    PrintNumber(ships);
                }
                else if (choice == '4')
                {
                    Console.Clear();
                    ChangePosition(ships);
                }
                else if (choice == '5')
                {
                    Console.WriteLine("press any key to exit.....");
                    Console.ReadKey();
                    break;
                }
            }

        }
        static char menu()
        {
            char option;
            Console.Clear();
            Console.WriteLine("1.Add Ship");
            Console.WriteLine("2.View Ship Position");
            Console.WriteLine("3.View Ship Serial Number");
            Console.WriteLine("4.Change Ship Position");
            Console.WriteLine("5.Exit");
            Console.Write("Enter your option: ");
            option =char.Parse(Console.ReadLine());
            return option;
        }
        static ship AddShip()
        {

            string num;
            char La_direction, Lo_direction;
            int La_degree, Lo_degree;
            float La_min, Lo_min;
            Console.Write(" Enter Ship Number: ");
            num = Console.ReadLine();
            Console.WriteLine(" Enter Ship Latitude: ");
            Console.Write(" Enter Latitude’s Degree: ");
            La_degree = int.Parse(Console.ReadLine());
            Console.Write(" Enter Latitude’s Minute: ");
            La_min = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            La_direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude’s Degree: ");
            Lo_degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            Lo_min = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            Lo_direction = char.Parse(Console.ReadLine());
            angle longitude = new angle(Lo_degree,Lo_min,Lo_direction);
            angle latitude = new angle(La_degree, La_min, La_direction);
            ship ships = new ship(num,latitude,longitude);
            return ships;

        }
        static void PrintPosition(List<ship> s)
        {
            string position;
            Console.Write("Enter Ship Serial Number to find its position: ");
            position = Console.ReadLine();
            for(int i=0; i < s.Count(); i++)
            {
                if (position == s[i].Number)
                {
                    s[i].PrintPosition();
                    break;
                }
            }

        }
        static void PrintNumber(List<ship> s)
        {
            char La_direction, Lo_direction;
            int La_degree, Lo_degree;
            float La_min, Lo_min;
            Console.WriteLine(" Enter Ship Latitude: ");
            Console.Write(" Enter Latitude’s Degree: ");
            La_degree = int.Parse(Console.ReadLine());
            Console.Write(" Enter Latitude’s Minute: ");
            La_min = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            La_direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude’s Degree: ");
            Lo_degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            Lo_min = float.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Direction: ");
            Lo_direction = char.Parse(Console.ReadLine());
            angle longitude1 = new angle(Lo_degree, Lo_min, Lo_direction);
            angle latitude1 = new angle(La_degree, La_min, La_direction);
            for (int i = 0; i < s.Count(); i++)
            {
                if (longitude1 == s[i].longitude && latitude1==s[i].latitude)
                {
                    s[i].PrintNumber();
                    break;
                }
            }

        }
        static void ChangePosition(List<ship> s)
        {
            string num;
            char La_direction, Lo_direction;
            int La_degree, Lo_degree;
            float La_min, Lo_min;
            Console.Write(" Enter Ship’s serial number whose position you want to change: ");
            num = Console.ReadLine();
            Console.WriteLine(" Enter Ship Latitude: ");
            Console.Write(" Enter Latitude’s Degree: ");
            La_degree = int.Parse(Console.ReadLine());
            Console.Write(" Enter Latitude’s Minute: ");
            La_min = float.Parse(Console.ReadLine());
            Console.Write("Enter Latitude’s Direction: ");
            La_direction = char.Parse(Console.ReadLine());
            Console.WriteLine("Enter Ship Longitude: ");
            Console.Write("Enter Longitude’s Degree: ");
            Lo_degree = int.Parse(Console.ReadLine());
            Console.Write("Enter Longitude’s Minute: ");
            Lo_min = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Longitude’s Direction: ");
            Lo_direction = char.Parse(Console.ReadLine());
            for (int i = 0; i < s.Count(); i++)
            {
                if (num == s[i].Number)
                {
                    s[i].latitude.ChangeAngle(La_degree, La_min, La_direction);
                    s[i].longitude.ChangeAngle(Lo_degree, Lo_min, Lo_direction);
                    break;
                }
            }
        }
    }
}
