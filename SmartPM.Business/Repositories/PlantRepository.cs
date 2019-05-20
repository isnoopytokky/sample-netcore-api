using Dapper;
using SmartPM.Business.Helpers;
using SmartPM.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SmartPM.Business.Repositories
{
    public class PlantRepository
    {
        public IEnumerable<M_Plant> GetPlant()
        {
            using (var db = new SqlConnection(Configs.ConnectionString))
            {
                var result = db.Query<M_Plant>("p_Plant_Get");
                return result;
            }
        }

        public void AddPlant(M_Plant plant)
        {
            using (var db = new SqlConnection(Configs.ConnectionString))
            {
                db.Execute(@"p_Plant_Insert 
                            @PlantID
                          , @PlantCode
                          , @PlantName
                          , @CreateBy", plant);
            }
        }

        public void UpdatePlant(M_Plant plant)
        {
            using (var db = new SqlConnection(Configs.ConnectionString))
            {
                db.Execute(@"p_Plant_Update
                            @PlantID
                          , @PlantCode
                          , @PlantName
                          , @UpdateBy", plant);
            }
        }

        public void DeletePlant(int plantID)
        {
            using (var db = new SqlConnection(Configs.ConnectionString))
            {
                db.Execute("p_Plant_Delete @PlantID", new
                {
                    PlantID=plantID
                });
            }
        }
    }
}
