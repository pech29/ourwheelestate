using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WheelEstate.Models.BaseClasses;

namespace WheelEstate.Models
{
    public class SiteReview : ReviewBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public bool? Crowded { get; set; }

        public float Cost { get; set; }

        public bool? FamilyFriendly { get; set; }

    }
}