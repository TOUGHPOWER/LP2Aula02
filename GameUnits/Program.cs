using System;

namespace GameUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            MilitaryUnit m1 = new MilitaryUnit(20,20, 20);
            MilitaryUnit m2 = new MilitaryUnit(50, 100, 30);
            SettlerUnit s1 = new SettlerUnit(10,100);

            Console.WriteLine(m1.Health);
            Console.WriteLine(m1.Value);
            m1.Move();
            Console.WriteLine(m2.Health);
            Console.WriteLine(m2.Value);
            m2.Move();
            Console.WriteLine(s1.Health);
            Console.WriteLine(s1.Value);
            s1.Move();

            Console.WriteLine(s1.ToString());
            Console.WriteLine(m1.ToString());


        }
    }
}
