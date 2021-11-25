namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Barber_shifts
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barber_shifts()
        {
            Barber_Avail = new HashSet<Barber_Avail>();
        }

        [Key]
        [Column(Order = 0)]
        public int barber_id { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int shift_id { get; set; }

        public int price { get; set; }

        public virtual Barber Barber { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Barber_Avail> Barber_Avail { get; set; }

        public virtual Shift Shift { get; set; }
    }
}
