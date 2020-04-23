using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace LibraryManagmentSystem.dml
{
    public class DataModelLayer
    {
        SqlConnection sql = new SqlConnection("server=LAPTOP-Q17CS5HU;database=Librarydb;integrated security=true");

        public bool AdminLogin(string user, string pass)
        {
            SqlCommand sqlc = new SqlCommand("select count(*) from Logintable where Username=@user and Password=@pass", sql);
            sqlc.Parameters.Add(new SqlParameter("@user", user));
            sqlc.Parameters.Add(new SqlParameter("@pass", pass));
            sql.Open();
            int validation = (int)sqlc.ExecuteScalar();
            sql.Close();
            if (validation > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataSet Display()
        {
            SqlDataAdapter sqld = new SqlDataAdapter("select * from Booktable", sql);
            DataSet set = new DataSet();
            sqld.Fill(set);
            return set;
        }

        public bool AddBook(int id, string name, int copies, string status, int price, string author)
        {
            SqlCommand sqlc = new SqlCommand("adduser @id,@name,@copies,@status,@price,@author", sql);
            sqlc.Parameters.Add(new SqlParameter("@id", id));
            sqlc.Parameters.Add(new SqlParameter("@name", name));
            sqlc.Parameters.Add(new SqlParameter("@copies", copies));
            sqlc.Parameters.Add(new SqlParameter("@status", status));
            sqlc.Parameters.Add(new SqlParameter("@price", price));
            sqlc.Parameters.Add(new SqlParameter("@author", author));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }

        public bool DeleteBook(int id)
        {
            SqlCommand sqlc = new SqlCommand("deletebook @id", sql);
            sqlc.Parameters.Add(new SqlParameter("@id", id));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }

        public bool UpdateBook(int id, string name, int copies, string status, int price, string author)
        {
            SqlCommand sqlc = new SqlCommand("updateuser @id,@name,@copies,@status,@price,@author", sql);
            sqlc.Parameters.Add(new SqlParameter("@id", id));
            sqlc.Parameters.Add(new SqlParameter("@name", name));
            sqlc.Parameters.Add(new SqlParameter("@copies", copies));
            sqlc.Parameters.Add(new SqlParameter("@status", status));
            sqlc.Parameters.Add(new SqlParameter("@price", price));
            sqlc.Parameters.Add(new SqlParameter("@author", author));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }

        public bool UserRegistration(string name, string password, string usn, string branch, string year, int phone)
        {
            SqlCommand sqlc = new SqlCommand("Registration @id,@name,@copies,@status,@price,@author", sql);
            sqlc.Parameters.Add(new SqlParameter("@id", name));
            sqlc.Parameters.Add(new SqlParameter("@name", password));
            sqlc.Parameters.Add(new SqlParameter("@copies", usn));
            sqlc.Parameters.Add(new SqlParameter("@status", branch));
            sqlc.Parameters.Add(new SqlParameter("@price", year));
            sqlc.Parameters.Add(new SqlParameter("@author", phone));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }

        public DataSet DisplayUser()
        {
            SqlDataAdapter sqld = new SqlDataAdapter("select * from Usertable", sql);
            DataSet set = new DataSet();
            sqld.Fill(set);
            return set;
        }

        public bool AddUser(string name, string password)
        {
            int id1 = 0, id2 = 0, id3 = 0;
            SqlCommand sqlc = new SqlCommand("insert into Userlogintable values(@name,@password,@id1,@id2,@id3)", sql);
            sqlc.Parameters.Add(new SqlParameter("name", name));
            sqlc.Parameters.Add(new SqlParameter("@password", password));
            sqlc.Parameters.Add(new SqlParameter("@id1", id1));
            sqlc.Parameters.Add(new SqlParameter("@id2", id2));
            sqlc.Parameters.Add(new SqlParameter("@id3", id3));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }

        public bool UserLogin(string user, string pass)
        {
            SqlCommand sqlc = new SqlCommand("select count(*) from Userlogintable where Username=@user and Password=@pass", sql);
            sqlc.Parameters.Add(new SqlParameter("@user", user));
            sqlc.Parameters.Add(new SqlParameter("@pass", pass));
            sql.Open();
            int validation = (int)sqlc.ExecuteScalar();
            sql.Close();
            if (validation > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool RequestedBook(string bookname, string user)
        {
            SqlCommand sqlc = new SqlCommand("requestedbook @name,@password,'22-04-2020','pending' ", sql);
            sqlc.Parameters.Add(new SqlParameter("name", bookname));
            sqlc.Parameters.Add(new SqlParameter("@password", user));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }
        public DataSet IssueBook()
        {
            SqlDataAdapter sqld = new SqlDataAdapter("select * from Requsetedbooktable", sql);
            DataSet set = new DataSet();
            sqld.Fill(set);
            return set;
        }

        public bool Transcation(string bookname,string user)
        {
            SqlCommand sqlc = new SqlCommand("insert into Issuebooktable values (@bookname,@user,'22-04-2020','Issued')", sql);
     
            sqlc.Parameters.Add(new SqlParameter("@bookname",bookname));
            sqlc.Parameters.Add(new SqlParameter("@user",user));
            sql.Open();
            int validation = sqlc.ExecuteNonQuery();
            sql.Close();
            if (validation > 0)
                return true;
            else
                return false;
        }
        public  DataSet DisplayedBook(string name)
        {
            SqlDataAdapter sqld = new SqlDataAdapter("select * from Issuebooktable where Username=@name" , sql);
            sqld.SelectCommand.Parameters.Add("@name", name);
            DataSet set = new DataSet();
            sqld.Fill(set);
            return set;
        }


        static void Main(string[] args)
        {
        }

    }
}

