using BarberShopCodeFirstFromDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarberShopValidation
{
    /// <summary>
    ///  author: Steven 
    ///  id:300329089
    ///  Thus is the validation class for Shop
    /// </summary>
    public static class ShopValidation
    {
        /// <summary>
        /// Make sure all shop info exists and is not blank
        /// </summary>
        /// <param name="shop"></param>
        /// <returns></returns>
        public static bool ShopInfoIsInvalid(this Shop shop)
        {
            return (shop == null ||
                    shop.shop_name == null || shop.shop_name.Trim().Length == 0 || shop.location.Trim().Length == 0 || shop.postal_code.Trim().Length == 0 ||
                    shop.location == null || shop.postal_code == null);
        }

    }
}
