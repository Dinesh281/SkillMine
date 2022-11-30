using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine
{
    class DisplayTypesOfDatatypes
    {
        static void Main(string[] args)
        {
            byte by = 123;
            Console.WriteLine("Byte = "+by);

            sbyte sby = -124;
            Console.WriteLine("sByte = "+sby);

            short sh = 567;
            Console.WriteLine("short =  " + sh);

            long lon = 421;
            Console.WriteLine("Long = " + lon);

            int a = 421;
            Console.WriteLine("Int = " + a);

            float fl = 57.56f;
            Console.WriteLine("Float = " + fl);

            double db = 476.23;
            Console.WriteLine("Double = " + db);

            char ch = 'a';
            Console.WriteLine("Char = " + ch);

            bool bl = true;
            Console.WriteLine("Boolean = " + bl);
        }
    }
}
