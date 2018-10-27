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

            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? \n (Enter a number 1-20): ");

            uint studentOne = SelectStudent();
            while (studentOne == 0)
            {
                Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20):  ");
                studentOne = SelectStudent();
            }

            Console.WriteLine($"Student {studentOne} is {CollectionOfList.PickAStudent(studentOne)}. What would you like to know about {CollectionOfList.PickAStudent(studentOne)}? \n (enter \"hometown\" or \"favorite food\")  ");







            Console.ReadKey();
        }

        public static uint SelectStudent()
        {
            bool studentVerification = false;
            uint studentNumber;
            string student;

            while (!studentVerification)
            {
                
                student = Console.ReadLine();

                try
                {
                    studentVerification = uint.TryParse(student,out studentNumber);
                }
                catch (FormatException)
                {
                    
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20):  ");
                    throw;
                }
                if (studentNumber > 20 || studentNumber < 1)
                {
                    Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20):  ");
                    continue;
                }

                return studentNumber;                                    
            }

            return 0;

        }
    }
}
