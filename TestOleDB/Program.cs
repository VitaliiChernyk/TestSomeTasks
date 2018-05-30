using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOleDB
{
    class Program
    {
        static void Main(string[] args)
        {
            string connctionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source="
                                     + @"D:\Programing\Learning\aspmvc\GameStore\DB\GameStore.mdf";
            string queryString = "SELECT Name,Description,[Category] from dbo.Games "
                                 + "WHERE GameID > ? "
                                 + "Order by Price";
            int paramValue = 1;
            using (OleDbConnection connection = new OleDbConnection(connctionString))
            {
                OleDbCommand command = new OleDbCommand(queryString,connection);
                command.Parameters.AddWithValue("@idNumber", paramValue);
                try
                {
                    connection.Open();
                    OleDbDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        Console.WriteLine("\t{0}\t{1}\t{2}", reader[0], reader[1], reader[2]);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                Console.ReadKey();
            }
        }
    }
}
