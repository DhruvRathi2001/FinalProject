using FinalProject.DataAccess;

namespace FinalProject.Process
{
    public class EnquiryLoginProcess
    {

        EnquiryLoginDataAccess elda = new EnquiryLoginDataAccess();

        public void CreateEnquirer(string email, string password)
        {
            try
            {
                elda.CreateEnquirer(email, password);
            }
            catch
            {
                throw ;
            }
           
        }

        public int GetEnquirer(string email, string password)
        {
            try
            {
                return elda.GetEnquirer(email, password);
            }
            catch
            {
                throw;
            }

        }
    }
}
