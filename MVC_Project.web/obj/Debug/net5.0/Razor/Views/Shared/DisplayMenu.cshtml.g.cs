#pragma checksum "E:\ITI\Store\Store\MVC_Project.web\Views\Shared\DisplayMenu.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a85158de68dd64521253275714104c15039c17b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_DisplayMenu), @"mvc.1.0.view", @"/Views/Shared/DisplayMenu.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a85158de68dd64521253275714104c15039c17b", @"/Views/Shared/DisplayMenu.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5b3ffb9689000b7563089ed5cffb1ca3e2abbe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_DisplayMenu : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Food>>
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
            WriteLiteral("\r\n ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0a85158de68dd64521253275714104c15039c17b3413", async() => {
                WriteLiteral("\r<div  class=\"hero_area\">\r\n      <div class=\"bg-box\">\r\n        <img src=\"images/main.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 117, "\"", 123, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
      </div>
      <!-- slider section -->
      <section class=""slider_section"">
        <div id=""customCarousel1"" class=""carousel slide"" data-ride=""carousel"">
          <div class=""carousel-inner"">
            <div class=""carousel-item active"">
              <div class=""container"">
                <div class=""row"">
                  <div class=""col-md-7 col-lg-6"">
                    <div class=""detail-box"">
                      <h2 style=""color:black;font-family:'Times New Roman', Times, serif"">Design Your Home
With Furniture You Can Buy
And Shop It Hassle Free.</h2>
                      
                      <div class=""btn-box"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 815, "\"", 822, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn1""> Order Now </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
            <div class=""carousel-item"">
              <div class=""container"">
                <div class=""row"">
                  <div class=""col-md-7 col-lg-6"">
                    <div class=""detail-box"">
                      <h1>Fast Food Restaurant</h1>
                      <p>
                        Doloremque, itaque aperiam facilis rerum, commodi,
                        temporibus sapiente ad mollitia laborum quam quisquam
                        esse error unde. Tempora ex doloremque, labore, sunt
                        repellat dolore, iste magni quos nihil ducimus libero
                        ipsam.
                      </p>
                      <div class=""btn-box"">
                        <a href=""CustomerMenu\Basket"" class=""btn1""> Order Now </a>
                      </div>
                    ");
                WriteLiteral(@"</div>
                  </div>
                </div>
              </div>
            </div>
            <div class=""carousel-item"">
              <div class=""container"">
                <div class=""row"">
                  <div class=""col-md-7 col-lg-6"">
                    <div class=""detail-box"">
                      <h1>Fast Food Restaurant</h1>
                      <p>
                        Doloremque, itaque aperiam facilis rerum, commodi,
                        temporibus sapiente ad mollitia laborum quam quisquam
                        esse error unde. Tempora ex doloremque, labore, sunt
                        repellat dolore, iste magni quos nihil ducimus libero
                        ipsam.
                      </p>
                      <div class=""btn-box"">
                        <a");
                BeginWriteAttribute("href", " href=\"", 2682, "\"", 2689, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""btn1""> Order Now </a>
                      </div>
                    </div>
                  </div>
                </div>
              </div>
            </div>
          </div>
          <div class=""container"">
            <ol class=""carousel-indicators"">
              <li
                data-target=""#customCarousel1""
                data-slide-to=""0""
                class=""active""
              ></li>
              <li data-target=""#customCarousel1"" data-slide-to=""1""></li>
              <li data-target=""#customCarousel1"" data-slide-to=""2""></li>
            </ol>
          </div>
        </div>
      </section>
      <!-- end slider section -->
    </div>

    <!-- offer section -->

    <section class=""offer_section layout_padding-bottom"">
      <div class=""offer_container"">
        <div class=""container"">
          <div class=""row"">
            <div class=""col-md-6"">
              <div class=""box"">
                <div class=""img-box"">
                  <img s");
                WriteLiteral("rc=\"images/desk.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 3734, "\"", 3740, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"detail-box\">\r\n                  <h5>Today\'s Deals</h5>\r\n                  <h6><span>20%</span> Off</h6>\r\n                  <a");
                BeginWriteAttribute("href", " href=\"", 3923, "\"", 3930, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    Order Now
                    <svg
                      version=""1.1""
                      id=""Capa_1""
                      xmlns=""http://www.w3.org/2000/svg""
                      xmlns:xlink=""http://www.w3.org/1999/xlink""
                      x=""0px""
                      y=""0px""
                      viewBox=""0 0 456.029 456.029""
                      style=""enable-background: new 0 0 456.029 456.029""
                      xml:space=""preserve""
                    >
                      <g>
                        <g>
                          <path
                            d=""M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                     c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z""
                          />
                        </g>
                      </g>
                      <g>
                        <g>
                          <path
                ");
                WriteLiteral(@"            d=""M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                     C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                     c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                     C457.728,97.71,450.56,86.958,439.296,84.91z""
                          />
                        </g>
                      </g>
                      <g>
                        <g>
                          <path
                            d=""M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                     c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z""
                          />
                        </g>
                      </g>
                    </svg>
                  </a>
        ");
                WriteLiteral("        </div>\r\n              </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n              <div class=\"box\">\r\n                <div class=\"img-box\">\r\n                  <img src=\"images/chair.jpg\"");
                BeginWriteAttribute("alt", " alt=\"", 6190, "\"", 6196, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                </div>\r\n                <div class=\"detail-box\">\r\n                  <h5>Today\'s Deals</h5>\r\n                  <h6><span>15%</span> Off</h6>\r\n                  <a");
                BeginWriteAttribute("href", " href=\"", 6379, "\"", 6386, 0);
                EndWriteAttribute();
                WriteLiteral(@">
                    Order Now
                    <svg
                      version=""1.1""
                      id=""Capa_1""
                      xmlns=""http://www.w3.org/2000/svg""
                      xmlns:xlink=""http://www.w3.org/1999/xlink""
                      x=""0px""
                      y=""0px""
                      viewBox=""0 0 456.029 456.029""
                      style=""enable-background: new 0 0 456.029 456.029""
                      xml:space=""preserve""
                    >
                      <g>
                        <g>
                          <path
                            d=""M345.6,338.862c-29.184,0-53.248,23.552-53.248,53.248c0,29.184,23.552,53.248,53.248,53.248
                     c29.184,0,53.248-23.552,53.248-53.248C398.336,362.926,374.784,338.862,345.6,338.862z""
                          />
                        </g>
                      </g>
                      <g>
                        <g>
                          <path
                ");
                WriteLiteral(@"            d=""M439.296,84.91c-1.024,0-2.56-0.512-4.096-0.512H112.64l-5.12-34.304C104.448,27.566,84.992,10.67,61.952,10.67H20.48
                     C9.216,10.67,0,19.886,0,31.15c0,11.264,9.216,20.48,20.48,20.48h41.472c2.56,0,4.608,2.048,5.12,4.608l31.744,216.064
                     c4.096,27.136,27.648,47.616,55.296,47.616h212.992c26.624,0,49.664-18.944,55.296-45.056l33.28-166.4
                     C457.728,97.71,450.56,86.958,439.296,84.91z""
                          />
                        </g>
                      </g>
                      <g>
                        <g>
                          <path
                            d=""M215.04,389.55c-1.024-28.16-24.576-50.688-52.736-50.688c-29.696,1.536-52.224,26.112-51.2,55.296
                     c1.024,28.16,24.064,50.688,52.224,50.688h1.024C193.536,443.31,216.576,418.734,215.04,389.55z""
                          />
                        </g>
                      </g>
                     
                    </svg>
         ");
                WriteLiteral(@"         </a>
                </div>
              </div>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- end offer section -->

    <!-- food section -->

    <section class=""food_section layout_padding-bottom"">
      <div class=""container"">
        <div class=""heading_container heading_center"">
          <h2>Best sellers</h2>
        </div>
        <div style=""margin-top:40px""></div>
");
                WriteLiteral(@"   </div>
</div> 
}
</div>
  </div>
        </div>
    </section>

    <!-- end food section -->

    <!-- about section -->

    <section class=""about_section layout_padding"">
      <div class=""container"">
        <div class=""row"">
          <div class=""col-md-6"">
            <div class=""img-box"">
              <img src=""images/main.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 10370, "\"", 10376, 0);
                EndWriteAttribute();
                WriteLiteral(@" />
            </div>
          </div>
          <div class=""col-md-6"">
            <div class=""detail-box"">
              <div class=""heading_container"">
                <h2>We Are Burgesta</h2>
              </div>
              <p>
                There are many variations of passages of Lorem Ipsum available,
                but the majority have suffered alteration in some form, by
                injected humour, or randomised words which don't look even
                slightly believable. If you are going to use a passage of Lorem
                Ipsum, you need to be sure there isn't anything embarrassing
                hidden in the middle of text. All
              </p>
              <a");
                BeginWriteAttribute("href", " href=\"", 11101, "\"", 11108, 0);
                EndWriteAttribute();
                WriteLiteral(@"> Read More </a>
            </div>
          </div>
        </div>
      </div>
    </section>

    <!-- end about section -->



    <!-- client section -->

    <section class=""client_section layout_padding-bottom"">
      <div class=""container"">
        <div class=""heading_container heading_center psudo_white_primary mb_45"">
          <h2>What Says Our Customers</h2>
        </div>
        <div class=""carousel-wrap row"">
          <div class=""owl-carousel client_owl-carousel"">
            <div class=""item"">
              <div class=""box"">
                <div class=""detail-box"">
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                    do eiusmod tempor incididunt ut labore et dolore magna
                    aliqua. Ut enim ad minim veniam
                  </p>
                  <h6>Michell Martin</h6>
                  <p>magna aliqua</p>
                </div>
                <div class=""img-box"">
         ");
                WriteLiteral("         <img src=\"images/man3.jfif\"");
                BeginWriteAttribute("alt", " alt=\"", 12169, "\"", 12175, 0);
                EndWriteAttribute();
                WriteLiteral(@" class=""box-img"" />
                </div>
              </div>
            </div>
            <div class=""item"">
              <div class=""box"">
                <div class=""detail-box"">
                  <p>
                    Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed
                    do eiusmod tempor incididunt ut labore et dolore magna
                    aliqua. Ut enim ad minim veniam
                  </p>
                  <h6>Mike Hamell</h6>
                  <p>magna aliqua</p>
                </div>
                <div class=""img-box"">
                  <img src=""images/man2.jpg""");
                BeginWriteAttribute("alt", " alt=\"", 12814, "\"", 12820, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"box-img\" />\r\n                </div>\r\n              </div>\r\n            </div>\r\n          </div>\r\n        </div>\r\n      </div>\r\n    </section>\r\n\r\n     ");
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
            WriteLiteral("\r\n    <!-- end client section -->\r\n\r\n \r\n\r\n");
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
