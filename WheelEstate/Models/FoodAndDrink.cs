using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WheelEstate.Models.BaseClasses;
using WheelEstate.Models.Enums;


namespace WheelEstate.Models
{
    public class FoodAndDrink : EntityBase
    {
        public FoodAndDrink()
        {
            RoadTrips = new List<RoadTrip>();
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public EstablishmentType EstablishmentType { get; set; }

        public MealType MealType { get; set; }

        public virtual IList<FoodAndDrinkReview> FoodAndDrinkReviews { get; set; }

        public virtual IList<RoadTrip> RoadTrips { get; set; }
    }
}