#pragma checksum "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3e15c8bda9072fbd0fab28c8a28881486fb97889"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e15c8bda9072fbd0fab28c8a28881486fb97889", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b69c9b799689f215fbcc18a112898da4ddd763a", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<vroom2.Models.Model>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DatHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute(",asp-controller", new global::Microsoft.AspNetCore.Html.HtmlString("Model"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
  
    Layout = "~/Views/Shared/LayoutUser.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e15c8bda9072fbd0fab28c8a28881486fb978894711", async() => {
                WriteLiteral("\r\n\r\n    \r\n \r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e15c8bda9072fbd0fab28c8a28881486fb978895694", async() => {
                WriteLiteral("\r\n    <h2 style=\"text-align:center;margin-top:70px\">");
#nullable restore
#line 13 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
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
       <tr>          <th style=""border:none;padding:10px;text-align: center;"">Id sản phẩm</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Dòng sản phẩm</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Tên sản phẩm</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Hình ảnh</th>
                     <th style=""border:none;padding:10px;text-align: center;"">Giá</th>
                     <th style=""border:n");
                WriteLiteral("one;padding:10px;text-align: center;\"></th>\r\n       </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 55 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
             if (Model != null)
            {
                

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <tr>\r\n");
                WriteLiteral("                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 63 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 64 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.Make.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
                WriteLiteral("                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 66 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.Name));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n");
                WriteLiteral("                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\"><img style=\"width:300px;height:150px\"");
                BeginWriteAttribute("src", " src=\"", 2307, "\"", 2327, 1);
#nullable restore
#line 68 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
WriteAttributeValue("", 2313, item.ImageUrl, 2313, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 2328, "\"", 2334, 0);
                EndWriteAttribute();
                WriteLiteral("/> </td>\r\n                        <td style=\"border:none; text-align: center;padding:10px;background-color: white\">");
#nullable restore
#line 69 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                                                                                                    Write(Html.DisplayFor(m=>item.Price));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                        \r\n                        \r\n");
                WriteLiteral(@"
                           <td style=""border:none; text-align: center;padding:10px;background-color: white"">

                             <div class=""btn-group"" role=""group"">
                                 <!--đường dẫn-->
                               <button  class=""btn  s-full-width js-buy-ticket""style=""background-color:blue"">Đặt hàng</button>

                                   <!--form đặt hàng ; đặt ở đây để lấy id item-->
                                       <div class=""modal js-modal"">
                                          <div class=""modal-container js-modal-container"">
                                              <div class=""modal-close js-modal-close"">
                                              
                                              </div>
                                              <header class=""modal-header"">
                                               
                                               <h2>Bảng Thanh toán</h2>
                            ");
                WriteLiteral("         \r\n                                              </header>\r\n                                              <div class=\"modal-body\">\r\n                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e15c8bda9072fbd0fab28c8a28881486fb9788911803", async() => {
                    WriteLiteral(@"
                                                      <input id=""ticket-email"" type=""text"" class=""modal-input"" placeholder=""Mã sản phẩm""name=""IdModel""/>
                                                      <input id=ticket-quantity type=""text"" class=""modal-input"" placeholder=""Họ và tên""name=""Ten""/>
                                                        
                                                      <input id=""ticket-email"" type=""text"" class=""modal-input"" placeholder=""Số điện thoại ""name=""SDT""/>
                                                      
                                                      <input id=""ticket-quantity"" type=""text"" class=""modal-input"" placeholder=""Ngày xem xe"" name=""Date""/>   
                                                      
                                                      <!--Type là hidden-->
                                                     
                                                      
                                                  ");
                    WriteLiteral("    <input id=\"buy-tickets\" type=\"submit\" class=\"btn btn-primary\" value=\"Đặt Hàng\"/>\r\n                                                \r\n                                                \r\n                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                              </div>
                                              
                                          </div>
                                      </div>
               
                            
                            
                            </div>
                        </td>
                    </tr>
");
#nullable restore
#line 117 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 117 "D:\D\Thiết kế web chuyên nghiệp\vroom2\vroom2\Views\User\Index.cshtml"
                 

            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n </table>\r\n\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
                WriteLiteral("\r\n");
                WriteLiteral(@"
<style>
    .clear {
    clear:both;
}
.text-white {
    color:#fff !important;
}
.text-center {
    text-align: center !important;
}
.btn {
    color: #fff;
    background-color: black;
    text-decoration: none;
    padding: 11px 16px;
    display: inline-block;
    margin-top: 15px;
    border: none;
}
.pull-right {
    float: right !important;
}
.btn:hover {
    cursor: pointer;
    color: black;
    background-color:#ccc ;
}
.row {
    margin-left: -8px ;
    margin-right: -8px ;
}
.row::after {
    content: """";
    display: block;
    clear: both;
}
.col {
    float: left;
    padding-left: 8px;
    padding-right: 8px;
}
.col-third {
    width: 33.33333%;
}
.col-full {
    width: 100%;
}
.col-half {
    width: 50%;
}
.mt-8 {
    margin-top: 8px !important;
}
.mt-16 {
    margin-top: 16px !important;}
.mt-32 {
    margin-top: 32px !important ;
}
/*main*/
#main {

}
#header {
    position: fixed;
    top: 0;
    left: 0;
    right: 0;
  ");
                WriteLiteral(@"  height: 46px;
    background-color:red;
    z-index: 1;
    
}
#nav {
    display: inline-block;
}
#nav, .subnav {
    list-style-type: none;

}
#nav > li {
    display:inline-block;
    
}
#nav li {
    position: relative;
}
#nav >li > a {
    color:#fff;
    text-transform: uppercase ;

}
#nav li a {
    color:#fff;
    text-decoration: none;
    line-height: 46px ;
    padding: 0 24px;
    display:block;
}
#nav li:hover .subnav {
    display: block;
}
#nav > li:hover > a,
#nav .subnav li:hover a {
      color:red;
      background-color: #ccc;
}
#nav .subnav {
   display:none;
   position: absolute;
   top: 100%;
   left: 0 ;
   min-width: 160px;
   background-color:red;
   box-shadow: 0 0 10px rgba(0, 0, 0, 0.3) ;
}
#nav.subnav a {
    color: red;
    padding: 0 12px;
    line-height: 38px;
}
#nav .nav-arrow-down {
    font-size: 10px;
}
#header .mobile-menu-btn {
    position: absolute;
    top: 0;
    right: 0;
    display: none
}
#header .");
                WriteLiteral(@"mobile-menu-btn,
#header .search-btn {
   float: right;
   padding: 0 21px;
}

#header .search-btn:hover {
    background-color:  #f44336; 
    cursor: pointer;
}
#header .mobile-menu-btn:hover {
    background-color:  #ccc; 
}
#header .mobile-menu-btn:hover .menu-icon {
     color: #000;
 }
#header .menu-icon,
#header .search-icon {
    color: #fff ;
    font-size: 20px;
    line-height: 46px;
}

#slider {
    position: relative;
  margin-top: 46px; 
  padding-top: 50%;
  background: url('/assets/img/slider/slide\ 1.jpg') top center / cover no-repeat ;
}
#slider .text-content {
    position: absolute;
    bottom: 47px;
    color: #fff;
    width: 100%;
    text-align: center;
}
#slider .text-heading{
  font-weight: 500;
  font-size: 24px;
}
#slider .text-description{
    font-size: 15px;
    margin-top: 25px;
}
#content {

}
#content .content-section{
    width: 800px;
    max-width: 100%;
    padding: 64px 0 112px;
    margin-left: auto;
    margin-right: ");
                WriteLiteral(@"auto;
    padding-left: 16px;
    padding-right: 16px;
}
#content .section-heading {
    font-size: 30px;
    font-weight: 500;
    letter-spacing: 4px;
}
#content .section-sub-heading{
    
    font-size: 15px ;
    margin-top: 25px;
    font style: italic;
    opacity: 0.6 ;
}
#content .section-heading,
#content .section-sub-heading {
    text-align: center;
}
#content .about-text{
    margin-top: 25px
    font-size: 15px ;
    text-align: justify;
    line-height: 1.4;
}
#content .member-list {
    margin-top: 32px;
}

#content .member-name{
      font-size: 15px;
      
}
#content .member-img{
    width: 154px;
    margin-top: 15px;
    border-radius: 4px;
}
/*tour section */
.tour-section {
    background-color: #000;
}
.tickets-list {
    background-color: #fff;
    margin-top: 40px;
    list-style: none;
}
.tickets-list li {
color: #757575;
font-size: 15px;
padding:  11px 16px;
border-bottom: 1px solid #ddd;
}
.tickets-list .sold-out {
    backgrou");
                WriteLiteral(@"nd-color: #f44336;
    color:#fff;
    padding: 3px 4px;
    margin-left: 16px;

}
.tickets-list .quantity {
    float: right;
    width: 24px;
    height: 24px;
    background-color: black;
    color: #fff;
    border-radius: 50%;
    text-align: center;
    line-height: 24px;
    margin-top: -3px;
}
/* Places*/

.places-list {
    
    
    margin-top: 16px;
   
}

.places-img {
 width: 100%;
 padding: 0  8px;
}
.places-body {
    padding: 16px;
    font-size: 15px;
    
background-color: #fff;

}
.places-heading {
    font-size: 15px;
    font-weight: 600;
}
.places-time {
    margin-top: 15px;
    color: #757575; ;
}
.places-desc {
    margin-top: 15px;
    line-height: 1.4;
}

/*contact form*/
.contact-content {
    margin-top: 48px;
}
.contact-info{
    font-size: 18px;
    line-height: 1.5;
}
.contact-info i[class*=""ti-""] {
    width: 30px;
    display: inline-block;
    line-height: 1.5;
}
.contact-form {
    font-size: 15px;
}

.conta");
                WriteLiteral(@"ct-form.form-control {
  padding: 10px;
  border: 1px solid #ccc;
  width: 100%;
}
/*map*/
.map-section img {
    width: 100%;
}

/*footer section*/
#footer {
  padding: 64px 16px;
  text-align: center;

}
#footer .social-list {
     font-size: 24px;
}
#footer .social-list a {
    text-decoration: none;
    color: rgba(0,0,0,0.6);
}
#footer .social-list a:hover {
    color: rgba(0,0,0,0.4);
}
#footer .copyright {
    margin-top: 15px;
    color: rgba(0,0,0,0.6);
}
#footer .copyright a {
    color: rgba(0,0,0,0.6);
}
.modal {
    position: fixed;
    top: 0;
    right: 0;
    bottom: 0;
    left: 0;
    background-color: rgba(0,0,0,0.4);
   
    align-items: center;
    justify-content: center;
    display: none ;
}
.modal.open {
    display: flex ;
}
.modal-container {
    background: #fff;
    width: 900px;
    max-width: calc(100% - 32px);
    min-height: 200px;
    position: relative;
    animation: modalFadeIn ease 0.5s;

}
.modal-header {
    back");
                WriteLiteral(@"ground: #009688;
    height: 130px;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 30px;
    color: #fff;
}
.modal-heading-icon {
    margin-right: 16px;
}
.modal-close {
    position: absolute;
    right: 0;
    top: 0;
    color: #fff;
    padding: 12px;
    cursor: pointer;
    opacity: 0.8;
}
.modal-close:hover {
    opacity: 1;
}
.modal-body {
    padding: 16px;
}
.modal-label {
    display: block;
    font-size: 15px;
    margin-bottom: 12px;
}
.modal-input {
    border: 1px solid #ccc;
    width: 100%;
    padding: 10px;
    font-size: 15px;
    margin-bottom: 24px;
}
#buy-tickets {
    background: #009688;
    border: none;
    color: #fff;
    width: 100%;
    font-size: 15px;
    text-transform: uppercase;
    padding: 18px;
    cursor: pointer;
}
#buy-tickets:hover {
    opacity: 0.9;
}
.modal-footer {
    padding: 16px;
    text-align: right;
   
}
.modal-footer a {
    color: #2196f3;
}


</style");
                WriteLiteral(@">


    <script>
        var header = document.getElementById('header');
        var moblieMenu = document.getElementById('mobile-menu');
        var headerHeight = header.clientHeight ;

        // Đong mở moble menu 
        moblieMenu.onclick=function() {
            var isClosed = header. clientHeight === headerHeight;
            if(isClosed) {
                header.style.height = 'auto';
            } else{
                header.style.height = null;
            }
        }
        // tự động đóng khi chọn menu 
        var menuItems = document.querySelectorAll('#nav li a[href*=""#""]');
        for (var i=0; i < menuItems.length; i++) {
            var menuItems = menuItems[i];
           
            
            menuItems.onclick = function() {
                var isParentMenu = this.nextElementSibling &&  menuItem.nextElementSibling.classList.contains('subnav');
                if (!isParentMenu) {
                header.style.height = null; }
            }
        }
    ");
                WriteLiteral(@"</script>
    <script>
        const  buyBtns = document.querySelectorAll('.js-buy-ticket')
        const  modal = document.querySelector('.js-modal')
        const  modalClose = document.querySelector('.js-modal-close')
        const modalContainer = document.querySelector('.js-modal-container')
      
        function showBuyTickets() {
         modal.classList.add('open')
       }
        
       function hideBuyTickets() {
         modal.classList.remove('open')
       }
        
        for(const buyBtn of buyBtns) {
            buyBtn.addEventListener('click',showBuyTickets)
        }

        modalClose.addEventListener('click',hideBuyTickets)
        modal.addEventListener('click',hideBuyTickets)
        modalContainer.addEventListener('click',function(even){
            event.stopPropagation()
        })
    </script>



");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<vroom2.Models.Model>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591