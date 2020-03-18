namespace Itinerary
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Detail
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string location { get; set; }

        [Column(TypeName = "date")]
        public DateTime date { get; set; }

        [Column(TypeName = "money")]
        public decimal cost { get; set; }

        [Required]
        [StringLength(50)]
        public string activity { get; set; }

        public TimeSpan timeOpen { get; set; }

        public TimeSpan timeClose { get; set; }

        public TimeSpan timeStart { get; set; }

        public TimeSpan timeEnd { get; set; }

        [Required]
        [StringLength(50)]
        public string toWear { get; set; }

        [Required]
        [StringLength(50)]
        public string toBring { get; set; }
    }
}
