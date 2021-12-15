using System;
using System.Collections.Generic;

#nullable disable

namespace SurveyResourcesAPI.Models
{
    public partial class SurveyParcelsLink
    {
        public int Spid { get; set; }
        public int SurveyId { get; set; }
        public string Gnis { get; set; }
        public string MunicipalId { get; set; }
        public string Block { get; set; }
        public string Lot { get; set; }
        public string QualificationCode { get; set; }
        public string PamsPin { get; set; }
        public string TaxSheet { get; set; }
        public DateTime? ValidationDate { get; set; }
        public bool? IsActive { get; set; }
        public DateTime? RetirementDate { get; set; }
        public string RetirementComments { get; set; }
        public bool? ManualAdd { get; set; }
        public byte[] AddTimeStamp { get; set; }
    }
}
