using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter
{
    class Account
    {
        private string AccountGUID;
        private string Forename;
        private string Surname;
        private int AccountTypeId;


        public Account()
        {
            this.AccountGUID = string.Empty;
            this.Forename = string.Empty;
            this.Surname = string.Empty;
            this.AccountTypeId = 0;
        }

        public virtual void Login() { }

        public virtual void Logout() { }
        
    }
}
