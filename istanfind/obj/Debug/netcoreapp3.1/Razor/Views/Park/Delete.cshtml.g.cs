#pragma checksum "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc9f909ca9386613a3971397b7c89ceb8f24c7bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Park_Delete), @"mvc.1.0.view", @"/Views/Park/Delete.cshtml")]
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
#line 1 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\_ViewImports.cshtml"
using istanfind;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\_ViewImports.cshtml"
using istanfind.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
using istanfind.Resources;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc9f909ca9386613a3971397b7c89ceb8f24c7bc", @"/Views/Park/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a004301f8feb3171cab316505d278f55aba55d76", @"/Views/_ViewImports.cshtml")]
    public class Views_Park_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<istanfind.Models.Park>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 5 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
      
		ViewData["Title"] = "Delete";
	

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>");
#nullable restore
#line 9 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("sil"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<h3>");
#nullable restore
#line 11 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
Write(SharedLocalizer.GetLocalizedHtmlString("silecekmisin"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\t<div>\r\n\t\t<h4>");
#nullable restore
#line 13 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
       Write(SharedLocalizer.GetLocalizedHtmlString("parklar"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n\t\t<hr />\r\n\t\t<dl class=\"row\">\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 17 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 20 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 23 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 26 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 29 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.WebSiteUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 32 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.WebSiteUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 35 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 38 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Adress));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 41 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.AdressUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 44 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.AdressUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 47 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 50 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Score));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 53 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.DataText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 56 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.DataText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 59 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TitleText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 62 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TitleText));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t\t<dt class=\"col-sm-2\">\r\n\t\t\t\t");
#nullable restore
#line 65 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dt>\r\n\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t");
#nullable restore
#line 68 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ImageUrl));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t</dd>\r\n\t\t</dl>\r\n\r\n\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc9f909ca9386613a3971397b7c89ceb8f24c7bc11318", async() => {
                WriteLiteral("\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "bc9f909ca9386613a3971397b7c89ceb8f24c7bc11583", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 73 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\t\t\t<input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n\t\t\t");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bc9f909ca9386613a3971397b7c89ceb8f24c7bc13364", async() => {
#nullable restore
#line 75 "C:\Users\akiny\OneDrive\Masaüstü\istanfind\istanfind\Views\Park\Delete.cshtml"
                             Write(SharedLocalizer.GetLocalizedHtmlString("listeyedon"));

#line default
#line hidden
#nullable disable
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
                WriteLiteral("\r\n\t\t");
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
            WriteLiteral("\r\n\t</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<istanfind.Models.Park> Html { get; private set; }
    }
}
#pragma warning restore 1591
