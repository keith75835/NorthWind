using System;
using System.Data;
using System.Data.SqlClient;

namespace NORTHWIND_TRADERS
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("New Supplier");
            string newSupplier = Console.ReadLine();
            string query = "INSERT INTO Suppliers ";

        }
        public void viewsuppliers()
        {
            using (SqlConnection connection = new SqlConnection(@"Data Source = (localdb)\MSSQLLocalDB; Initial Catalog = NORTHWND; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False"))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand("SELECT * FROM Suppliers", connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            for (int i = 0; i < reader.FieldCount; i++)
                            {
                                Console.WriteLine(reader.GetValue(i));
                            }
                            Console.WriteLine();
                        }
                    }
                }
            }
        }
    }
}
