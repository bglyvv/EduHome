#pragma checksum "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Shared\Components\User\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22d89985b5c9bece5c428fbf5dc43e544b99dedc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Shared_Components_User_Default), @"mvc.1.0.view", @"/Areas/Admin/Views/Shared/Components/User/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Shared/Components/User/Default.cshtml", typeof(AspNetCore.Areas_Admin_Views_Shared_Components_User_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22d89985b5c9bece5c428fbf5dc43e544b99dedc", @"/Areas/Admin/Views/Shared/Components/User/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bdf109ff8c5382f253bf09a9f160d3f310288e6", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Shared_Components_User_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("navbar-brand brand-logo"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Dashboard", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("dropdown-item"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Logout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Users", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 257, true);
            WriteLiteral(@"<nav class=""navbar col-lg-12 col-12 p-0 fixed-top d-flex flex-row"">
    <div class=""navbar-brand-wrapper d-flex justify-content-center"">
        <div class=""navbar-brand-inner-wrapper d-flex justify-content-between align-items-center w-100"">
            ");
            EndContext();
            BeginContext(257, 142, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ee6dfd25761d43de9011f882984bc738", async() => {
                BeginContext(355, 40, true);
                WriteLiteral("<img src=\"images/logo.svg\" alt=\"logo\" />");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(399, 6613, true);
            WriteLiteral(@"
            <a class=""navbar-brand brand-logo-mini"" href=""index.html""><img src=""images/logo-mini.svg"" alt=""logo"" /></a>
            <button class=""navbar-toggler navbar-toggler align-self-center"" type=""button"" data-toggle=""minimize"">
                <span class=""mdi mdi-sort-variant""></span>
            </button>
        </div>
    </div>
    <div class=""navbar-menu-wrapper d-flex align-items-center justify-content-end"">
        <ul class=""navbar-nav mr-lg-4 w-100"">
            <li class=""nav-item nav-search d-none d-lg-block w-100"">
                <div class=""input-group"">
                    <div class=""input-group-prepend"">
                        <span class=""input-group-text"" id=""search"">
                            <i class=""mdi mdi-magnify""></i>
                        </span>
                    </div>
                    <input type=""text"" class=""form-control"" placeholder=""Search now"" aria-label=""search"" aria-describedby=""search"">
                </div>
            </li>
        ");
            WriteLiteral(@"</ul>
        <ul class=""navbar-nav navbar-nav-right"">
            <li class=""nav-item dropdown mr-1"">
                <a class=""nav-link count-indicator dropdown-toggle d-flex justify-content-center align-items-center"" id=""messageDropdown"" href=""#"" data-toggle=""dropdown"">
                    <i class=""mdi mdi-message-text mx-0""></i>
                    <span class=""count""></span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""messageDropdown"">
                    <p class=""mb-0 font-weight-normal float-left dropdown-header"">Messages</p>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <img src=""images/faces/face4.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""item-content flex-grow"">
                            <h6 class=""ellipsis font-weight-normal"">
                                David Gr");
            WriteLiteral(@"ey
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                The meeting is cancelled
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <img src=""images/faces/face2.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""item-content flex-grow"">
                            <h6 class=""ellipsis font-weight-normal"">
                                Tim Cook
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                New product launch
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class");
            WriteLiteral(@"=""item-thumbnail"">
                            <img src=""images/faces/face3.jpg"" alt=""image"" class=""profile-pic"">
                        </div>
                        <div class=""item-content flex-grow"">
                            <h6 class=""ellipsis font-weight-normal"">
                                Johnson
                            </h6>
                            <p class=""font-weight-light small-text text-muted mb-0"">
                                Upcoming board meeting
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li class=""nav-item dropdown mr-4"">
                <a class=""nav-link count-indicator dropdown-toggle d-flex align-items-center justify-content-center notification-dropdown"" id=""notificationDropdown"" href=""#"" data-toggle=""dropdown"">
                    <i class=""mdi mdi-bell mx-0""></i>
                    <span class=""count""></span>
                </a>
                <");
            WriteLiteral(@"div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""notificationDropdown"">
                    <p class=""mb-0 font-weight-normal float-left dropdown-header"">Notifications</p>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <div class=""item-icon bg-success"">
                                <i class=""mdi mdi-information mx-0""></i>
                            </div>
                        </div>
                        <div class=""item-content"">
                            <h6 class=""font-weight-normal"">Application Error</h6>
                            <p class=""font-weight-light small-text mb-0 text-muted"">
                                Just now
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <div class=""item-icon bg-warn");
            WriteLiteral(@"ing"">
                                <i class=""mdi mdi-settings mx-0""></i>
                            </div>
                        </div>
                        <div class=""item-content"">
                            <h6 class=""font-weight-normal"">Settings</h6>
                            <p class=""font-weight-light small-text mb-0 text-muted"">
                                Private message
                            </p>
                        </div>
                    </a>
                    <a class=""dropdown-item"">
                        <div class=""item-thumbnail"">
                            <div class=""item-icon bg-info"">
                                <i class=""mdi mdi-account-box mx-0""></i>
                            </div>
                        </div>
                        <div class=""item-content"">
                            <h6 class=""font-weight-normal"">New user registration</h6>
                            <p class=""font-weight-light small-text mb-0 text-muted");
            WriteLiteral(@""">
                                2 days ago
                            </p>
                        </div>
                    </a>
                </div>
            </li>
            <li class=""nav-item nav-profile dropdown"">
                <a class=""nav-link dropdown-toggle"" href=""#"" data-toggle=""dropdown"" id=""profileDropdown"">
                    <img src=""images/faces/face5.jpg"" alt=""profile"" />
                    <span class=""nav-profile-name"">");
            EndContext();
            BeginContext(7013, 16, false);
#line 124 "C:\Users\Kanan\Desktop\EduHome\BackEndProject\Areas\Admin\Views\Shared\Components\User\Default.cshtml"
                                              Write(ViewBag.Fullname);

#line default
#line hidden
            EndContext();
            BeginContext(7029, 344, true);
            WriteLiteral(@"</span>
                </a>
                <div class=""dropdown-menu dropdown-menu-right navbar-dropdown"" aria-labelledby=""profileDropdown"">
                    <a class=""dropdown-item"">
                        <i class=""mdi mdi-settings text-primary""></i>
                        Settings
                    </a>
                    ");
            EndContext();
            BeginContext(7373, 195, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "141075dcae9b408983172ea3f0375ae8", async() => {
                BeginContext(7441, 123, true);
                WriteLiteral("\r\n                        <i class=\"mdi mdi-logout text-primary\"></i>\r\n                        Logout\r\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(7568, 273, true);
            WriteLiteral(@"
                </div>
            </li>
        </ul>
        <button class=""navbar-toggler navbar-toggler-right d-lg-none align-self-center"" type=""button"" data-toggle=""offcanvas"">
            <span class=""mdi mdi-menu""></span>
        </button>
    </div>
</nav>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
