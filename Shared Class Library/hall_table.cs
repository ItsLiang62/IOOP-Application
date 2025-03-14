﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace Shared_Class_Library
{
    class HallTable : Table
    {
        public HallTable(string connectionString) : base(connectionString)
        {
        }

        public void InsertRow(string hallNumber, string hallName, int capacity, string recommendedEvent1, string recommendedevent2, bool isAvailable)
        {

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();

                string query = "INSERT INTO Hall (HallNumber, HallName, Capacity, RecommendedEvent1, RecommendedEvent2, IsAvailable) " +
                               "VALUES (@HallNumber, @HallName, @Capacity, @RecommendedEvent1, @RecommendedEvent2, @IsAvailable)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber);
                    cmd.Parameters.AddWithValue("@HallName", hallName);
                    cmd.Parameters.AddWithValue("@Capacity", capacity);
                    cmd.Parameters.AddWithValue("@RecommendedEvent1", recommendedEvent1);
                    cmd.Parameters.AddWithValue("@RecommendedEvent2", recommendedevent2);
                    cmd.Parameters.AddWithValue("@IsAvailable", isAvailable);

                    cmd.ExecuteNonQuery();

                }
            }
        }
        public object GetValue(string hallNumber, string column)
        {
            List<string> allowedColumns = new List<string> { "HallNumber, HallName, Capacity, RecommendedEvent1, RecommendedEvent2, IsAvailable" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Hall WHERE HallNumber = @HallNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return reader[column];
                        }
                        else
                        {
                            throw new Exception("Cannot find data. Are you sure you entered the HallNumber correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetColumnValues(string column)
        {
            List<string> allowedColumns = new List<string> { "HallNumber, HallName, Capacity, RecommendedEvent1, RecommendedEvent2, IsAvailable" };

            if (!allowedColumns.Contains(column))
            {
                throw new Exception("Invalid column name. Please enter a correct column.");
            }

            List<object> columnValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT {column} FROM Hall";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            columnValues.Add(reader[column]);
                        }
                        if (columnValues.Count > 0)
                        {
                            return columnValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find column. Are you sure you entered the column name correctly?");
                        }
                    }
                }

            }
        }

        public List<object> GetRowValues(string hallNumber)
        {

            List<object> rowValues = new List<object>();

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            {
                conn.Open();
                string query = $"SELECT * FROM Hall WHERE HallNumber = @HallNumber";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@HallNumber", hallNumber);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            rowValues.Add(reader["HallNumber"]);
                            rowValues.Add(reader["HallName"]);
                            rowValues.Add(reader["Capacity"]);
                            rowValues.Add(reader["RecommendedEvent1"]);
                            rowValues.Add(reader["RecommendedEvent2"]);
                            rowValues.Add(reader["IsAvailable"]);

                            return rowValues;
                        }
                        else
                        {
                            throw new Exception("Cannot find unique row. Are you sure you entered HallNumber correctly?");
                        }
                    }
                }

            }
        }
    }
}
