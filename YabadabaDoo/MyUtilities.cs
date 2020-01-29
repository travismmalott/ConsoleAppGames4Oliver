using System;
using System.Data.SqlClient;
public class MyUtilities
{
    public static void Display(object value)
    {
        try
        {
            using (var connection = new SqlConnection("server=saftsqlserver.database.windows.net;database=mysqldatabase;user id=student;password=Pa$$w0rd"))
            {
                connection.Open();
                using (var command = new SqlCommand("insert messages (value) values (@value)", connection))
                {
                    command.Parameters.AddWithValue("@value", value);
                    command.ExecuteNonQuery();
                    Console.WriteLine("no error, you are a rockstar!!");
                }
            }
        }
        catch (ArgumentException)
        {
            Console.WriteLine("Connection string error, you blew it.");
        }
        catch (SqlException)
        {
            Console.WriteLine("sql database offline, they blew it.");
        }
        catch (Exception)
        {
            Console.WriteLine("Unknown error, somebody blew it.");
        }
    }
    public static int? GetInt(string prompt)
    {
        int? result = null;
        int maxCount = 3;
        int count = 0;
        string s;
        int i;
       do
        {
            Console.Write(prompt);
            Console.Write(" ");
           s = Console.ReadLine();
            if (int.TryParse(s, out i))
            {
                result = i;
            }
            else
            {
                result = null;
            }
            ++count;
        }
        while (result == null && count < maxCount);
        return result;
    }
    public static decimal? GetDecimal(string prompt)
    {
        decimal? result = null;
        decimal maxCount = 3;
        decimal count = 0;
        string s;
        decimal i;
        do
        {
            Console.Write(prompt);
            Console.Write(" ");
            s = Console.ReadLine();
            if (decimal.TryParse(s, out i))
            {
                result = i;
            }
            else
            {
                result = null;
            }
            ++count;
        }
        while (result == null && count < maxCount);
        return result;
    }

}