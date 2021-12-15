using System;
using System.Collections.Generic;

#nullable disable

namespace WebApplication1.Models
{
    public partial class LkupDocumentType
    {
        public int DocumentTypeId { get; set; }
        public string FileSubstring { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string ApplicationTenant { get; set; }
        public string ApplicationRoute { get; set; }
        public string PktableName { get; set; }
    }
}
