using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WheelEstate.Models
{
    public class RoadTrip
    {
        public RoadTrip()
        {
            // Set default values for new object creation
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
        }

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public virtual IList<Campground> Campgrounds { get; set; }

        public virtual IList<Sight> Sights { get; set; }

        public virtual IList<FoodAndDrink> FoodAndDrinks { get; set; }

        /// <summary>
        /// Date this object was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date this object was updated or modified
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public string UserName { get; set; }

    }
}