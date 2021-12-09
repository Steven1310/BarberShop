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
    ///  Thus is the validation class for Barber
    /// </summary>
    public static class BarberValidation
    {
        /// <summary>
        /// Make sure all user info exists and is not blank
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public static bool BarberInfoIsInvalid(this Barber barber)
        {
            return (barber == null ||
                    barber.barber_name == null || barber.barber_name.Trim().Length == 0 || barber.barber_email.Trim().Length == 0 || barber.barber_contact.Trim().Length == 0 ||
                    barber.barber_email == null || barber.barber_contact == null);
        }

    }
}
