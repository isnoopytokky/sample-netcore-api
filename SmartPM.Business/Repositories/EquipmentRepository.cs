using Dapper;
using SmartPM.Business.Helpers;
using SmartPM.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SmartPM.Business.Repositories
{
    public class EquipmentRepository
    {
        public IEnumerable<M_Equipment> GetEQ(string eqCode,string eqName)
        {
            using (var db = new SqlConnection(Configs.ConnectionString))
            {
                var result = db.Query<M_Equipment>("p_EQ_Get @EQCode,@EQName",
                  new { EQCode=eqCode,
                  EQName=eqName});

                return result;
            }
        }

        public void AddEQ(M_Equipment model)
        {
            using(var db=new SqlConnection(Configs.ConnectionString))
            {
                db.Execute("p_EQ_Insert @EQCode,@EQName,@Location", model);
            }
        }

        public void UpdateEQ(M_Equipment model)
        {
            using(var db=new SqlConnection(Configs.ConnectionString))
            {
                db.Execute("p_EQ_Update @EQCode,@EQName,@Location", model);
            }
        }

        public void DeleteEQ(string eq_code)
        {
            using(var db=new SqlConnection(Configs.ConnectionString))
            {
                db.Execute("p_EQ_Delete @EQCode", new { EQ_CODE = eq_code });
            }
        }


    }
}
