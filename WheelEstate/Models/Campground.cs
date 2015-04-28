using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WheelEstate.Models.BaseClasses;

namespace WheelEstate.Models
{
    public class Campground : EntityBase
    {
        public Campground()
        {
            RoadTrips = new List<RoadTrip>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public bool? FamilyFriendly { get; set; }

        public virtual IList<CampgroundReview> CampgroundReviews { get; set; }

        public virtual IList<RoadTrip> RoadTrips { get; set; }
    }
}