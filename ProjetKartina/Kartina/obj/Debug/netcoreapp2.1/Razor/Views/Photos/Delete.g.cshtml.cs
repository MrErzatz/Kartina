#pragma checksum "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8159d9d0d4849f68104036f447dddecfdd349472"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Photos_Delete), @"mvc.1.0.view", @"/Views/Photos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Photos/Delete.cshtml", typeof(AspNetCore.Views_Photos_Delete))]
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
#line 1 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\_ViewImports.cshtml"
using Kartina;

#line default
#line hidden
#line 2 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\_ViewImports.cshtml"
using Kartina.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8159d9d0d4849f68104036f447dddecfdd349472", @"/Views/Photos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cca603c46fb55325c6d1c11fc94cb5f31b3fb0c1", @"/Views/_ViewImports.cshtml")]
    public class Views_Photos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Kartina.Models.Photo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(73, 166, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Photo</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(240, 44, false);
#line 15 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdFormat));

#line default
#line hidden
            EndContext();
            BeginContext(284, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(328, 40, false);
#line 18 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdFormat));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 43, false);
#line 21 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdTheme));

#line default
#line hidden
            EndContext();
            BeginContext(455, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(499, 39, false);
#line 24 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdTheme));

#line default
#line hidden
            EndContext();
            BeginContext(538, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(582, 46, false);
#line 27 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TitrePhoto));

#line default
#line hidden
            EndContext();
            BeginContext(628, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(672, 42, false);
#line 30 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TitrePhoto));

#line default
#line hidden
            EndContext();
            BeginContext(714, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(758, 52, false);
#line 33 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DescriptionPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(810, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(854, 48, false);
#line 36 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DescriptionPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(902, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(946, 45, false);
#line 39 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PrixPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1035, 41, false);
#line 42 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PrixPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1076, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1120, 48, false);
#line 45 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.LargeurPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1168, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1212, 44, false);
#line 48 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.LargeurPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1256, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1300, 48, false);
#line 51 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.HauteurPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1348, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1392, 44, false);
#line 54 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.HauteurPhoto));

#line default
#line hidden
            EndContext();
            BeginContext(1436, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1480, 46, false);
#line 57 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.DateDepose));

#line default
#line hidden
            EndContext();
            BeginContext(1526, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1570, 42, false);
#line 60 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.DateDepose));

#line default
#line hidden
            EndContext();
            BeginContext(1612, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1656, 59, false);
#line 63 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdOrientationNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1715, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1759, 70, false);
#line 66 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdOrientationNavigation.NomOrientation));

#line default
#line hidden
            EndContext();
            BeginContext(1829, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1873, 59, false);
#line 69 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.IdUtilisateurNavigation));

#line default
#line hidden
            EndContext();
            BeginContext(1932, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1976, 69, false);
#line 72 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.IdUtilisateurNavigation.IdUtilisateur));

#line default
#line hidden
            EndContext();
            BeginContext(2045, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(2083, 212, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e6b07089144c56939d2132ae489626", async() => {
                BeginContext(2109, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2119, 41, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a5537633a5df455fbd053899835a88de", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 77 "C:\Users\Administrateur\source\repos\ProjetKartina\Kartina\Views\Photos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IdPhoto);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2160, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(2244, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e22579f304904d6482d65e1a6201f9a3", async() => {
                    BeginContext(2266, 12, true);
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
                BeginContext(2282, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2295, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Kartina.Models.Photo> Html { get; private set; }
    }
}
#pragma warning restore 1591