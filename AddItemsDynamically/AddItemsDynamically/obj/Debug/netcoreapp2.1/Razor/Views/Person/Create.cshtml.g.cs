#pragma checksum "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "803e6da6e282e71ea29779d71608eab80bdc6427"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Create), @"mvc.1.0.view", @"/Views/Person/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Person/Create.cshtml", typeof(AspNetCore.Views_Person_Create))]
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
#line 1 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\_ViewImports.cshtml"
using AddItemsDynamically;

#line default
#line hidden
#line 2 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\_ViewImports.cshtml"
using AddItemsDynamically.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"803e6da6e282e71ea29779d71608eab80bdc6427", @"/Views/Person/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42dee49d1484c88fe3f5ab7318645e0fc299ccf6", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AddItemsDynamically.Models.Person>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery-1.10.2.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Scripts/jquery.validate.unobtrusive.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(42, 3, true);
            WriteLiteral(" \r\n");
            EndContext();
#line 3 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(83, 26, true);
            WriteLiteral(" \r\n<h2>Create</h2>\r\n \r\n \r\n");
            EndContext();
#line 10 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
 using (Html.BeginForm()) 
{
    

#line default
#line hidden
            BeginContext(145, 23, false);
#line 12 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(176, 84, true);
            WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Person</h4>\r\n        <hr />\r\n        ");
            EndContext();
            BeginContext(261, 64, false);
#line 17 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
   Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(325, 48, true);
            WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(374, 93, false);
#line 19 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
       Write(Html.LabelFor(model => model.Name, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(467, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(523, 93, false);
#line 21 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
           Write(Html.EditorFor(model => model.Name, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(616, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(635, 82, false);
#line 22 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(717, 87, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n \r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(805, 93, false);
#line 27 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
       Write(Html.LabelFor(model => model.City, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(898, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(954, 93, false);
#line 29 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
           Write(Html.EditorFor(model => model.City, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1047, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1066, 82, false);
#line 30 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.City, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1148, 87, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n \r\n        <div class=\"form-group\">\r\n            ");
            EndContext();
            BeginContext(1236, 96, false);
#line 35 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
       Write(Html.LabelFor(model => model.Address, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1332, 55, true);
            WriteLiteral("\r\n            <div class=\"col-md-10\">\r\n                ");
            EndContext();
            BeginContext(1388, 96, false);
#line 37 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
           Write(Html.EditorFor(model => model.Address, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 18, true);
            WriteLiteral("\r\n                ");
            EndContext();
            BeginContext(1503, 85, false);
#line 38 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
           Write(Html.ValidationMessageFor(model => model.Address, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 256, true);
            WriteLiteral(@"
            </div>
        </div>
 
        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Create"" class=""btn btn-default"" />
            </div>
        </div>
    </div>
");
            EndContext();
#line 48 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
}

#line default
#line hidden
            BeginContext(1847, 14, true);
            WriteLiteral(" \r\n<div>\r\n    ");
            EndContext();
            BeginContext(1862, 40, false);
#line 51 "D:\Test\shahrokh\AddItemsDynamically\AddItemsDynamically\Views\Person\Create.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 13, true);
            WriteLiteral("\r\n</div>\r\n \r\n");
            EndContext();
            BeginContext(1915, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803e6da6e282e71ea29779d71608eab80bdc642710771", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1969, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1971, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803e6da6e282e71ea29779d71608eab80bdc642711951", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2027, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(2029, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "803e6da6e282e71ea29779d71608eab80bdc642713131", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2097, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AddItemsDynamically.Models.Person> Html { get; private set; }
    }
}
#pragma warning restore 1591