using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DBMVC.Models
{
    // Need to specify what table this matches to (otherwise Dapper assumes the table name ends with an "s"
    [Table("category")]
    public class Category
    {
        // Need to specify which feild is the primary key
        [Key]
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public string description { get; set; }

        public override string ToString()
        {
            return $"{categoryId} {categoryName} {description}";
        }
    }
}
