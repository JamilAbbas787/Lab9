using System.Collections.Generic;
using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab09
{
    class CollectioOfList
    {
        public static string PickAStudent(int numberOnArray)
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


            var selectedStudent = from val in studentNames where val.Key == 1 select val.Value;

           } 
        
        public static List<string> Hometown(int numberOnArray)
        {
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
                "Toronto",

            };

            return studentHomeTowns;

        }

        



    }
}
