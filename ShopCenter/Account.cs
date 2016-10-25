using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter
{
    class Account
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public int AccountTypeId { get; set; }

        public override void CreateAccount();
        public override void DeleteAccount();
        public override void Login();
        public override void Logout();



    }
}
