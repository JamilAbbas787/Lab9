using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class Program

    {
       //
       //After I add a new person to my list it does not save to the actual list. 
       //I tried to add a new person then would try to search for them and the list reverts back to it's origanl length.
       //Tried using a normal list and a KeyValuePair.
       //Also had some trouble with exceptions.
       //

        static void Main(string[] args)
        {
            
            Console.WriteLine("Welcome to our C# class. Which student would you like to learn more about? \n (Enter a number 1-20): ");

            uint studentOne = SelectStudent();
            while (studentOne == 0)
            {
                Console.WriteLine("That student does not exist. Please try again. (enter a number 1-20):  ");
                studentOne = SelectStudent();
            }

            Console.WriteLine($"Student {studentOne} is {CollectionOfList.PickAStudent(studentOne,"placeholder" )}. What would you like to know about {CollectionOfList.PickAStudent(studentOne, "placeholder")}? \n (enter \"color\", \"hometown\" or \"favorite food\")  ");

            string answerToQuestion;
            string continueAnswer = "";
            answerToQuestion = Console.ReadLine();
            do
            {
                
                bool verificationOfAnswerToQuestionOptionHometown = answerToQuestion.Equals("hometown", StringComparison.OrdinalIgnoreCase);
                bool verificationOfAnswerToQuestionOptionFood = answerToQuestion.Equals("favorite food", StringComparison.OrdinalIgnoreCase);
                bool verificationOfAnswerToQuestionOptioncColor = answerToQuestion.Equals("color", StringComparison.OrdinalIgnoreCase);

                if (verificationOfAnswerToQuestionOptionFood)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne, "placeholder")}'s {answerToQuestion} is {CollectionOfList.SelectFood(studentOne, "placeholder")}. ");
                }
                else if ( verificationOfAnswerToQuestionOptionHometown)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne, "placeholder")}'s {answerToQuestion} is {CollectionOfList.SelectHometown(studentOne, "placeholder")}. ");
                }
                else if (verificationOfAnswerToQuestionOptioncColor)
                {
                    Console.Write($"{CollectionOfList.PickAStudent(studentOne, "placeholder")}'s favorite {answerToQuestion} is {CollectionOfList.SelectColor(studentOne, "placerholder")}. ");
                }
                else
                {
                    Console.WriteLine("That data does not exist. Please try again. (enter \"hometown\" or \"favorite food\" or \"color\"):  ");
                    answerToQuestion = Console.ReadLine();
                    continue;
                }

                Console.WriteLine("Would you like to know more, find out about a new student, or add a student to the database? (\n" +
                    "enter \"yes\" or \"no\" or \"add\" or \"new\"):  ");
                continueAnswer = Console.ReadLine();

                if (continueAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                {
                   Console.WriteLine($"What more would you like to know about {CollectionOfList.PickAStudent(studentOne, "placeholder")}? \n(enter \"color\", \"hometown\" or \"favorite food\")  ");
                    answerToQuestion = Console.ReadLine();
                }
                else if (continueAnswer.Equals("add", StringComparison.OrdinalIgnoreCase))
                {
                    // James - I like that you made a new class to help solve this problem, I would instead create a normal List of class Student.
                    // the Student class will then hold all the properties that a student cares about.
                    // so like var billy = new Student();
                    // billy.Name = "Billy";
                    // billy.Food = "Pizza";
                    // billy.Color = "Blue";
                    // then store this student in a list and do this for the amount of students that you want to store.
                    CollectionOfList.AddNewStudent();
                    Console.WriteLine($"Would you like to continue (enter yes or no)");
                    continueAnswer = Console.ReadLine();
                    if (continueAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase))
                    {
                        listLength++;
                        Console.WriteLine("Enter a new number: ");
                        studentOne = SelectStudent();
                        Console.WriteLine($"You choose {CollectionOfList.PickAStudent(studentOne, "placeholder")}. \n" +
                            $" What would you like to know about {CollectionOfList.PickAStudent(studentOne, "placeholder")} (enter \"hometown\" or \"favorite food\" or \"color\"): ");
                        answerToQuestion = Console.ReadLine();
                    }
                }
                else if (continueAnswer.Equals("new", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Enter a new number:  ");
                    studentOne = SelectStudent();
                    Console.WriteLine($" What would you like to know about { CollectionOfList.PickAStudent(studentOne, "placeholder")} " +
                        $"(enter \"hometown\" or \"favorite food\" or \"color\"): ");
                    answerToQuestion = Console.ReadLine();
                }


            } while (continueAnswer.Equals("yes", StringComparison.OrdinalIgnoreCase) || continueAnswer.Equals("new", StringComparison.OrdinalIgnoreCase));

            Console.WriteLine("Bye!");

           Console.ReadKey();
        }

        public static int listLength= 20;
        public static uint SelectStudent()
        {
            bool studentVerification = false;
            uint studentNumber;
            string student;

            while (!studentVerification)
            {
                studentVerification = false;
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
                if (studentNumber > listLength || studentNumber < 1)
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
