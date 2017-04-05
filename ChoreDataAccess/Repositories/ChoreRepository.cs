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
        public EntityBase Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<EntityBase> GetList()
        {
            var results = new List<EntityBase>();

            string sqlString = "SELECT Chore, Id " +
                               "FROM Chore ";

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
                        
                        results.Add(chore);
                    }

                    reader.Close();
                }
            }

            return results;
        }
        
        public EntityBase Save(EntityBase entity)
        {
            throw new NotImplementedException();
            // TODO
            // return entity;
        }
    }
}
