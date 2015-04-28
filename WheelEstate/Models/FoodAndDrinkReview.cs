using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WheelEstate.Models.BaseClasses;

namespace WheelEstate.Models
{
    public class FoodAndDrinkReview : ReviewBase
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Range(0, 5)]
        public int? FoodRating { get; set; }

        [Range(0, 5)]
        public int? BeerRating { get; set; }

        public bool? DraftBeer { get; set; }

        [Range(0, 150)]
        public int? NumberOfDraftBeers { get; set; }
    }
}