using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Management_System
{
   public class Book
    {
         public int Id { get; set; }
        public string Title { get; set; }
        public string AuthorName { get; set; }
        public bool IsAvailable { get; set; }
        public Book(int id, string title, string authorName)
        {
            Id = id;
            Title = title;
            AuthorName = authorName;
        }

        public   void DisplayInfo()
        {
            Console.WriteLine($"id={Id} \n  title={Title} \n AuthorName={AuthorName}\n  IsAvailable={IsAvailable}");
        }
    }
}
