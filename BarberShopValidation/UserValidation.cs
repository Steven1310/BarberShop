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
    ///  Thus is the validation class for USER
    /// </summary>
    public static class UserValidation
    {
        /// <summary>
        /// Make sure all user info exists and is not blank
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool UserInfoIsInvalid(this User user)
        {
            return (user == null ||
                    user.user_name == null || user.user_name.Trim().Length == 0 || user.user_email.Trim().Length == 0 || user.user_contact.Trim().Length == 0 ||
                    user.user_email == null || user.user_contact == null);
        }
    }
}
