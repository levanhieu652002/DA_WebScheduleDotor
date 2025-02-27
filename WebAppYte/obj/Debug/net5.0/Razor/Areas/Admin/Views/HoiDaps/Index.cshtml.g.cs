#pragma checksum "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bc15a9ef622eb59721a5331b62fa50128ad68c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_HoiDaps_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/HoiDaps/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bc15a9ef622eb59721a5331b62fa50128ad68c5", @"/Areas/Admin/Views/HoiDaps/Index.cshtml")]
    public class Areas_Admin_Views_HoiDaps_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebAppYte.Models.HoiDap>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutAd.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>Quản lý hỏi đáp</h2>


<table class=""table table-bordered"">
    <tr>
        <th>
            Người hỏi
        </th>
        <th>
            Người trả lời
        </th>
        <th>
            Câu hỏi
        </th>
        <th>
            Trả lời
        </th>
        <th>
            Ngày hỏi
        </th>
        <th>
            Ngày trả lời
        </th>
        <th>
            Trạng thái
        </th>
        <th></th>
    </tr>

");
#nullable restore
#line 37 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 41 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MabnNavigation.Tenbn));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.MandNavigation.Hoten));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 47 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Hoi));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 50 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Dap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 53 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(item.Ngayhoi.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n");
#nullable restore
#line 55 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
             if (item.Trangthai == 1)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td>\n                    ");
#nullable restore
#line 58 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
               Write(item.Ngaytl.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n");
#nullable restore
#line 60 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <td></td>\n");
#nullable restore
#line 64 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 67 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
              
                if (item.Trangthai == 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        <h5 style=\"color:red\">Chưa trả lời</h5>\n                    </td>\n");
#nullable restore
#line 73 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
                }
                if (item.Trangthai == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <td>\n                        <h5 style=\"color:red\">Đã trả lời</h5>\n                    </td>\n");
#nullable restore
#line 79 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
                }
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <td>\n                ");
#nullable restore
#line 82 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.ActionLink("Sửa", "Edit", new { id = item.Ma }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 83 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.ActionLink("Chi tiết", "Details", new { id = item.Ma }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\n                ");
#nullable restore
#line 84 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
           Write(Html.ActionLink("Xóa", "Delete", new { id = item.Ma }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n\n        </tr>\r\n");
#nullable restore
#line 88 "D:\DA\WebAppYte\WebAppYte\Areas\Admin\Views\HoiDaps\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\n</table>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebAppYte.Models.HoiDap>> Html { get; private set; }
    }
}
#pragma warning restore 1591
