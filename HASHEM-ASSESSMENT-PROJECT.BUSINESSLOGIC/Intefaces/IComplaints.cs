using HASHEM_ASSESSMENT_PROJECT.DATA.DTO;
using HASHEM_ASSESSMENT_PROJECT.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces
{
   public interface IComplaints
    {
        Task<long> CreateVehicleOnwnerComplaints(VehicleOwnersComplaints voc);
        Task<long> CreateGasStationComplaints(GasStationComplaints gsc);
        Task<IEnumerable<GasStationComplaints>> GetAllGasStatioComplaints();
        Task<IEnumerable<VehicleOwnersComplaints>> GetAllVehicleOwnersComplaints();
        Task<ViewDocumentDTO> GetGasStatioComplaints(int recordId);
        Task<ViewDocumentDTO> GetVehicleOwnersComplaints(int recordId);
    }
}
