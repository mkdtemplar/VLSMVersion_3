#pragma checksum "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/VLSM_/VlsmResultNew.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1282272bf95ffea8ed623f526a018561f817b3dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.VlsmResultNew), @"mvc.1.0.view", @"/VlsmResultNew.cshtml")]
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
#line 1 "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/_ViewImports.cshtml"
using VLSMVersion_3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/_ViewImports.cshtml"
using VLSMVersion_3.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/VLSM_/VlsmResultNew.cshtml"
using System.Collections;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/VLSM_/VlsmResultNew.cshtml"
using System.Collections.Specialized;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1282272bf95ffea8ed623f526a018561f817b3dc", @"/VlsmResultNew.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d254c4c2f9ea4d851c042dfa8a76888f4085948a", @"/_ViewImports.cshtml")]
    public class VlsmResultNew : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VLSMVersion_3.Models.VLSM_Model>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DisplayDatabase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 5 "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/VLSM_/VlsmResultNew.cshtml"
  
    ViewData["Title"] = "VlsmResult";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    
    table {
        background-color: lightblue;
        border-collapse: collapse;
        border: 1px solid gray;
        justify-content: center;
        align-items: center;
        text-align: center;
        margin-bottom: 5px;
        margin-top: 5px;
    }

    th,
    td {
        padding: 5px;
        border: 1px solid gray;
    }

    tr:nth-child(even) {
        background-color: lightcoral;
    }

    tr:first-child {
        background-color: lightgreen;
    }
    .center {
        justify-content: center;
        align-items: center;
        text-align: center;
        margin-bottom: 5px;
        margin-top: 5px;
    }
</style>


<h1>VlsmResultNew</h1>

<hr />

");
#nullable restore
#line 48 "/mnt/99ebcd88-419d-4d30-a13a-b5d3286276ce/C#/PracticalApps/VLSMVersion_3/VLSMVersion_3/Views/VLSM_/VlsmResultNew.cshtml"
Write(ViewData["FinalResult"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1282272bf95ffea8ed623f526a018561f817b3dc5169", async() => {
                WriteLiteral("Display Database Content");
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