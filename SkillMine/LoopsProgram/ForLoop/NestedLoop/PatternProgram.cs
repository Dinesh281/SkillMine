using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.LoopsProgram.ForLoop.NestedLoop
{
    /*   1234
         1234
         1234
         1234   */
    class PatternProgram1
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= 4; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    /* 1
       12
       123
       1234  */
    class PatternProgram2
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
    /*   ****
         ***
         **
         *      */
    class PatternProgram3
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
    /*   1234
         123
         12
         1      */
    class PatternProgram4
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 5-i; j++)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
    /*   1
         23
         456
         78910   */
    class PatternProgram5
    {
        static void Main(string[] args)
        {
            int c = 1;
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(c+" ");
                    c++;
                }
                Console.WriteLine();
            }
        }
    }
    /*    *
          * *
          *   *
          * * * *   */
    class PatternProgram6
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (i == 1 || j == 1 || i == j||i==5)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    /* 
         *    *
         * *  *
         *  * *
         *    *
 */
    class PatternProgram7
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    if (j == 1 || i == j || j == 4)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    /* 
           *
           *
       * * * * *
           *
           *
*/
    class PatternProgram8
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    if (j == 3 || i == 3)
                    {
                        Console.Write("* ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
/*    * 
      * O
      * O *
      * O * O
      * O * O *        */
    class PatternProgram9
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write("O ");
                    }
                    else
                    {
                        Console.Write("* ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
    /* A
       A B
       A B C
       A B C D  */
    class PatternProgram10
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write((char)(j+64)+" ");
                }
                Console.WriteLine();
            }
        }
    }
    /*   D C B A
         D C B 
         D C
         D           */
    class PatternProgram11
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 4; i++)
            {
                for (int j = i; j <= 4; j++)
                {
                    Console.Write((char)(68+i-j) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
