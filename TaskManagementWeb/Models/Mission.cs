using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementWeb.Models
{
    public class Mission
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="A Task Description is Required")]
        public string Description { get; set; }
        [Display(Name = "Time Added")]
        [DataType(DataType.DateTime)]
        public DateTime AddTime { get; set; }
        [Display(Name = "Time Completed")]
        [DataType(DataType.DateTime)]
        public DateTime CompleteTime { get; set; }
        public bool Completed { get; set; }
        public bool Dotted { get; set; }

    }
}
