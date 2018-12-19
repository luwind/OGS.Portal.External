using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OGS.Portal.External.Models
{
    public class Contractor_Master
    {
        public int ContractorID { get; set; }
        public string Contract_Number { get; set; }
        public string Company_Name { get; set; }
        public string Federal_Id { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Address_Line1 { get; set; }
        public string Address_Line2 { get; set; }
        public string City { get; set; }
        public string ZipCode { get; set; }
        public string State { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public DateTime? Contract_Start_Date { get; set; }
        public DateTime? Contract_Exp_Date { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedOn { get; set; }
        public DateTime? UpdatedBy { get; set; }
        public string NYS_Vendor_ID { get; set; }
    }
}
