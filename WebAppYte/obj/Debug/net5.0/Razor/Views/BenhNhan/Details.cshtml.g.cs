#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d642c7be49d6049c288235cde7b422a1db84cc86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BenhNhan_Details), @"mvc.1.0.view", @"/Views/BenhNhan/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d642c7be49d6049c288235cde7b422a1db84cc86", @"/Views/BenhNhan/Details.cshtml")]
    public class Views_BenhNhan_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.BenhNhan>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/Common/css/hoso.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imgavt"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Common/images/anhbenhnhan.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("170"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("170"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 4 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
   ViewBag.Title = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d642c7be49d6049c288235cde7b422a1db84cc864933", async() => {
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
<link href=""https://fonts.googleapis.com/icon?family=Material+Icons"" rel=""stylesheet"">

<br />
<div id=""nivoslider"" class=""slides nivoSlider"">

    <div class=""nivo-directionNav""><a class=""nivo-prevNav"">Prev</a><a class=""nivo-nextNav"">Next</a></div>
    <div class=""nivo-slice"" name=""0"" style=""left: 0px; width: 1530px; height: 160px; opacity: 1; overflow: hidden;"">
        <div class=""col-sm-12"" style=""position:absolute; width:1519px; height:auto; display:block !important; top:180px; left:200px;"">
            <nav aria-label=""breadcrumbs"" class=""rank-math-breadcrumb""><p><a href=""/Home/Index"">TRANG CHỦ</a><span class=""separator""> &gt; </span><span class=""last"">HỒ SƠ CÁ NHÂN</span></p></nav>
        </div>

    </div>
</div>
<div class=""text-center"">
    <h1 class=""div_head text-center cl_head text-uppercase font_hel sz_24 mb_15  pb_15"">
        HỒ SƠ CÁ NHÂN
    </h1>
</div>
<br />
<br />
<div");
            BeginWriteAttribute("class", " class=\"", 1072, "\"", 1080, 0);
            EndWriteAttribute();
            WriteLiteral(">\n    <div class=\"col-md-6\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d642c7be49d6049c288235cde7b422a1db84cc867170", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        &nbsp;\n        <div class=\"divInfo\">\n            Họ tên : <b> ");
#nullable restore
#line 32 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Tenbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\n            <br />\n            Tài khoản: ");
#nullable restore
#line 34 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Tendn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            Mật khẩu : ");
#nullable restore
#line 36 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                  Write(Html.DisplayFor(model => model.Mk));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            Giới tính :  ");
#nullable restore
#line 38 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                    Write(Html.DisplayFor(model => model.Gioitinh));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            Giới tính :  ");
#nullable restore
#line 40 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                    Write(ViewBag.ngay);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <button class=\"btn-warning\">\n                ");
#nullable restore
#line 43 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
           Write(Html.ActionLink("Cập nhật", "Edit", new { id = Model.Mabn }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </button>\n        </div>\n    </div>\n    <div class=\"col-md-6\">\n        <div class=\"divInfo\">\n\n            <span class=\"material-icons\">wifi_calling</span> &nbsp; Số điện thoại :  ");
#nullable restore
#line 50 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                                                                                Write(Html.DisplayFor(model => model.Sdt));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <span class=\"material-icons\">\n                email\n            </span> &nbsp; Email :  ");
#nullable restore
#line 54 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                               Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n            <span class=\"material-icons\">\n                home\n            </span> &nbsp;\n            Địa chỉ : ");
#nullable restore
#line 59 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Diachi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            <br />\n\n        </div>\n\n    </div>\n\n</div>\n<br />\n<br />\n<br />\n<br />\n<br />\n<br />\n<center>\n\n    <h4><a");
            BeginWriteAttribute("href", " href=\"", 2432, "\"", 2495, 1);
#nullable restore
#line 75 "D:\DA\WebAppYte\WebAppYte\Views\BenhNhan\Details.cshtml"
WriteAttributeValue("", 2439, Url.Action("Index", "Hoidap", new { id = @ViewBag.id }), 2439, 56, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">GỬI CÂU HỎI CHO BÁC SĨ</a></h4>\n</center>\n<br />\n<br />\n<br />\n<br />\n<br />\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYte.Models.BenhNhan> Html { get; private set; }
    }
}
#pragma warning restore 1591
