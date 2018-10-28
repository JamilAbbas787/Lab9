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
            string continueAnswer = "";
            do
            {
                answerToQuestion = Console.ReadLine();
                bool verificationOfAnswerToQuestionOptionHometown = answerToQuestion.Equals("hometown", StringComparison.OrdinalIgnoreCase);
                bool verificationOfAnswerToQuestionOptionFood = answerToQuestion.Equals("favorite food", StringComparison.OrdinalIgnoreCase);
                bool verificationOfAnswerToQuestionOptioncColor = answerToQuestion.Equals("color", StringComparison.OrdinalIgnoreCase);

                if (verificationOfAnswerToQuestionOptionFood)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne)}'s {answerToQuestion} is {CollectionOfList.SelectFood(studentOne)}. ");
                }
                else if ( verificationOfAnswerToQuestionOptionHometown)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne)}'s {answerToQuestion} is {CollectionOfList.SelectHometown(studentOne)}. ");
                }
                else if (verificationOfAnswerToQuestionOptioncColor)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne)}'s favorite {answerToQuestion} is {CollectionOfList.SelectColor(studentOne)}. ");
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\"):  ");
                    continue;
                }

                Console.WriteLine("Would you like to know more or add a student to the database? (enter \"yes\" or \"no\" or \"add\"):  ");
                continueAnswer = Console.ReadLine();

                if (continueAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                   Console.WriteLine($"What more would you like to know about {CollectionOfList.PickAStudent(studentOne)}? \n(enter \"color\", \"hometown\" or \"favorite food\")  ");
                }
                else if (continueAnswer.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Great!");

                    Console.Write("What's the name of the new student: ");
                    string newStudentName = Console.ReadLine();
                    
                    while (string.IsNullOrEmpty(newStudentName))
                    {
                        Console.Write("Looks you forgot to enter text. What's the new students name?: ");
                        newStudentName = Console.ReadLine();
                    }

                    Console.Write($"What's {newStudentName}'s favorite color?: ");
                    string newStudentFavoriteColor = Console.ReadLine();

                    while (string.IsNullOrEmpty(newStudentFavoriteColor))
                    {
                        Console.Write($"Looks you forgot to enter a color. What's {newStudentName}'s favorite color?: ");
                        newStudentFavoriteColor = Console.ReadLine();                   
                    }

                    Console.Write($"What's {newStudentName}'s favorite food?: ");
                    string newStudentFavoriteFood = Console.ReadLine();

                    while (string.IsNullOrEmpty(newStudentFavoriteFood))
                    {
                        Console.Write($"Looks you forgot to enter a food. What's {newStudentName}'s favorite food?: ");
                        newStudentFavoriteFood = Console.ReadLine();
                    }

                    Console.Write($"What's {newStudentName}'s hometown?: ");
                    string newStudentHomeTown = Console.ReadLine();

                    while (string.IsNullOrEmpty(newStudentHomeTown))
                    {
                        Console.Write($"Looks you forgot to enter a color. What's {newStudentName}'s favorite color?: ");
                        newStudentHomeTown = Console.ReadLine();
                    }

                    Console.WriteLine($"Awesome. So the new student is {newStudentName}. {newStudentName}'s favorite color is {newStudentFavoriteColor}, \n" +
                        $"favorite food is {newStudentFavoriteFood}, and hometown is {newStudentHomeTown} ");
                }


            } while (continueAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Bye!");

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
