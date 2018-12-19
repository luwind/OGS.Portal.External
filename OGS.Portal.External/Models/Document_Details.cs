using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OGS.Portal.External.Models
{
    public class Document_Details
    {
        public int Doc_Details_Id { get; set; }
        public int Doc_cat_Id { get; set; }
        public string Contract_Number { get; set; }

        //[Required]
        //[Display(Name = "Select the file to upload")]
        //[DataType(DataType.Upload)]
        //public IFormFile file { get; set; }
        //public string Disp_Message { get; set; }


        public string Document_Name { get; set; }
        public string Note { get; set; }
        public string Document_Path { get; set; }
        

        public DateTime? Upload_Date { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedOn { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }

        public Document_Category_Master Doc_cat_ { get; set; }
    }
}
