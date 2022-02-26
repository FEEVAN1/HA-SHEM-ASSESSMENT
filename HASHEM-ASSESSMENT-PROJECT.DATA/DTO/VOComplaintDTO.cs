using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.DTO
{
   public class VOComplaintDTO
    {
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "First Name can not be empty")]
        [Display(Name = "First Name")]
        [StringLength(55)]
        public string FirstName { get; set; }
        [Required(ErrorMessage = "Last Name can not be null")]
        [Display(Name = "Last Name")]
        [StringLength(55)]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Vehicle Type is required")]
        [Display(Name = "Vehicle Type")]
        public string VehicleType { get; set; }
        [Required(ErrorMessage = "Proof of Ownership is required")]
        [Display(Name = " Proof of Vehicle Ownership")]
        public IFormFile VehicleOwnershipProofUrl { get; set; }
        [Required(ErrorMessage = "Fuel Purchase date is required")]
        [Display(Name = "Purhcase Date")]
        public DateTime FuelPurhcaseDate { get; set; }
        [Required(ErrorMessage = "Fuel Name station is required")]
        [Display(Name = "Gas Station Name")]
        public string GasStationName { get; set; }
        [Required(ErrorMessage = "Purchase Receipt is required")]
        [Display(Name = " Purchase Receipt")]
        public IFormFile PurchaseReceipt { get; set; }
        [Display(Name = "Purchase Outlet")]
        public string PurchaseOutlet { get; set; }
        [Required(ErrorMessage = "Fuel quantity Purchased is required")]
        [Display(Name = "Litres Purchase")]
        public int LitresPurchase { get; set; }
    }
}
