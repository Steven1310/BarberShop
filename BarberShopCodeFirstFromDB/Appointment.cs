namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Appointment")]
    public partial class Appointment
    {
        [Key]
        public int appointment_id { get; set; }

        public int? barberAvail_id { get; set; }

        public int? haircut_id { get; set; }

        public int? user_id { get; set; }

        public TimeSpan? appointment_time { get; set; }

        [StringLength(10)]
        public string status_id { get; set; }

        [StringLength(1)]
        public string payment_status { get; set; }

        public int? review { get; set; }

        public virtual Haircut Haircut { get; set; }

        public virtual Status Status { get; set; }

        public virtual User User { get; set; }

        public virtual Barber_Avail Barber_Avail { get; set; }
    }
}
