#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0c5c22f8c7878fc6ea1ff8d56dbb1093ce26f747"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Event_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Event/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Event/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Event_Detail))]
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
#line 1 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c5c22f8c7878fc6ea1ff8d56dbb1093ce26f747", @"/Areas/Admin/Views/Event/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901e7c2bbfb5a082ff900225b5567e29d38e7f0", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Event_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EventDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("event-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("speaker"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(22, 302, true);
            WriteLiteral(@"<!-- Event Details Start -->
<div class=""event-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-8"">
                <div class=""event-details"">
                    <div class=""event-details-img"">
                        ");
            EndContext();
            BeginContext(324, 62, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65de38a87ae5439d873f3722863f8b78", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 334, "~/img/event/", 334, 12, true);
#line 9 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 346, Model.Event.Image, 346, 18, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(386, 90, true);
            WriteLiteral("\r\n                        <div class=\"event-date\">\r\n                            <h3>Date: ");
            EndContext();
            BeginContext(477, 71, false);
#line 11 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                 Write(Model.Event.Date.ToString("dd MMM, yyyy", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(548, 152, true);
            WriteLiteral("</h3>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"event-details-content\">\r\n                        <h2>");
            EndContext();
            BeginContext(701, 18, false);
#line 15 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                       Write(Model.Event.Header);

#line default
#line hidden
            EndContext();
            BeginContext(719, 98, true);
            WriteLiteral("</h2>\r\n                        <ul>\r\n                            <li><span>Time Interval : </span>");
            EndContext();
            BeginContext(818, 20, false);
#line 17 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                                        Write(Model.Event.Interval);

#line default
#line hidden
            EndContext();
            BeginContext(838, 63, true);
            WriteLiteral("</li>\r\n                            <li><span>Location : </span>");
            EndContext();
            BeginContext(902, 20, false);
#line 18 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                                   Write(Model.Event.Location);

#line default
#line hidden
            EndContext();
            BeginContext(922, 65, true);
            WriteLiteral("</li>\r\n                        </ul>\r\n                        <p>");
            EndContext();
            BeginContext(988, 19, false);
#line 20 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                      Write(Model.Event.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1007, 159, true);
            WriteLiteral("</p>\r\n                        <div class=\"speakers-area fix\">\r\n                            <h4>Speakers</h4>\r\n                            <div class=\"row\">\r\n\r\n");
            EndContext();
#line 25 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                 foreach (Speaker speaker in Model.Speakers)
                                {


#line default
#line hidden
            BeginContext(1281, 202, true);
            WriteLiteral("                                    <div class=\"single-speaker\" style=\"margin-left:30px\">\r\n                                        <div class=\"speaker-img\">\r\n                                            ");
            EndContext();
            BeginContext(1483, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "42237ae8b9564c3a80544a169d955250", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1493, "~/img/event/", 1493, 12, true);
#line 30 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
AddHtmlAttributeValue("", 1505, speaker.Image, 1505, 14, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1535, 166, true);
            WriteLiteral("\r\n                                        </div>\r\n                                        <div class=\"speaker-name\">\r\n                                            <h5>");
            EndContext();
            BeginContext(1702, 12, false);
#line 33 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                           Write(speaker.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1714, 54, true);
            WriteLiteral("</h5>\r\n                                            <p>");
            EndContext();
            BeginContext(1769, 18, false);
#line 34 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                          Write(speaker.Speciality);

#line default
#line hidden
            EndContext();
            BeginContext(1787, 99, true);
            WriteLiteral(" </p>\r\n                                        </div>\r\n                                    </div>\r\n");
            EndContext();
#line 37 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Event\Detail.cshtml"
                                }

#line default
#line hidden
            BeginContext(1921, 204, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Event Details End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EventDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591