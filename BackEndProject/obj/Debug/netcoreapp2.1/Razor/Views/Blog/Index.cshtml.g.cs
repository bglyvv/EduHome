#pragma checksum "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc10040cd2755a7d64b91664634781ea0ba516c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Index), @"mvc.1.0.view", @"/Views/Blog/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Index.cshtml", typeof(AspNetCore.Views_Blog_Index))]
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
#line 1 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#line 2 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#line 3 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bc10040cd2755a7d64b91664634781ea0ba516c2", @"/Views/Blog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f6a7137cbfc21f64254730f2e3df1d47d27077f", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BlogVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(15, 103, true);
            WriteLiteral("<!-- Banner Area Start -->\r\n<div class=\"banner-area-wrapper\">\r\n    <div class=\"banner-area text-center\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 118, "\"", 195, 5);
            WriteAttributeValue("", 126, "background-image:", 126, 17, true);
            WriteAttributeValue(" ", 143, "url(/img/banner/", 144, 17, true);
#line 4 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
WriteAttributeValue("", 160, Model.Background.Image, 160, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 183, ")", 183, 1, true);
            WriteAttributeValue(" ", 184, "!important", 185, 11, true);
            EndWriteAttribute();
            BeginContext(196, 762, true);
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>blog / right side bar</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""pagination"">
                            <ul>
");
            EndContext();
#line 28 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                                 for (int i = 1; i <= +ViewBag.PageCount; ++i)
                                {


#line default
#line hidden
            BeginContext(1075, 52, true);
            WriteLiteral("                                    <li><a href=\"#\">");
            EndContext();
            BeginContext(1128, 1, false);
#line 31 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                                               Write(i);

#line default
#line hidden
            EndContext();
            BeginContext(1129, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 32 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                                }

#line default
#line hidden
            BeginContext(1175, 405, true);
            WriteLiteral(@"                            </ul>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-4"">
                <div class=""blog-sidebar right"">
                    <div class=""single-blog-widget mb-50"">
                        <h3>search</h3>
                        <div class=""blog-search"">
                            ");
            EndContext();
            BeginContext(1580, 339, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "422d4b12d1cf4db38140cdef23d7b4a7", async() => {
                BeginContext(1609, 303, true);
                WriteLiteral(@"
                                <input type=""search"" placeholder=""Search..."" name=""search"" />
                                <button type=""submit"">
                                    <span><i class=""fa fa-search""></i></span>
                                </button>
                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1919, 193, true);
            WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"single-blog-widget mb-50\">\r\n                        <h3>Events</h3>\r\n                        <ul>\r\n");
            EndContext();
#line 54 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                             foreach (Event eventName in Model.Events)
                            {

#line default
#line hidden
            BeginContext(2215, 48, true);
            WriteLiteral("                                <li><a href=\"#\">");
            EndContext();
            BeginContext(2264, 26, false);
#line 56 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                                           Write(eventName.Header.ToUpper());

#line default
#line hidden
            EndContext();
            BeginContext(2290, 11, true);
            WriteLiteral("</a></li>\r\n");
            EndContext();
#line 57 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"

                            }

#line default
#line hidden
            BeginContext(2334, 528, true);
            WriteLiteral(@"                        </ul>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <div class=""single-blog-banner"">
                            <a href=""blog-details.html"" id=""blog""><img src=""img/blog/blog-img.jpg"" alt=""blog""></a>
                            <h2>best<br> eductaion<br> theme</h2>
                        </div>
                    </div>
                    <div class=""single-blog-widget mb-50"">
                        <h3>latest events</h3>
");
            EndContext();
#line 69 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                         foreach (Event _event in Model.Events)
                        {


#line default
#line hidden
            BeginContext(2956, 289, true);
            WriteLiteral(@"                            <div class=""single-post mb-30"">
                                <div class=""single-post-img"">
                                    <a href=""blog-details.html"" style=""width:33% !important; margin-top:5px!important"">
                                        <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3245, "\"", 3274, 2);
            WriteAttributeValue("", 3251, "img/event/", 3251, 10, true);
#line 75 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
WriteAttributeValue("", 3261, _event.Image, 3261, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3275, 417, true);
            WriteLiteral(@" alt=""post"">
                                        <div class=""blog-hover"">
                                            <i class=""fa fa-link""></i>
                                        </div>
                                    </a>
                                </div>
                                <div class=""single-post-content"">
                                    <h4><a href=""blog-details.html"">");
            EndContext();
            BeginContext(3693, 13, false);
#line 82 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                                                               Write(_event.Header);

#line default
#line hidden
            EndContext();
            BeginContext(3706, 50, true);
            WriteLiteral("</a></h4>\r\n                                    <p>");
            EndContext();
            BeginContext(3757, 65, false);
#line 83 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                                  Write(_event.Date.ToString("MMM dd, yyyy",CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(3822, 82, true);
            WriteLiteral("</p>\r\n                                </div>\r\n                            </div>\r\n");
            EndContext();
#line 86 "/Users/kanan/Desktop/EduHome/BackEndProject/Views/Blog/Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(3931, 829, true);
            WriteLiteral(@"                    </div>
                    <div class=""single-blog-widget"">
                        <h3>tags</h3>
                        <div class=""single-tag"">
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">course</a>
                            <a href=""blog-details.html"" class=""mr-10 mb-10"">education</a>
                            <a href=""blog-details.html"" class=""mb-10"">teachers</a>
                            <a href=""blog-details.html"" class=""mr-10"">learning</a>
                            <a href=""blog-details.html"" class=""mr-10"">university</a>
                            <a href=""blog-details.html"">events</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Blog End -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BlogVM> Html { get; private set; }
    }
}
#pragma warning restore 1591