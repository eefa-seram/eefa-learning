#pragma checksum "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d4214b602b328c0321ff59433d4d07d793b4b812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Index), @"mvc.1.0.view", @"/Views/User/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/User/Index.cshtml", typeof(AspNetCore.Views_User_Index))]
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
#line 1 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2;

#line default
#line hidden
#line 2 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\_ViewImports.cshtml"
using WebApplication2.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d4214b602b328c0321ff59433d4d07d793b4b812", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b36aee4455a440795f240a74431c307640c545e", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebApplication2.Models.ViewModels.UserListViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(73, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(163, 126, true);
            WriteLiteral("<hr />\r\n<h1>لیست کاربران </h1>\r\n\r\n<hr />\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(290, 38, false);
#line 15 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Id));

#line default
#line hidden
            EndContext();
            BeginContext(328, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(384, 41, false);
#line 18 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
            EndContext();
            BeginContext(425, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 24 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(560, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(621, 37, false);
#line 28 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Id));

#line default
#line hidden
            EndContext();
            BeginContext(658, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(726, 40, false);
#line 31 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
            EndContext();
            BeginContext(766, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
            BeginContext(911, 24, true);
            WriteLiteral("\r\n                    <a");
            EndContext();
            BeginWriteAttribute("onclick", " onclick=\"", 935, "\"", 968, 3);
            WriteAttributeValue("", 945, "GetUserInfo(\'", 945, 13, true);
#line 36 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
WriteAttributeValue("", 958, item.Id, 958, 8, false);

#line default
#line hidden
            WriteAttributeValue("", 966, "\')", 966, 2, true);
            EndWriteAttribute();
            BeginContext(969, 92, true);
            WriteLiteral(" class=\"btn btn-info\"> مشاهده جزئیات بیشتر </a>\r\n                 </td>\r\n            </tr>\r\n");
            EndContext();
#line 39 "D:\amozesh\asp\projhe\eefa-seram\2609\WebApplication2\Views\User\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1072, 934, true);
            WriteLiteral(@"    </tbody>
</table>







<!-- Modal -->
<div class=""modal fade"" id=""DetailModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLongTitle"" aria-hidden=""true"">
    <div class=""modal-dialog"" role=""document"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"">اطلاعات بیشتر از کاربر</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                 <div id=""UserInfo"">

                 </div>
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">بستن</button>

            </div>
        </div>
    </div>
</div>



");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(2025, 191, true);
                WriteLiteral("\r\n <script>\r\n\r\n     function GetUserInfo(UserId) {\r\n         $(\"#UserInfo\").load(\"/User/UserDetailViewComponent/\" + UserId);\r\n         $(\"#DetailModal\").modal(\"show\");\r\n     }\r\n\r\n </script>\r\n");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebApplication2.Models.ViewModels.UserListViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
