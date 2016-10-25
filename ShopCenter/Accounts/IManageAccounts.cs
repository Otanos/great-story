using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Accounts
{
    interface IManageAccounts
    {
        void CreateAccount();
        void DeleteAccount();
        void DisableAccount();
        void EnableAccount();
    }
}
