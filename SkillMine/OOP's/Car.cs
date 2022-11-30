using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.OOP_s
{
    class Car
    {
        int car_number;
        string car_name;
        string car_colour;
        string car_price;
        public void display(int a, string name, string colour, string price){
            Console.WriteLine("Car Number = " + a);
            Console.WriteLine("Car Name = " + name);
            Console.WriteLine("Car colour = " + colour);
            Console.WriteLine("Car Price = " + price);
        }

        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.car_number = 1214;
            c1.car_name = "Honda";
            c1.car_colour = "Carbon Black";
            c1.car_price = "20 Lakh";
            c1.display(c1.car_number, c1.car_name, c1.car_colour, c1.car_price);
            Console.WriteLine("//////////////////////////");

            Car c2 = new Car();
            c2.car_number = 1261;
            c2.car_name = "Tata";
            c2.car_colour = "Black";
            c2.car_price = "25 Lakh";
            c2.display(c2.car_number, c2.car_name, c2.car_colour, c2.car_price);
            Console.WriteLine("//////////////////////////");

            Car c3 = new Car();
            c3.car_number = 2412;
            c3.car_name = "MG";
            c3.car_colour = "Blue";
            c3.car_price = "60 Lakh";
            c3.display(c3.car_number, c3.car_name, c3.car_colour, c3.car_price);
            Console.WriteLine("//////////////////////////");

            Car c4 = new Car();
            c4.car_number = 2124;
            c4.car_name = "Bukati";
            c4.car_colour = "Carbon Black";
            c4.car_price = "40 Lakh";
            c4.display(c4.car_number, c4.car_name, c4.car_colour, c4.car_price);
        }
    }
}
