﻿using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class LkupSurveyResourceType
    {
        public string ResourceTypeCode { get; set; }
        public string Description { get; set; }
        public int? DisplayOrder { get; set; }
        public bool? IsActive { get; set; }
    }
}
