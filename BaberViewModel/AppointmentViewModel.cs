using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaberViewModel
{
    public class AppointmentViewModel
    {
        public int appointment_id { get; set; }
        public string BarberName { get; set; }

        public string HairStyle { get; set; }

       public string user_name { get; set; }

        public TimeSpan appointment_time { get; set; }

        public string Status { get; set; }

        public string payment_status { get; set; }

    }
}
