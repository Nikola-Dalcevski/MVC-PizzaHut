#pragma checksum "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccd618b5230691a1458469de6332d3673d11242"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pizza_Details), @"mvc.1.0.view", @"/Views/Pizza/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pizza/Details.cshtml", typeof(AspNetCore.Views_Pizza_Details))]
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
#line 1 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\_ViewImports.cshtml"
using SEDC.PizzaHut.WebApp;

#line default
#line hidden
#line 2 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\_ViewImports.cshtml"
using SEDC.PizzaHut.WebApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccd618b5230691a1458469de6332d3673d11242", @"/Views/Pizza/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cc71d3508f55c9ea479aa2190cb72ee66cdf59c5", @"/Views/_ViewImports.cshtml")]
    public class Views_Pizza_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<SEDC.PizzaHut.BusinessLayer.ViewModels.PizzaViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(62, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(107, 119, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Pizza</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(227, 40, false);
#line 14 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(267, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(311, 36, false);
#line 17 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(347, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(391, 45, false);
#line 20 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.PizzaType));

#line default
#line hidden
            EndContext();
            BeginContext(436, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(480, 46, false);
#line 23 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayFor(model => model.PizzaType.Name));

#line default
#line hidden
            EndContext();
            BeginContext(526, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(570, 40, false);
#line 26 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(610, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(654, 36, false);
#line 29 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(690, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(734, 41, false);
#line 32 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(775, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(819, 37, false);
#line 35 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(856, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(904, 54, false);
#line 40 "C:\Users\nikol\Desktop\GitMvc\sedc7-08-aspnetmvc\g4\Class 6\SEDC.PizzaHut\SEDC.PizzaHut.WebApp\Views\Pizza\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(958, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(966, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "222bd83cac3c409cb808b33d8fb89734", async() => {
                BeginContext(988, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1004, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<SEDC.PizzaHut.BusinessLayer.ViewModels.PizzaViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
