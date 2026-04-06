namespace RouteWeaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("RoutePoint")]
    public partial class RoutePoint
    {
        [Key]
        public int route_point_id { get; set; }

        public int route_id { get; set; }

        public int attraction_id { get; set; }

        public virtual Attraction Attraction { get; set; }

        public virtual Routes Routes { get; set; }
    }
}
