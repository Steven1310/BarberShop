namespace BarberShopCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Shop
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Shop()
        {
            Barber_Avail = new HashSet<Barber_Avail>();
        }

        [Key]
        public int shop_id { get; set; }

        [Required]
        [StringLength(70)]
        public string shop_name { get; set; }

        [Required]
        [StringLength(70)]
        public string location { get; set; }

        [Required]
        [StringLength(6)]
        public string postal_code { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Barber_Avail> Barber_Avail { get; set; }
    }
}
