using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
   public class Library
    {
        List<Book> Books = new List<Book>();
        List<AbstractPerson> Members = new List<AbstractPerson>();
        public void AddBook(Book book)
        {
            if (! Books.Contains(book))
            {
                Books.Add(book);
            }
            else
                Console.WriteLine("This book is exist");
        }
        public void AddMember(AbstractPerson member)
        {
            if (!Members.Contains(member))
            {
                Members.Add(member);
            }
            else
                Console.WriteLine("This member is exist");
        }
        public Book FindBookById(int id)
        {
            foreach (var item in Books)
            {
                if (item.Id == id)
                {
                    return item;
                }
                 
            }
            return null;

        }
        public AbstractPerson FindMemberById(int id)
        {
            foreach (var item in Members)
            {
                if (item.Id == id)
                {
                    return item;
                }

            }
            return null;

        }
        public   string DisplayAllBooks()
        {
            return $"{string.Join(", ", Books)}";
        }
        public string DisplayAllMembers()
        {
            return $"{string.Join(", ", Members)}";
        }


    }
}
