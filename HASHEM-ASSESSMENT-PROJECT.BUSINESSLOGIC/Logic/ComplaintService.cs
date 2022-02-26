using HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces;
using HASHEM_ASSESSMENT_PROJECT.DATA.DTO;
using HASHEM_ASSESSMENT_PROJECT.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Logic
{
    public class ComplaintService : IComplaints
    {
        DbContextClass _dxt;
        ILogger _log;
       
        public ComplaintService(DbContextClass dxt, ILogger log)
        {
            _dxt = dxt;
            _log = log;           
        }

        public async Task<long> CreateVehicleOnwnerComplaints(VehicleOwnersComplaints voc)
        {
            long response = 0;
            try
            {
                voc.Date = DateTime.Now;
                await _dxt.VehicleOwnersComplaints.AddAsync(voc);
                response = await _dxt.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "CreateVehicleOnwnerComplaints / ComplaintService", "ERROR");
            }
            return response;
        }

        public async Task<long> CreateGasStationComplaints(GasStationComplaints gsc)
        {
            long response = 0;
            try
            {
                gsc.Date = DateTime.Now;
                await _dxt.GasStationComplaints.AddAsync(gsc);
                response = await _dxt.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "CreateGasStationComplaints / ComplaintService", "ERROR");
            }
            return response;
        }

        public async Task<IEnumerable<GasStationComplaints>> GetAllGasStatioComplaints()
        {
            List<GasStationComplaints> all = new List<GasStationComplaints>();
            try
            {
                all = await _dxt.GasStationComplaints.ToListAsync();
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "GetAllGasStatusComplaints / ComplaintService", "ERROR");
            }
            return all;
        }
        public async Task<IEnumerable<VehicleOwnersComplaints>> GetAllVehicleOwnersComplaints()
        {
            List<VehicleOwnersComplaints> all = new List<VehicleOwnersComplaints>();
            try
            {
                all = await _dxt.VehicleOwnersComplaints.ToListAsync();
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "GetAllVehicleOwnersComplaints / ComplaintService", "ERROR");
            }
            return all;
        }

        public async Task<ViewDocumentDTO> GetGasStatioComplaints(int recordId)
        {
            ViewDocumentDTO vdd = new ViewDocumentDTO();
            try
            {
                GasStationComplaints g = await _dxt.GasStationComplaints.Where(x => x.Id == recordId).FirstOrDefaultAsync();
                vdd = new ViewDocumentDTO() { SupplyInvoiceUrl = g.SupplyInvoiceUrl};
                vdd = new ViewDocumentDTO() { SupplyInvoiceUrl = g.SupplyInvoiceUrl};
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "GetGasStatioComplaints / ComplaintService", "ERROR");
            }
            return vdd;
        }
        public async Task<ViewDocumentDTO> GetVehicleOwnersComplaints(int recordId)
        {
            ViewDocumentDTO vdd = new ViewDocumentDTO();
            try
            {
                VehicleOwnersComplaints v = await  _dxt.VehicleOwnersComplaints.Where(x => x.Id == recordId).FirstOrDefaultAsync();
                vdd = new ViewDocumentDTO() { PurchaseReceipt = v.PurchaseReceipt, VehicleOwnershipProofUrl = v.VehicleOwnershipProofUrl };
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "GetVehicleOwnersComplaints / ComplaintService", "ERROR");
            }
            return vdd;
        }
    }
}
