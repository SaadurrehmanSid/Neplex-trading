#pragma checksum "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65d779389c6c63ab080ce604fc5bd695a09b5b01"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_ShoppingCartBucket_Default), @"mvc.1.0.view", @"/Views/Shared/Components/ShoppingCartBucket/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/ShoppingCartBucket/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_ShoppingCartBucket_Default))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65d779389c6c63ab080ce604fc5bd695a09b5b01", @"/Views/Shared/Components/ShoppingCartBucket/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"213c849198faf6b0c1c560051fb4202a5d03e719", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_ShoppingCartBucket_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShoppingCartVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("sm-cart-product"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Products", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("remove"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveFromShoppingCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(27, 216, true);
            WriteLiteral("\r\n\r\n<div class=\"disflow\">\r\n    <div class=\"circle-shopping expand\">\r\n        <div class=\"shopping-carts text-right\">\r\n            <div class=\"cart-toggler\">\r\n                <a href=\"#\"><i class=\"icon-bag\"></i></a>\r\n");
            EndContext();
#line 11 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                 if (Model.ShoppingCart.ShoppingCartItems.Count > 0)
                {

#line default
#line hidden
            BeginContext(332, 60, true);
            WriteLiteral("                    <a href=\"#\"><span class=\"cart-quantity\">");
            EndContext();
            BeginContext(393, 42, false);
#line 13 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                       Write(Model.ShoppingCart.ShoppingCartItems.Count);

#line default
#line hidden
            EndContext();
            BeginContext(435, 13, true);
            WriteLiteral("</span></a>\r\n");
            EndContext();
#line 14 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"

                }

#line default
#line hidden
            BeginContext(469, 115, true);
            WriteLiteral("            </div>\r\n            <div class=\"restrain small-cart-content\">\r\n                <ul class=\"cart-list\">\r\n");
            EndContext();
#line 19 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                     foreach (var item in Model.ShoppingCart.ShoppingCartItems)
                    {

#line default
#line hidden
            BeginContext(688, 58, true);
            WriteLiteral("                        <li>\r\n                            ");
            EndContext();
            BeginContext(746, 232, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d779389c6c63ab080ce604fc5bd695a09b5b018483", async() => {
                BeginContext(859, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(893, 51, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "65d779389c6c63ab080ce604fc5bd695a09b5b018894", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 903, "~/img/", 903, 6, true);
#line 23 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
AddHtmlAttributeValue("", 909, item.Product.ProductImage, 909, 26, false);

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
                BeginContext(944, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 22 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                                                                        WriteLiteral(item.Product.ProductId);

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
            BeginContext(978, 95, true);
            WriteLiteral("\r\n                            <div class=\"small-cart-detail\">\r\n                                ");
            EndContext();
            BeginContext(1073, 162, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65d779389c6c63ab080ce604fc5bd695a09b5b0113182", async() => {
                BeginContext(1197, 34, true);
                WriteLiteral("<i class=\"fa fa-times-circle\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 26 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                                                                                       WriteLiteral(item.Product.ProductId);

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
            BeginContext(1235, 89, true);
            WriteLiteral("\r\n                                <a class=\"small-cart-name\" href=\"product-details.html\">");
            EndContext();
            BeginContext(1325, 24, false);
#line 27 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                                                  Write(item.Product.ProductName);

#line default
#line hidden
            EndContext();
            BeginContext(1349, 70, true);
            WriteLiteral("</a>\r\n                                <span class=\"quantitys\"><strong>");
            EndContext();
            BeginContext(1420, 11, false);
#line 28 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                           Write(item.Amount);

#line default
#line hidden
            EndContext();
            BeginContext(1431, 16, true);
            WriteLiteral("</strong>x<span>");
            EndContext();
            BeginContext(1448, 18, false);
#line 28 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                                                       Write(item.Product.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1466, 83, true);
            WriteLiteral("</span></span>\r\n                            </div>\r\n                        </li>\r\n");
            EndContext();
#line 31 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                    }

#line default
#line hidden
            BeginContext(1572, 91, true);
            WriteLiteral("\r\n\r\n                </ul>\r\n                <p class=\"total\">Subtotal: <span class=\"amount\">");
            EndContext();
            BeginContext(1664, 23, false);
#line 35 "C:\Users\Saad ur rehman\source\repos\Neplex trading\Neplex trading\Views\Shared\Components\ShoppingCartBucket\Default.cshtml"
                                                           Write(Model.ShoppingCartTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1687, 201, true);
            WriteLiteral("</span></p>\r\n                <p class=\"buttons\">\r\n                    <a href=\"checkout.html\" class=\"button\">Checkout</a>\r\n                </p>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShoppingCartVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
