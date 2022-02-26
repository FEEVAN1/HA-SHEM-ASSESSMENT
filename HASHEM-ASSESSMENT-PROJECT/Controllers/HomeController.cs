using HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces;
using HASHEM_ASSESSMENT_PROJECT.DATA.DTO;
using HASHEM_ASSESSMENT_PROJECT.DATA.Models;
using HASHEM_ASSESSMENT_PROJECT.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        IWebHostEnvironment _env;
        IComplaints _cs;

        public HomeController(ILogger<HomeController> logger, IWebHostEnvironment env, IComplaints cs )
        {
            _logger = logger;
            _env = env;
            _cs = cs;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult VehicleOwners()
        {
            return View();
        }

        public IActionResult GasStationOwners()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> VehicleOwners(VOComplaintDTO v)
        {
            if (ModelState.IsValid)
            {
                string pooUrl = UploadedFile(v.VehicleOwnershipProofUrl);
                string receipturl = UploadedFile(v.PurchaseReceipt);
                long reply = await _cs.CreateVehicleOnwnerComplaints(new VehicleOwnersComplaints() { 
                    Date = DateTime.Now, 
                    FirstName = v.FirstName, 
                    LastName = v.LastName, 
                    VehicleType = v.VehicleType, 
                    FuelPurhcaseDate = v.FuelPurhcaseDate,
                    GasStationName = v.GasStationName, 
                    PurchaseOutlet = v.PurchaseOutlet, 
                    PurchaseReceipt = receipturl, 
                    VehicleOwnershipProofUrl = pooUrl, 
                    LitresPurchase = v.LitresPurchase 
                });
                if (reply > 0)
                {
                    TempData["success"] = "SUCCESS! Your complaint was submitted successfully!";
                }
                else
                {
                    TempData["failed"] = "FAILED! Unable to Submit your complaint, Please Retry!";
                }
                return RedirectToAction(nameof(VehicleOwners));
            }else
            { 
                TempData["failed"] = "FAILED! Unable to Submit your complaint, Please Provide all details and retry!"; 
            }
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> GasStationOwners(GSComplaintsDTO g)
        {
            if (ModelState.IsValid)
            {
                string invoiceurl = UploadedFile(g.SupplyInvoiceUrl);               
                long reply = await _cs.CreateGasStationComplaints(new GasStationComplaints()
                {
                    Date = DateTime.Now,
                    BusinessName = g.BusinessName,
                    SupplyDate = g.SupplyDate,
                    SupplyLocation = g.SupplyLocation,
                    SupplyInvoiceUrl = invoiceurl,
                    TotalQuantityRecieved = g.TotalQuantityRecieved
                });
                if (reply > 0)
                {
                    TempData["success"] = "SUCCESS! Your complaint was submitted successfully!";
                }
                else
                {
                    TempData["failed"] = "FAILED! Unable to Submit your complaint, Please Retry!";
                }
                return RedirectToAction(nameof(GasStationOwners));
            }
            else
            {
                TempData["failed"] = "FAILED! Unable to Submit your complaint, Please Provide all details and retry!";
            }
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        private string UploadedFile(IFormFile file)
        {
            string uniqueFileName = null;

            if (file.FileName != null)
            {
                string uploadsFolder = Path.Combine(_env.WebRootPath, "UserUploadedFiles");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + file.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                   file.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
    }
}
