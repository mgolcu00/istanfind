#pragma checksum "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f00b4b6185596f73eb8f5b438c063a0579abbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Manage__Layout), @"mvc.1.0.view", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
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
#line 1 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\_ViewImports.cshtml"
using istanfind.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\_ViewImports.cshtml"
using istanfind.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\_ViewImports.cshtml"
using istanfind.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using istanfind.Areas.Identity.Pages.Account;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_ViewImports.cshtml"
using istanfind.Areas.Identity.Pages.Account.Manage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
using istanfind.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f00b4b6185596f73eb8f5b438c063a0579abbf", @"/Areas/Identity/Pages/Account/Manage/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"912926fe974ffdfbcfe0c3eadb0e600b9f5607c5", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"909a6a25815726a34c9f415514ba927e038ea1c1", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b5b8c757d72535ad1a273b6c1d3ecdb7634ed3bc", @"/Areas/Identity/Pages/Account/Manage/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Manage__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ManageNav", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
  
	if (ViewData.TryGetValue("ParentLayout", out var parentLayout))
	{
		Layout = (string)parentLayout;
	}
	else
	{
		Layout = "/Areas/Identity/Pages/_Layout.cshtml";
	}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 14 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("hesabiyonet"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n<div>\r\n\t<h4>");
#nullable restore
#line 17 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
   Write(SharedLocalizer.GetLocalizedHtmlString("ayardegistir"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t<hr />\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-md-3\">\r\n\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "73f00b4b6185596f73eb8f5b438c063a0579abbf6083", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\t\t</div>\r\n\t\t<div class=\"col-md-9\">\r\n\t\t\t");
#nullable restore
#line 24 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
       Write(RenderBody());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\t");
#nullable restore
#line 30 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Areas\Identity\Pages\Account\Manage\_Layout.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
            }
            );
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public LocService SharedLocalizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
