#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "461ade0c0cf4c0615c3287cb756243d2062f7b1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Course_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Course/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Course/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Course_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"461ade0c0cf4c0615c3287cb756243d2062f7b1b", @"/Areas/Admin/Views/Course/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Course_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CourseDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("courses-details"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:50%"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(23, 843, true);
            WriteLiteral(@"<!-- Banner Area Start -->
<div class=""banner-area-wrapper"">
    <div class=""banner-area text-center"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>courses details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Blog Start -->
<div class=""courses-details-area blog-area pt-150 pb-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""courses-details"">
                    <div class=""courses-details-img"">
                        ");
            EndContext();
            BeginContext(866, 84, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "3586a9a512f44ba8b0138a2791310d52", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 876, "~/img/course/", 876, 13, true);
#line 26 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
AddHtmlAttributeValue("", 889, Model.Course.Image, 889, 19, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
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
            BeginContext(950, 116, true);
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"course-details-content\">\r\n                        <h2>");
            EndContext();
            BeginContext(1067, 17, false);
#line 29 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                       Write(Model.Course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1084, 104, true);
            WriteLiteral("</h2>\r\n                        <div class=\"row\">\r\n                            <div class=\"col-md-6\">\r\n\r\n");
            EndContext();
#line 33 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                 foreach (CourseDetail detail in Model.CourseDetails)
                                {
                                    if (detail.Id == Model.Course.CourseDetailId)
                                    {

#line default
#line hidden
            BeginContext(1432, 43, true);
            WriteLiteral("                                        <p>");
            EndContext();
            BeginContext(1476, 14, false);
#line 37 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                      Write(detail.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1490, 7, true);
            WriteLiteral(" </p>\r\n");
            EndContext();
            BeginContext(1499, 275, true);
            WriteLiteral(@"                                        <div class=""course-details-left"">
                                            <div class=""single-course-left"">
                                                <h3>about course</h3>
                                                <p>");
            EndContext();
            BeginContext(1775, 18, false);
#line 42 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                              Write(detail.AboutCourse);

#line default
#line hidden
            EndContext();
            BeginContext(1793, 258, true);
            WriteLiteral(@"</p>
                                            </div>
                                            <div class=""single-course-left"">
                                                <h3>how to apply</h3>
                                                <p>");
            EndContext();
            BeginContext(2052, 17, false);
#line 46 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                              Write(detail.HowToApply);

#line default
#line hidden
            EndContext();
            BeginContext(2069, 274, true);
            WriteLiteral(@"</p>
                                            </div>
                                            <div class=""single-course-left"">
                                                <h3>certification</h3>
                                                <p class=""margin"">");
            EndContext();
            BeginContext(2344, 20, false);
#line 50 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                                             Write(detail.Certification);

#line default
#line hidden
            EndContext();
            BeginContext(2364, 108, true);
            WriteLiteral("</p>\r\n\r\n                                            </div>\r\n                                        </div>\r\n");
            EndContext();
#line 54 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(2546, 90, true);
            WriteLiteral("                            </div>\r\n                            <div class=\"col-md-6\">\r\n\r\n");
            EndContext();
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                 foreach (CourseFeature feature in Model.CourseFeatures)
                                {
                                    if (feature.Id == Model.Course.CourseFeatureId)
                                    {


#line default
#line hidden
            BeginContext(2887, 349, true);
            WriteLiteral(@"                                <div class=""course-details-right"">
                                    <h3>COURSE FEATURES</h3>
                                    <table style=""width:100%"">
                                        <tr>
                                            <th>Starts</th>
                                            <td>");
            EndContext();
            BeginContext(3237, 75, false);
#line 69 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.StartingDate.ToString("dd MMM, yyyy", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(3312, 211, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Duration</th>\r\n                                            <td>");
            EndContext();
            BeginContext(3524, 16, false);
#line 73 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.Duration);

#line default
#line hidden
            EndContext();
            BeginContext(3540, 223, true);
            WriteLiteral(" Month</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Class Duration</th>\r\n                                            <td>");
            EndContext();
            BeginContext(3764, 21, false);
#line 77 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.ClassDuration);

#line default
#line hidden
            EndContext();
            BeginContext(3785, 220, true);
            WriteLiteral(" Hours</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Skill Level</th>\r\n                                            <td>");
            EndContext();
            BeginContext(4006, 18, false);
#line 81 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.SkillLevel);

#line default
#line hidden
            EndContext();
            BeginContext(4024, 211, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Language</th>\r\n                                            <td>");
            EndContext();
            BeginContext(4236, 16, false);
#line 85 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.Language);

#line default
#line hidden
            EndContext();
            BeginContext(4252, 211, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Students</th>\r\n                                            <td>");
            EndContext();
            BeginContext(4464, 16, false);
#line 89 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.Students);

#line default
#line hidden
            EndContext();
            BeginContext(4480, 213, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                        <tr>\r\n                                            <th>Assesments</th>\r\n                                            <td>");
            EndContext();
            BeginContext(4694, 18, false);
#line 93 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                           Write(feature.Assesments);

#line default
#line hidden
            EndContext();
            BeginContext(4712, 172, true);
            WriteLiteral("</td>\r\n                                        </tr>\r\n                                    </table>\r\n                                    <h3 class=\"text-danger\">course fee $");
            EndContext();
            BeginContext(4885, 11, false);
#line 96 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                                                   Write(feature.Fee);

#line default
#line hidden
            EndContext();
            BeginContext(4896, 47, true);
            WriteLiteral("</h3>\r\n                                </div>\r\n");
            EndContext();
#line 98 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Course\Detail.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(5017, 195, true);
            WriteLiteral("                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CourseDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
