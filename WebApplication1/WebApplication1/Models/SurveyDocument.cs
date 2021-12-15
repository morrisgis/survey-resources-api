using System;
using System.Collections.Generic;

#nullable disable

namespace SurveyResourcesAPI.Models
{
    public partial class SurveyDocument
    {
        public int DocumentId { get; set; }
        public int SurveyId { get; set; }
        public string SurveySource { get; set; }
        public string DocumentType { get; set; }
        public string FileName { get; set; }
        public string FolderPath { get; set; }
        public string FileExtension { get; set; }
        public string McgisUrl { get; set; }
        public bool? HasWorldFile { get; set; }
        public bool? HasTraverse { get; set; }
        public string OrigFilePath { get; set; }
        public string ExternalUrl { get; set; }
        public int? OrigSurveyId { get; set; }
        public string LastEditor { get; set; }
        public DateTime? LastEditDate { get; set; }
        public byte[] TempTimestamp { get; set; }
        public string TempFileName { get; set; }
        public bool? TempHasMatch { get; set; }

        public virtual SurveyResource Survey { get; set; }
    }
}
