#pragma checksum "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "77905f1875a73c6d6deddcf6beb04148b3b13d53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(BeadDotNetApp.Pages.Beads.Pages_Beads_Details), @"mvc.1.0.razor-page", @"/Pages/Beads/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Beads/Details.cshtml", typeof(BeadDotNetApp.Pages.Beads.Pages_Beads_Details), @"{id:int?}")]
namespace BeadDotNetApp.Pages.Beads
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/_ViewImports.cshtml"
using BeadDotNetApp;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"77905f1875a73c6d6deddcf6beb04148b3b13d53", @"/Pages/Beads/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b41ad191c58f36b5bffa8a56526f3785a93916f7", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Beads_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(66, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(111, 118, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Bead</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(230, 49, false);
#line 15 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.Material));

#line default
#line hidden
            EndContext();
            BeginContext(279, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(323, 45, false);
#line 18 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.Material));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 46, false);
#line 21 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.Shape));

#line default
#line hidden
            EndContext();
            BeginContext(458, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(502, 42, false);
#line 24 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.Shape));

#line default
#line hidden
            EndContext();
            BeginContext(544, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(588, 46, false);
#line 27 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.Color));

#line default
#line hidden
            EndContext();
            BeginContext(634, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(678, 42, false);
#line 30 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.Color));

#line default
#line hidden
            EndContext();
            BeginContext(720, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(764, 47, false);
#line 33 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.SizeMM));

#line default
#line hidden
            EndContext();
            BeginContext(811, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(855, 43, false);
#line 36 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.SizeMM));

#line default
#line hidden
            EndContext();
            BeginContext(898, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(942, 49, false);
#line 39 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(991, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1035, 45, false);
#line 42 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.Quantity));

#line default
#line hidden
            EndContext();
            BeginContext(1080, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1124, 51, false);
#line 45 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.PricePoint));

#line default
#line hidden
            EndContext();
            BeginContext(1175, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1219, 47, false);
#line 48 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.PricePoint));

#line default
#line hidden
            EndContext();
            BeginContext(1266, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1310, 46, false);
#line 51 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Bead.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1356, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1400, 42, false);
#line 54 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
       Write(Html.DisplayFor(model => model.Bead.Brand));

#line default
#line hidden
            EndContext();
            BeginContext(1442, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1489, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3f34023af778447cb9eea8ca7c1d340b", async() => {
                BeginContext(1540, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "/Users/carolynn/dev/C-Sharp/BeadDotNetApp/Pages/Beads/Details.cshtml"
                           WriteLiteral(Model.Bead.ID);

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
            BeginContext(1548, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1556, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a5c29c93864e4976b0cde598a8a0040e", async() => {
                BeginContext(1578, 17, true);
                WriteLiteral("Back to Bead List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1599, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BeadDotNetApp.Pages.Beads.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeadDotNetApp.Pages.Beads.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<BeadDotNetApp.Pages.Beads.DetailsModel>)PageContext?.ViewData;
        public BeadDotNetApp.Pages.Beads.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
