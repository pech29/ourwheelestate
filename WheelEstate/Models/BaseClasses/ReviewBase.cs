using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WheelEstate.Models.BaseClasses
{
    public class ReviewBase
    {
        public ReviewBase()
        {
            // Set default values for new object creation
            CreatedDate = DateTime.UtcNow;
            ModifiedDate = DateTime.UtcNow;
        }

        /// <summary>
        /// General notes
        /// </summary>
        public string Notes { get; set; }

        /// <summary>
        /// Date this object was created
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Date this object was updated or modified
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// The date the location was visited and the review is associated with.
        /// </summary>
        [Required]
        public DateTime DateVisited { get; set; }

        public bool? PetFriendly { get; set; }

        public string UserName { get; set; }
    }
}