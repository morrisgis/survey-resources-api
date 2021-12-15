using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class SurveyLandholderInterest
    {
        public int Lhiid { get; set; }
        public int SurveyId { get; set; }
        public string Agencyid { get; set; }
        public bool IsPrimary { get; set; }
    }
}
