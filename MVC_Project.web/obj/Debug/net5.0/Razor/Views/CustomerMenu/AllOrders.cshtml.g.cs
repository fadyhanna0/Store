#pragma checksum "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b85adc55a1bab9347ffa176f32772996ccb2bbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_CustomerMenu_AllOrders), @"mvc.1.0.view", @"/Views/CustomerMenu/AllOrders.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b85adc55a1bab9347ffa176f32772996ccb2bbe", @"/Views/CustomerMenu/AllOrders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b3ffb9689000b7563089ed5cffb1ca3e2abbe7", @"/Views/_ViewImports.cshtml")]
    public class Views_CustomerMenu_AllOrders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Order>>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4b85adc55a1bab9347ffa176f32772996ccb2bbe3433", async() => {
                WriteLiteral("\r\n\r\n     <div class=\"heading_container heading_center\">\r\n        </div>\r\n        <div style=\"margin-top:120px\"></div>\r\n");
#nullable restore
#line 8 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
         foreach (var item in Model)
       {
           
       

#line default
#line hidden
#nullable disable
                WriteLiteral(@"    <div style=""width: 100%; display: flex ; flex-direction: row; margin-top: 50px;  align-items: center;"">

        <div style=""display: flex; flex-direction:column; width:20%; margin-left: 30px;"">
            <h3 style=""display: block;margin-right: 50px; "">");
#nullable restore
#line 15 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                                                       Write(item.AppUser.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n              <h5 style=\"display: block;margin-right: 50px; \">");
#nullable restore
#line 16 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                                                         Write(item.AppUser.Phone);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n            <h5 style=\"display: block;margin-right: 50px; \">");
#nullable restore
#line 17 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                                                       Write(item.AppUser.Address);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n             <h5 style=\"display: block;margin-right: 50px; \">");
#nullable restore
#line 18 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                                                        Write(item.DateTime);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>



        </div>



        <div style=""width: 50%;margin-right: 50px;"">

            <table class=""table  table-hover"" style=""border-bottom: 1px solid #999;"">
                <tr  style=""background-color:#e0ebeb"">
                     <th>Product</th>
                    <th>quantity</th>
                    <th>Price</th>
                    <th>Total_item_price</th>
                </tr>

                <!-- for loop on items-->
");
#nullable restore
#line 37 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                 foreach (var item2 in item.OrderItemsList){

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                      <td>");
#nullable restore
#line 39 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                     Write(item2.Product.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 40 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                   Write(item2.quantity);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 41 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                   Write(String.Format("{0:0.00}",@item2.Product.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 42 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                   Write(String.Format("{0:0.00}",@item2.Total_item_price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                  \r\n                </tr>\r\n");
#nullable restore
#line 45 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"

                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </table>\r\n\r\n\r\n        </div>\r\n\r\n\r\n\r\n        <div>\r\n\r\n            <h3 style=\"display:block;\"> EGP ");
#nullable restore
#line 56 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
                                       Write(String.Format("{0:0.00}",@item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</h3>\r\n                <a class=\"btn btn-danger del\"");
                BeginWriteAttribute("href", " href=\"", 1826, "\"", 1868, 2);
                WriteAttributeValue("", 1833, "\\CustomerMenu\\DeleteOrders\\", 1833, 27, true);
#nullable restore
#line 57 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
WriteAttributeValue("", 1860, item.Id, 1860, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Delete</a>\r\n                <a class=\"btn btn-success\"");
                BeginWriteAttribute("href", " href=\"", 1924, "\"", 1966, 2);
                WriteAttributeValue("", 1931, "\\CustomerMenu\\AcceptOrders\\", 1931, 27, true);
#nullable restore
#line 58 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
WriteAttributeValue("", 1958, item.Id, 1958, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">Confirm the Order</a>\r\n          \r\n\r\n        </div>\r\n\r\n\r\n    </div>\r\n    <hr>\r\n");
#nullable restore
#line 66 "E:\ITI\Store\Store\MVC_Project.web\Views\CustomerMenu\AllOrders.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

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

             </script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Order>> Html { get; private set; }
    }
}
#pragma warning restore 1591
