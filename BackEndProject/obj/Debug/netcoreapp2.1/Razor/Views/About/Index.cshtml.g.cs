#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8c2614c7f1eab299b861018c0d6ba136b9027edc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_About_Index), @"mvc.1.0.view", @"/Views/About/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/About/Index.cshtml", typeof(AspNetCore.Views_About_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8c2614c7f1eab299b861018c0d6ba136b9027edc", @"/Views/About/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901e7c2bbfb5a082ff900225b5567e29d38e7f0", @"/Views/_ViewImports.cshtml")]
    public class Views_About_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AboutVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("default-btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Course", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Teacher", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(16, 105, true);
            WriteLiteral("\r\n<!-- Banner Area Start -->\r\n<div class=\"banner-area-wrapper\">\r\n    <div class=\"banner-area text-center\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 121, "\"", 198, 5);
            WriteAttributeValue("", 129, "background-image:", 129, 17, true);
            WriteAttributeValue(" ", 146, "url(/img/banner/", 147, 17, true);
#line 5 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 163, Model.Background.Image, 163, 23, false);

#line default
#line hidden
            WriteAttributeValue("", 186, ")", 186, 1, true);
            WriteAttributeValue(" ", 187, "!important", 188, 11, true);
            EndWriteAttribute();
            BeginContext(199, 665, true);
            WriteLiteral(@">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-xs-12"">
                    <div class=""banner-content-wrapper"">
                        <div class=""banner-content"">
                            <h2>about us</h2>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- Banner Area End -->
<!-- About Start -->
<div class=""about-area pt-145 pb-155"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
                    <h2>");
            EndContext();
            BeginContext(865, 20, false);
#line 26 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                   Write(Model.AboutUs.Header);

#line default
#line hidden
            EndContext();
            BeginContext(885, 30, true);
            WriteLiteral("</h2>\r\n                    <p>");
            EndContext();
            BeginContext(916, 21, false);
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                  Write(Model.AboutUs.Content);

#line default
#line hidden
            EndContext();
            BeginContext(937, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"hidden-sm\">");
            EndContext();
            BeginContext(985, 26, false);
#line 28 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                    Write(Model.AboutUs.ShortContent);

#line default
#line hidden
            EndContext();
            BeginContext(1011, 26, true);
            WriteLiteral("</p>\r\n                    ");
            EndContext();
            BeginContext(1037, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c9e973cca31149baa0b212493ffbae39", async() => {
                BeginContext(1103, 12, true);
                WriteLiteral("view courses");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1119, 152, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            EndContext();
            BeginContext(1271, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "a172ac7d02de414cb48dc78b5286d051", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1281, "~/img/about/", 1281, 12, true);
#line 34 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
AddHtmlAttributeValue("", 1293, Model.AboutUs.Image, 1293, 20, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1327, 512, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Teacher Start -->
<div class=""teacher-area pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""title"">
                    <h2>meet our teachers</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
            EndContext();
#line 53 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
             foreach (Teacher teacher in Model.Teachers)
            {


#line default
#line hidden
            BeginContext(1914, 195, true);
            WriteLiteral("                <div class=\"col-md-3 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-teacher\">\r\n                        <div class=\"single-teacher-img\">\r\n                            ");
            EndContext();
            BeginContext(2109, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c7340942aa94d2994164d5aa7337c45", async() => {
                BeginContext(2184, 4, true);
                WriteLiteral("<img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 2188, "\"", 2220, 2);
                WriteAttributeValue("", 2194, "img/teacher/", 2194, 12, true);
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 2206, teacher.Image, 2206, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(2221, 15, true);
                WriteLiteral(" alt=\"teacher\">");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                                                              WriteLiteral(teacher.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2240, 140, true);
            WriteLiteral("\r\n                        </div>\r\n                        <div class=\"single-teacher-content text-center\">\r\n                            <h2>");
            EndContext();
            BeginContext(2380, 92, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91235f9aecc34883a22a2ccc7ee91dc0", async() => {
                BeginContext(2456, 12, false);
#line 62 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                                                                                      Write(teacher.Name);

#line default
#line hidden
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 62 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                                                                  WriteLiteral(teacher.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2472, 99, true);
            WriteLiteral("</h2>\r\n                            <h4>Associate Professor</h4>\r\n                            <ul>\r\n");
            EndContext();
#line 65 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                 foreach (AboutTeacher about in Model.AboutTeachers)
                                {
                                    if (teacher.AboutTeacherId == about.Id)
                                    {

#line default
#line hidden
            BeginContext(2808, 62, true);
            WriteLiteral("                                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2870, "\"", 2892, 1);
#line 69 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 2877, about.Facebook, 2877, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2893, 108, true);
            WriteLiteral("><i class=\"zmdi zmdi-facebook\"></i></a></li>\r\n                                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3001, "\"", 3024, 1);
#line 70 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3008, about.Pinterest, 3008, 16, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3025, 109, true);
            WriteLiteral("><i class=\"zmdi zmdi-pinterest\"></i></a></li>\r\n                                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3134, "\"", 3153, 1);
#line 71 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3141, about.Vimeo, 3141, 12, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3154, 105, true);
            WriteLiteral("><i class=\"zmdi zmdi-vimeo\"></i></a></li>\r\n                                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3259, "\"", 3280, 1);
#line 72 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 3266, about.Twitter, 3266, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3281, 45, true);
            WriteLiteral("><i class=\"zmdi zmdi-twitter\"></i></a></li>\r\n");
            EndContext();
#line 73 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                    }
                                }

#line default
#line hidden
            BeginContext(3400, 121, true);
            WriteLiteral("\r\n                            </ul>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 80 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3536, 271, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Teacher End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
            EndContext();
#line 90 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                 foreach (Testimonial testimonial in Model.Testimonials)
                {


#line default
#line hidden
            BeginContext(3902, 291, true);
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 4193, "\"", 4233, 2);
            WriteAttributeValue("", 4199, "img/testimonial/", 4199, 16, true);
#line 97 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 4215, testimonial.Image, 4215, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4234, 167, true);
            WriteLiteral(" alt=\"testimonial\">\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
            EndContext();
            BeginContext(4402, 23, false);
#line 100 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                  Write(testimonial.Description);

#line default
#line hidden
            EndContext();
            BeginContext(4425, 46, true);
            WriteLiteral("</p>\r\n                                    <h4>");
            EndContext();
            BeginContext(4472, 16, false);
#line 101 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                   Write(testimonial.Name);

#line default
#line hidden
            EndContext();
            BeginContext(4488, 47, true);
            WriteLiteral("</h4>\r\n                                    <h5>");
            EndContext();
            BeginContext(4536, 22, false);
#line 102 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                                   Write(testimonial.Speciality);

#line default
#line hidden
            EndContext();
            BeginContext(4558, 143, true);
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 107 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(4720, 427, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140 pb-100"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 5147, "\"", 5222, 3);
            WriteAttributeValue("", 5155, "background-image:url(img/notice/", 5155, 32, true);
#line 120 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 5187, Model.NoticeVideo.Image, 5187, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 5211, ")!important", 5211, 11, true);
            EndWriteAttribute();
            BeginContext(5223, 115, true);
            WriteLiteral(">\r\n                        <div class=\"video-icon video-hover\">\r\n                            <a class=\"video-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 5338, "\"", 5368, 1);
#line 122 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
WriteAttributeValue("", 5345, Model.NoticeVideo.Link, 5345, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(5369, 401, true);
            WriteLiteral(@">
                                <i class=""zmdi zmdi-play""></i>
                            </a>
                        </div>
                    </div>
                </div>
            </div>
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-left-wrapper"">
                    <h3>notice board</h3>
                    <div class=""notice-left"">
");
            EndContext();
#line 133 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                         foreach (NoticeBoard board in Model.NoticeBoards)
                        {


#line default
#line hidden
            BeginContext(5875, 110, true);
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
            EndContext();
            BeginContext(5986, 65, false);
#line 137 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                               Write(board.Date.ToString("dd, MMM yyyy", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(6051, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(6094, 13, false);
#line 138 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                              Write(board.Content);

#line default
#line hidden
            EndContext();
            BeginContext(6107, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 140 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\About\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(6176, 133, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</section>\r\n<!-- Notice End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AboutVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
