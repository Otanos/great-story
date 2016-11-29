using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter
{   
    class AdminAccount:Account, Accounts.IManageAccounts, Accounts.IManageProducts
    {
        Account UserAccount = new Account();

        private SqlCommand _createAccount;
        private SqlCommand _deleteAccount;
        private SqlCommand _disableAccount;
        private SqlCommand _enableAccount;
        private SqlCommand _addProduct;
        private SqlCommand _deleteProduct;

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

        public void AddProduct()
        {

        }

        public void DeleteProduct()
        {

        }

        public void EditProductPrize()
        {

        }

        public void EditProductDescription()
        {

        }

        public void EditProductName()
        {

        }
    }
}
