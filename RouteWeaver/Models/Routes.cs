namespace RouteWeaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Routes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Routes()
        {
            RoutePoint = new HashSet<RoutePoint>();
        }

        [Key]
        public int route_id { get; set; }

        [StringLength(150)]
        public string route_title { get; set; }

        public int? points_amount { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RoutePoint> RoutePoint { get; set; }
    }
}
