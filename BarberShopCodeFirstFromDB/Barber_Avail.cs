namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Barber_Avail
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barber_Avail()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Key]
        public int barberAvail_id { get; set; }

        public int? shop_id { get; set; }

        public int? barber_id { get; set; }

        public int? shift_id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual Shop Shop { get; set; }

        public virtual Barber_shifts Barber_shifts { get; set; }
    }
}
