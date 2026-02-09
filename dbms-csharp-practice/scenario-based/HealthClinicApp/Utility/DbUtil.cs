using Microsoft.Data.SqlClient;

public static class DbUtil
{
    // Local SQL Server (Docker / Localhost)
    private static readonly string connectionString =
        "Server=127.0.0.1,1433;" +
        "Database=HealthClinicDB;" +
        "User Id=sa;" +
        "Password=#16March2007#;" +
        "Encrypt=False;" +
        "TrustServerCertificate=True;";

    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }
}


// using System;
// using Microsoft.Data.SqlClient;
// class StudentConnection
// {
    
//     public static void Main(string[] args)
//     {
//         string querry="Select * from Patients";

//        string connectionString =
// "Server=127.0.0.1,1433;" +
// "Database=HealthClinicDB;" +
// "User Id=sa;" +
// "Password=Gurjar#123;" +
// "Encrypt=True;" +
// "TrustServerCertificate=True;";

//         using SqlConnection connection=new SqlConnection(connectionString);
//         connection.Open();
//         Console.WriteLine("Connection established");
//          SqlCommand command =new SqlCommand(querry,connection);
//         SqlDataReader reader=command.ExecuteReader();
//         while (reader.Read())
//         {
//             System.Console.WriteLine(reader["patient_id"]+" "+reader["name"]+" "+reader["dob"]);
//         }
//         reader.Close();
//         connection.Close();

//     }
// }