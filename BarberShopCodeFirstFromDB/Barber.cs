namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Barber")]
    public partial class Barber
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barber()
        {
            Barber_shifts = new HashSet<Barber_shifts>();
        }

        [Key]
        public int barber_id { get; set; }

        [Required]
        [StringLength(10)]
        public string barber_name { get; set; }

        [Required]
        [StringLength(30)]
        public string barber_email { get; set; }

        [Required]
        [StringLength(12)]
        public string barber_contact { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Barber_shifts> Barber_shifts { get; set; }
    }
}
