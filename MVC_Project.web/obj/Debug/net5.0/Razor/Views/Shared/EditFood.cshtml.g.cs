#pragma checksum "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "519d853d3b575b624137365fcd313dde0b5ae20f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_EditFood), @"mvc.1.0.view", @"/Views/Shared/EditFood.cshtml")]
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
#line 1 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\_ViewImports.cshtml"
using MVC_Project.web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\_ViewImports.cshtml"
using MVC_Project.Core.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\_ViewImports.cshtml"
using Restaurant.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"519d853d3b575b624137365fcd313dde0b5ae20f", @"/Views/Shared/EditFood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b3ffb9689000b7563089ed5cffb1ca3e2abbe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_EditFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("\\menu\\EditFood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519d853d3b575b624137365fcd313dde0b5ae20f4477", async() => {
                WriteLiteral("\r\n    <div>\r\n        \r\n        <input type=\"hidden\" name=\"Id\" id=\"Id\"");
                BeginWriteAttribute("value", "value=", 126, "", 141, 1);
#nullable restore
#line 5 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
WriteAttributeValue("", 132, Model.Id, 132, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  class=\"form-control\" />\r\n        <label for=\"Name\">Name</label>\r\n        <input type=\"text\" name=\"Name\" id=\"Name\"");
                BeginWriteAttribute("value", "value=", 256, "", 273, 1);
#nullable restore
#line 7 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
WriteAttributeValue("", 262, Model.Name, 262, 11, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  class=\"form-control\" />\r\n   </div>\r\n        <div>\r\n        <label for=\"Image\">Image</label>\r\n        <input type=\"text\" name=\"Image\" id=\"Image\"");
                BeginWriteAttribute("value", "value=", 418, "", 436, 1);
#nullable restore
#line 11 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
WriteAttributeValue("", 424, Model.Image, 424, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  class=\"form-control\" />\r\n  </div>\r\n  <div>\r\n        <label for=\"Price\">Price</label>\r\n        <input type=\"text\" name=\"Price\" id=\"Price\"");
                BeginWriteAttribute("value", "value=", 574, "", 592, 1);
#nullable restore
#line 15 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
WriteAttributeValue("", 580, Model.Price, 580, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"enter Price\"  class=\"form-control\" />\r\n  </div>\r\n  <div>\r\n        <label for=\"Description\">Description</label>\r\n        <input type=\"text\" name=\"Description\" id=\"Description\"");
                BeginWriteAttribute("value", "value=", 780, "", 804, 1);
#nullable restore
#line 19 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
WriteAttributeValue("", 786, Model.Description, 786, 18, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"enter Description\"  class=\"form-control\" />\r\n </div>\r\n   <div>\r\n       \r\n        <label for=\"Category_Id\">categories</label>\r\n        <select name=\"Category_Id\" id=\"Category_Id\" class=\"form-control\">\r\n");
#nullable restore
#line 25 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
            foreach (var categoriesItem in ViewBag.categories)
            {
                if (categoriesItem.Id == Model.Category_Id)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519d853d3b575b624137365fcd313dde0b5ae20f8059", async() => {
#nullable restore
#line 29 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
                                                            Write(categoriesItem.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
                       WriteLiteral(categoriesItem.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
               }else{

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "519d853d3b575b624137365fcd313dde0b5ae20f10585", async() => {
#nullable restore
#line 31 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
                                                   Write(categoriesItem.Name);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 31 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
                       WriteLiteral(categoriesItem.Id);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 32 "E:\ITI\asp.net mvc core\MVC_Prroject\MVC_Project_Solution\MVC_Project.web\Views\Shared\EditFood.cshtml"
           }}

#line default
#line hidden
#nullable disable
                WriteLiteral("        </select>\r\n        </div>\r\n\r\n    <input type=\"submit\" class=\"btn btn-sucess\" value=\"Save\" />\r\n\r\n  ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
