#pragma checksum "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0858bc03ac192c1711364c62c5be40efeb0d0c5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Formations_Delete), @"mvc.1.0.view", @"/Views/Formations/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Formations/Delete.cshtml", typeof(AspNetCore.Views_Formations_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0858bc03ac192c1711364c62c5be40efeb0d0c5f", @"/Views/Formations/Delete.cshtml")]
    public class Views_Formations_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilRougeApi.Models.Formation>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(81, 179, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Formation</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(261, 41, false);
#line 15 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(302, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(366, 37, false);
#line 18 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Titre));

#line default
#line hidden
            EndContext();
            BeginContext(403, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(466, 41, false);
#line 21 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Duree));

#line default
#line hidden
            EndContext();
            BeginContext(507, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(571, 37, false);
#line 24 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Duree));

#line default
#line hidden
            EndContext();
            BeginContext(608, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(671, 44, false);
#line 27 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Date_Deb));

#line default
#line hidden
            EndContext();
            BeginContext(715, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(779, 40, false);
#line 30 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Date_Deb));

#line default
#line hidden
            EndContext();
            BeginContext(819, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(882, 44, false);
#line 33 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Personne));

#line default
#line hidden
            EndContext();
            BeginContext(926, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(990, 51, false);
#line 36 "C:\Users\khdiallo.stage\Documents\FilRougeApi\FilRougeApi\Views\Formations\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Personne.PersonneID));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 269, true);
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""FormationID"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilRougeApi.Models.Formation> Html { get; private set; }
    }
}
#pragma warning restore 1591
