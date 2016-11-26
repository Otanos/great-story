using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCenter.Accounts
{
    interface IManageProducts
    {
        void AddProduct();
        void DeleteProduct();
        void EditProductPrize();
        void EditProductDescription();
        void EditProductName();
    }
}
