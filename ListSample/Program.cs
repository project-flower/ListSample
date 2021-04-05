using System;
using System.Collections.Generic;

namespace ListSample
{
    class Program
    {
        class Class1
        {
            public string Member;
        }

        static void Main(string[] args)
        {
            var list = new List<Class1>();
            int i;

            for (i = 0; i < 20; ++i)
            {
                list.Add(new Class1() { Member = i.ToString() });
            }

            i = 0;

            foreach (Class1 class1 in list)
            {
                if (i.ToString().Length < 2)
                {
                    class1.Member = (i * 2).ToString();
                    // System.InvalidOperationException
                    //list[i] = class1;
                }

                ++i;
            }

            foreach (Class1 class1 in list)
            {
                Console.Write(class1.Member + ",");
            }

            Console.ReadLine();
        }
    }
}
