using Books;
using ConsoleInputs;

char answer;
char option;
string isbn = string.Empty;
string author = string.Empty;
string title = string.Empty;
int numberOfPages = 0;

Console.WriteLine("BOOK CHARGE ASSISTANT.");

do
{
    option = Input.AskOption();

    if (option == '1')
    {
        Book.AutoBookLoad();
        answer = Input.AskToGoOn();
    }
    else if (option == '2')
    {
        isbn = Input.RequestISBN();
        title = Input.RequestTitle();
        author = Input.RequestAuthor();
        numberOfPages = Input.RequestNumberOfPages(); 
       
        Book.ManualBookLoad(isbn, title, author, numberOfPages);
        answer = Input.AskToGoOn();
    }
    else
    {
        answer = 'n';
    }
} while (answer == 'y');