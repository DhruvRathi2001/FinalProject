using FinalProject.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Reflection;

namespace FinalProject.DataAccess
{
    public class EnquiryLoginDataAccess : DBConnection
    {

        public void CreateEnquirer(string email, string password)
        {
            string sql = "sp_createLoginEnquiry";
            try
            {
                ExecuteNonQuery(
                sqltext: sql,
                    commandType: CommandType.StoredProcedure,
                new SqlParameter("@email", email),
                new SqlParameter("@password", password));

            }
            catch (SqlException sqle)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
        }

        public int GetEnquirer(string email, string password)
        {
            int id = 1;
            string sql = "sp_getEnquirerId";
            try
            {
                var reader = ExecuteReader(
                    sqltext: sql,
                    commandType: CommandType.StoredProcedure,
                    new SqlParameter("@email", email),
                    new SqlParameter("@password",password));
                while (reader.Read())
                {
                    id=reader.GetInt32(0);
                }

            }
            catch (SqlException sqle)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return id;
        }
        public int UpdateEnquirer(string email, string password)
        {
            string sql = "sp_updateEnquiry";
            try
            {
                ExecuteNonQuery(
                sqltext: sql,
                    commandType: CommandType.StoredProcedure,
                new SqlParameter("@email", email),
                new SqlParameter("@password", password));

            }
            catch (SqlException sqle)
            {
                throw;
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                CloseConnection();
            }
            return id;
        }
    }
}
