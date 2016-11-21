using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter
{
    class Account
    {
        private string _accountGUID;
        private string _forename;
        private string _surname;
        private int _accountTypeId;


        public Account()
        {
            this._accountGUID = string.Empty;
            this._forename = string.Empty;
            this._surname = string.Empty;
            this._accountTypeId = 0;
        }

        public virtual void Login() { }

        public virtual void Logout() { }
        
    }
}
