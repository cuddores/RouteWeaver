namespace RouteWeaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Cities
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Cities()
        {
            Attraction = new HashSet<Attraction>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int city_id { get; set; }

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int country_id { get; set; }

        [Required]
        [StringLength(255)]
        public string city_name { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Attraction> Attraction { get; set; }

        public virtual Country Country { get; set; }
    }
}
