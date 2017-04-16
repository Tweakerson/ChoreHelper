using ChoreDataAccess.Interface;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using ChoreData;
using System;

namespace ChoreDataAccess.Repositories
{
    public class ChoreEventRepository : IChoreEventRepository
    {
        public ChoreEvent Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ChoreEvent> GetList()
        {
            var results = new List<ChoreEvent>();

            string sqlString = "SELECT Id, ChoreId, EventDate " +
                               "FROM ChoreEvent ";

            using (var connection = new SqlConnection(@"Server=localhost\SQLEXPRESS;Database=master;Trusted_Connection=True;"))
            {
                connection.Open();
                using (var comm = new SqlCommand(sqlString, connection))
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        ChoreEvent chore = new ChoreEvent();
                        var i = -1;
                        chore.Id = (int?)reader[++i];
                        chore.Chore = new Chore();
                        chore.Chore.Id = (int?)reader[++i];
                        chore.Completed = (DateTime?)reader[++i];
                        results.Add(chore);
                    }

                    reader.Close();
                }
            }

            return results;
        }
        
        public ChoreEvent Save(ChoreEvent entity)
        {
            throw new NotImplementedException();
            // TODO
            // return entity;
        }
    }
}
