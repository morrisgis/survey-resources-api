﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyResourcesAPI.Models
{
    public class DataSort
    {
        public string FieldName { get; set; }
        public string Direction { get; set; } = "ASC";
    }
}
