using System;
using System.Collections.Generic;
using System.Data.SqlClient;


namespace ProductDataBase
{
    public class Product
    {
        private readonly SqlConnection conn;

        // Add product and delete pruduct
        public void insertProduct(Products product)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Products](ProductID, ProductName, ProductPrice, ProductStock, ProductDescription) VALUES(@ID, @Name, @Price, @Stock, @Description)";

                    command.Parameters.AddWithValue("@ID", product.productID);
                    command.Parameters.AddWithValue("@Name", product.productName);
                    command.Parameters.AddWithValue("@Price", product.productPrice);
                    command.Parameters.AddWithValue("@Stock", product.productStock);
                    command.Parameters.AddWithValue("@Description", product.productDescription);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("Product Added");
                    connection.Close();
                }
            }
        }

        public void deleteProduct(string ID)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Products WHERE ProductID = @ID";
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
        // add and delete users
        public void insertUser(Users users)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "INSERT INTO [Users](UserID, UserName, UserSurname, UserUsername, UserPassword) VALUES(@ID, @Name, @Surname, @Username, @Password)";

                    command.Parameters.AddWithValue("@ID", users.UserID);
                    command.Parameters.AddWithValue("@Name", users.UserName);
                    command.Parameters.AddWithValue("@Price", users.UserSurname);
                    command.Parameters.AddWithValue("@Stock", users.UserUsername);
                    command.Parameters.AddWithValue("@Description", users.USerPassword);

                    connection.Open();
                    command.ExecuteNonQuery();
                    Console.WriteLine("User Added");
                    connection.Close();
                }
            }
        }

        public void deleteUser(string ID)
        {
            using (SqlConnection connection = new SqlConnection())
            {
                using (SqlCommand command = connection.CreateCommand())
                {
                    command.CommandText = "DELETE FROM Users WHERE UserID = @ID";
                    connection.Open();
                    command.Parameters.AddWithValue("@ID", ID);
                    command.ExecuteNonQuery();
                }
                connection.Close();
            }
        }
    }
}