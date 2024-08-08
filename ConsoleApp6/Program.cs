using System.Net;
using System.Text.Json;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book_Details> BookStore = new List<Book_Details>();

            string jsonReader = File.ReadAllText("bookStore.json");
            BookStore = JsonSerializer.Deserialize<List<Book_Details>>(jsonReader);

            while (true)
            {
                Console.Write("Enter operation \n1.Add book: \n2.View book: \n3.Search book: \n4.Delete book: \n5.Update book: \n6.Exit system\n");
                int operation = readInt("Operation number : ");

                //add book
                if (operation == 1)
                {
                    int bookId = readInt("Enter book Id : ");
                    string bookName = read("Enter book name : ");
                    string bookAuthor = read("Enter book author : ");
                    int noOfCopies = readInt("Enter no of copies : ");

                    Book_Details book = new Book_Details(bookId,bookName,bookAuthor,noOfCopies);

                    BookStore.Add(book);

                }

                //view book
                else if(operation== 2)
                {
                    foreach (Book_Details book in BookStore)
                    {
                        Console.WriteLine(book);
                    }
                }

                //search book
                else if(operation == 3)
                {
                    Book_Details.BookSearch(BookStore);
                }

                //Delete book
                else if(operation == 4)
                {
                    Book_Details.BookDelete(BookStore);  
                }

                //Update book
                else if (operation == 5)
                {
                    Book_Details.UpdateBookDetails(BookStore);

                }

                //exit
                else if (operation== 6)
                {
                    string jsonWrite = JsonSerializer.Serialize(BookStore);
                    File.WriteAllText("bookStore.json", jsonWrite);
                    break;
                }
            }
        }

        public static string read(string message)
        {
            Console.Write(message);
            string read = Console.ReadLine();
            return read;
        }

        public static int readInt(string message)
        {
            Console.Write(message);
            string readInt = Console.ReadLine();
            return int.Parse(readInt);
        }
    }
}
