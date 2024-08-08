using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Book_Details
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int NoOfCopies { get; set; }

        public Book_Details(int bookId,string bookName, string bookAuthor, int noOfCopies) 
        {
            BookId = bookId;
            BookName = bookName;
            BookAuthor = bookAuthor;
            NoOfCopies = noOfCopies;
        }

        public Book_Details() { }


        //Book display
        public override string ToString()
        {
            string display = $"Book id: {BookId} Book name: {BookName} Book author: {BookAuthor} No of copies: {NoOfCopies}";
            return display;
        }

        
        //Book search method
        public static void BookSearch(List<Book_Details> BookStore)
        {
            while (true)
            {
                Console.WriteLine("Enter Book search type : \n1.Id \n2.book name \n3.Author\n4.Exit search \n ");
                int SearchBook = Program.readInt("Enter search type number: ");
                if (SearchBook == 1)
                {
                    int searchId = Program.readInt("Enter book id ");
                    foreach (Book_Details book in BookStore)
                    {
                        if (book.BookId == searchId)
                        {
                            Console.WriteLine(book);
                        }
                        
                    }
                }
                else if (SearchBook == 2)
                {
                    string searchBookName = Program.read("Enter book name ");
                    foreach (Book_Details book in BookStore)
                    {
                        if (book.BookName.Contains(searchBookName))
                        {
                            Console.WriteLine(book);
                        }
                    }
                }
                else if (SearchBook == 3)
                {
                    string searchBookAuthor = Program.read("Enter book author ");
                    foreach (Book_Details book in BookStore)
                    {
                        if (book.BookAuthor.Contains(searchBookAuthor))
                        {
                            Console.WriteLine(book);
                        }
                    }
                }
                else if (SearchBook==4)
                {
                    break;
                }
                else { break; }
            }



        }

        //Book delete method
        public static void BookDelete(List<Book_Details> BookStore)
        {
            while (true)
            {
                Console.WriteLine("Enter Book delete type : \n1.Id \n2.book name \n3.Exit delete \n ");
                int DeleteBook = Program.readInt("Enter delete type number: ");

                if (DeleteBook == 1)
                {
                    int BookDeleteId = Program.readInt("Book delete \nEnter book id: ");
                    for (int i = 0; i < BookStore.Count; i++)
                    {
                        if (BookStore[i].BookId == BookDeleteId)
                        {
                            BookStore.RemoveAt(i);
                            Console.WriteLine("Book deleted");
                        }
                    }
                }
                else if (DeleteBook == 2)
                {
                    string BookDeleteName = Program.read("Book delete \nEnter book name: ");
                    for (int i = 0; i < BookStore.Count; i++)
                    {
                        if (BookStore[i].BookName == BookDeleteName)
                        {
                            BookStore.RemoveAt(i);
                            Console.WriteLine("Book deleted");
                        }
                    }
                }
                else if(DeleteBook == 3)
                {
                    break ;
                }


            }


        }

        //Book update method
        public static void UpdateBookDetails(List<Book_Details> BookStore)
        {
            int oldBookId = Program.readInt("Update book details\nEnter current book id: ");

            foreach (Book_Details book in BookStore)
            {
                if (book.BookId == oldBookId)
                {
                    string newBookId = Program.read("Enter new book id: ");
                    string newBookName = Program.read("Enter new book name: ");
                    string newBookAuthor = Program.read("Enter new book author: ");
                    string newNoOfCopies = Program.read("Enter new number of copies: ");
 
                    
                    book.BookId = int.Parse(newBookId);
                    book.BookName = newBookName;
                    book.BookAuthor = newBookAuthor;
                    book.NoOfCopies = int.Parse(newNoOfCopies);

                    Console.WriteLine("Book details updated");
                    break;
                }
            }
        }

    }
}


