using System;
using System.Collections.Generic;

#nullable disable

namespace SurveyResourcesAPI.Models
{
    public partial class SurveyLandUse
    {
        public int Luid { get; set; }
        public int SurveyId { get; set; }
        public string ClassificationCode { get; set; }
        public bool IsPrimary { get; set; }
    }
}
