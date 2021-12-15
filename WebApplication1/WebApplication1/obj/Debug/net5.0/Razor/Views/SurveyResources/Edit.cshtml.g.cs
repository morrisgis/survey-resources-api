#pragma checksum "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "33aeb47de3519cd7c102c88a955b982f9ad5bc5d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SurveyResources_Edit), @"mvc.1.0.view", @"/Views/SurveyResources/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"33aeb47de3519cd7c102c88a955b982f9ad5bc5d", @"/Views/SurveyResources/Edit.cshtml")]
    public class Views_SurveyResources_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveyResourcesAPI.Models.SurveyResource>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>SurveyResource</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""SurveyId"" />
            <div class=""form-group"">
                <label asp-for=""ResourceType"" class=""control-label""></label>
                <input asp-for=""ResourceType"" class=""form-control"" />
                <span asp-validation-for=""ResourceType"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SurveySource"" class=""control-label""></label>
                <input asp-for=""SurveySource"" class=""form-control"" />
                <span asp-validation-for=""SurveySource"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SurveyCoordinateSystem"" class=""control-label""></label>
                <input asp-for=""SurveyCoordin");
            WriteLiteral(@"ateSystem"" class=""form-control"" />
                <span asp-validation-for=""SurveyCoordinateSystem"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SurveyTitle"" class=""control-label""></label>
                <input asp-for=""SurveyTitle"" class=""form-control"" />
                <span asp-validation-for=""SurveyTitle"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PresentName"" class=""control-label""></label>
                <input asp-for=""PresentName"" class=""form-control"" />
                <span asp-validation-for=""PresentName"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AliasNames"" class=""control-label""></label>
                <input asp-for=""AliasNames"" class=""form-control"" />
                <span asp-validation-for=""AliasNames"" class=""text-danger""></span>
            </div>
         ");
            WriteLiteral(@"   <div class=""form-group"">
                <label asp-for=""SurveyDate"" class=""control-label""></label>
                <input asp-for=""SurveyDate"" class=""form-control"" />
                <span asp-validation-for=""SurveyDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PrimaryMuniId"" class=""control-label""></label>
                <input asp-for=""PrimaryMuniId"" class=""form-control"" />
                <span asp-validation-for=""PrimaryMuniId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SurveySiteGeneralAddress"" class=""control-label""></label>
                <input asp-for=""SurveySiteGeneralAddress"" class=""form-control"" />
                <span asp-validation-for=""SurveySiteGeneralAddress"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""SurveyDescription"" class=""control-label""></label>
   ");
            WriteLiteral(@"             <input asp-for=""SurveyDescription"" class=""form-control"" />
                <span asp-validation-for=""SurveyDescription"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""IsPublicLandholderInterest"" /> ");
#nullable restore
#line 68 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
                                                                                       Write(Html.DisplayNameFor(model => model.IsPublicLandholderInterest));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""CoClerkFileNumber"" class=""control-label""></label>
                <input asp-for=""CoClerkFileNumber"" class=""form-control"" />
                <span asp-validation-for=""CoClerkFileNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CoClerkBookNumber"" class=""control-label""></label>
                <input asp-for=""CoClerkBookNumber"" class=""form-control"" />
                <span asp-validation-for=""CoClerkBookNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CoClerkPageNumber"" class=""control-label""></label>
                <input asp-for=""CoClerkPageNumber"" class=""form-control"" />
                <span asp-validation-for=""CoClerkPageNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <");
            WriteLiteral(@"label asp-for=""DevReviewNumber"" class=""control-label""></label>
                <input asp-for=""DevReviewNumber"" class=""form-control"" />
                <span asp-validation-for=""DevReviewNumber"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""PosiUnitId"" class=""control-label""></label>
                <input asp-for=""PosiUnitId"" class=""form-control"" />
                <span asp-validation-for=""PosiUnitId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""GreenAcresSurveyId"" class=""control-label""></label>
                <input asp-for=""GreenAcresSurveyId"" class=""form-control"" />
                <span asp-validation-for=""GreenAcresSurveyId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OtherSurveyId"" class=""control-label""></label>
                <input asp-for=""OtherSurveyId"" class=""form-contro");
            WriteLiteral(@"l"" />
                <span asp-validation-for=""OtherSurveyId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OstfProjectId"" class=""control-label""></label>
                <input asp-for=""OstfProjectId"" class=""form-control"" />
                <span asp-validation-for=""OstfProjectId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""OrigSurveyId"" class=""control-label""></label>
                <input asp-for=""OrigSurveyId"" class=""form-control"" />
                <span asp-validation-for=""OrigSurveyId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Comment"" class=""control-label""></label>
                <input asp-for=""Comment"" class=""form-control"" />
                <span asp-validation-for=""Comment"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
         ");
            WriteLiteral(@"       <label asp-for=""MetaCreationDateTime"" class=""control-label""></label>
                <input asp-for=""MetaCreationDateTime"" class=""form-control"" />
                <span asp-validation-for=""MetaCreationDateTime"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""HasValidSurveyDocument"" /> ");
#nullable restore
#line 128 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
                                                                                   Write(Html.DisplayNameFor(model => model.HasValidSurveyDocument));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"HasValidBaseSurvey\" /> ");
#nullable restore
#line 133 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
                                                                               Write(Html.DisplayNameFor(model => model.HasValidBaseSurvey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"HasValidSurveyParcelsLink\" /> ");
#nullable restore
#line 138 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
                                                                                      Write(Html.DisplayNameFor(model => model.HasValidSurveyParcelsLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </label>\r\n            </div>\r\n            <div class=\"form-group form-check\">\r\n                <label class=\"form-check-label\">\r\n                    <input class=\"form-check-input\" asp-for=\"HasValidLandholderInterests\" /> ");
#nullable restore
#line 143 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
                                                                                        Write(Html.DisplayNameFor(model => model.HasValidLandholderInterests));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""BaseMapUpdateStatus"" class=""control-label""></label>
                <input asp-for=""BaseMapUpdateStatus"" class=""form-control"" />
                <span asp-validation-for=""BaseMapUpdateStatus"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""NoParcelSurvey"" /> ");
#nullable restore
#line 153 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
                                                                           Write(Html.DisplayNameFor(model => model.NoParcelSurvey));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <label asp-for=""Cogoreport"" class=""control-label""></label>
                <input asp-for=""Cogoreport"" class=""form-control"" />
                <span asp-validation-for=""Cogoreport"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastEditor"" class=""control-label""></label>
                <input asp-for=""LastEditor"" class=""form-control"" />
                <span asp-validation-for=""LastEditor"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""LastEditDate"" class=""control-label""></label>
                <input asp-for=""LastEditDate"" class=""form-control"" />
                <span asp-validation-for=""LastEditDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NewFilename"" class=""control-label""></label");
            WriteLiteral(@">
                <input asp-for=""NewFilename"" class=""form-control"" />
                <span asp-validation-for=""NewFilename"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 188 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyResources\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyResourcesAPI.Models.SurveyResource> Html { get; private set; }
    }
}
#pragma warning restore 1591
