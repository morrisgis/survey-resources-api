using System;
using System.Collections.Generic;

#nullable disable

namespace SurveyResourcesAPI.Models
{
    public partial class SurveyResource
    {
        public SurveyResource()
        {
            SurveyDocuments = new HashSet<SurveyDocument>();
        }

        public int SurveyId { get; set; }
        public string ResourceType { get; set; }
        public string SurveySource { get; set; }
        public string SurveyCoordinateSystem { get; set; }
        public string SurveyTitle { get; set; }
        public string PresentName { get; set; }
        public string AliasNames { get; set; }
        public DateTime? SurveyDate { get; set; }
        public string PrimaryMuniId { get; set; }
        public string SurveySiteGeneralAddress { get; set; }
        public string SurveyDescription { get; set; }
        public bool IsPublicLandholderInterest { get; set; }
        public string CoClerkFileNumber { get; set; }
        public string CoClerkBookNumber { get; set; }
        public string CoClerkPageNumber { get; set; }
        public string DevReviewNumber { get; set; }
        public int? PosiUnitId { get; set; }
        public string GreenAcresSurveyId { get; set; }
        public string OtherSurveyId { get; set; }
        public int? OstfProjectId { get; set; }
        public int? OrigSurveyId { get; set; }
        public string Comment { get; set; }
        public string MetaCreationDateTime { get; set; }
        public bool HasValidSurveyDocument { get; set; }
        public bool HasValidBaseSurvey { get; set; }
        public bool HasValidSurveyParcelsLink { get; set; }
        public bool HasValidLandholderInterests { get; set; }
        public string BaseMapUpdateStatus { get; set; }
        public bool NoParcelSurvey { get; set; }
        public string Cogoreport { get; set; }
        public string LastEditor { get; set; }
        public DateTime? LastEditDate { get; set; }
        public byte[] TestTimeStamp { get; set; }
        public string NewFilename { get; set; }

        public virtual ICollection<SurveyDocument> SurveyDocuments { get; set; }
    }
}
