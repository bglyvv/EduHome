#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "89191ca1abf3d80bb5e3e2e00bdd466b896a7832"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Detail), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Detail.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Users/Detail.cshtml", typeof(AspNetCore.Areas_Admin_Views_Users_Detail))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"89191ca1abf3d80bb5e3e2e00bdd466b896a7832", @"/Areas/Admin/Views/Users/Detail.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Users_Detail : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BackEndProject.Areas.Admin.ViewModels.UserEditVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark mt-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
  
    ViewData["Title"] = "Detail";
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(129, 334, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-md-12 grid-margin stretch-card"">

        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">User</h4>
                <table style=""width:100%"">
                    <tr>
                        <th>Fullname:</th>
                        <td>");
            EndContext();
            BeginContext(464, 14, false);
#line 16 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                       Write(Model.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(478, 132, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Username:</th>\r\n                        <td>");
            EndContext();
            BeginContext(611, 14, false);
#line 20 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                       Write(Model.Username);

#line default
#line hidden
            EndContext();
            BeginContext(625, 129, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Email:</th>\r\n                        <td>");
            EndContext();
            BeginContext(755, 11, false);
#line 24 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                       Write(Model.Email);

#line default
#line hidden
            EndContext();
            BeginContext(766, 128, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Role:</th>\r\n                        <td>");
            EndContext();
            BeginContext(895, 10, false);
#line 28 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                       Write(Model.Role);

#line default
#line hidden
            EndContext();
            BeginContext(905, 34, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n");
            EndContext();
#line 30 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                     if (Model.Role == "Moderator")
                    {

#line default
#line hidden
            BeginContext(1015, 108, true);
            WriteLiteral("                        <tr>\r\n                            <th>Course:</th>\r\n                            <td>");
            EndContext();
            BeginContext(1124, 17, false);
#line 34 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                           Write(Model.Course.Name);

#line default
#line hidden
            EndContext();
            BeginContext(1141, 38, true);
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            EndContext();
#line 36 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Users\Detail.cshtml"
                    }

#line default
#line hidden
            BeginContext(1202, 92, true);
            WriteLiteral("                </table>\r\n\r\n            </div>\r\n        </div>\r\n\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(1294, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0818e81ff78f4d488f4c01192bf4156e", async() => {
                BeginContext(1342, 11, true);
                WriteLiteral("Go to Index");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1357, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BackEndProject.Areas.Admin.ViewModels.UserEditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
