using Validations;

namespace ConsoleInputs
{
    public static class Input
    {
        private static string isbn = " ";
        private static string author = " ";
        public static string title = " ";
        public static string numberOfPages = " ";

        public static char AskOption()
        {
            Console.Write("How do you want to charge a new book?\n\t1_Auto\t2_Manual\n");
            char option = Console.ReadKey().KeyChar;
            Console.Clear();
            return option;
        }

        public static string RequestISBN()
        {
            do
            {
                Console.WriteLine("Enter ISBN number: ");
                isbn = Console.ReadLine();
                Console.Clear();
            } while (!Validation.ValidateISBN(isbn));
            string checkedISBN = isbn;
            return checkedISBN;
        }

        public static string RequestTitle()
        {
            do
            {
                Console.WriteLine("Enter Book Title: ");
                title = Console.ReadLine();
                Console.Clear();
            } while (!Validation.ValidateTitle(title));
            string checkedTitle = title;
            return checkedTitle;
        }

        public static string RequestAuthor()
        {
            do
            {
                Console.WriteLine("Enter Author name: ");
                author = Console.ReadLine();
                Console.Clear();
            } while (!Validation.ValidateAuthor(author));
            string checkedAuthor = author;
            return checkedAuthor;
        }

        public static int RequestNumberOfPages()
        {
            do
            {
                Console.WriteLine("Enter number of pages: ");
                numberOfPages = Console.ReadLine();
                Console.Clear();
            } while (!Validation.ValidateNumberOfPages(numberOfPages));
            int checkedNumberOfPages = int.Parse(numberOfPages);
            return checkedNumberOfPages;
        }

        public static char AskToGoOn()
        {
            Console.Write("Do you want to keep loading books?\n\t'y'es\t'n'o\n");
            char answer = Console.ReadKey().KeyChar;
            Console.Clear();
            return answer;
        }
    }
}