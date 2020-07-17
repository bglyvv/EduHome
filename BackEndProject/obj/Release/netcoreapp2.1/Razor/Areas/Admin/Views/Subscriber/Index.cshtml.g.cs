#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76e8bb02d1f2a53f878a6786065ccb7e1181d93f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Subscriber_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Subscriber/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Subscriber/Index.cshtml", typeof(AspNetCore.Areas_Admin_Views_Subscriber_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76e8bb02d1f2a53f878a6786065ccb7e1181d93f", @"/Areas/Admin/Views/Subscriber/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Subscriber_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Subscriber>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Seen", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Subscriber", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
  
    Layout = "_AdminLayout";

#line default
#line hidden
            BeginContext(69, 508, true);
            WriteLiteral(@"<div class=""row"">
    <div class=""col-lg-12 grid-margin stretch-card"">
        <div class=""card"">
            <div class=""card-body"">
                <h4 class=""card-title"">Reply List</h4>
                <div class=""col-12"">
                    <a class=""btn btn-warning checkbox_button"" id=""read_reply"" style=""display:none;"">Mark selected as seen</a>
                    <a class=""btn btn-danger checkbox_button"" id=""delete_reply"" style=""display:none"">Delete selected</a>

                </div>
");
            EndContext();
#line 15 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                 if (Model.Count() > 0)
                {

#line default
#line hidden
            BeginContext(637, 479, true);
            WriteLiteral(@"                    <div class=""table-responsive"">
                        <table class=""table "">
                            <thead>
                                <tr>
                                    <th>
                                        <input type=""checkbox"" id=""checkbox"" name=""name"" value=""All"" />
                                    </th>
                                </tr>
                            </thead>
                            <tbody>
");
            EndContext();
#line 27 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                 foreach (Subscriber subscriber in Model)
                                {
                                    

#line default
#line hidden
#line 29 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                     if (subscriber.isActivated == false)
                                    {

#line default
#line hidden
            BeginContext(1340, 208, true);
            WriteLiteral("                                        <tr class=\"rows\">\r\n                                            <td>\r\n                                                <input class=\"checkbox\" type=\"checkbox\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 1548, "\"", 1570, 1);
#line 33 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
WriteAttributeValue("", 1556, subscriber.Id, 1556, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1571, 170, true);
            WriteLiteral(" />\r\n                                            </td>\r\n                                            <td class=\"py-1\">\r\n                                                <p>");
            EndContext();
            BeginContext(1742, 25, false);
#line 36 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                              Write(subscriber.Mail.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(1767, 202, true);
            WriteLiteral("*</p>\r\n                                            </td>\r\n                                            \r\n                                            <td>\r\n                                                ");
            EndContext();
            BeginContext(1969, 173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "410c593ca4534c1ab1cc462e781afbc1", async() => {
                BeginContext(2089, 49, true);
                WriteLiteral("<i class=\"mdi mdi-check-all btn-icon-append\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 40 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                                                       WriteLiteral(subscriber.Id);

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
            BeginContext(2142, 68, true);
            WriteLiteral("\r\n                                                <a id=\"delete_one\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2210, "\"", 2232, 1);
#line 41 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
WriteAttributeValue("", 2218, subscriber.Id, 2218, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2233, 168, true);
            WriteLiteral(" class=\"btn btn-danger\"><i class=\" mdi mdi-delete-forever \"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 44 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
            BeginContext(2521, 241, true);
            WriteLiteral("                                        <tr class=\"rows\" style=\"background-color:#d7d0d0\">\r\n                                            <td>\r\n                                                <input class=\"checkbox\" type=\"checkbox\" name=\"name\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2762, "\"", 2784, 1);
#line 49 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
WriteAttributeValue("", 2770, subscriber.Id, 2770, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2785, 170, true);
            WriteLiteral(" />\r\n                                            </td>\r\n                                            <td class=\"py-1\">\r\n                                                <p>");
            EndContext();
            BeginContext(2956, 25, false);
#line 52 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                              Write(subscriber.Mail.ToLower());

#line default
#line hidden
            EndContext();
            BeginContext(2981, 219, true);
            WriteLiteral("</p>\r\n                                            </td>\r\n                                            \r\n                                            <td>\r\n                                                <a id=\"delete_one\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 3200, "\"", 3222, 1);
#line 56 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
WriteAttributeValue("", 3208, subscriber.Id, 3208, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3223, 168, true);
            WriteLiteral(" class=\"btn btn-danger\"><i class=\" mdi mdi-delete-forever \"></i></a>\r\n                                            </td>\r\n                                        </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                    }

#line default
#line hidden
#line 59 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                     

                                }

#line default
#line hidden
            BeginContext(3467, 100, true);
            WriteLiteral("                            </tbody>\r\n                        </table>\r\n                    </div>\r\n");
            EndContext();
#line 65 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3625, 46, true);
            WriteLiteral("<h2 class=\"mt-5\">There are no new replies</h2>");
            EndContext();
#line 67 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Subscriber\Index.cshtml"
                                                               }

#line default
#line hidden
            BeginContext(3674, 58, true);
            WriteLiteral("            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3749, 6035, true);
                WriteLiteral(@"
    <script src=""https://unpkg.com/sweetalert/dist/sweetalert.min.js""></script>
    <script>
        let checkboxes = document.querySelectorAll("".checkbox"")
        let rows = document.querySelectorAll("".rows"")
        let selectAll = document.getElementById(""checkbox"")
        let buttons = document.querySelectorAll("".checkbox_button"")
        console.log(selectAll)
        for (var i = 0; i < checkboxes.length; ++i)
        {
            checkboxes[i].onclick = function ()
            {
                for (var k = 0; k < buttons.length; ++k)
                {
                    buttons[k].style.display = ""inline-block"";
                }
                if (this.checked)
                {
                    this.parentElement.parentElement.classList.add(""row-color"")
                }
                else
                {
                    this.parentElement.parentElement.classList.remove(""row-color"")
                }
                if (document.querySelectorAll("".row-color"")");
                WriteLiteral(@".length == 0)
                {
                    for (var k = 0; k < buttons.length; ++k) {
                        buttons[k].style.display = ""none"";
                    }
                }
                if (document.querySelectorAll("".row-color"").length == rows.length) {
                    selectAll.checked = true;
                }
                else
                {
                    selectAll.checked = false;
                }
            }

        }
        selectAll.onclick = function ()
        {
            if (this.checked) {
                for (let i = 0; i < rows.length; ++i) {
                    if (rows[i].className == ""rows"") {
                        rows[i].classList.add(""row-color"")
                    }
                }
                for (var k = 0; k < checkboxes.length; ++k)
                {
                    checkboxes[k].checked = true;
                }
                for (var k = 0; k < buttons.length; ++k) {
                    button");
                WriteLiteral(@"s[k].style.display = ""inline-block"";
                }

            }
            else
            {
                for (let i = 0; i < rows.length; ++i) {
                    rows[i].classList.remove(""row-color"")
                }
                for (var k = 0; k < checkboxes.length; ++k) {
                    checkboxes[k].checked = false;
                }
                for (var k = 0; k < buttons.length; ++k) {
                    buttons[k].style.display = ""none"";
                }
            }
        }

        $(""#read_reply"").click(function () {

            let values = [];
            for (var i = 0; i < checkboxes.length; ++i)
            {
                if (checkboxes[i].checked)
                {
                    values.push(checkboxes[i].value);
                }
            }
            $.ajax({
                url: ""/Admin/Subscriber/AllRead"",
                type: ""Post"",
                //dataType: ""json"",
                data: { value: JSON.string");
                WriteLiteral(@"ify(values) },
                success: function (response)
                {
                    selectAll.checked = false;
                    for (var k = 0; k < buttons.length; ++k) {
                        buttons[k].style.display = ""none"";
                    }
                    for (var i = 0; i < checkboxes.length; ++i) {
                        checkboxes[i].checked = false;
                    }
                    location.reload();
                }
            })

        })

        $(""#delete_reply"").click(function () {
            let values = [];
            for (var i = 0; i < checkboxes.length; ++i) {
                if (checkboxes[i].checked) {
                    values.push(checkboxes[i].value);
                }
            }
            $.ajax({
                url: ""/Admin/Subscriber/AllDelete"",
                type: ""Get"",
                //dataType: ""json"",
                data: { value: JSON.stringify(values) },
                success: function (resp");
                WriteLiteral(@"onse) {
                    selectAll.checked = false;
                    for (var k = 0; k < buttons.length; ++k) {
                        buttons[k].style.display = ""none"";
                    }
                    for (var i = 0; i < checkboxes.length; ++i) {
                        checkboxes[i].checked = false;
                    }
                    location.reload();
                }
            })
        })

        $(""#delete_one"").click(function (e) {
            e.preventDefault();
            swal({
                title: ""Are you sure?"",
                text: ""Once deleted, you will not be able to recover this file!"",
                icon: ""warning"",
                buttons: true,
                dangerMode: true,
            })
                .then((willDelete) => {
                    if (willDelete) {
                        $.ajax({
                            url: ""/Admin/Subscriber/DeleteOne?key="" + $(""#delete_one"").attr(""value""),
                           ");
                WriteLiteral(@" type: ""Get"",
                            success: function (response) {
                                selectAll.checked = false;
                                for (var k = 0; k < buttons.length; ++k) {
                                    buttons[k].style.display = ""none"";
                                }
                                for (var i = 0; i < checkboxes.length; ++i) {
                                    checkboxes[i].checked = false;
                                }
                                location.reload();
                            }

                        })
                        swal(""Poof! Your file has been deleted!"", {
                            icon: ""success"",
                        });

                    } else {
                        swal(""Your file is safe!"");
                    }
                });
        })
    </script>

");
                EndContext();
            }
            );
            BeginContext(9787, 2, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Subscriber>> Html { get; private set; }
    }
}
#pragma warning restore 1591
