using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyResourcesAPI.Models
{
    [AttributeUsage(AttributeTargets.Property,
        Inherited = false,
        AllowMultiple = false)]
    internal sealed class OptionalAttribute : Attribute
    {
    }
    public class DataFilter
    {
        public string FieldName { get; set; }

        public string Operator { get; set; } // <,>,=,IN,True,False,Contains,Like

        [Optional]
        public List<string> StringValues { get; set; }

        [Optional]
        public List<double> NumValues { get; set; }

        [Optional]
        public string Group { get; set; } // AND/OR Grouping
    }
}
