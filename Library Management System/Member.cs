using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
   public class Member: AbstractPerson
    {

        public Member(int id, string name):base(id,name)
        {
           
        }
        public override void DisplayInfo() => Console.WriteLine($"Id= {Id} \n name is{Name}");
        public bool BorrowBook(Book book)
        {
            if (book.IsAvailable)
            {
                BorrowedBooks.Add(book);
                book.IsAvailable = false;
                return true;
            }
            return false;
        }
        public void ReturnBook(Book book)
        {
            if (BorrowedBooks.Contains(book))
            {
                BorrowedBooks.Remove(book);
                book.IsAvailable = true;

            }
        }
        public  string DisplayBorrowedBooks()
        {
            return $"{string.Join(", ", BorrowedBooks)}";
        }
    }
}
