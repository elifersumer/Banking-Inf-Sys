using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace Staj_Projesi
{
    public class CustomerDal
    {
        string ConnectionString = ConfigurationManager.ConnectionStrings["BankContext"].ConnectionString;

        public List<Customer> _customers = new List<Customer>();

        public List<Customer> GetAll()
        {
            using (BankContext context = new BankContext())
            {
                return context.CUSTOMER.ToList();
            }
        }

        public string GetGender(string Id,string output)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int id = Convert.ToInt32(Id);
               
                SqlCommand command = new SqlCommand("Select * from CUSTOMER where CustomerId=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                
                SqlDataReader dataReader = command.ExecuteReader();
               
                while (dataReader.Read())
                {
                    output += dataReader["Gender"].ToString();
                }
                
                dataReader.Close();
                connection.Close();

                return output;
            }
        }

        public string GetLastName(string Id, string output)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int id = Convert.ToInt32(Id);

                SqlCommand command = new SqlCommand("Select * from CUSTOMER where CustomerId=@id", connection);
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output += dataReader["LastName"].ToString();
                }

                dataReader.Close();
                connection.Close();

                return output;
            }
        }

        public string CustomerContain(string Id, string output)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int id = Convert.ToInt32(Id);

                SqlCommand command = new SqlCommand("Select * from CUSTOMER where CustomerId=@id", connection);
                command.Parameters.AddWithValue("@id", id);

                SqlDataReader dataReader = command.ExecuteReader();

                while (dataReader.Read())
                {
                    output += dataReader["CustomerId"].ToString();
                }

                dataReader.Close();
                connection.Close();

                return output;
            }
        }

        //public string GetById(string key)
        //{
        //    using (BankContext context = new BankContext())
        //    {
        //        string cont = context.CUSTOMER.Where(p => p.CustomerId.Contains(key)).ToString();
        //        return cont;
        //    }
        //}


    }
}