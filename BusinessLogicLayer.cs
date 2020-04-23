using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LibraryManagmentSystem.dml;
using System.Data;
using LibraryManagmentSystem.exception;

namespace LibraryManagmentSystem.bll
{
    public class BusinessLogicLayer
    {
        static DataModelLayer Data = new DataModelLayer();
        public static bool Check(string Name)
        {
            bool Validation = true;
            char[] name = Name.ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z' || name[i] >= 'A' && name[i] <= 'Z')
                {
                    Validation = true;
                }
                else
                {
                    Validation = false;
                    break;
                }
            }
            if (Validation)
            {
                return Validation;
            }
            else
                return Validation;
        }

        public static bool Password(string Password)
        {
            int LowerCase = 0;
            int UpperCase = 0;
            int SpecialCharacter = 0;
            char[] name = Password.ToCharArray();
            for (int i = 0; i < name.Length; i++)
            {
                if (name[i] >= 'a' && name[i] <= 'z')
                {
                    LowerCase++;
                }
                else if (name[i] >= 'A' && name[i] <= 'Z')
                {
                    UpperCase++;
                }
                else if (!(name[i] >= 'a' && name[i] <= 'z') && !(name[i] >= 'A' && name[i] <= 'Z') && !(name[i] >= '0' && name[i] <= '9'))
                {
                    SpecialCharacter++;
                }
            }
            if (LowerCase > 4 && UpperCase > 0 && SpecialCharacter > 0)
            {
                return true;
            }
            return false;
        }

        public static bool AdminLogin(string Username, string Password)
        {
            if (Check(Username) && Password.Length > 4 && Password.Length < 15)
            {
                return Data.AdminLogin(Username, Password);
            }
            return false;
        }

        public static DataSet Display()
        {
           return Data.Display();
        }

        public static bool AddBook(int id, string name, int copies, string status,int Price, string author)
        {
            if (id > 0 && id < 100)
            {
                if (Check(name) && Check(author) && name.Length > 2 && name.Length < 15 && author.Length > 2 && author.Length < 15)
                {
                    if (copies > 0 && copies < 200)
                    {
                        if (status.Equals("new") || status.Equals("old"))
                        {
                            if (Price > 50 && Price < 5000)
                            {
                               return Data.AddBook(id, name, copies, status, Price, author);
                            }
                            else
                                throw new LibraryException("enter valid price");
                        }
                        else
                            throw new LibraryException("enter  valid status");
                    }
                    else
                        throw new LibraryException("enter valid copies");
                }
                else
                    throw new LibraryException("enter valid bookname or author name");
            }
            else
                throw new LibraryException("enter valid book id");
        }

        public static bool delete(int id)
        {
            if (id > 0 && id < 20)
            {
                return Data.DeleteBook(id);
            }
            return false;
        }

        public static bool UpdateBook(int id, string name, int copies, string status, int Price, string author)
        {
            if (id > 0 && id < 100)
            {
                if (Check(name) && Check(author) && name.Length > 2 && name.Length < 15 && author.Length > 2 && author.Length < 15)
                {
                    if (copies > 0 && copies < 200)
                    {
                        if (status.Equals("new") || status.Equals("old"))
                        {
                            if (Price > 50 && Price < 5000)
                            {
                                return Data.UpdateBook(id, name, copies, status, Price, author);
                            }
                            else
                                throw new LibraryException("enter valid price");
                        }
                        else
                            throw new LibraryException("enter  valid status");
                    }
                    else
                        throw new LibraryException("enter valid copies");
                }
                else
                    throw new LibraryException("enter valid bookname or author name");
            }
            else
                throw new LibraryException("enter valid book id");
        }

        public static bool UserRegistration(string name,string password,string usn,string branch,string year,int number)
        {
            if (Check(name) && Check(branch))
            {
                if (Password(password))
                {
                    return Data.UserRegistration(name, password, usn, branch, year, number);
                }
                else
                    throw new LibraryException("password should conatins 1 special character 1 upper case minimum 5 lower case");

            }
            else
                throw new LibraryException("enter valid name or branch");
        }


        public static DataSet DisplayUser()
        {
          return  Data.DisplayUser();
        }

        public static bool Adduser(string name,string password)
        {
           return Data.AddUser(name, password);
        }

        public static bool UserLogin(string Username, string password)
        {
            if (Check(Username) && password.Length > 4 && password.Length < 15 )
            {
                if (Password(password))
                {
                    return Data.UserLogin(Username, password);
                }
                return false;
            }
            return false;
        }

        public static bool RequestedBook(string bookname,string user)
        {
            if( Check(user))
            {
                return Data.RequestedBook(bookname, user);
            }
            return false;
        }

        public static DataSet Issue()
        {
            return Data.IssueBook();
        }
        public static bool Transcation(string book,string user)
        {
           return Data.Transcation(book, user);
        }

        public static DataSet DisplayedBook(string name)
        {
            return Data.DisplayedBook(name);
        }
        static void Main(string[] args)
        {
        }


    }
}
