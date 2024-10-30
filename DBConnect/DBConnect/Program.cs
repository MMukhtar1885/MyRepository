using MySql.Data;
using MySql.Data.MySqlClient;

string connStr ="server=localhost;user=root;database=world_connection;port=3306;password=Mukhtar2580";
MySqlConnection conn = new MySqlConnection(connStr);

 static void Main()
 {
string connStr ="server=localhost;user=root;database=world_connection;port=3306;password=Mukhtar2580";
 MySqlConnection conn = new MySqlConnection(connStr);
 try
 {
 Console.WriteLine("Connecting to MySQL--- world database");
 conn.Open();
 // Perform database operations
 string sql = "SELECT Name, HeadOfState FROM Country WHERE Continent='Oceania'";
 MySqlCommand cmd = new MySqlCommand(sql, conn);
 MySqlDataReader rdr = cmd.ExecuteReader();
 while (rdr.Read())
 {
 Console.WriteLine(rdr[0]+" -- "+rdr[1]);
 }
 rdr.Close();
 }
 catch (Exception ex)
 {
 Console.WriteLine(ex.ToString());
 }
 conn.Close(); // close the connection
 Console.WriteLine("Done the job");
 }

