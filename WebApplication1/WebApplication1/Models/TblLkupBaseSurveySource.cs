using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class TblLkupBaseSurveySource
    {
        public string Code { get; set; }
        public string Value { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? Active { get; set; }
    }
}
