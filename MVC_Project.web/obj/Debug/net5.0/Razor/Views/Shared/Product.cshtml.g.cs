#pragma checksum "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "62d29af97056b649fbf680603a53c99f80163b02"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Product), @"mvc.1.0.view", @"/Views/Shared/Product.cshtml")]
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
#line 1 "E:\ITI\Store\Store\MVC_Project.web\Views\_ViewImports.cshtml"
using MVC_Project.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\Store\Store\MVC_Project.web\Views\_ViewImports.cshtml"
using MVC_Project.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITI\Store\Store\MVC_Project.web\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITI\Store\Store\MVC_Project.web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"62d29af97056b649fbf680603a53c99f80163b02", @"/Views/Shared/Product.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b3ffb9689000b7563089ed5cffb1ca3e2abbe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Product : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Food>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"food_section layout_padding-bottom\">\r\n      <div class=\"container\">\r\n        <div class=\"heading_container heading_center\">\r\n        </div>\r\n        <div style=\"margin-top:150px\"></div>\r\n<div class=\"container\">\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 9 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <div class=\"col-md-6 col-sm-12 col-lg-4\">\r\n  <div class=\"card\" style=\"width: 20rem;margin-right:40px !important;margin-bottom:40px ; border-radius:20px 20px 0px 0px; background-color:rgb(240, 245, 245)\">\r\n      <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 546, "\"", 571, 2);
            WriteAttributeValue("", 552, "/images/", 552, 8, true);
#nullable restore
#line 13 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
WriteAttributeValue("", 560, item.Image, 560, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Card image cap\" style=\"height: 10rem;width:12rem; margin:auto;margin-top:20px;\">\r\n  <div class=\"card-body\" style=\"background-color:rgb(34, 40, 49);border-radius:0px 0px 20px 20px\">\r\n    <h5 class=\"card-title\" style=\"color:white\">");
#nullable restore
#line 15 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
                                          Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n    <p class=\"card-text\" style=\"color:white\" >");
#nullable restore
#line 16 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
                                         Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <h3 class=\"card-text\" style=\"color:white;display:inline-block\" > <span class=\"a-price-symbol\">EGP  </span>");
#nullable restore
#line 17 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
                                                                                                         Write(String.Format("{0:0.00}", item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "62d29af97056b649fbf680603a53c99f80163b026226", async() => {
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Add to Cart\" class=\"btn btn-primary\"/>\r\n            <input type=\"number\" style=\"width:70px; margin-left:70px; border-radius:10px\"  min=1 name=\"quantity\" value=1 >\r\n\r\n      ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1083, "\\CustomerMenu\\AddInBasket\\", 1083, 26, true);
#nullable restore
#line 18 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
AddHtmlAttributeValue("", 1109, item.Id, 1109, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n  </div>\r\n   </div>\r\n</div> \r\n");
#nullable restore
#line 26 "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\Product.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n  </div>\r\n        </div>\r\n    </section>\r\n\r\n    <!-- end food section -->\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591