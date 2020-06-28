using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SafetyObservation.Models
{
    public class DisplayObsModel
    {
        public string SerialNo { get; set; }
        [Required]
        [StringLength(5,ErrorMessage ="Invalid length")]
        public string PICCode { get; set; }
        public string Observer { get; set; }

    }
}
