#pragma checksum "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21354e01323d256b04740b1ea1cd7fbb0635f576"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Tintucs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Tintucs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21354e01323d256b04740b1ea1cd7fbb0635f576", @"/Areas/Admin/Views/Tintucs/Details.cshtml")]
    public class Areas_Admin_Views_Tintucs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebAppYte.Models.BaiViet>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("loading", new global::Microsoft.AspNetCore.Html.HtmlString("lazy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:150px;height:150px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
  
    ViewBag.Title = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAd.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>Chi tiết tin tức</h2>\n\n<div>\n\n    <hr />\n    <dl class=\"dl-horizontal\">\n        <dt>\n           Tiêu đề\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 19 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tieude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n           Nội dung\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 27 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
       Write(Html.Raw(@Model.Noidung));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n           Hình ảnh\n        </dt>\n\n        <dd>\n            <a class=\"thumb_cgia\">\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "21354e01323d256b04740b1ea1cd7fbb0635f5764821", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 608, "~/images/images/", 608, 16, true);
#nullable restore
#line 36 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
AddHtmlAttributeValue("", 624, Model.Hinhanh, 624, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n            </a>\n        </dd>\n\n        <dt>\n           Mô tả\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 45 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.Mota));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\n        <dt>\n          Ngày đăng\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 53 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
       Write(Model.Ngaydang.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt>\n           Thể loại\n        </dt>\n\n        <dd>\n            ");
#nullable restore
#line 60 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
       Write(Html.DisplayFor(model => model.MaloaiNavigation.Tenloai));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        \n\n    </dl>\n</div>\n<p>\n    ");
#nullable restore
#line 67 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
Write(Html.ActionLink("Sửa", "Edit", new { id = Model.Mabv }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n    ");
#nullable restore
#line 68 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\Tintucs\Details.cshtml"
Write(Html.ActionLink("Quay lại", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</p>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebAppYte.Models.BaiViet> Html { get; private set; }
    }
}
#pragma warning restore 1591
