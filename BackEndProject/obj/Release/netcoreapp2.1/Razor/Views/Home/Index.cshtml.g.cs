#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cee239464416c539efc53773d7ce08b0f94f1a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cee239464416c539efc53773d7ce08b0f94f1a67", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3901e7c2bbfb5a082ff900225b5567e29d38e7f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("about"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(15, 175, true);
            WriteLiteral("\r\n<!-- Background Area Start -->\r\n<section id=\"slider-container\" class=\"slider-area two\">\r\n    <div class=\"slider-owl owl-theme owl-carousel\">\r\n        <!-- Start Slider -->\r\n");
            EndContext();
#line 7 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
         foreach (Slider slider in Model.Sliders) 
        {

#line default
#line hidden
            BeginContext(253, 38, true);
            WriteLiteral("        <div class=\"single-slide item\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 291, "\"", 347, 4);
            WriteAttributeValue("", 299, "background-image:", 299, 17, true);
            WriteAttributeValue(" ", 316, "url(/img/slider/", 317, 17, true);
#line 9 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 333, slider.Image, 333, 13, false);

#line default
#line hidden
            WriteAttributeValue("", 346, ")", 346, 1, true);
            EndWriteAttribute();
            BeginContext(348, 416, true);
            WriteLiteral(@">
            <!-- Start Slider Content -->
            <div class=""slider-content-area"">
                <div class=""container"">
                    <div class=""row"">
                        <div class=""col-md-10 col-md-offset-1"">
                            <div class=""slide-content-wrapper"">
                                <div class=""slide-content text-center"">
                                    <h2>");
            EndContext();
            BeginContext(765, 24, false);
#line 17 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                   Write(Model.AboutSlider.Header);

#line default
#line hidden
            EndContext();
            BeginContext(789, 47, true);
            WriteLiteral(" </h2>\r\n                                    <p>");
            EndContext();
            BeginContext(837, 25, false);
#line 18 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                  Write(Model.AboutSlider.Content);

#line default
#line hidden
            EndContext();
            BeginContext(862, 341, true);
            WriteLiteral(@"  </p>
                                    <a class=""default-btn"" href=""about.html"">Learn more</a>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <!-- Start Slider Content -->
        </div> 
");
            EndContext();
#line 28 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1214, 209, true);
            WriteLiteral("        <!-- End Slider -->\r\n    </div>\r\n</section>\r\n<!-- Background Area End -->\r\n<!-- Service Start -->\r\n<div class=\"service-area two pt-150 pb-150\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 37 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
             foreach (Service service in Model.Services)
            {


#line default
#line hidden
            BeginContext(1498, 160, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-4 col-xs-12\">\r\n                    <div class=\"single-service\">\r\n                        <h3><a href=\"teacher.html\">");
            EndContext();
            BeginContext(1659, 14, false);
#line 42 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                              Write(service.Header);

#line default
#line hidden
            EndContext();
            BeginContext(1673, 38, true);
            WriteLiteral("</a></h3>\r\n                        <p>");
            EndContext();
            BeginContext(1712, 15, false);
#line 43 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                      Write(service.Content);

#line default
#line hidden
            EndContext();
            BeginContext(1727, 58, true);
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 46 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1800, 283, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Service End -->
<!-- About Start -->
<div class=""about-area pb-155"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6"">
                <div class=""about-content"">
                    <h2>");
            EndContext();
            BeginContext(2084, 20, false);
#line 57 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                   Write(Model.AboutUs.Header);

#line default
#line hidden
            EndContext();
            BeginContext(2104, 30, true);
            WriteLiteral("</h2>\r\n                    <p>");
            EndContext();
            BeginContext(2135, 21, false);
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                  Write(Model.AboutUs.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2156, 47, true);
            WriteLiteral("</p>\r\n                    <p class=\"hidden-sm\">");
            EndContext();
            BeginContext(2204, 26, false);
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                    Write(Model.AboutUs.ShortContent);

#line default
#line hidden
            EndContext();
            BeginContext(2230, 235, true);
            WriteLiteral("</p>\r\n                    <a class=\"default-btn\" href=\"about.html\">view courses</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6 col-sm-6\">\r\n                <div class=\"about-img\">\r\n                    ");
            EndContext();
            BeginContext(2465, 56, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b9e61e11b5894e53bb9c58af1bf076c7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 2475, "~/img/about/", 2475, 12, true);
#line 65 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 2487, Model.AboutUs.Image, 2487, 20, false);

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
            BeginContext(2521, 536, true);
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>
</div>
<!-- About End -->
<!-- Courses Area Start -->
<div class=""courses-area two pt-150 pb-150 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section1.png"" alt=""section-title"">
                    <h2>COURSES WE OFFER</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
            EndContext();
#line 84 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
             foreach (Course course in Model.Courses)
            {


#line default
#line hidden
            BeginContext(3129, 254, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-course\">\r\n                        <div class=\"course-img\">\r\n                            <a href=\"course-details.html\">\r\n                                <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 3383, "\"", 3413, 2);
            WriteAttributeValue("", 3389, "img/course/", 3389, 11, true);
#line 91 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 3400, course.Image, 3400, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3414, 362, true);
            WriteLiteral(@" alt=""course"">
                                <div class=""course-hover"">
                                    <i class=""fa fa-link""></i>
                                </div>
                            </a>
                        </div>
                        <div class=""course-content"">
                            <h3><a href=""course-details.html"">");
            EndContext();
            BeginContext(3777, 11, false);
#line 98 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                                         Write(course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(3788, 11, true);
            WriteLiteral("</a></h3>\r\n");
            EndContext();
#line 99 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                             foreach (CourseDetail detail in Model.CourseDetails)
                            {
                                if (course.CourseDetailId == detail.Id)
                                {

#line default
#line hidden
            BeginContext(4021, 39, true);
            WriteLiteral("                                    <p>");
            EndContext();
            BeginContext(4061, 14, false);
#line 103 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                  Write(detail.Content);

#line default
#line hidden
            EndContext();
            BeginContext(4075, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 104 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                }
                            }

#line default
#line hidden
            BeginContext(4147, 179, true);
            WriteLiteral("\r\n                            <a class=\"default-btn\" href=\"course-details.html\">read more</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 111 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4341, 396, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Courses Area End -->
<!-- Notice Start -->
<section class=""notice-area two pt-140"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-6 col-sm-6 col-xs-12"">
                <div class=""notice-right-wrapper mb-25 pb-25"">
                    <h3>TAKE A VIDEO TOUR</h3>
                    <div class=""notice-video""");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 4737, "\"", 4812, 3);
            WriteAttributeValue("", 4745, "background-image:url(img/notice/", 4745, 32, true);
#line 123 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 4777, Model.NoticeVideo.Image, 4777, 24, false);

#line default
#line hidden
            WriteAttributeValue("", 4801, ")!important", 4801, 11, true);
            EndWriteAttribute();
            BeginContext(4813, 115, true);
            WriteLiteral(">\r\n                        <div class=\"video-icon video-hover\">\r\n                            <a class=\"video-popup\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4928, "\"", 4958, 1);
#line 125 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 4935, Model.NoticeVideo.Link, 4935, 23, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4959, 401, true);
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
#line 136 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                         foreach (NoticeBoard board in Model.NoticeBoards)
                        {


#line default
#line hidden
            BeginContext(5465, 110, true);
            WriteLiteral("                            <div class=\"single-notice-left mb-23 pb-20\">\r\n                                <h4>");
            EndContext();
            BeginContext(5576, 65, false);
#line 140 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                               Write(board.Date.ToString("dd, MMM yyyy", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(5641, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(5684, 13, false);
#line 141 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                              Write(board.Content);

#line default
#line hidden
            EndContext();
            BeginContext(5697, 42, true);
            WriteLiteral("</p>\r\n                            </div>\r\n");
            EndContext();
#line 143 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                        }

#line default
#line hidden
            BeginContext(5766, 562, true);
            WriteLiteral(@"                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
<!-- Notice End -->
<!-- Event Area Start -->
<div class=""event-area two text-center pt-100 pb-145"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>UPCOMMING EVENTS</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
            EndContext();
#line 163 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
             foreach (Event _event in Model.Events) 
            {

#line default
#line hidden
            BeginContext(6397, 321, true);
            WriteLiteral(@"            <div class=""col-md-6 col-sm-12 col-xs-12"">
                <div class=""single-event mb-35"" style=""display:flex !important;align-items:center !important;padding:0px!important"">
                    <div class=""event-img"" style=""width:50% !important"">
                        <a href=""event-details.html""><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 6718, "\"", 6747, 2);
            WriteAttributeValue("", 6724, "img/event/", 6724, 10, true);
#line 168 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 6734, _event.Image, 6734, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(6748, 166, true);
            WriteLiteral(" alt=\"event\"></a>\r\n                    </div>\r\n                    <div class=\"event-content text-left\" style=\"padding: 0px !important\">\r\n                        <h3>");
            EndContext();
            BeginContext(6915, 65, false);
#line 171 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                       Write(_event.Date.ToString("dd MMM yyyy", CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(6980, 64, true);
            WriteLiteral("</h3>\r\n                        <h4><a href=\"event-details.html\">");
            EndContext();
            BeginContext(7045, 13, false);
#line 172 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                                    Write(_event.Header);

#line default
#line hidden
            EndContext();
            BeginContext(7058, 102, true);
            WriteLiteral("</a></h4>\r\n                        <ul>\r\n                            <li><i class=\"fa fa-clock-o\"></i>");
            EndContext();
            BeginContext(7161, 15, false);
#line 174 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                                        Write(_event.Interval);

#line default
#line hidden
            EndContext();
            BeginContext(7176, 71, true);
            WriteLiteral("</li>\r\n                            <li><i class=\"fa fa-map-marker\"></i>");
            EndContext();
            BeginContext(7248, 15, false);
#line 175 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                                           Write(_event.Location);

#line default
#line hidden
            EndContext();
            BeginContext(7263, 292, true);
            WriteLiteral(@"</li>
                        </ul>
                        <div class=""event-content-right"">
                            <a class=""default-btn"" href=""event-details.html"">join now</a>
                        </div>
                    </div>
                </div>
            </div>
");
            EndContext();
#line 183 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(7570, 274, true);
            WriteLiteral(@"        </div>
    </div>
</div>
<!-- Event Area End -->
<!-- Testimonial Area Start -->
<div class=""testimonial-area pt-110 pb-105 text-center"">
    <div class=""container"">
        <div class=""row"">
            <div class=""testimonial-owl owl-theme owl-carousel"">
");
            EndContext();
#line 193 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                 foreach (Testimonial testimonial in Model.Testimonials)
                {

#line default
#line hidden
            BeginContext(7937, 291, true);
            WriteLiteral(@"                    <div class=""col-md-8 col-md-offset-2 col-sm-12"">
                        <div class=""single-testimonial"">
                            <div class=""testimonial-info"">
                                <div class=""testimonial-img"">
                                    <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 8228, "\"", 8268, 2);
            WriteAttributeValue("", 8234, "img/testimonial/", 8234, 16, true);
#line 199 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 8250, testimonial.Image, 8250, 18, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(8269, 167, true);
            WriteLiteral(" alt=\"testimonial\">\r\n                                </div>\r\n                                <div class=\"testimonial-content\">\r\n                                    <p>");
            EndContext();
            BeginContext(8437, 23, false);
#line 202 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                  Write(testimonial.Description);

#line default
#line hidden
            EndContext();
            BeginContext(8460, 46, true);
            WriteLiteral("</p>\r\n                                    <h4>");
            EndContext();
            BeginContext(8507, 16, false);
#line 203 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                   Write(testimonial.Name);

#line default
#line hidden
            EndContext();
            BeginContext(8523, 47, true);
            WriteLiteral("</h4>\r\n                                    <h5>");
            EndContext();
            BeginContext(8571, 22, false);
#line 204 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                   Write(testimonial.Speciality);

#line default
#line hidden
            EndContext();
            BeginContext(8593, 143, true);
            WriteLiteral("</h5>\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
            EndContext();
#line 209 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(8755, 510, true);
            WriteLiteral(@"            </div>
        </div>
    </div>
</div>
<!-- Testimonial Area End -->
<!-- Blog Area Start -->
<div class=""blog-area pt-150 pb-150"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12"">
                <div class=""section-title text-center"">
                    <img src=""img/icon/section.png"" alt=""section-title"">
                    <h2>LATEST FROM BLOG</h2>
                </div>
            </div>
        </div>
        <div class=""row"">
");
            EndContext();
#line 227 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
             foreach (Blog blog in Model.Blogs)
            {

#line default
#line hidden
            BeginContext(9329, 214, true);
            WriteLiteral("                <div class=\"col-md-4 col-sm-6 col-xs-12\">\r\n                    <div class=\"single-blog\">\r\n                        <div class=\"blog-img\">\r\n                            <a href=\"blog-details.html\"><img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 9543, "\"", 9569, 2);
            WriteAttributeValue("", 9549, "img/blog/", 9549, 9, true);
#line 232 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
WriteAttributeValue("", 9558, blog.Image, 9558, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(9570, 374, true);
            WriteLiteral(@" alt=""blog""></a>
                            <div class=""blog-hover"">
                                <a href=""blog-details.html""><i class=""fa fa-link""></i></a>
                            </div>
                        </div>
                        <div class=""blog-content"">
                            <div class=""blog-top"">
                                <p>By ");
            EndContext();
            BeginContext(9945, 14, false);
#line 239 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                 Write(blog.Publisher);

#line default
#line hidden
            EndContext();
            BeginContext(9959, 5, true);
            WriteLiteral("  /  ");
            EndContext();
            BeginContext(9965, 62, false);
#line 239 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                                     Write(blog.Date.ToString("MMM dd, yyy",CultureInfo.InvariantCulture));

#line default
#line hidden
            EndContext();
            BeginContext(10027, 200, true);
            WriteLiteral("  /  <i class=\"fa fa-comments-o\"></i> 4</p>\r\n                            </div>\r\n                            <div class=\"blog-bottom\">\r\n                                <h2><a href=\"blog-details.html\">");
            EndContext();
            BeginContext(10228, 11, false);
#line 242 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
                                                           Write(blog.Header);

#line default
#line hidden
            EndContext();
            BeginContext(10239, 206, true);
            WriteLiteral("</a></h2>\r\n                                <a href=\"blog-details.html\">read more</a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
            EndContext();
#line 248 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(10460, 60, true);
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n<!-- Blog Area End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
