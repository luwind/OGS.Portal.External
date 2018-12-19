using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OGS.Portal.External.Models
{
    public class Product_Details_Tmp
    {
        public int ProductID { get; set; }
        public string ContractorID { get; set; }
        public string Product_Name { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string SKU { get; set; }
        public string Bundle_Part_No { get; set; }
        public string Type_Of_Cloud_Service { get; set; }
        public string UOM { get; set; }
        public string Units_Per_UOM { get; set; }
        public string List_Price { get; set; }
        public string Min_NYS_Discount { get; set; }
        public string Actual_NYS_Discount { get; set; }
        public string Actual_Contract_Price { get; set; }
        public string Percent_Edu_Discount { get; set; }
        public string Net_NYS_Edu_Price { get; set; }
        public string LotId { get; set; }
    }
}
