#pragma checksum "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3867d32ec6557f66e7a68b2c23cd787388db938d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SurveyDocuments_Delete), @"mvc.1.0.view", @"/Views/SurveyDocuments/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3867d32ec6557f66e7a68b2c23cd787388db938d", @"/Views/SurveyDocuments/Delete.cshtml")]
    public class Views_SurveyDocuments_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication1.Models.SurveyDocument>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>SurveyDocument</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.SurveySource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.SurveySource));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DocumentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DocumentType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FolderPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FolderPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FileExtension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FileExtension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.McgisUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.McgisUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HasWorldFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HasWorldFile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HasTraverse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HasTraverse));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrigFilePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrigFilePath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ExternalUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ExternalUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 75 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.OrigSurveyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 78 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.OrigSurveyId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 81 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastEditor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 84 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastEditor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 87 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LastEditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 90 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LastEditDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 93 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TempTimestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 96 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TempTimestamp));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 99 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TempFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 102 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TempFileName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 105 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TempHasMatch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 108 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TempHasMatch));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 111 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Survey));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 114 "C:\Users\dbouchard\source\repos\WebApplication1\WebApplication1\Views\SurveyDocuments\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Survey.SurveyId));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""DocumentId"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication1.Models.SurveyDocument> Html { get; private set; }
    }
}
#pragma warning restore 1591
