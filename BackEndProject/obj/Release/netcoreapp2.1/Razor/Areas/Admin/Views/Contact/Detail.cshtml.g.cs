#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "115855ad841547b515250dedf74d1e1e35ad4b22"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Contact/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Contact_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"115855ad841547b515250dedf74d1e1e35ad4b22", @"/Areas/Admin/Views/Contact/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BackEndProject.Areas.Admin.ViewModels.ContactVM>
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
            BeginContext(56, 255, true);
            WriteLiteral("<!-- Teacher Start -->\r\n<div class=\"teacher-details-area pt-150 pb-60\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n            <div class=\"col-md-5 col-sm-5 col-xs-12\">\r\n                <div class=\"teacher-details-img\">\r\n                    ");
            EndContext();
            BeginContext(311, 53, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "7f6ba6b1ac2e4e5eb6de63a5c7b0ae06", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 321, "~/img/logo/", 321, 11, true);
#line 8 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
AddHtmlAttributeValue("", 332, Model.Data.Logo, 332, 16, false);

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
            BeginContext(364, 239, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-7 col-sm-7 col-xs-12\">\r\n                <div class=\"teacher-details-content ml-50\">\r\n                    <ul>\r\n                        <li><span>Location: </span>");
            EndContext();
            BeginContext(604, 19, false);
#line 14 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
                                              Write(Model.Data.Location);

#line default
#line hidden
            EndContext();
            BeginContext(623, 54, true);
            WriteLiteral("</li>\r\n                        <li><span>Mail: </span>");
            EndContext();
            BeginContext(678, 15, false);
#line 15 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
                                          Write(Model.Data.Mail);

#line default
#line hidden
            EndContext();
            BeginContext(693, 53, true);
            WriteLiteral("</li>\r\n                        <li><span>Web: </span>");
            EndContext();
            BeginContext(747, 14, false);
#line 16 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
                                         Write(Model.Data.Web);

#line default
#line hidden
            EndContext();
            BeginContext(761, 89, true);
            WriteLiteral("</li>\r\n                        <li>\r\n                            <span>Numbers: </span>\r\n");
            EndContext();
#line 19 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
                             foreach (CenterPhoneNumber cpn in Model.Numbers)
                            {

#line default
#line hidden
            BeginContext(960, 35, true);
            WriteLiteral("                                <p>");
            EndContext();
            BeginContext(996, 9, false);
#line 21 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
                              Write(cpn.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1005, 6, true);
            WriteLiteral("</p>\r\n");
            EndContext();
#line 22 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
                            }

#line default
#line hidden
            BeginContext(1042, 363, true);
            WriteLiteral(@"                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-3 col-sm-4"">
                <div class=""teacher-contact"">
                    <ul style=""list-style:none;float:left"">
                        <li><a target=""_blank"" style=""float:left""");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1405, "\"", 1446, 2);
            WriteAttributeValue("", 1412, "@", 1412, 1, true);
            WriteAttributeValue("", 1414, "Model.ElementAt(0).Data.Facebook", 1414, 32, true);
            EndWriteAttribute();
            BeginContext(1447, 92, true);
            WriteLiteral("><i class=\" mdi mdi-facebook \"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1539, "\"", 1567, 1);
#line 33 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
WriteAttributeValue("", 1546, Model.Data.Pinterest, 1546, 21, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1568, 91, true);
            WriteLiteral("><i class=\"mdi mdi-pinterest\"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1659, "\"", 1683, 1);
#line 34 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
WriteAttributeValue("", 1666, Model.Data.Vimeo, 1666, 17, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1684, 87, true);
            WriteLiteral("><i class=\"mdi mdi-vimeo\"></i></a></li>\r\n                        <li><a target=\"_blank\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1771, "\"", 1797, 1);
#line 35 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Detail.cshtml"
WriteAttributeValue("", 1778, Model.Data.Twitter, 1778, 19, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1798, 172, true);
            WriteLiteral("><i class=\"mdi mdi-twitter\"></i></a></li>\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- Teacher End -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackEndProject.Areas.Admin.ViewModels.ContactVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
