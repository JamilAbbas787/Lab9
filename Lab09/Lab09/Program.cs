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

            Console.WriteLine($"Student {studentOne} is {CollectionOfList.PickAStudent(studentOne)}. What would you like to know about {CollectionOfList.PickAStudent(studentOne)}? \n (enter \"color\", \"hometown\" or \"favorite food\")  ");

            string answerToQuestion;
            string continueAnswer;
            do
            {
                answerToQuestion = Console.ReadLine();
                bool verificationOfAnswerToQuestionOptionHometown = answerToQuestion.Equals("hometown", StringComparison.OrdinalIgnoreCase);
                bool verificationOfAnswerToQuestionOptionFood = answerToQuestion.Equals("favorite food", StringComparison.OrdinalIgnoreCase);
                bool verificationOfAnswerToQuestionOptioncColor = answerToQuestion.Equals("color", StringComparison.OrdinalIgnoreCase);

                if (verificationOfAnswerToQuestionOptionFood)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne)}'s {answerToQuestion} is {CollectionOfList.SelectFood(studentOne)} ");
                }
                else if ( verificationOfAnswerToQuestionOptionHometown)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne)}'s {answerToQuestion} is {CollectionOfList.SelectHometown(studentOne)} ");
                }
                else if (verificationOfAnswerToQuestionOptioncColor)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne)}'s {answerToQuestion} is {CollectionOfList.SelectColor(studentOne)} ");
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\"):  ");
                    continue;
                }

                Console.WriteLine("Would you like to know more? (enter \"yes\" or \"no\"):  ");
                continueAnswer = Console.ReadLine();
                
                //continueAnswer.Equals("yes",StringComparison.OrdinalIgnoreCase) ? continue; 

            } while (continueAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase));

       

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
                catch (FormatException ex)
                {
                    Console.WriteLine(ex);
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
