#pragma checksum "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fbf0537c1e210e5c8616ee7e3648de09c754f123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_VLSM__VlsmResult), @"mvc.1.0.view", @"/Views/VLSM_/VlsmResult.cshtml")]
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
#nullable restore
#line 1 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\_ViewImports.cshtml"
using VLSMVersion_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\_ViewImports.cshtml"
using VLSMVersion_3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fbf0537c1e210e5c8616ee7e3648de09c754f123", @"/Views/VLSM_/VlsmResult.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d254c4c2f9ea4d851c042dfa8a76888f4085948a", @"/Views/_ViewImports.cshtml")]
    public class Views_VLSM__VlsmResult : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VLSMVersion_3.Models.VLSM_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "VlsmResult", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
  
    ViewData["Title"] = "VlsmResult";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>VlsmResult</h1>\r\n\r\n<div>\r\n    <h4>VLSM_Model</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
       Write(Html.DisplayNameFor(model => model.IP_Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n           ");
#nullable restore
#line 17 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
      Write(ViewData["IP_Address"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
       Write(Html.DisplayNameFor(model => model.LansValues));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n");
#nullable restore
#line 23 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
              
                var i = 1;
                foreach (var item in (List<Lans>)ViewData["LansValues"])
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                  <p>Lan[");
#nullable restore
#line 27 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
                     Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("]:");
#nullable restore
#line 27 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
                             Write(" ");

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 27 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
                                   Write(item.InitialLanValues);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 28 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
       Write(Html.DisplayNameFor(model => model.cidrValue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
       Write(ViewData["cidrValue"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            <label>Netword ID:</label>\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
       Write(ViewData["NetworkID"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            <label>Total hosts:</label>\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 47 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
       Write(ViewData["TotalHosts"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 52 "D:\C#\PracticalApps\VLSMVersion_3\VLSMVersion_3\Views\VLSM_\VlsmResult.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbf0537c1e210e5c8616ee7e3648de09c754f1237917", async() => {
                WriteLiteral("Back to List");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VLSMVersion_3.Models.VLSM_Model> Html { get; private set; }
    }
}
#pragma warning restore 1591
