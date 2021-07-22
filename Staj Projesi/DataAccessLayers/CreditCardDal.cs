using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace Staj_Projesi
{
    public class CreditCardDal
    {
        private string output;
        string ConnectionString = ConfigurationManager.ConnectionStrings["BankContext"].ConnectionString;

        List<CreditCard> creditCards = new List<CreditCard>();

        public List<CreditCard> GetAll()
        {
            using (BankContext context = new BankContext())
            {
                return context.CREDITCARD.ToList();
            }
        }

       

        public string GetCreditCardInfo(string info)
        {

            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                connection.Open();
                int id = Int32.Parse(info);
                SqlCommand command = new SqlCommand("Select * from CREDITCARD where CustomerId=@id",connection);
                command.Parameters.AddWithValue("@id", id);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output += dataReader["CustomerName"] + "\n";
                    output += dataReader["CreditCardNumber"] + "\n";
                    output += dataReader["Limit"] + " TL" + "\n";
                    output += dataReader["ExpiredDate"].ToString();
                }

                dataReader.Close();
                connection.Close();

                return output;
            }
        }

    }
}
