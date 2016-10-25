using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter
{   
    class AdminAccount:Account, Accounts.IManageAccounts
    {
        Account Admin = new Account();

        public void CreateAccount()
        {

        }

        public void DeleteAccount()
        {
            
        }

        public void DisableAccount()
        {
            
        }

        public void EnableAccount()
        {
            
        }
    }
}
