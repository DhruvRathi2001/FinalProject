using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Net.NetworkInformation;

namespace FinalProject.Model
{
    public class CreateEnquiry
    {

        private string _firstName = "";
        private string _lastName = "";
        private string _address1 = "";
        private string _address2 = "";
        private string _address3 = "";
        private string _phoneNumber = "";
        private string _email = "";
        private DateTime _dob;
        private string _city = "";
        private string _country = "";
        private int _status;
        private int _pincode;
        private int _wants_cheque;
        private string _feedback = "";
        private int _managerId;
        private bool _isActive = false;
        private string _accountType = "";
        private int _enqLogid=0;
        private int _balance = 0;

        public CreateEnquiry()
        {
        }

        public CreateEnquiry(string firstName, string lastName, string address1, string address2, string address3, string phoneNumber,
                       string email, DateTime date, string city, string country, int status, int pincode, int wants_cheque,
                       string feedback, int managerId, bool isActive, string accountType, int enqLogid,int balance)
        {
            _firstName = firstName;
            _lastName = lastName;
            _address1 = address1;
            _address2 = address2;
            _address3 = address3;
            _phoneNumber = phoneNumber;
            _email = email;
            _dob = date;
            _city = city;
            _country = country;
            _status = status;
            _pincode = pincode;
            _wants_cheque = wants_cheque;
            _feedback = feedback;
            _managerId = managerId;
            _isActive = isActive;
            _accountType = accountType;
            _enqLogid = enqLogid;
            _balance = balance;
        }

        public string FirstName
        {
            get { return _firstName; }
            set { _firstName = value; }
        }

        public string LastName
        {
            get { return _lastName; }
            set { _lastName = value; }
        }

        public string Address1
        {
            get { return _address1; }
            set { _address1 = value; }
        }

        public string Address2
        {
            get { return _address2; }
            set { _address2 = value; }
        }

        public string Address3
        {
            get { return _address3; }
            set { _address3 = value; }
        }

        public string PhoneNumber
        {
            get { return _phoneNumber; }
            set { _phoneNumber = value; }
        }

        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }

        public DateTime DOB
        {
            get { return _dob; }
            set { _dob = value; }
        }

        public string City
        {
            get { return _city; }
            set { _city = value; }
        }

        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public int Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public int Pincode
        {
            get { return _pincode; }
            set { _pincode = value; }
        }

        public int WantsCheque
        {
            get { return _wants_cheque; }
            set { _wants_cheque = value; }
        }

        public string Feedback
        {
            get { return _feedback; }
            set { _feedback = value; }
        }

        public int ManagerId
        {
            get { return _managerId; }
            set { _managerId = value; }
        }

        public bool IsActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        public string AccountType
        {
            get { return _accountType; }
            set { _accountType = value; }
        }

        public int EnqLogid
        {
            get { return _enqLogid; }
            set { _enqLogid = value; }
        }
        public int Balance
        {
            get { return _balance; }
            set { _balance = value; }
        }
    }
}
