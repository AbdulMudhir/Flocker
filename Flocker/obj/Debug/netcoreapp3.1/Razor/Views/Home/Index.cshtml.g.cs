#pragma checksum "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68898862ef46e3850299b267b88cde4bca0e8f1b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68898862ef46e3850299b267b88cde4bca0e8f1b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b5646f269e6a79c4a147a501d807fed346e661e", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("header-img"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Image/CashBag@2x.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
  
    Layout = "~/Views/_Layout.cshtml";
    ViewBag.Title = "Home";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
Write(await Component.InvokeAsync("CategoryNavigation"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <section class=""header"">

        <div class=""container "">

            <div class=""heading-content"">
                <h1 class=""heading"">BUY & Sell Fast</h1>
                <h4 class=""sub-heading"">Have too much stuff you no longer need? Then why not sell them now?</h4>
                <div class=""sellnow row justifiy-center align-center"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68898862ef46e3850299b267b88cde4bca0e8f1b6161", async() => {
                WriteLiteral("Sell Now");
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
            WriteLiteral("</div>\r\n\r\n            </div>\r\n\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "68898862ef46e3850299b267b88cde4bca0e8f1b7572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
        </div>

    </section>






        <section class=""spotlight"">

            <div class=""container"">

                <div class=""spotlight-heading"">
                    <h1>Spotlight</h1>
                </div>

                <ul class=""spotlight-item"">

");
#nullable restore
#line 43 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                     foreach (var item in Model.AllSpotlight)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"card-container\">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68898862ef46e3850299b267b88cde4bca0e8f1b9331", async() => {
                WriteLiteral("\r\n                                <img class=\"card-img\"");
                BeginWriteAttribute("src", " src=\"", 1273, "\"", 1313, 1);
#nullable restore
#line 48 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
WriteAttributeValue("", 1279, Url.Content(item.Images[0].Image), 1279, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <span class=\"iconify crown\" data-inline=\"false\" data-icon=\"ant-design:crown-filled\" ></span>\r\n\r\n                                <div class=\"card-title\">\r\n                                    <h4>");
#nullable restore
#line 52 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                   Write(item.Name.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n\r\n");
#nullable restore
#line 54 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                     if(@item.Price.ToString() == "0.00" )
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <h5 class=\"card-price\">Free</h5>\r\n");
#nullable restore
#line 57 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                    }
                                    else{


#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <h5 class=\"card-price\">£");
#nullable restore
#line 60 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 61 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                                </div>\r\n\r\n\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 47 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                                                              WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                        </li>\r\n");
#nullable restore
#line 70 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


                </ul>



            </div>






        </section>


        <section class=""new-content"">

            <div class=""container"">

                <div class=""new-heading"">
                    <h1>Newly Added  Product</h1>
                </div>

                <ul class=""new-item"">

");
#nullable restore
#line 100 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                     foreach (var item in Model.AllProduct)
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <li class=\"card-container \">\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "68898862ef46e3850299b267b88cde4bca0e8f1b14965", async() => {
                WriteLiteral("\r\n                                <img class=\"card-img\"");
                BeginWriteAttribute("src", " src=\"", 2749, "\"", 2789, 1);
#nullable restore
#line 105 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
WriteAttributeValue("", 2755, Url.Content(item.Images[0].Image), 2755, 34, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n                                <div class=\"card-title\">\r\n                                    <h4>");
#nullable restore
#line 107 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                   Write(item.Name.ToUpper());

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n");
#nullable restore
#line 108 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                     if (@item.Price.ToString() == "0.00")
                                    {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <h5 class=\"card-price\">Free</h5>\r\n");
#nullable restore
#line 111 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                    }
                                    else
                                    {


#line default
#line hidden
#nullable disable
                WriteLiteral("                                        <h5 class=\"card-price\">£");
#nullable restore
#line 115 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                                           Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n");
#nullable restore
#line 116 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                                </div>\r\n                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 104 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"
                                                                              WriteLiteral(item.ProductId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n                        </li>\r\n");
#nullable restore
#line 122 "C:\Users\Abdul\source\repos\Flocker\Flocker\Views\Home\Index.cshtml"


                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                </ul>\r\n\r\n\r\n\r\n            </div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n        </section>\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
