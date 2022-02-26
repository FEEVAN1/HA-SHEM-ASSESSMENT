using HASHEM_ASSESSMENT_PROJECT.DATA.Helper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.Models
{
   public class DbContextClass : DbContext
    {
       
        public DbContextClass(DbContextOptions<DbContextClass> options) : base(options)
        {

        }       
        public DbSet<GasStationComplaints> GasStationComplaints { get; set; }
        public DbSet<VehicleOwnersComplaints> VehicleOwnersComplaints { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<Logs> Logs { get; set; }
    }
}
