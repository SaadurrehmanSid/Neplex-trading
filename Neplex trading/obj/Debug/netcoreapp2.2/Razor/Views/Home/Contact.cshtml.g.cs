#pragma checksum "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Home\Contact.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36f8e717f1788b2ed6134db0e214879700a3dbd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Contact), @"mvc.1.0.view", @"/Views/Home/Contact.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Contact.cshtml", typeof(AspNetCore.Views_Home_Contact))]
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
#line 1 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\_ViewImports.cshtml"
using Neplex_trading;

#line default
#line hidden
#line 2 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\_ViewImports.cshtml"
using Neplex_trading.Models;

#line default
#line hidden
#line 3 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\_ViewImports.cshtml"
using Neplex_trading.ViewModels;

#line default
#line hidden
#line 4 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\_ViewImports.cshtml"
using Neplex_trading.Data.Interfaces;

#line default
#line hidden
#line 5 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36f8e717f1788b2ed6134db0e214879700a3dbd3", @"/Views/Home/Contact.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213c849198faf6b0c1c560051fb4202a5d03e719", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Contact : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Home\Contact.cshtml"
  
    ViewData["Title"] = "Contact";

#line default
#line hidden
            BeginContext(45, 266, true);
            WriteLiteral(@"
<div class=""breadcrumbs"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""container-inner"">
                    <ul>
                        <li class=""home"">
                            ");
            EndContext();
            BeginContext(311, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "36f8e717f1788b2ed6134db0e214879700a3dbd34900", async() => {
                BeginContext(355, 4, true);
                WriteLiteral("Home");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(363, 2105, true);
            WriteLiteral(@"
                            <span><i class=""fa fa-angle-right""></i></span>
                        </li>
                        <li class=""category3""><span>Contact-us</span></li>
                    </ul>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""main-contact-area"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-xs-12 col-sm-12 col-md-3 col-lg-3"">
                <div class=""page-sidebar-area"">
                    <aside class=""sidebar-content"">
                        <div class=""bar-title"">
                            <div class=""bar-ping""><img src=""img/bar-ping.png"" alt=""""></div>
                            <h2>Contact Us Via:</h2>
                        </div>
                        <ul class=""sidebar-tags"">
                            <li>neplextrading@gmail.com</li>
                            <li>rananaveedrana001@gmail.com</li>
                            <li>+923030616001</li>
               ");
            WriteLiteral(@"             <li>+923476100348</li>
                        </ul>
                    </aside>
                </div>
            </div>
            <div class=""col-xs-12 col-sm-12 col-md-9 col-lg-9"">
                <div class=""contact-us-area"">
                    <div class=""google-map-area"">
                        <!--  Map Section -->
                        <div id=""contacts"" class=""map-area"">
                            <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d53941.22996203337!2d74.32976448102991!3d32.32993331381203!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x391edbaf7b7f8025%3A0xdf762e65d36172c0!2sDaska%2C%20Sialkot%2C%20Punjab%2C%20Pakistan!5e0!3m2!1sen!2s!4v1578669545310!5m2!1sen!2s"" width=""100%"" height=""350"" frameborder=""0"" style=""border:0;"" allowfullscreen=""""></iframe>
                        </div>
                    </div><br /><br />
                    <h3 class="""">Street Baba Nanak Wali Daska(Sialkot),Pakistan</h3>

                </div>
 ");
            WriteLiteral("           </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
