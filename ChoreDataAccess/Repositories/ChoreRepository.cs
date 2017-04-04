using ChoreDataAccess.Interface;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChoreData;
using System;

namespace ChoreDataAccess.Repositories
{
    public class ChoreRepository : IChoreRepository
    {
        public IEnumerable<Chore> GetList()
        {
            var results = new List<Chore>();

            string sqlString = "SELECT chore " +
                               "FROM chorelist ";

            using (var connection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
            {
                connection.Open();
                using (var comm = new SqlCommand(sqlString, connection))
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        Chore chore = new Chore();
                        var i = -1;
                        chore.Id = (int)reader[++i];
                        chore.Name = reader[++i].ToString();
                        chore.Completed = (DateTime)reader[++i];

                        results.Add(chore);

                    }
                    reader.Close();
                }
            }

            return results;
        }

        public Chore Save(Chore entity)
        {
            
            return entity;
        }
    }
}
