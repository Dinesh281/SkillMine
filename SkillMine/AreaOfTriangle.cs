using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine
{
    class AreaOfTriangle
    {
        static void Main(string[] args)
        {
            float b, h;
            Console.WriteLine("Enter base");
            b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height");
            h = float.Parse(Console.ReadLine());
            float area ;
            area = 0.5f * b * h;
            Console.WriteLine("Area of Triangle is " + area);
        }
    }
}
