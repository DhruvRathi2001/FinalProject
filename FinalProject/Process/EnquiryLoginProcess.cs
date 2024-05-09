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

        public int GetEnquirer(string email)
        {
            try
            {
                return elda.GetEnquirer(email);
            }
            catch
            {
                throw;
            }

        }

        public void CreateEnquiry(string firstName, string lastName, string address1, string address2, string address3, string phoneNumber,
                         string email, DateTime dob, string city, string country, int status, int pincode, int wantsCheque,
                         string feedback, int managerId, bool isActive, string accountType ,int EnqLogId, int balance)
        {
            try
            {
               

                    elda.CreateEnquiry(firstName, lastName, address1, address2, address3, phoneNumber, email, dob, city, country,
                                             status, pincode, wantsCheque, feedback, managerId, isActive, accountType, EnqLogId,balance);
              

            }
            catch
            {
               
                throw;
            }
        }


    }
}
