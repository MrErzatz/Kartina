#pragma checksum "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d3c68ae0cd318af79fc96e081199a2e0b7e9261e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Utilisateurs_Details), @"mvc.1.0.view", @"/Views/Utilisateurs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Utilisateurs/Details.cshtml", typeof(AspNetCore.Views_Utilisateurs_Details))]
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
#line 1 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\_ViewImports.cshtml"
using Kartina;

#line default
#line hidden
#line 2 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\_ViewImports.cshtml"
using Kartina.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d3c68ae0cd318af79fc96e081199a2e0b7e9261e", @"/Views/Utilisateurs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca603c46fb55325c6d1c11fc94cb5f31b3fb0c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Utilisateurs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kartina.Models.Utilisateur>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(35, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Home/About.cshtml";

#line default
#line hidden
            BeginContext(123, 125, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Utilisateur</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(249, 39, false);
#line 15 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(288, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(332, 35, false);
#line 18 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nom));

#line default
#line hidden
            EndContext();
            BeginContext(367, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(411, 42, false);
#line 21 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(453, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(497, 38, false);
#line 24 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Prenom));

#line default
#line hidden
            EndContext();
            BeginContext(535, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(579, 47, false);
#line 27 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(626, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(670, 43, false);
#line 30 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(713, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(757, 41, false);
#line 33 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(798, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(842, 37, false);
#line 36 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(879, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(923, 43, false);
#line 39 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MotPass));

#line default
#line hidden
            EndContext();
            BeginContext(966, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1010, 39, false);
#line 42 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MotPass));

#line default
#line hidden
            EndContext();
            BeginContext(1049, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1093, 44, false);
#line 45 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Civilité));

#line default
#line hidden
            EndContext();
            BeginContext(1137, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1181, 40, false);
#line 48 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Civilité));

#line default
#line hidden
            EndContext();
            BeginContext(1221, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1265, 45, false);
#line 51 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1354, 41, false);
#line 54 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Telephone));

#line default
#line hidden
            EndContext();
            BeginContext(1395, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1439, 55, false);
#line 57 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdAdresseNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1494, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1538, 61, false);
#line 60 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdAdresseNavigation.IdAdresse));

#line default
#line hidden
            EndContext();
            BeginContext(1599, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1643, 65, false);
#line 63 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IdProfilUtilisateurNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1708, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1752, 72, false);
#line 66 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
       Write(Html.DisplayFor(model => model.IdProfilUtilisateurNavigation.TypeProfil));

#line default
#line hidden
            EndContext();
            BeginContext(1824, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1871, 65, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6ba82d2c5bda4e39915347697c18189e", async() => {
                BeginContext(1928, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 71 "C:\Users\M2iformation\Desktop\ProjetKartina\ProjetKartina\Kartina\Views\Utilisateurs\Details.cshtml"
                           WriteLiteral(Model.IdUtilisateur);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1936, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1944, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "55b661bc1b81446a99c9f03cd52affd3", async() => {
                BeginContext(1966, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1982, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kartina.Models.Utilisateur> Html { get; private set; }
    }
}
#pragma warning restore 1591
