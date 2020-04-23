using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.exception
{
   public class LibraryException : Exception 
    {
     public LibraryException():base()
        {

        }
        public LibraryException(string message):base(message)
        {

        }
        public LibraryException(string message,Exception innerException):base(message,innerException)
        {

        }
        static void Main(string[] args)
        {
        }
    }
}
