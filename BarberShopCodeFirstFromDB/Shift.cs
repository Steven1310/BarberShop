namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shift
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shift()
        {
            Barber_shifts = new HashSet<Barber_shifts>();
        }

        [Key]
        public int shift_id { get; set; }

        public TimeSpan shift_start_time { get; set; }

        public TimeSpan shift_end_time { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Barber_shifts> Barber_shifts { get; set; }
    }
}
