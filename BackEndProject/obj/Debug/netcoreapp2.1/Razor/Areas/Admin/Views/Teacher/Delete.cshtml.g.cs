#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "172a2813cecc62eb52045ae10b1057f81a868fba"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"172a2813cecc62eb52045ae10b1057f81a868fba", @"/Areas/Admin/Views/Teacher/Delete.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "f7dffce46faf478aba3fbc011aa24a8c", async() => {
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
            BeginContext(675, 24, false);
#line 16 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                  Write(Model.AboutTeacher.About);

#line default
#line hidden
            EndContext();
            BeginContext(699, 81, true);
            WriteLiteral("</p>\r\n                    <ul>\r\n                        <li><span>Degree: </span>");
            EndContext();
            BeginContext(781, 25, false);
#line 18 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                            Write(Model.AboutTeacher.Degree);

#line default
#line hidden
            EndContext();
            BeginContext(806, 60, true);
            WriteLiteral("</li>\r\n                        <li><span>Experience: </span>");
            EndContext();
            BeginContext(867, 29, false);
#line 19 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                Write(Model.AboutTeacher.Experience);

#line default
#line hidden
            EndContext();
            BeginContext(896, 106, true);
            WriteLiteral(" years experience</li>\r\n                        <li>\r\n                            <span>Hobbies: </span>\r\n");
            EndContext();
#line 22 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                             foreach (Hobby hobby in Model.Hobbies)
                            {

#line default
#line hidden
            BeginContext(1102, 64, true);
            WriteLiteral("                                <p style=\"display:inline-block\">");
            EndContext();
            BeginContext(1167, 10, false);
#line 24 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                           Write(hobby.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1177, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 25 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                            }

#line default
#line hidden
            BeginContext(1214, 80, true);
            WriteLiteral("                        </li>\r\n                        <li><span>Fculty: </span>");
            EndContext();
            BeginContext(1295, 29, false);
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                            Write(Model.Department.Abbreviation);

#line default
#line hidden
            EndContext();
            BeginContext(1324, 2, true);
            WriteLiteral(", ");
            EndContext();
            BeginContext(1327, 21, false);
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                                            Write(Model.Department.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1348, 306, true);
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
            BeginContext(1655, 23, false);
#line 36 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                      Write(Model.AboutTeacher.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(1678, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>Phone : </span>");
            EndContext();
            BeginContext(1729, 24, false);
#line 37 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                       Write(Model.AboutTeacher.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1753, 50, true);
            WriteLiteral("</p>\r\n                    <p><span>Skype : </span>");
            EndContext();
            BeginContext(1804, 24, false);
#line 38 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                       Write(Model.AboutTeacher.Skype);

#line default
#line hidden
            EndContext();
            BeginContext(1828, 132, true);
            WriteLiteral("</p>\r\n                    <ul style=\"list-style:none;float:left\">\r\n                        <li><a target=\"_blank\" style=\"float:left\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1960, "\"", 1995, 1);
#line 40 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 1967, Model.AboutTeacher.Facebook, 1967, 28, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1996, 92, true);
            WriteLiteral("><i class=\" mdi mdi-facebook \"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2088, "\"", 2124, 1);
#line 41 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 2095, Model.AboutTeacher.Pinterest, 2095, 29, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2125, 91, true);
            WriteLiteral("><i class=\"mdi mdi-pinterest\"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2216, "\"", 2248, 1);
#line 42 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 2223, Model.AboutTeacher.Vimeo, 2223, 25, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2249, 87, true);
            WriteLiteral("><i class=\"mdi mdi-vimeo\"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2336, "\"", 2370, 1);
#line 43 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
WriteAttributeValue("", 2343, Model.AboutTeacher.Twitter, 2343, 27, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2371, 890, true);
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
            BeginContext(3262, 20, false);
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Language);

#line default
#line hidden
            EndContext();
            BeginContext(3282, 710, true);
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
            BeginContext(3993, 22, false);
#line 68 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.TeamLeader);

#line default
#line hidden
            EndContext();
            BeginContext(4015, 709, true);
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
            BeginContext(4725, 23, false);
#line 78 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Development);

#line default
#line hidden
            EndContext();
            BeginContext(4748, 705, true);
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
            BeginContext(5454, 18, false);
#line 88 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Design);

#line default
#line hidden
            EndContext();
            BeginContext(5472, 709, true);
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
            BeginContext(6182, 22, false);
#line 98 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Innovation);

#line default
#line hidden
            EndContext();
            BeginContext(6204, 712, true);
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
            BeginContext(6917, 25, false);
#line 108 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Teacher\Delete.cshtml"
                                                          Write(Model.Skill.Communication);

#line default
#line hidden
            EndContext();
            BeginContext(6942, 259, true);
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
            BeginContext(7201, 188, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b229c2439f2048ba906ad2927062bd22", async() => {
                BeginContext(7221, 93, true);
                WriteLiteral("\r\n            <button type=\"submit\" class=\"btn btn-danger mr-2\">Delete</button>\r\n            ");
                EndContext();
                BeginContext(7314, 58, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "934e8ed347ac4b11bcf8d4de245db58b", async() => {
                    BeginContext(7357, 11, true);
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
                BeginContext(7372, 10, true);
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
            BeginContext(7389, 44, true);
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
