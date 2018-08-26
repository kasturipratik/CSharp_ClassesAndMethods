using System;
using System.Collections;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
     
            Student a = new Student(1, "Pratik", "baltimore", "4102459450");
            Student b = new Student(2, "Pratap", "Maryland", "4102454436");
            arrayList.Add(a);
            arrayList.Add(b);
            foreach(Student st in arrayList)
            {
                Console.WriteLine(st);
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
