using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class SurveyTaxMapLink
    {
        public int Stmid { get; set; }
        public int SurveyId { get; set; }
        public string Gnis { get; set; }
        public string MunicipalId { get; set; }
        public string TaxSheet { get; set; }
        public DateTime? ValidationDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RetirementDate { get; set; }
        public string RetirementComments { get; set; }
        public bool? ManualAdd { get; set; }
        public byte[] AddTimeStamp { get; set; }
    }
}
