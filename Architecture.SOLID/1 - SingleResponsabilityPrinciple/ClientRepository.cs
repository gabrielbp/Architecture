﻿using System.Data.SqlClient;

namespace Architecture.SOLID.SingleResponsabilityPrinciple
{
  public class ClientRepository
  {
    public void Add(Client client)
    {
      using (var connection = new SqlConnection())
      {
        connection.ConnectionString = "MyConnectionString";

        var command = new SqlCommand();
        command.Connection = connection;
        command.CommandType = System.Data.CommandType.Text;
        command.CommandText = 
          @"INSERT INTO CLIENT (NAME, EMAIL, CPF, REGISTERDATE) 
            VALUES (@name, @email, @cpf, @registerDate)";

        command.Parameters.AddWithValue("name", client.Name);
        command.Parameters.AddWithValue("email", client.Email);
        command.Parameters.AddWithValue("cpf", client.CPF);
        command.Parameters.AddWithValue("registerDate", client.RegisterDate);

        connection.Open();
        command.ExecuteNonQuery();
      }
    }
  }
}
