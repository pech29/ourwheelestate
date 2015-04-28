using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelEstate.Models.BaseClasses
{
    public class EntityBase : ReviewBase
    {
        [Required]
        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string Zipcode { get; set; }

        public string Website { get; set; }

        public Guid? RoadTripId { get; set; }

        public virtual RoadTrip RoadTrip { get; set; }

    }
}