using Dapper;
using SmartPM.Business.Helpers;
using SmartPM.Business.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace SmartPM.Business.Repositories
{
    public class UserDefinedRepository
    {
        public IEnumerable<M_UserDefined> GetUserDefined(string category,string keyID)
        {
            using(var db=new SqlConnection(Configs.ConnectionString))
            {
                var result=db.Query<M_UserDefined>("p_UserDefined_Get @Category,@KeyID", new
                {
                    Category=category,
                    KeyID= keyID
                });

                return result;
            }
        }

        public void AddUserDefined(M_UserDefined model)
        {
            using(var db=new SqlConnection(Configs.ConnectionString))
            {
                db.Execute("p_UserDefined_Insert @Category,@KeyID,@Value,@Value_2,@Value_3,@IsActive,@Remark"
                    , model);
            }
        }

        public void UpdateUserDefined(M_UserDefined model)
        {
            using(var db=new SqlConnection(Configs.ConnectionString)) {
                db.Execute("p_UserDefined_Update @ID,@Category,@KeyID,@Value,@Value_2,@Value_3,@IsActive,@Remark"
                   , model);
            }
        }

        public void DeleteUserDefined(int id)
        {
            using(var db=new SqlConnection(Configs.ConnectionString))
            {
                db.Execute("p_UserDefined_Delete @ID", new { ID = id });
            }
        }
    }
}
