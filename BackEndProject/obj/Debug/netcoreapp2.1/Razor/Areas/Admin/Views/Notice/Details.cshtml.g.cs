#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Notice\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "34415e74f16a2dbbb05d8cefdc4b530e857b0ab4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Notice_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Notice/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Notice/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Notice_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"34415e74f16a2dbbb05d8cefdc4b530e857b0ab4", @"/Areas/Admin/Views/Notice/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Notice_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NoticeBoard>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-dark ml-3 mt-5"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(20, 238, true);
            WriteLiteral("\r\n<div class=\"row\">\r\n    <div class=\"col-md-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <h4 class=\"card-title\">Slider</h4>\r\n                <h4 class=\"card-title\">Board №");
            EndContext();
            BeginContext(259, 8, false);
#line 8 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Notice\Details.cshtml"
                                         Write(Model.Id);

#line default
#line hidden
            EndContext();
            BeginContext(267, 156, true);
            WriteLiteral("</h4>\r\n                <table>\r\n                    <tr>\r\n                        <th >Date</th>\r\n                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
            EndContext();
            BeginContext(424, 10, false);
#line 12 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Notice\Details.cshtml"
                                                     Write(Model.Date);

#line default
#line hidden
            EndContext();
            BeginContext(434, 160, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                    <tr>\r\n                        <th>Content</th>\r\n                        <td>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;");
            EndContext();
            BeginContext(595, 13, false);
#line 16 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Notice\Details.cshtml"
                                                     Write(Model.Content);

#line default
#line hidden
            EndContext();
            BeginContext(608, 76, true);
            WriteLiteral("</td>\r\n                    </tr>\r\n                </table>\r\n                ");
            EndContext();
            BeginContext(684, 68, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "24985a6f8fd04901a545cbb8b79ec591", async() => {
                BeginContext(737, 11, true);
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
            BeginContext(752, 64, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n\r\n    </div>\r\n\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NoticeBoard> Html { get; private set; }
    }
}
#pragma warning restore 1591
