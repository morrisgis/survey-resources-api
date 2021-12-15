using System;
using System.Collections.Generic;

#nullable disable

namespace SurveyResourcesAPI.Models
{
    public partial class TblLkupBaseSurveyType
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? Active { get; set; }
    }
}
