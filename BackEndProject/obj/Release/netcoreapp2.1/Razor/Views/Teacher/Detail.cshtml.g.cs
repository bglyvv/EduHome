#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f3c9832a94c28b966fa2f6f1a86de99b02f7ad6a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Teacher_Detail), @"mvc.1.0.view", @"/Views/Teacher/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Teacher/Detail.cshtml", typeof(AspNetCore.Views_Teacher_Detail))]
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
#line 1 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\_ViewImports.cshtml"
using BackEndProject.Models;

#line default
#line hidden
#line 3 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\_ViewImports.cshtml"
using System.Globalization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f3c9832a94c28b966fa2f6f1a86de99b02f7ad6a", @"/Views/Teacher/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901e7c2bbfb5a082ff900225b5567e29d38e7f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Teacher_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(24, 103, true);
            WriteLiteral("<!-- Banner Area Start -->\r\n<div class=\"banner-area-wrapper\">\r\n    <div class=\"banner-area text-center\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 127, "\"", 204, 5);
            WriteAttributeValue("", 135, "background-image:", 135, 17, true);
            WriteAttributeValue(" ", 152, "url(/img/banner/", 153, 17, true);
#line 4 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 169, Model.Background.Image, 169, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 192, ")", 192, 1, true);
            WriteAttributeValue(" ", 193, "!important", 194, 11, true);
            EndWriteAttribute();
            BeginContext(205, 698, true);
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>teachers / details</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- Teacher Start -->
<div class=""teacher-details-area pt-150 pb-60"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-5 col-sm-5 col-xs-12"">
                <div class=""teacher-details-img"">
                    ");
            EndContext();
            BeginContext(903, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "09acd336b4da41c68cec79a5c8fca47e", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 913, "~/img/teacher/", 913, 14, true);
#line 25 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
AddHtmlAttributeValue("", 927, Model.Teacher.Image, 927, 20, false);

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
            BeginContext(963, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
            EndContext();
            BeginContext(1150, 18, false);
#line 30 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                   Write(Model.Teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1168, 31, true);
            WriteLiteral("</h2>\r\n                    <h5>");
            EndContext();
            BeginContext(1200, 29, false);
#line 31 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                   Write(Model.AboutTeacher.Speciality);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 69, true);
            WriteLiteral("</h5>\r\n                    <h4>about me</h4>\r\n                    <p>");
            EndContext();
            BeginContext(1299, 34, false);
#line 33 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                  Write(Html.Raw(Model.AboutTeacher.About));

#line default
#line hidden
            EndContext();
            BeginContext(1333, 81, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>degree: </span>");
            EndContext();
            BeginContext(1415, 25, false);
#line 35 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                            Write(Model.AboutTeacher.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(1440, 60, true);
            WriteLiteral("</li>\r\n                        <li><span>experience: </span>");
            EndContext();
            BeginContext(1501, 29, false);
#line 36 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                Write(Model.AboutTeacher.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(1530, 76, true);
            WriteLiteral(" years experience</li>\r\n                        <li><span>hobbies: </span>\r\n");
            EndContext();
#line 38 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                             foreach (Hobby hobby in Model.Hobbies) 
                            {

#line default
#line hidden
            BeginContext(1707, 64, true);
            WriteLiteral("                                <p style=\"display:inline-block\">");
            EndContext();
            BeginContext(1772, 10, false);
#line 40 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                           Write(hobby.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1782, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 41 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(1819, 81, true);
            WriteLiteral("                        </li>\r\n                        <li><span>faculty: </span>");
            EndContext();
            BeginContext(1901, 29, false);
#line 43 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.Department.Abbreviation);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1933, 21, false);
#line 43 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                                             Write(Model.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1954, 309, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>contact information</h4>
                    <p><span>mail me : </span>");
            EndContext();
            BeginContext(2264, 23, false);
#line 52 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                         Write(Model.AboutTeacher.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(2287, 56, true);
            WriteLiteral("</p>\r\n                    <p><span>make a call : </span>");
            EndContext();
            BeginContext(2344, 24, false);
#line 53 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                             Write(Model.AboutTeacher.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2368, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>skype : </span>");
            EndContext();
            BeginContext(2419, 24, false);
#line 54 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                       Write(Model.AboutTeacher.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(2443, 62, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2505, "\"", 2540, 1);
#line 56 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2512, Model.AboutTeacher.Facebook, 2512, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2541, 76, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2617, "\"", 2653, 1);
#line 57 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2624, Model.AboutTeacher.Pinterest, 2624, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2654, 77, true);
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2731, "\"", 2763, 1);
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2738, Model.AboutTeacher.Vimeo, 2738, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2764, 73, true);
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                        <li><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2837, "\"", 2871, 1);
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
WriteAttributeValue("", 2844, Model.AboutTeacher.Twitter, 2844, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2872, 892, true);
            WriteLiteral(@"><i class=""zmdi zmdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(3765, 20, false);
#line 74 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3785, 710, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 90%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(4496, 22, false);
#line 84 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(4518, 709, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(5228, 23, false);
#line 94 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(5251, 705, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(5957, 18, false);
#line 104 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(5975, 709, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(6685, 22, false);
#line 114 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(6707, 712, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(7420, 25, false);
#line 124 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Teacher\Detail.cshtml"
                                                          Write(Model.Skill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(7445, 293, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Teacher End -->
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TeacherDetailVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
