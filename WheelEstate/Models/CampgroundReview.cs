using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WheelEstate.Models.BaseClasses;

namespace WheelEstate.Models
{
    public class CampgroundReview : ReviewBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Range(0, 5)]
        public int? SiteNumber { get; set; }

        [Range(0, 5)]
        public int? WifiStrength { get; set; }

        [Range(0, 5)]
        public int? BathroomCleanliness { get; set; }

        [Range(0, 5)]
        public int? LaundryCleanliness { get; set; }

        [Range(0, 5)]
        public int? OverallAppeal { get; set; }

        public bool? FamilyFriendly { get; set; }

        public float? AverageNightlyRate { get; set; }

        public Guid? CampgroundId { get; set; }

        public virtual Campground Campground { get; set; }
    }
}