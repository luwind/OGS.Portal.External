using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OGS.Portal.External.Models
{
    public class Document_Category_Master
    {
        public int Doc_Cat_ID { get; set; }
        public string Doc_Category { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
