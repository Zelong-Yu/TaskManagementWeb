using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TaskManagementWeb.Models
{
    public class Mission
    {
        public int Id { get; set; }
        public string Description { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime AddTime { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CompleteTime { get; set; }
        public bool Completed { get; set; }
        public bool Dotted { get; set; }

    }
}
