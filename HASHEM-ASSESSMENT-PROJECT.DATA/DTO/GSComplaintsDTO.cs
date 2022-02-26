using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.DTO
{
   public class GSComplaintsDTO
    {
        [Required(ErrorMessage = "Business Name is required")]
        [Display(Name = "Business Name")]
        public string BusinessName { get; set; }
        [Required(ErrorMessage = "Supply Location is required")]        
        [Display(Name = "Supply Date")]
        public DateTime SupplyDate { get; set; }
        [Required(ErrorMessage = "Supply Location is required")]
        [StringLength(85)]
        [Display(Name = "Supply Location")]
        public string SupplyLocation { get; set; }
        [Required(ErrorMessage = "Supply Invoice as evidence is required")]       
        [Display(Name = "Supply Invoice")]
        public IFormFile SupplyInvoiceUrl { get; set; }
        [Required(ErrorMessage = "Fuel quantity Received is required")]
        [Display(Name = "Quantity Recieved")]
        public int TotalQuantityRecieved { get; set; }
    }
}
