#pragma checksum "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2efbbe8aa33a54052f02302e5eb3ca6ed1f9f133"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SurveyDocuments_Details), @"mvc.1.0.view", @"/Views/SurveyDocuments/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2efbbe8aa33a54052f02302e5eb3ca6ed1f9f133", @"/Views/SurveyDocuments/Details.cshtml")]
    public class Views_SurveyDocuments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SurveyResourcesAPI.Models.SurveyDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>SurveyDocument</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveySource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.SurveySource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DocumentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.DocumentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FolderPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.FolderPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FileExtension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.FileExtension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 44 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.McgisUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.McgisUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 50 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasWorldFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 53 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasWorldFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 56 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasTraverse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 59 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasTraverse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 62 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrigFilePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 65 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrigFilePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 68 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ExternalUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 71 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.ExternalUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 74 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.OrigSurveyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 77 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.OrigSurveyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 80 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastEditor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 83 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastEditor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 86 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LastEditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 89 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.LastEditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 92 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TempTimestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 95 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.TempTimestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 98 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TempFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 101 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.TempFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 104 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TempHasMatch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 107 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.TempHasMatch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 110 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 113 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Survey.SurveyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3932, "\"", 3964, 1);
#nullable restore
#line 118 "C:\Users\dbouchard\Documents\Repos\survey-resources-api\WebApplication1\WebApplication1\Views\SurveyDocuments\Details.cshtml"
WriteAttributeValue("", 3947, Model.DocumentId, 3947, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SurveyResourcesAPI.Models.SurveyDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591
