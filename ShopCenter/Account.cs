using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter
{
    class Account
    {
        public string AccountGUID { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int AccountTypeId { get; set; }

        // Creating User Account with specified type
        public override void CreateAccount();

        // Deleting User Account 
        public override void DeleteAccount();

        // Login to the system Account
        public override void Login();

        // Logout from the system
        public override void Logout();        
    }
}
