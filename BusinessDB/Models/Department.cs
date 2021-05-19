using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;


namespace BusinessDB.Models
{
    [Table("department")]
    public class Department
    {
        public string id { get; set; }
        public string name { get; set; }

        public string location { get; set; }
    }
}
