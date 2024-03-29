#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2bf16450b0b0508d58a97798be16773004b2bfc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Contact_Phone), @"mvc.1.0.view", @"/Areas/Admin/Views/Contact/Phone.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Contact/Phone.cshtml", typeof(AspNetCore.Areas_Admin_Views_Contact_Phone))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2bf16450b0b0508d58a97798be16773004b2bfc", @"/Areas/Admin/Views/Contact/Phone.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Contact_Phone : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CenterPhoneNumber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeletePhone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Contact", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger remove_button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_Validation", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(39, 1550, true);
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Data</h4>
                <div class=""row"">
                    <!-- Button trigger modal -->
                    <button type=""button"" class=""btn btn-success"" data-toggle=""modal"" data-target=""#exampleModalCenter"">
                        Create a new phone number
                    </button>

                    <!-- Modal -->
                    <div class=""modal fade"" id=""exampleModalCenter"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
                        <div class=""modal-dialog modal-dialog-centered"" role=""document"">
                            <div class=""modal-content"">
                                <div class=""modal-header"">
                                    <h5 class=""modal-title"" id=""exampleModalLongTitle"">Modal title</h5>
                                   ");
            WriteLiteral(@" <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                                        <span aria-hidden=""true"">&times;</span>
                                    </button>
                                </div>
                                    <div class=""modal-body"">
                                        <div class=""form-group"">
                                            <label>Phone</label>
                                            <input id=""phone"" class=""form-control"" />");
            EndContext();
            BeginContext(1590, 23, false);
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
                                                                                Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(1613, 1137, true);
            WriteLiteral(@"
                                            <span class=""text-danger"" id=""warning""></span>
                                        </div>
                                    </div>
                                    <button type=""submit"" class=""btn btn-primary"" data-dismiss=""modal"" id=""create"">Create</button>
                                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Close</button>
                                
                            </div>
                        </div>
                    </div>
                </div>
                <div class=""table-responsive"">
                    <table class=""table table-striped"" id=""table"">
                        <thead>
                            <tr>
                                <th>
                                    Phone Number
                                </th>
                                <th>
                                    Details
                                </th>");
            WriteLiteral("\n                            </tr>\r\n                        </thead>\r\n                        <tbody id=\"body\">\r\n");
            EndContext();
#line 51 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
                             foreach (CenterPhoneNumber cpn in Model)
                            {

#line default
#line hidden
            BeginContext(2852, 136, true);
            WriteLiteral("                                <tr>\r\n                                    <td class=\"py-1\">\r\n                                        <p>");
            EndContext();
            BeginContext(2989, 9, false);
#line 55 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
                                      Write(cpn.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(2998, 131, true);
            WriteLiteral("</p>\r\n                                    </td>\r\n                                    <td>\r\n                                        ");
            EndContext();
            BeginContext(3129, 213, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d1861d31d19460696274f11c6af904b", async() => {
                BeginContext(3274, 36, true);
                WriteLiteral("<i class=\" mdi mdi-delete-forever \">");
                EndContext();
                BeginContext(3311, 23, false);
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
                                                                                                                                                                                                                        Write(Html.AntiForgeryToken());

#line default
#line hidden
                EndContext();
                BeginContext(3334, 4, true);
                WriteLiteral("</i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "name", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
AddHtmlAttributeValue("", 3163, cpn.Id, 3163, 7, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 58 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
                                                                                     WriteLiteral(cpn.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3342, 84, true);
            WriteLiteral("\r\n                                    </td>\r\n                                </tr>\r\n");
            EndContext();
#line 61 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Contact\Phone.cshtml"
                            }

#line default
#line hidden
            BeginContext(3457, 146, true);
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3620, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3626, 30, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c0b0bdeba11a4b42a5f716543145ace0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3656, 1298, true);
                WriteLiteral(@"

    <script>

        let input = document.getElementById('phone')
        let button = document.getElementById('create')

        button.onclick = function ()
        {
            if (input.value.trim() == """") {
                $(""#warning"").text(""This Field is required"") ;
            }
            else
            {
                $.ajax({
                    url: ""/Admin/Contact/CreatePhone?key="" + input.value,
                    type: ""Get"",
                    success: function (response) {
                        console.log(response)
                        $(""#body"").append(response);
                    }

                })
            }
        }

        let buttons = document.getElementsByClassName('remove_button')
       
        for (let remove in buttons) {
            remove.onclick = function ()
            {
                console.log(this.tagName)
                $.ajax({
                    url: ""/Admin/Contact/DeletePhone?key="" + this.tagName,
   ");
                WriteLiteral(@"                 type: ""Get"",
                    success: function (response) {
                        console.log(response)
                        $(""#body"").append(response);
                    }

                })
            }
        }

    </script>

");
                EndContext();
            }
            );
            BeginContext(4957, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CenterPhoneNumber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
