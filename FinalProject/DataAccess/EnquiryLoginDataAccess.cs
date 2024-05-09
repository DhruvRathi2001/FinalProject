using FinalProject.Model;
using Microsoft.Data.SqlClient;
using System.Data;
using System.Diagnostics.Metrics;
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

        public int GetEnquirer(string email)
        {
            int id = 0;
            string sql = "sp_getEnquirerId";
            try
            {
                var reader = ExecuteReader(
                    sqltext: sql,
                    commandType: CommandType.StoredProcedure,
                    new SqlParameter("@email", email)
                    );
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


        public void CreateEnquiry(
              string firstName,
              string lastName,
              string address1,
              string address2,
              string address3,
              string phoneNumber,
              string email,
               DateTime dob,
              string city,
              string country,
               int status,
               int pincode,
              int wants_cheque,
              string feedback,
               int managerId,
             bool isActive,
            string accountType,
           int enqLogid,
           int balance
       )
        {
            string sql = "sp_createEnquiry";
            try
            {
                ExecuteNonQuery(
                    sqltext: sql,
                    commandType: CommandType.StoredProcedure,
                    new SqlParameter("@fName", firstName),
                    new SqlParameter("@lName", lastName),
                    new SqlParameter("@address1", address1),
                    new SqlParameter("@address2", address2),
                    new SqlParameter("@address3", address3),
                    new SqlParameter("@phoneNumber", phoneNumber),
                    new SqlParameter("@email", email),
                    new SqlParameter("@DOB", dob),
                    new SqlParameter("@city", city),
                    new SqlParameter("@country", country),
                    new SqlParameter("@status", status),
                    new SqlParameter("@pincode", pincode),
                    new SqlParameter("@wants_cheque", wants_cheque),
                    new SqlParameter("@feedback", feedback),
                    new SqlParameter("@managerId", managerId),
                    new SqlParameter("@isActive", isActive),
                    new SqlParameter("@accountType", accountType),
                    new SqlParameter("@enqlogid", enqLogid),
                    new SqlParameter("@balance", balance)
                );
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

    }
}
