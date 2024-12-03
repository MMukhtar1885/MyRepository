using MySql.Data;
using MySql.Data.MySqlClient;


public class DBConnect
{
    public static void Main()
    {
        string connStr = "server=localhost;user=root;database=world;port=3306;password=L3tM31n";
        MySqlConnection conn = new MySqlConnection(connStr);
        try
        {
            Console.WriteLine("Connecting to MySQL--- world database");
            conn.Open();
            // Perform database operations
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.ToString());
        }
        conn.Close(); // close the connection
        Console.WriteLine("Done the job");
    }

}