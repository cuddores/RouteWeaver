namespace RouteWeaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Attraction")]
    public partial class Attraction
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Attraction()
        {
            AttractionReviews = new HashSet<AttractionReviews>();
            RoutePoint = new HashSet<RoutePoint>();
        }

        [Key]
        public int attraction_id { get; set; }

        public int city_id { get; set; }

        public int type_id { get; set; }

        [Required]
        [StringLength(255)]
        public string name { get; set; }

        public double attraction_rating { get; set; }

        [Required]
        [StringLength(255)]
        public string address { get; set; }

        [Required]
        [StringLength(255)]
        public string location { get; set; }

        [NotMapped]
        public double Latitude
        {
            get
            {
                var parts = location.Split('/');
                return double.Parse(parts[0].Trim(), System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        [NotMapped]
        public double Longitude
        {
            get
            {
                var parts = location.Split('/');
                return double.Parse(parts[1].Trim(), System.Globalization.CultureInfo.InvariantCulture);
            }
        }

        public virtual AttractionType AttractionType { get; set; }

        public virtual Cities Cities { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AttractionReviews> AttractionReviews { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoutePoint> RoutePoint { get; set; }
    }
}
