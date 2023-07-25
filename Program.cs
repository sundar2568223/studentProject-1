using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentDataProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"D:\Projects\RainbowSchools.txt");
            System.Console.WriteLine(text);
            Console.ReadLine();

        }
    }
}