#pragma checksum "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5343e7a32acd820b41bc9e7065cd813220d57739"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Order_OrderingDishes), @"mvc.1.0.view", @"/Views/Order/OrderingDishes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Order/OrderingDishes.cshtml", typeof(AspNetCore.Views_Order_OrderingDishes))]
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
#line 1 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\_ViewImports.cshtml"
using TomasosPizzeria;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5343e7a32acd820b41bc9e7065cd813220d57739", @"/Views/Order/OrderingDishes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cfae9784ff2c76f6541a602102a4a6a6ce5b866", @"/Views/_ViewImports.cshtml")]
    public class Views_Order_OrderingDishes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TomasosPizzeria.ViewModels.ViewModelOrders>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CustomerDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Order", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddDish", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Checkout", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "OrderingDishes", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("dish"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            BeginContext(55, 82, true);
            WriteLiteral("\r\n<div class=\"row justify-content-center\">\r\n    <div class=\"col-sm-6\" id=\"name\">\r\n");
            EndContext();
            BeginContext(271, 25, true);
            WriteLiteral("        <h2> Welcome!!!  ");
            EndContext();
            BeginContext(297, 25, false);
#line 11 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                    Write(Model.loggedCustomer.Namn);

#line default
#line hidden
            EndContext();
            BeginContext(322, 70, true);
            WriteLiteral("  </h2>\r\n    </div>\r\n    <div class=\"text-left\" id=\"Up\">\r\n        <h4>");
            EndContext();
            BeginContext(392, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5343e7a32acd820b41bc9e7065cd813220d577396743", async() => {
                BeginContext(449, 27, true);
                WriteLiteral(" Update Contact Information");
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
            BeginContext(480, 118, true);
            WriteLiteral("</h4>\r\n\r\n     \r\n    </div>\r\n</div>\r\n\r\n<h3>Order Your Dishes</h3>\r\n\r\n<div class=\"row justify-content-center\">\r\n\r\n\r\n    ");
            EndContext();
            BeginContext(598, 989, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5343e7a32acd820b41bc9e7065cd813220d577398481", async() => {
                BeginContext(679, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
#line 28 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
         foreach (var dishTypeData in Model.dishByTypes)
        {

#line default
#line hidden
                BeginContext(754, 68, true);
                WriteLiteral("            <div class=\"card\" id=\"dishType\">\r\n                <h1>  ");
                EndContext();
                BeginContext(823, 16, false);
#line 31 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                 Write(dishTypeData.Key);

#line default
#line hidden
                EndContext();
                BeginContext(839, 34, true);
                WriteLiteral(" </h1>\r\n                <br />\r\n\r\n");
                EndContext();
#line 34 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                 foreach (var dish in dishTypeData.Value)
                {

#line default
#line hidden
                BeginContext(951, 25, true);
                WriteLiteral("                    <h4> ");
                EndContext();
                BeginContext(977, 16, false);
#line 36 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                    Write(dish.MatrattNamn);

#line default
#line hidden
                EndContext();
                BeginContext(993, 6, true);
                WriteLiteral("</h4> ");
                EndContext();
                BeginContext(1043, 37, true);
                WriteLiteral("                    <p> Ingredients: ");
                EndContext();
                BeginContext(1081, 27, false);
#line 37 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                                Write(Model.dishIngredients[dish]);

#line default
#line hidden
                EndContext();
                BeginContext(1108, 6, true);
                WriteLiteral("</p>\r\n");
                EndContext();
                BeginContext(1116, 31, true);
                WriteLiteral("                    <p> Price: ");
                EndContext();
                BeginContext(1148, 9, false);
#line 39 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                          Write(dish.Pris);

#line default
#line hidden
                EndContext();
                BeginContext(1157, 9, true);
                WriteLiteral(" Kr</p>\r\n");
                EndContext();
                BeginContext(1209, 28, true);
                WriteLiteral("                        <h5>");
                EndContext();
                BeginContext(1237, 90, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5343e7a32acd820b41bc9e7065cd813220d5773911800", async() => {
                    BeginContext(1315, 8, true);
                    WriteLiteral(" Add >> ");
                    EndContext();
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
#line 42 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                                                                             WriteLiteral(dish.MatrattId);

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
                BeginContext(1327, 7, true);
                WriteLiteral("</h5>\r\n");
                EndContext();
#line 43 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
                    

                }

#line default
#line hidden
                BeginContext(1377, 22, true);
                WriteLiteral("\r\n            </div>\r\n");
                EndContext();
#line 48 "C:\Users\emran\Desktop\.NET CMS\ASP.NET MVC 1\Assignment\TomasosPizzeria\TomasosPizzeria\Views\Order\OrderingDishes.cshtml"
        }

#line default
#line hidden
                BeginContext(1410, 44, true);
                WriteLiteral("\r\n        <br /><br />\r\n      \r\n        <h4>");
                EndContext();
                BeginContext(1454, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5343e7a32acd820b41bc9e7065cd813220d5773915246", async() => {
                    BeginContext(1502, 16, true);
                    WriteLiteral("Review the Order");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1522, 58, true);
                WriteLiteral("</h4>\r\n\r\n        \r\n        <br /><br /> <br /><br />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1587, 12, true);
            WriteLiteral("\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TomasosPizzeria.ViewModels.ViewModelOrders> Html { get; private set; }
    }
}
#pragma warning restore 1591
