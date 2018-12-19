using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OGS.Portal.External.Models
{
    public class Product_Details
    {
        public int ProductID { get; set; }
        public int ContractorID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string SKU { get; set; }
        public string Bundle_Part_No { get; set; }
        public string Type_Of_Cloud_Service { get; set; }
        public string UOM { get; set; }
        public string Units_Per_UOM { get; set; }
        public decimal List_Price { get; set; }
        public decimal Min_NYS_Discount { get; set; }
        public decimal Actual_NYS_Discount { get; set; }
        public decimal Actual_Contract_Price { get; set; }
        public decimal? Percent_Edu_Discount { get; set; }
        public decimal? Net_NYS_Edu_Price { get; set; }
        public bool? IsActive { get; set; }
        public int LotId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
    }
}
