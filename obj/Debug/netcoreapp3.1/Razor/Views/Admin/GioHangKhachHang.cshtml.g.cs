#pragma checksum "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e7b0ac3862b42f8a091c8ca0fe0d938ee3d2ef45"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_GioHangKhachHang), @"mvc.1.0.view", @"/Views/Admin/GioHangKhachHang.cshtml")]
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
#line 1 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\_ViewImports.cshtml"
using vroom2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\_ViewImports.cshtml"
using vroom2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e7b0ac3862b42f8a091c8ca0fe0d938ee3d2ef45", @"/Views/Admin/GioHangKhachHang.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b69c9b799689f215fbcc18a112898da4ddd763a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Admin_GioHangKhachHang : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<vroom2.Models.DonHang>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("if(!confirm(\'Are you sure you want to delete this order\')){return false}"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteDonHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", new global::Microsoft.AspNetCore.Html.HtmlString("Delete"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("DeleteDonHang"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n\r\n\r\n    <h2 style=\"text-align:center;margin-top:70px\">Giỏ hàng cửa khách ");
#nullable restore
#line 8 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                                                                Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
<style>
.container_swap{
width: 1200px;
margin:auto;/* căn giữa*/
margin-top: 50px;
}

.div_con2{
width: 600px;

float: left;

text-align: center;
}

</style>


<div class=""container_swap"">
    <div class=""div_con2"">
       
      
       
    </div>
   
    
</div>
<!--Bảng -->
<i class=""ti-pencil-alt""></i>
<!--chỉnh boder none-->
<table style=""border-collapse:collapse;width:1000px; margin:auto; border:none; border-spacing:0px;background-color: #B0E0E6"">
    <thead >
       <tr>
                    
                     <th style=""border:none;padding:10px;text-align: center;"">Tên sản phẩm</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Hình ảnh</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Giá</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Tình trạng</th>
                     <th style=""border:none;padding:10px;text-align: center;""></th>
       </tr>
    <");
            WriteLiteral("/thead>\r\n    <tbody>\r\n");
#nullable restore
#line 51 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 53 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n");
            WriteLiteral("                       \r\n");
            WriteLiteral("                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 60 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
            WriteLiteral("                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\"><img style=\"width:300px;height:150px\"");
            BeginWriteAttribute("src", " src=\"", 1913, "\"", 1933, 1);
#nullable restore
#line 62 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
WriteAttributeValue("", 1919, item.ImageUrl, 1919, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1934, "\"", 1940, 0);
            EndWriteAttribute();
            WriteLiteral("/></td>\r\n                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 63 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 64 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.TinhTrang));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        \r\n");
            WriteLiteral(@"
                        <td style=""border:none; text-align: center;padding:10px;background-color: white"">

                             <div class=""btn-group"" role=""group"">     <!--Cho chung hàng-->
                                 <!--đường dẫn-->
                                       ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e7b0ac3862b42f8a091c8ca0fe0d938ee3d2ef4510534", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                                           <input hidden name=\"Id\"type=\"text\"");
                BeginWriteAttribute("value", " value=\"", 2875, "\"", 2891, 1);
#nullable restore
#line 74 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
WriteAttributeValue("", 2883, item.ID, 2883, 8, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("/>\r\n                                           ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e7b0ac3862b42f8a091c8ca0fe0d938ee3d2ef4511332", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                       ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                  
                                     
                                    
                                       
                                
                            </div>
                        </td>

                    </tr>
");
#nullable restore
#line 86 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 86 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\Admin\GioHangKhachHang.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n </table>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<vroom2.Models.DonHang>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591