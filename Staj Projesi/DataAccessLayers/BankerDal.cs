using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;


namespace Staj_Projesi
{
    public class BankerDal
    {
        string output;
        string ConnectionString = ConfigurationManager.ConnectionStrings["BankContext"].ConnectionString;
       
        List<Banker> bankers = new List<Banker>();

        public List<Banker> GetAll()
        {
            using (BankContext context = new BankContext())
            {
                return context.BANKER.ToList();
            }

        }

        public string GetBankerInfo(string info)
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                
                connection.Open();
                int id = Int32.Parse(info);
                SqlCommand command = new SqlCommand("Select * from BANKER where CustomerId=@id",connection);
                command.Parameters.AddWithValue("@id", id);


                SqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    output += dataReader["BankerId"].ToString() + "\n";
                    output += dataReader["FirstName"] + " ";
                    output += dataReader["LastName"] + "\n";
                    output += dataReader["City"] + "\n";
                    output += dataReader["Email"];


                }

                dataReader.Close();
                connection.Close();

                return output;
            }
        }
        
    }
}