using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WheelEstate.Models.BaseClasses;

namespace WheelEstate.Models
{
    public class Sight : EntityBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public SiteType SiteType { get; set; }

        public virtual IList<SiteReview> SiteReviews { get; set; }

        public virtual IList<RoadTrip> RoadTrips { get; set; }
    }
}