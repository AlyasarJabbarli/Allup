#pragma checksum "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e9046d978c32b98206ba4f7799bb3f7c6b8dc3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__BasketPartial), @"mvc.1.0.view", @"/Views/Shared/_BasketPartial.cshtml")]
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
#nullable restore
#line 2 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\_ViewImports.cshtml"
using Allup.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\_ViewImports.cshtml"
using Allup.ViewModels.BasketViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e9046d978c32b98206ba4f7799bb3f7c6b8dc3f", @"/Views/Shared/_BasketPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d06cb407e1ca6da14be170c61be6267e89a0ee59", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__BasketPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BasketVM>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromBasket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("product-close"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
            WriteLiteral("\r\n<ul class=\"cart-items\">\r\n");
#nullable restore
#line 4 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
     foreach (BasketVM basketVM in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>\r\n            <div class=\"single-cart-item d-flex\">\r\n                <div class=\"cart-item-thumb\">\r\n                    <a href=\"single-product.html\"><img");
            BeginWriteAttribute("src", " src=\"", 266, "\"", 310, 2);
            WriteAttributeValue("", 272, "/assets/images/product/", 272, 23, true);
#nullable restore
#line 9 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
WriteAttributeValue("", 295, basketVM.Image, 295, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"product\"></a>\r\n                    <span class=\"product-quantity\">");
#nullable restore
#line 10 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                                               Write(basketVM.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("x</span>\r\n                </div>\r\n                <div class=\"cart-item-content media-body\">\r\n                    <h5 class=\"product-name\"><a href=\"single-product.html\">");
#nullable restore
#line 13 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                                                                      Write(basketVM.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></h5>\r\n                    <span class=\"product-price\">???");
#nullable restore
#line 14 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                                            Write(basketVM.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e9046d978c32b98206ba4f7799bb3f7c6b8dc3f6266", async() => {
                WriteLiteral("<i class=\"fal fa-times\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 15 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                                                                                WriteLiteral(basketVM.ProductID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </li>\r\n");
#nullable restore
#line 19 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n<div class=\"price_content\">\r\n    <div class=\"cart-subtotals\">\r\n        <div class=\"products price_inline\">\r\n            <span class=\"label\">Subtotal</span>\r\n            <span class=\"value\">???");
#nullable restore
#line 25 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                             Write(Model.Sum(b=>b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"tax price_inline\">\r\n            <span class=\"label\">Taxes</span>\r\n            <span class=\"value\">???");
#nullable restore
#line 29 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                             Write(Model.Sum(b=>b.ExTax * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n    <div class=\"cart-total price_inline\">\r\n        <span class=\"label\">Total</span>\r\n        <span class=\"value\">???");
#nullable restore
#line 34 "C:\Users\Alik Jabbr\Desktop\ASP.NET\Allup\AllupProject\Allup\Views\Shared\_BasketPartial.cshtml"
                         Write(Model.Sum(b => b.ExTax * b.Count) + Model.Sum(b => b.Price * b.Count));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n    </div>\r\n</div> <!-- price content -->\r\n<div class=\"checkout text-center\">\r\n    <a href=\"checkout.html\" class=\"main-btn\">Checkout</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BasketVM>> Html { get; private set; }
    }
}
#pragma warning restore 1591
