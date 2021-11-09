using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleData
{
    internal class Program
    {
        public static string ConnectionString = "Data Source=DESKTOP-C25RLDB\\SQLEXPRESS;Initial Catalog=SomeDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        private static void Main(string[] args)
        {
            //dependecies SqlClient
            var res = "n";
            do
            {
                //AdoData();

                Console.WriteLine("Do you want to continue more");
                res = Console.ReadLine();
            } while (res.ToLower() == "y");

            Console.ReadLine();
        }

        private static void AdoData()
        {
            Console.WriteLine("Press 1 to View All\n2 to Insert\n3 to Update \n4 to Delete");
            var choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    ReadPersonalTable();
                    break;

                case "2":
                    InsertPersonal();
                    break;

                case "3":
                    UpdatePersonal();
                    break;

                case "4":
                    DeletePersonal();
                    break;

                default:
                    break;
            }
        }

        private static void ReadPersonalTable()
        {
            //step 1 create a connection object
            SqlConnection con = new SqlConnection(ConnectionString);
            //step 2
            string query = "select * from Personal";
            //step 3 create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //step 4 open the connection
            con.Open();
            //step 5 execute the command
            var res = cmd.ExecuteReader();
            //step 6 Close conenction
            con.Close();
            //step 7 Read the data
            while (res.Read())
            {
                Console.WriteLine($"Id => {res.GetFieldValue<int>(0)}, FullName => {res.GetFieldValue<string>(1)} {res.GetFieldValue<string>(2)}");
            }
        }

        private static void InsertPersonal()
        {
            Console.WriteLine("Enter FirstName ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            var lastName = Console.ReadLine();

            //step 1 create a connection object
            SqlConnection con = new SqlConnection(ConnectionString);
            //step 2
            string query = $"insert into Personal (first_name, last_name) values ('{firstName}','{lastName}')";
            //step 3 create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //step 4 open the connection
            con.Open();
            //step 5 execute the command
            var res = cmd.ExecuteNonQuery();

            //step 6 Close conenction
            con.Close();
        }

        private static void UpdatePersonal()
        {
            Console.WriteLine("Enter Id ");
            var id = Console.ReadLine();
            Console.WriteLine("Enter FirstName ");
            var firstName = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            var lastName = Console.ReadLine();

            //step 1 create a connection object
            SqlConnection con = new SqlConnection(ConnectionString);
            //step 2
            string query = $"update Personal set first_name='{firstName}', last_name='{lastName}' where id='{id}'";
            //step 3 create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //step 4 open the connection
            con.Open();
            //step 5 execute the command
            var res = cmd.ExecuteNonQuery();

            //step 6 Close conenction
            con.Close();
        }

        private static void DeletePersonal()
        {
            Console.WriteLine("Enter Id ");
            var id = Console.ReadLine();

            //step 1 create a connection object
            SqlConnection con = new SqlConnection(ConnectionString);
            //step 2
            string query = $"delete from Personal where id='{id}'";
            //step 3 create a command object
            SqlCommand cmd = new SqlCommand(query, con);
            //step 4 open the connection
            con.Open();
            //step 5 execute the command
            var res = cmd.ExecuteNonQuery();

            //step 6 Close conenction
            con.Close();
        }
    } //ORM => Object Relation Mapping/Mapper (EntityFramework,NHibernate, Dapper)
}
