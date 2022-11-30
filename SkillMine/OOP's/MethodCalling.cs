using System;
using System.Collections.Generic;
using System.Text;

namespace SkillMine.OOP_s
{
    class MethodCalling
    {
        int num1 = 20;
        int num2 = 10;
        public int Add (){
            return (num1 + num2);
            }
        public int Sub()
        {
            return (20 - 10);
        }
        public int Mul(int a,int b)
        {
            return (a * b);
        }
        static void Main(string[] args)
        {
             MethodCalling m = new MethodCalling();
            Console.WriteLine(m.Add());
            Console.WriteLine(m.Sub());
            Console.WriteLine(m.Mul(m.num1, m.num2));
            Console.WriteLine(m.Div(20,10));
        }
        public int Div(int a,int b)
        {
            return (a / b);
        }
    }
}
