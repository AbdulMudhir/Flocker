#pragma checksum "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04c7b4fb86deb7f8c3eb4b60ea3d70901da4553b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Profile_MyOffer), @"mvc.1.0.view", @"/Views/Profile/MyOffer.cshtml")]
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
#line 2 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\_ViewImports.cshtml"
using Flocker.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04c7b4fb86deb7f8c3eb4b60ea3d70901da4553b", @"/Views/Profile/MyOffer.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d3bc5b5bffc837fc1a0b25aa880eb5f5e605270", @"/Views/_ViewImports.cshtml")]
    public class Views_Profile_MyOffer : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProfileOfferViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/content/MyOffer.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("productColumn hoverGrey row  align-center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/script/OfferScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
  
    ViewData["Title"] = "MyOffer";
    Layout = "~/Views/_ProfileLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "04c7b4fb86deb7f8c3eb4b60ea3d70901da4553b5615", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"



<h1 class=""profile-table-title"">My Offer</h1>

<div class=""table  "">
    <div class=""table-title row align-center"">
        <h4 class=""userColumn"">Seller</h4>
        <h4 class=""priceColumn"">Price</h4>
        <h4  class=""productColumn"">Product Name</h4>
        <h4 class=""statusColumn"">Status</h4>
    </div>

");
#nullable restore
#line 24 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
     foreach (var item in Model.Offers)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"cell row align-center\">\r\n    <a class=\"userColumn\">");
#nullable restore
#line 28 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
                     Write(item.Product.Owner.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    <a class=\"priceColumn \">£");
#nullable restore
#line 29 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
                        Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c7b4fb86deb7f8c3eb4b60ea3d70901da4553b7897", async() => {
#nullable restore
#line 30 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
                                                                                                                                Write(item.Product.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(" ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
                                                      WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n    <div class=\"statusColumn row justifiy-center align-center\">\r\n\r\n\r\n");
#nullable restore
#line 35 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
         if (!item.isApproved && item.Product.Sold.IsSold)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"sold row justifiy-center align-center\">Already Sold</a>\r\n");
#nullable restore
#line 39 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
        }
        else if (item.isPending)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"pending row justifiy-center align-center \">Pending</a>\r\n            <a class=\"delete row justifiy-center align-center \">Delete</a>\r\n            <div class=\"confirmation-box\">\r\n\r\n                <input type=\"hidden\" name=\"OfferId\"");
            BeginWriteAttribute("value", " value=\"", 1395, "\"", 1416, 1);
#nullable restore
#line 47 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
WriteAttributeValue("", 1403, item.OfferId, 1403, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                <input type=\"hidden\" name=\"ProductId\"");
            BeginWriteAttribute("value", " value=\"", 1475, "\"", 1498, 1);
#nullable restore
#line 48 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
WriteAttributeValue("", 1483, item.ProductId, 1483, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n                <h1>Are you sure you want to delete</h1>\r\n                <a class=\"yes-button\" style=\"cursor:pointer\">Yes</a>\r\n                <a class=\"no-button\" style=\"cursor:pointer\">No</a>\r\n\r\n\r\n            </div>\r\n");
#nullable restore
#line 56 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
        }
        else if (!item.isApproved && !item.isPending)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"reject row justifiy-center align-center\">Rejected</a>\r\n");
#nullable restore
#line 60 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
        }
        else
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            <a class=\"sold row justifiy-center align-center\">You Bought</a>\r\n");
#nullable restore
#line 65 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n\r\n</div>\r\n");
#nullable restore
#line 70 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Profile\MyOffer.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "04c7b4fb86deb7f8c3eb4b60ea3d70901da4553b13730", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<CustomUserIdentity> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<CustomUserIdentity> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProfileOfferViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
