using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial
{
    class ChineseBook : Book
    {
        // Key word OVERRIDE to override the method from parent class method

        public override void PreviousPage()
        {
            Console.WriteLine("The previous page.");
        }
    }
}
