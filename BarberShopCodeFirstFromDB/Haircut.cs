namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Haircut")]
    public partial class Haircut
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Haircut()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Key]
        public int haircut_id { get; set; }

        [Required]
        [StringLength(15)]
        public string picture { get; set; }

        [Required]
        [StringLength(100)]
        public string description { get; set; }

        public int price { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }
    }
}
