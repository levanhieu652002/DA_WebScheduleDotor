#pragma checksum "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dc228780a44427417b46d8f57b1f30a6d1340c47"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Hoidap_Index), @"mvc.1.0.view", @"/Views/Hoidap/Index.cshtml")]
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
#line 2 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dc228780a44427417b46d8f57b1f30a6d1340c47", @"/Views/Hoidap/Index.cshtml")]
    public class Views_Hoidap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<WebAppYte.Models.HoiDap>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/images/bando1.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-responsive"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
   ViewBag.Title = "Index";
                Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div id=""nivoslider"" class=""slides nivoSlider"">

    <div class=""nivo-directionNav""><a class=""nivo-prevNav"">Prev</a><a class=""nivo-nextNav"">Next</a></div>
    <div class=""nivo-slice"" name=""0"" style=""left: 0px; width: 1530px; height: 160px; opacity: 1; overflow: hidden;"">
        <div class=""col-sm-12"" style=""position:absolute; width:1519px; height:auto; display:block !important; top:165px; left:170px;"">        
        </div>

    </div>

</div>
<h4 style=""color:orangered""> <b>Câu hỏi của bạn</b> </h4>
<h4><button class=""btn-default"">");
#nullable restore
#line 20 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
                           Write(Html.ActionLink("Gửi câu hỏi mới", "Create", new { id = @ViewBag.id }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</button></h4>\n<hr />\n<div class=\"col-md-8\">\n");
#nullable restore
#line 23 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<i>Người gửi : <b>");
#nullable restore
#line 25 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
             Write(item.MabnNavigation.Tenbn);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> &nbsp; <i class=\"fas fa-clock\"></i>&nbsp;");
#nullable restore
#line 25 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
                                                                                     Write(item.Ngaytl.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</i>\n                <h4 class=\"text-info\">Câu hỏi:</h4>\n                                <h5 class=\"text-primary\">");
#nullable restore
#line 27 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
                                                    Write(Html.DisplayFor(modelItem => item.Hoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                                <h4 class=\"text-warning\">Trả lời : </h4>\n                                                                <h5 class=\"text-success\"> ");
#nullable restore
#line 29 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
                                                                                     Write(Html.DisplayFor(modelItem => item.Dap));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\n                                                                                <hr />");
#nullable restore
#line 30 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
                                                                                      }

#line default
#line hidden
#nullable disable
            WriteLiteral("    Trang ");
#nullable restore
#line 31 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
      Write(Model.PageCount < Model.PageNumber ? 0 : Model.PageNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 31 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
                                                                    Write(Model.PageCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n    ");
#nullable restore
#line 33 "D:\DA\WebAppYte\WebAppYte\Views\Hoidap\Index.cshtml"
Write(Html.PagedListPager(Model, page => Url.Action("Index",
            new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</div>\n\n<div class=\"col-md-4\">\n    <h3 style=\"color:red\"> Bản đồ phân bố cơ sở trên khu vực</h3>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "dc228780a44427417b46d8f57b1f30a6d1340c477582", async() => {
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
            WriteLiteral("\n\n</div>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<WebAppYte.Models.HoiDap>> Html { get; private set; }
    }
}
#pragma warning restore 1591
