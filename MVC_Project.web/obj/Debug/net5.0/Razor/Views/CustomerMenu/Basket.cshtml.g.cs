#pragma checksum "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46f1904746fcbf7468671b899e255d46c1336aa9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerMenu_Basket), @"mvc.1.0.view", @"/Views/CustomerMenu/Basket.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46f1904746fcbf7468671b899e255d46c1336aa9", @"/Views/CustomerMenu/Basket.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b3ffb9689000b7563089ed5cffb1ca3e2abbe7", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerMenu_Basket : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderItem>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:6rem;width:8rem;display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"        <div class=""heading_container heading_center""></div>
        <div style=""margin-top:150px""></div>
 <table  class=""table table-bordered table-hover container"" width=""50%"">
      <tr  style=""background-color:#e0ebeb"">
       <th>
            ITEM
        </th>
        <th>
            QUANTITY	
        </th>
        <th>
            UNIT PRICE	
        </th>
        <th>
   right SUBTOTAL	
        </th></tr>
");
#nullable restore
#line 18 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
    foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "46f1904746fcbf7468671b899e255d46c1336aa94812", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 557, "~/images/", 557, 9, true);
#nullable restore
#line 22 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
AddHtmlAttributeValue("", 566, item.Product.Image, 566, 19, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                <p style=\"display:inline;margin-left:10px\">");
#nullable restore
#line 23 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
                                                      Write(item.Product.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                \r\n            </td>\r\n            <td>");
#nullable restore
#line 26 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
           Write(item.quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n           <td>");
#nullable restore
#line 27 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
          Write(String.Format("{0:0.00}",@item.Product.Price ));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
           Write(String.Format("{0:0.00}",@item.Total_item_price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "46f1904746fcbf7468671b899e255d46c1336aa97539", async() => {
                WriteLiteral("\r\n                <input type=\"hidden\" name=\"ProductId\"");
                BeginWriteAttribute("value", " value=\"", 1063, "\"", 1087, 1);
#nullable restore
#line 30 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
WriteAttributeValue("", 1071, item.Product_Id, 1071, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" >\r\n               <td><input type=\"submit\" class=\"btn btn-danger del\" value=\"Delete\" ></td>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 967, "\\CustomerMenu\\DeleteItem\\", 967, 25, true);
#nullable restore
#line 29 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
AddHtmlAttributeValue("", 992, item.Order_Id, 992, 14, false);

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
            WriteLiteral("\r\n        </tr>\r\n");
#nullable restore
#line 34 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<div style=\"margin:30px 0px 50px 170px\">\r\n           <h3 style=\"display:inline-block;margin-right:480px\"> Total Price : EGP ");
#nullable restore
#line 37 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
                                                                             Write(String.Format("{0:0.00}", @ViewBag.TotalPrice));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h3>\r\n           <label for=\"payment\">Select Payment Method</label>\r\n    <select style=\"margin-right:100px\" id=\"payment\" onchange=\"AjaxCall()\" \">\r\n");
#nullable restore
#line 40 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
            foreach (var Item in ViewBag.Payment)
            {
               

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <option");
            BeginWriteAttribute("value", " value=\"", 1665, "\"", 1683, 1);
#nullable restore
#line 43 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
WriteAttributeValue("", 1673, Item.Type, 1673, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 43 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
                                           Write(Item.Type);

#line default
#line hidden
#nullable disable
            WriteLiteral("</option>\r\n");
#nullable restore
#line 44 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\Basket.cshtml"
                
           }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        </select>
       <a class=""btn btn-success"" href=""\CustomerMenu\Checkout"">Checkout</a>
    </div>
   <div id=""div1""></div>
    
             <script>
                 var deletebtn=document.getElementsByClassName(""del"");
                 for(var i=0;i<deletebtn.length;i++)
                 {
                       deletebtn[i].addEventListener(""click"",function(e){
                           var res =confirm(""Do you want to delete this Item?"")
                           if(res==false){
                               e.preventDefault();
                           }
                       });
                 }
                 </script>




");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
<script>
      function AjaxCall(){
            var id=$(""#payment"").val();
            console.log(id);
            if(id==""Credit"")
            $.ajax(
                {
                    url  : ""/CustomerMenu/Payment"",
                    success: function(result){
                                $(""#div1"").html(result);
                        }
                }
                );
           
             }
             </script>");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderItem>> Html { get; private set; }
    }
}
#pragma warning restore 1591
