using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class CollectionOfList
    {
        
        public static string PickAStudent(uint numberOnArray, string newName)
        {


            //    var studentNames = new List<KeyValuePair<uint, string>>
            //    {
            //        new KeyValuePair<uint, string>(1, "Dylan Larkin"),
            //        new KeyValuePair<uint, string>(2, "Jimmy Howard"),
            //        new KeyValuePair<uint, string>(3, "Niklas Kronwall"),
            //        new KeyValuePair<uint, string>(4, "Justin Abdelkader"),
            //        new KeyValuePair<uint, string>(5, "Gustav Nyquist"),
            //        new KeyValuePair<uint, string>(6, "Anthony Mantha"),
            //        new KeyValuePair<uint, string>(7, "Andreas Athanasiou"),
            //        new KeyValuePair<uint, string>(8, "Thomas Vanek"),
            //        new KeyValuePair<uint, string>(9, "Michael Rasmussen"),
            //        new KeyValuePair<uint, string>(10, "Evgeny Svechnikov"),
            //        new KeyValuePair<uint, string>(11, "Mike Green"),
            //        new KeyValuePair<uint, string>(12, "Luke Glendening"),
            //        new KeyValuePair<uint, string>(13, "Dennis Cholowski"),
            //        new KeyValuePair<uint, string>(14, "Jonathan Bernier"),
            //        new KeyValuePair<uint, string>(15, "Danny Dekeyser"),
            //        new KeyValuePair<uint, string>(16, "Tyler Bertuzzi"),
            //        new KeyValuePair<uint, string>(17, "Darren Helm"),
            //        new KeyValuePair<uint, string>(18, "Johan Franzen"),
            //        new KeyValuePair<uint, string>(19, "Jonathan Ericsson"),
            //        new KeyValuePair<uint, string>(20, "Frans Nielsen"),

            //};

            var studentNames = new List<string>
            {
                "Dylan Larkin",
                "Jimmy Howard",
                "Niklas Kronwall",
                "Justin Abdelkader",
                "Gustav Nyquist",
                "Anthony Mantha",
                "Andreas Athanasiou",
                "Thomas Vanek",
                "Michael Rasmussen",
                "Evgeny Svechnikov",
                "Mike Green",
                "Luke Glendening",
                "Dennis Cholowski",
                "Jonathan Bernier",
                "Danny Dekeyser",
                "Tyler Bertuzzi",
                "Darren Helm",
                "Johan Franzen",
                "Jonathan Ericsson",
                "Frans Nielsen"
            };

            try
            {
                studentNames.Count();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($" {ex} That student does not exist. Please try again. (enter a number 1 - 20): ");
            }

            if (numberOnArray >= newStudentID)
            {

                //studentNames.Insert(20, new KeyValuePair<uint, string>(numberOnArray, newName));
                studentNames.Add(newName);
            }

            //var selectionOfStudent = (from val in studentNames where val.Key == numberOnArray select val.Value).FirstOrDefault();
            int select = (-1) + (int)numberOnArray ;
            var selectionOfStudent = studentNames[select];
            return selectionOfStudent;
            
        }


        public static string SelectHometown(uint numberOnArray, string newHometown)
        {
            //var studentHomeTowns = new List<KeyValuePair<uint, string>>
            //{
            //    new KeyValuePair<uint, string>(1, "Detroit"),
            //    new KeyValuePair<uint, string>(2, "Hartford"),
            //    new KeyValuePair<uint, string>(3, "Stockholm"),
            //    new KeyValuePair<uint, string>(4, "Detroit"),
            //    new KeyValuePair<uint, string>(5, "Stockholm"),
            //    new KeyValuePair<uint, string>(6, "Toronto"),
            //    new KeyValuePair<uint, string>(7, "Toronto"),
            //    new KeyValuePair<uint, string>(8, "Baden bin Wein"),
            //    new KeyValuePair<uint, string>(9, "Stockholm"),
            //    new KeyValuePair<uint, string>(10,"Moscow"),
            //    new KeyValuePair<uint, string>(11,"Toronto"),
            //    new KeyValuePair<uint, string>(12, "Detroit"),
            //    new KeyValuePair<uint, string>(13, "Toronto"),
            //    new KeyValuePair<uint, string>(14, "Toronto"),
            //    new KeyValuePair<uint, string>(15, "Detroit"),
            //    new KeyValuePair<uint, string>(16, "Vancouver"),
            //    new KeyValuePair<uint, string>(17, "Winnipeg"),
            //    new KeyValuePair<uint, string>(18, "Stockholm"),
            //    new KeyValuePair<uint, string>(19, "Stockholm"),
            //    new KeyValuePair<uint, string>(20, "Herning"),

            //};

            var studentHomeTowns = new List<string>
            {
                "Detroit",
                "Hartford",
                "Stockholm",
                "Detroit",
                "Stockholm",
                "Toronto",
                "Toronto",
                "Baden bin Wein",
                "Stockholm",
                "Moscow",
                "Toronto",
                "Detroit",
                "Toronto",
                "Toronto",
                "Detroit",
                "Vancouver",
                "Winnipeg",
                "Stockholm",
                "Stockholm",
                "Herning",
            };

            if (numberOnArray >= newStudentID)
            {
                studentHomeTowns.Add(newHometown);
            }

            //var studentHometown = (from val in studentHomeTowns where val.Key == numberOnArray select val.Value).FirstOrDefault();
            int select = (-1) + (int)numberOnArray;
            var studentHometown = studentHomeTowns[select];
            return studentHometown;

        }

        public static string SelectFood(uint numberOnArray, string newFood)
        {
            //var food = new List<KeyValuePair<uint, string>>
            //{
            //    new KeyValuePair<uint, string>(1, "Cheese Cake"),
            //    new KeyValuePair<uint, string>(2, "Pasta"),
            //    new KeyValuePair<uint, string>(3, "Hamburger"),
            //    new KeyValuePair<uint, string>(4, "Hot Dog"),
            //    new KeyValuePair<uint, string>(5, "Chinese"),
            //    new KeyValuePair<uint, string>(6, "Pizza"),
            //    new KeyValuePair<uint, string>(7, "Fajita"),
            //    new KeyValuePair<uint, string>(8, "Taco"),
            //    new KeyValuePair<uint, string>(9, "BBQ"),
            //    new KeyValuePair<uint, string>(10, "Lobster"),
            //    new KeyValuePair<uint, string>(11, "Cheese Cake"),
            //    new KeyValuePair<uint, string>(12, "Pasta"),
            //    new KeyValuePair<uint, string>(13, "Hamburger"),
            //    new KeyValuePair<uint, string>(14, "Hot Dog"),
            //    new KeyValuePair<uint, string>(15, "Chinese"),
            //    new KeyValuePair<uint, string>(16, "Pizza"),
            //    new KeyValuePair<uint, string>(17, "Fajita"),
            //    new KeyValuePair<uint, string>(18, "Taco"),
            //    new KeyValuePair<uint, string>(19, "BBQ"),
            //    new KeyValuePair<uint, string>(20, "Lobster"),
            //    new KeyValuePair<uint, string>(21, ""),
            //    new KeyValuePair<uint, string>(22, ""),
            //    new KeyValuePair<uint, string>(23, ""),
            //    new KeyValuePair<uint, string>(24, ""),
            //    new KeyValuePair<uint, string>(25, "")

            //};

            var food = new List<string>
            {
                "Cheese Cake",
                "Pasta",
                "Hamburger",
                "Hot Dog",
                "Chinese",
                "Pizza",
                "Fajita",
                "Taco",
                "BBQ",
                "Lobster",
                "Cheese Cake",
                "Pasta",
                "Hamburger",
                "Hot Dog",
                "Chinese",
                "Pizza",
                "Fajita",
                "Taco",
                "BBQ",
                "Lobster",
           
            };

            if (numberOnArray >= newStudentID)
            {

                //food.Insert(listLocation, new KeyValuePair<uint, string>(numberOnArray, newFood));
                food.Add(newFood);
            }

            //var selectedFood = (from val in food where val.Key == numberOnArray select val.Value).FirstOrDefault();
            int select = (-1) + (int)numberOnArray;
            var selectedFood = food[select];
            return selectedFood;
        }

        public static string SelectColor(uint numberOnList, string newColor)
        {
            //var color = new List<KeyValuePair<uint, string>>
            //{
            //    "Red",
            //    "Green",
            //    "Orange",
            //    "Yellow",
            //    "Pink",
            //    "Blue",
            //    "Red"),
            //    "Red"),
            //    "Blue"),
            //    "Purple",
            //    new KeyValuePair<uint, string>(11, "Blue"),
            //    new KeyValuePair<uint, string>(12, "Blue"),
            //    new KeyValuePair<uint, string>(13, "Blue"),
            //    new KeyValuePair<uint, string>(14, "Green"),
            //    new KeyValuePair<uint, string>(15, "Orange"),
            //    new KeyValuePair<uint, string>(16, "Red"),
            //    new KeyValuePair<uint, string>(17, "Yellow"),
            //    new KeyValuePair<uint, string>(18, "Orange"),
            //    new KeyValuePair<uint, string>(19, "Yellow"),
            //    new KeyValuePair<uint, string>(20, "Red"),
            //    new KeyValuePair<uint, string>(21, "BBQ"),
            //    new KeyValuePair<uint, string>(22, "BBQ"),
            //    new KeyValuePair<uint, string>(23, "BBQ"),
            //    new KeyValuePair<uint, string>(24, "BBQ"),
            //    new KeyValuePair<uint, string>(25, "BBQ"),

            //};

            var color = new List<string>
            {
                "Red",
                "Green",
                "Orange",
                "Yellow",
                "Pink",
                "Blue",
                "Red",
                "Red",
                "Blue",
                "Purple",
                "Blue",
                "Blue",
                "Blue",
                "Green",
                "Orange",
                "Red",
                "Yellow",
                "Orange",
                "Yellow",
                "Red",
                "BBQ",
                "BBQ",
                "BBQ",
                "BBQ",
                "BBQ",

            };

            if (numberOnList >= newStudentID)
            {

                //color.Insert(listLocation, new KeyValuePair<uint, string>(numberOnList, newColor));
                color.Add(newColor);
            }

            //var selectedColor = (from val in color where val.Key == numberOnList select val.Value).FirstOrDefault();
            int select = (-1) + (int)numberOnList;
            var selectedColor = color[select];
            return selectedColor;
        }

        public static uint newStudentID = 21;
        public static int listLocation = 20;
        

        public static void AddNewStudent()
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
                Console.Write($"Looks you forgot to enter a color. Where is {newStudentName}'s hometown?: ");
                newStudentHomeTown = Console.ReadLine();
            }

            
            Console.WriteLine($"Awesome. So the new student is {newStudentName}. {newStudentName}'s favorite color is {newStudentFavoriteColor}, \n" +
                $"favorite food is {newStudentFavoriteFood}, and hometown is {newStudentHomeTown}. ");

            
             PickAStudent(newStudentID, newStudentName);
             SelectHometown(newStudentID, newStudentHomeTown);
             SelectFood(newStudentID, newStudentFavoriteFood);
             SelectColor(newStudentID, newStudentFavoriteColor);
             newStudentID++;
             listLocation++;
            
            }

    }
}

        
