namespace RouteWeaver.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AttractionReviews
    {
        [Key]
        public int review_id { get; set; }

        public int user_id { get; set; }

        public int attraction_id { get; set; }

        public double rating { get; set; }

        [Column(TypeName = "date")]
        public DateTime created_date { get; set; }

        public virtual Attraction Attraction { get; set; }

        public virtual Users Users { get; set; }
    }
}
