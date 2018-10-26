using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? \n Enter a number 1-20): ");
            string student = Console.ReadLine();
            int.TryParse(student, out int studentNumber);

            //var student = new
            //CollectioOfList.PickAStudent(1);
            Console.WriteLine(CollectioOfList.PickAStudent(studentNumber));

            Console.ReadKey();
        }
    }
}
