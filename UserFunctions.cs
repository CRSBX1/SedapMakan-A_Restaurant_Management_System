using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SedapMakan
{
    public static class Username
    {
        public static string username;

        public static int id;

        public static string role;
    }

    

    public class Users
    {
        private string id;
        private string AccountName;
        private string Password;
        private string Email;
        private string FullName;
        private string PhoneNumber;
        private string Address;
        private string Role;

        public Users(string userid,string accname, string email, string pwd, string fullname, string phonenum, string address, string role)
        {
            id = userid;
            AccountName = accname;
            Password = pwd;
            Email = email;
            FullName = fullname;
            PhoneNumber = phonenum;
            Address = address;
            Role = role;
        }

        public string UserID
        {
            get { return id; }
        }

        public string accountname
        {
            get { return AccountName; } set { AccountName = value; }
        }

        public string password
        {
            get { return Password; }
            set { Password = value; }
        }

        public string fullname
        {
            get { return FullName; }
            set { FullName = value; }
        }

        public string email
        {
            get { return Email; }
            set { Email = value; }
        }

        public string phonenumber
        {
            get { return PhoneNumber; }
            set { PhoneNumber = value; }
        }

        public string address
        {
            get { return Address; }
            set { Address = value; }
        }

        public string role
        {
            get { return Role; }
            set { Role = value; }
        }
    }
}
