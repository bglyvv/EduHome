#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ececc8c684472f37fdddf19cc6ea92f7909ad260"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Teacher_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Teacher/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Teacher/Delete.cshtml", typeof(AspNetCore.Areas_Admin_Views_Teacher_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ececc8c684472f37fdddf19cc6ea92f7909ad260", @"/Areas/Admin/Views/Teacher/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Teacher_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TeacherDetailVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("teacher"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(24, 255, true);
            WriteLiteral("<!-- Teacher Start -->\r\n<div class=\"teacher-details-area pt-150 pb-60\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-5 col-sm-5 col-xs-12\">\r\n                <div class=\"teacher-details-img\">\r\n                    ");
            EndContext();
            BeginContext(279, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8b7e16d418cc467f8e28f3a2d3bb0e00", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 289, "~/img/teacher/", 289, 14, true);
#line 8 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
AddHtmlAttributeValue("", 303, Model.Teacher.Image, 303, 20, false);

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
            BeginContext(339, 186, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <h2>");
            EndContext();
            BeginContext(526, 18, false);
#line 13 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                   Write(Model.Teacher.Name);

#line default
#line hidden
            EndContext();
            BeginContext(544, 31, true);
            WriteLiteral("</h2>\r\n                    <h5>");
            EndContext();
            BeginContext(576, 29, false);
#line 14 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                   Write(Model.AboutTeacher.Speciality);

#line default
#line hidden
            EndContext();
            BeginContext(605, 69, true);
            WriteLiteral("</h5>\r\n                    <h4>About me</h4>\r\n                    <p>");
            EndContext();
            BeginContext(675, 34, false);
#line 16 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                  Write(Html.Raw(Model.AboutTeacher.About));

#line default
#line hidden
            EndContext();
            BeginContext(709, 81, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>Degree: </span>");
            EndContext();
            BeginContext(791, 25, false);
#line 18 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                            Write(Model.AboutTeacher.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(816, 60, true);
            WriteLiteral("</li>\r\n                        <li><span>Experience: </span>");
            EndContext();
            BeginContext(877, 29, false);
#line 19 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                Write(Model.AboutTeacher.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(906, 106, true);
            WriteLiteral(" years experience</li>\r\n                        <li>\r\n                            <span>Hobbies: </span>\r\n");
            EndContext();
#line 22 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                             foreach (Hobby hobby in Model.Hobbies)
                            {

#line default
#line hidden
            BeginContext(1112, 64, true);
            WriteLiteral("                                <p style=\"display:inline-block\">");
            EndContext();
            BeginContext(1177, 10, false);
#line 24 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                           Write(hobby.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1187, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 25 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                            }

#line default
#line hidden
            BeginContext(1224, 80, true);
            WriteLiteral("                        </li>\r\n                        <li><span>Fculty: </span>");
            EndContext();
            BeginContext(1305, 29, false);
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                            Write(Model.Department.Abbreviation);

#line default
#line hidden
            EndContext();
            BeginContext(1334, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1337, 21, false);
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                                            Write(Model.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1358, 306, true);
            WriteLiteral(@"</li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <h4>Contact information</h4>
                    <p><span>Mail : </span>");
            EndContext();
            BeginContext(1665, 23, false);
#line 36 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                      Write(Model.AboutTeacher.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(1688, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>Phone : </span>");
            EndContext();
            BeginContext(1739, 24, false);
#line 37 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                       Write(Model.AboutTeacher.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1763, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>Skype : </span>");
            EndContext();
            BeginContext(1814, 24, false);
#line 38 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                       Write(Model.AboutTeacher.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(1838, 132, true);
            WriteLiteral("</p>\r\n                    <ul style=\"list-style:none;float:left\">\r\n                        <li><a target=\"_blank\" style=\"float:left\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1970, "\"", 2005, 1);
#line 40 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 1977, Model.AboutTeacher.Facebook, 1977, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2006, 92, true);
            WriteLiteral("><i class=\" mdi mdi-facebook \"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2098, "\"", 2134, 1);
#line 41 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 2105, Model.AboutTeacher.Pinterest, 2105, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2135, 91, true);
            WriteLiteral("><i class=\"mdi mdi-pinterest\"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2226, "\"", 2258, 1);
#line 42 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 2233, Model.AboutTeacher.Vimeo, 2233, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2259, 87, true);
            WriteLiteral("><i class=\"mdi mdi-vimeo\"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2346, "\"", 2380, 1);
#line 43 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 2353, Model.AboutTeacher.Twitter, 2353, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2381, 890, true);
            WriteLiteral(@"><i class=""mdi mdi-twitter""></i></a></li>
                    </ul>
                </div>
            </div>
            <div class=""col-md-9 col-sm-8"">
                <div class=""skill-area"">
                    <h4>Skills</h4>
                </div>
                <div class=""skill-wrapper"">
                    <div class=""row"">
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>Language</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(3272, 20, false);
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3292, 710, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>Team leader</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 90%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(4003, 22, false);
#line 68 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(4025, 709, true);
            WriteLiteral(@"%</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>Development</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(4735, 23, false);
#line 78 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(4758, 705, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>Design</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(5464, 18, false);
#line 88 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(5482, 709, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>Innovation</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 85%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(6192, 22, false);
#line 98 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(6214, 712, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""col-sm-4"">
                            <div class=""skill-bar-item"">
                                <span>Communication</span>
                                <div class=""progress"">
                                    <div data-wow-delay=""1.2s"" data-wow-duration=""1.5s"" style=""width: 95%; visibility: visible; animation-duration: 1.5s; animation-delay: 1.2s; animation-name: fadeInLeft;"" data-progress=""50%"" class=""progress-bar wow fadeInLeft"">
                                        <span class=""text-top"">");
            EndContext();
            BeginContext(6927, 25, false);
#line 108 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(6952, 259, true);
            WriteLiteral(@" %</span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        ");
            EndContext();
            BeginContext(7211, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8fe729457cc848c79119fc7d46262f4d", async() => {
                BeginContext(7231, 93, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-danger mr-2\">Delete</button>\r\n            ");
                EndContext();
                BeginContext(7324, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "894ba6df21f44291a88e04ad13a2c5ac", async() => {
                    BeginContext(7367, 11, true);
                    WriteLiteral("Go to Index");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(7382, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7399, 44, true);
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n");
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
