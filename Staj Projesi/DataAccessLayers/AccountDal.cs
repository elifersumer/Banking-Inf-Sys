using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Staj_Projesi
{
    public class AccountDal
    {
        private string output;
        string ConnectionString = ConfigurationManager.ConnectionStrings["BankContext"].ConnectionString;

        List<Account> accounts = new List<Account>();
        
        public List<Account> GetAll()
        {
            using (BankContext context = new BankContext())
            {
                return context.ACCOUNT.ToList();
            }

        }

        public string GetAccountInfo(string info)
        {
            using (SqlConnection connection =new SqlConnection(ConnectionString))
            {
                
                connection.Open();
                int id = Int32.Parse(info);
                SqlCommand command = new SqlCommand("Select * from ACCOUNT where CustomerId=@id",connection);
                command.Parameters.AddWithValue("@id", id);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                { 
                    output += dataReader["CustomerName"] + "\n";
                    output += dataReader["Category"] + "\n"; 
                    output += dataReader["AccountNumber"] + "\n"; 
                    output += dataReader["Balance"];
                }

                dataReader.Close();
                connection.Close();

                return output;
            }
        }
    }
        }

    

