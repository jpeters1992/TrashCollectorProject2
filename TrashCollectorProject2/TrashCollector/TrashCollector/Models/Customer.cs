using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace TrashCollector.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }


        [Display(Name = "Last Name")]
        public string LastName { get; set; }


        [Display(Name = "Street Address")]
        public string StreetAddress { get; set; }
        public string CityName { get; set; }
        public string StateName { get; set; }


        [Display(Name = "Zip Code")]
        public double ZipCode { get; set; }

        [Display(Name = "Pickup Day")]
        public string PickUpDay { get; set; }

        [Display(Name = "Pick Up Confirmed")]
        public bool? PickupConfirmed { get; set; }

        [Display(Name = "$ Charge")]
        public double PickupCharge { get; set; }

        [Display(Name = "Balance")]
        public double? Balance { get; set; }

        [Display(Name = "Suspend Service - Start Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? SuspendStartDate { get; set; }

        [Display(Name = "Suspend Service - End Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? SuspendEndDate { get; set; }

        [Display(Name = "Extra Pickup Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime? ExtraPickUpDate { get; set; }

        [ForeignKey("ApplicationUser")]
        public string ApplicationId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }

}