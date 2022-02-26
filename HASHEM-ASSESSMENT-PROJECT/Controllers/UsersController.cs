using HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.Controllers
{
    public class UsersController : Controller
    {
        IComplaints _ics;
        public UsersController(IComplaints ics)
        {
            _ics = ics;
        }
        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Dashboard()
        {
            return View();
        }
        public async Task<IActionResult> GetVehicleOwnersComplaints()
        {
            return View(await _ics.GetAllVehicleOwnersComplaints());
        }
        public async Task<IActionResult> GetGasStationOwnersComplaints()
        {
            return View(await _ics.GetAllGasStatioComplaints());
        }

        public async Task<IActionResult> ViewVehicleOwnersComplaintDocument(string Id)
        {
            return View(await _ics.GetVehicleOwnersComplaints(int.Parse(Id)));
        }
        public async Task<IActionResult> ViewGasStationOwnersComplaintsDocument(string Id)
        {
            return View(await _ics.GetGasStatioComplaints(int.Parse(Id)));
        }
    }
}
