using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.DATA.Models
{
    public class Logs
    {
        [Key]
        public int Id { get; set; }
        public DateTime LogTime { get; set; }
        public string Type { get; set; }
        public string Location { get; set; }
        public string Details { get; set; }
    }
}
