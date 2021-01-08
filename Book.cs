using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        // Static Attribute
        public static int bookCount = 0;

        // Constructor
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            Author = aAuthor;
            pages = aPages;
            bookCount++;
        }

        public Book()
        {

        }

        public bool IsLong()
        {
            if(pages >= 500)
            {
                return true;
            }
            return false;
        }

        public string Author
        {
            get { return author; }
            set { 
                if(value != "")
                {
                    author = value;
                }
            }
        }

        public void NextPage()
        {
            Console.WriteLine("The next page.");
        }

        // Key word VIRTUAL allows subclass to override the method

        public virtual void PreviousPage()
        {
            Console.WriteLine("The previous page.");
        }
    }
}
