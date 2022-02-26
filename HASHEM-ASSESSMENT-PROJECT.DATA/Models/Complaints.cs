using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.Models
{
   public class VehicleOwnersComplaints
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
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
        public string VehicleOwnershipProofUrl { get; set; }
        [Required(ErrorMessage = "Fuel Purchase is required")]
        [Display(Name = "Purhcase Date")]
        public DateTime FuelPurhcaseDate { get; set; }
        [Required(ErrorMessage = "Fuel Name station is required")]
        [Display(Name = "Gas Station Name")]
        public string GasStationName { get; set; }
        public string PurchaseReceipt { get; set; }
        [Display(Name = "Purchase Outlet")]
        public string PurchaseOutlet { get; set; }
        [Required(ErrorMessage = "Fuel quantity Purchased is required")]
        [Display(Name = "Litres Purchase")]
        public int LitresPurchase { get; set; }
    }

    public class GasStationComplaints
    {
        [Key]
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [ScaffoldColumn(false)]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Business Name is required")]        
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }       
        [Required(ErrorMessage = "Supply Location is required")]
        [StringLength(100)]
        [Display(Name = "Supply Date")]
        public DateTime SupplyDate { get; set; }
        [Required(ErrorMessage = "Supply Location is required")]
        [StringLength(85)]
        [Display(Name = "Supply Location")]
        public string SupplyLocation { get; set; }
        [Required(ErrorMessage = "Supply Invoice as evidence is required")]
        [StringLength(255)]
        [Display(Name = "Supply Invoice")]
        public string SupplyInvoiceUrl { get; set; }
        [Required(ErrorMessage = "Fuel quantity Received is required")]       
        [Display(Name = "Quantity Recieved")]       
        public int TotalQuantityRecieved { get; set; }
    }
}
