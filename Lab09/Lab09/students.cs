using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class CollectionOfList
    {
        public static string PickAStudent(uint numberOnArray)
        {
            
            var studentNames = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Dylan Larkin"),
                new KeyValuePair<int, string>(2, "Jimmy Howard"),
                new KeyValuePair<int, string>(3, "Niklas Kronwall"),
                new KeyValuePair<int, string>(4, "Justin Abdelkader"),
                new KeyValuePair<int, string>(5, "Gustav Nyquist"),
                new KeyValuePair<int, string>(6, "Anthony Mantha"),
                new KeyValuePair<int, string>(7, "Andreas Athanasiou"),
                new KeyValuePair<int, string>(8, "Thomas Vanek"),
                new KeyValuePair<int, string>(9, "Michael Rasmussen"),
                new KeyValuePair<int, string>(10, "Evgeny Svechnikov"),
                new KeyValuePair<int, string>(11, "Mike Green"),
                new KeyValuePair<int, string>(12, "Luke Glendening"),
                new KeyValuePair<int, string>(13, "Dennis Cholowski"),
                new KeyValuePair<int, string>(14, "Jonathan Bernier"),
                new KeyValuePair<int, string>(15, "Danny Dekeyser"),
                new KeyValuePair<int, string>(16, "Tyler Bertuzzi"),
                new KeyValuePair<int, string>(17, "Darren Helm"),
                new KeyValuePair<int, string>(18, "Johan Franzen"),
                new KeyValuePair<int, string>(19, "Jonathan Ericsson"),
                new KeyValuePair<int, string>(20, "Frans Nielsen"),
                };
          
            try
            {
                studentNames.Count();
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine($" {ex} That student does not exist. Please try again. (enter a number 1 - 20): ");
            }

            var selectionOfStudent = (from val in studentNames where val.Key == numberOnArray select val.Value).FirstOrDefault();
            return selectionOfStudent;
           } 
       

        public static string SelectHometown(uint numberOnArray)
        {
            var studentHomeTowns = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Detroit"),
                new KeyValuePair<int, string>(2, "Hartford"),
                new KeyValuePair<int, string>(3, "Stockholm"),
                new KeyValuePair<int, string>(4, "Detroit"),
                new KeyValuePair<int, string>(5, "Stockholm"),
                new KeyValuePair<int, string>(6, "Toronto"),
                new KeyValuePair<int, string>(7, "Toronto"),
                new KeyValuePair<int, string>(8, "Baden bin Wein"),
                new KeyValuePair<int, string>(9, "Stockholm"),
                new KeyValuePair<int, string>(10,"Moscow"),
                new KeyValuePair<int, string>(11,"Toronto"),
                new KeyValuePair<int, string>(12, "Detroit"),
                new KeyValuePair<int, string>(13, "Toronto"),
                new KeyValuePair<int, string>(14, "Toronto"),
                new KeyValuePair<int, string>(15, "Detroit"),
                new KeyValuePair<int, string>(16, "Vancouver"),
                new KeyValuePair<int, string>(17, "Winnipeg"),
                new KeyValuePair<int, string>(18, "Stockholm"),
                new KeyValuePair<int, string>(19, "Stockholm"),
                new KeyValuePair<int, string>(20, "Herning")
            };

            var studentHometown = (from val in studentHomeTowns where val.Key == numberOnArray select val.Value).FirstOrDefault();
            return studentHometown;

        }

        public static string SelectFood(uint numberOnArray)
        {
            var food = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Cheese Cake"),
                new KeyValuePair<int, string>(2, "Pasta"),
                new KeyValuePair<int, string>(3, "Hamburger"),
                new KeyValuePair<int, string>(4, "Hot Dog"),
                new KeyValuePair<int, string>(5, "Chinese"),
                new KeyValuePair<int, string>(6, "Pizza"),
                new KeyValuePair<int, string>(7, "Fajita"),
                new KeyValuePair<int, string>(8, "Taco"),
                new KeyValuePair<int, string>(9, "BBQ"),
                new KeyValuePair<int, string>(10, "Lobster"),
                new KeyValuePair<int, string>(11, "Cheese Cake"),
                new KeyValuePair<int, string>(12, "Pasta"),
                new KeyValuePair<int, string>(13, "Hamburger"),
                new KeyValuePair<int, string>(14, "Hot Dog"),
                new KeyValuePair<int, string>(15, "Chinese"),
                new KeyValuePair<int, string>(16, "Pizza"),
                new KeyValuePair<int, string>(17, "Fajita"),
                new KeyValuePair<int, string>(18, "Taco"),
                new KeyValuePair<int, string>(19, "BBQ"),
                new KeyValuePair<int, string>(20, "Lobster")

            };

            var selectedFood = (from val in food where val.Key == numberOnArray select val.Value).FirstOrDefault();
            return selectedFood;
        }

        public static string SelectColor(uint numberOnList)
        {
            var color = new List<KeyValuePair<int, string>>
            {
                new KeyValuePair<int, string>(1, "Red"),
                new KeyValuePair<int, string>(2, "Green"),
                new KeyValuePair<int, string>(3, "Orange"),
                new KeyValuePair<int, string>(4, "Yellow"),
                new KeyValuePair<int, string>(5, "Pink"),
                new KeyValuePair<int, string>(6, "Blue"),
                new KeyValuePair<int, string>(7, "Red"),
                new KeyValuePair<int, string>(8, "Red"),
                new KeyValuePair<int, string>(9, "Blue"),
                new KeyValuePair<int, string>(10, "Purple"),
                new KeyValuePair<int, string>(11, "Blue"),
                new KeyValuePair<int, string>(12, "Blue"),
                new KeyValuePair<int, string>(13, "Blue"),
                new KeyValuePair<int, string>(14, "Green"),
                new KeyValuePair<int, string>(15, "Orange"),
                new KeyValuePair<int, string>(16, "Red"),
                new KeyValuePair<int, string>(17, "Yellow"),
                new KeyValuePair<int, string>(18, "Orange"),
                new KeyValuePair<int, string>(19, "Yellow"),
                new KeyValuePair<int, string>(20, "Red")

            };

            var selectedColor = (from val in color where val.Key == numberOnList select val.Value).FirstOrDefault();
            return selectedColor;
        }

    }
}
