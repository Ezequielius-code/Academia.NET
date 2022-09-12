using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Books
{
    internal static class Data
    {
        internal static string GenerateISBN()
        {
            Random random = new Random();

            string[] listOfISBN = new string[]
            {
                "363306964-X",
                "263660222-4",
                "776893208-0",
                "242667219-6",
                "083372975-6",
                "954562882-0",
                "727125178-2",
                "572059472-8",
                "054609455-4",
                "050132739-8"
            };

            string generatedISBN = listOfISBN[random.NextInt64(0, 10)];
            return generatedISBN;
        }

        internal static string GenerateTitle()
        {
            Random random = new Random();

            string[] listOfTitles = new string[]
            {
                "Bearer Of Glory",
                "Rebel Of Doom",
                "Women Of Evil",
                "Foreigners Of The Prison",
                "Farmers And Opponents",
                "Bringers And Servants",
                "Ruins Of The Forsaken",
                "Rise Of The Stockades",
                "Blinded By The Night",
                "Answering To My Dreams"
            };

            string generatedTitle = listOfTitles[random.NextInt64(0, 10)];
            return generatedTitle;
        }

        internal static string GenerateAuthor()
        {
            Random random = new Random();

            string[] listOfAuthors = new string[]
            {
                "Lind Zotto",
                "Charity Penke",
                "Warner Tegeller",
                "Obediah Osgordby",
                "Yevette Evans",
                "Clarita Louthe",
                "Gabriel Penney",
                "Nevin Meharg",
                "Gunther Cossom",
                "Hewett Taylorson"
            };

            string generatedAuthor = listOfAuthors[random.NextInt64(0, 10)];
            return generatedAuthor;
        }

        internal static int GenerateNumberOfPages()
        {
            Random random = new Random();
            Random numberOfPages = new Random();

            int[] listOfPagesQuantity = new int[]
            {
                numberOfPages.Next(500, 2501),
                numberOfPages.Next(500, 3001),
                numberOfPages.Next(500, 4001),
                numberOfPages.Next(500, 5001),
                numberOfPages.Next(500, 4790),
                numberOfPages.Next(500, 3561),
                numberOfPages.Next(500, 4813),
                numberOfPages.Next(500, 2456),
                numberOfPages.Next(500, 1323),
                numberOfPages.Next(500, 1425),
            };

            int generatedNumberOfPages = listOfPagesQuantity[random.NextInt64(0, 10)];
            return generatedNumberOfPages;
        }
    }
}
