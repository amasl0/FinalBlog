#pragma checksum "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d7bb150ccfa401f3df28ac21f4e97725b8ef6d0e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Editor), @"mvc.1.0.view", @"/Views/Home/Editor.cshtml")]
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
#line 1 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\_ViewImports.cshtml"
using FinalBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\_ViewImports.cshtml"
using FinalBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d7bb150ccfa401f3df28ac21f4e97725b8ef6d0e", @"/Views/Home/Editor.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee43d60ae1ce3e22293700c4355eabeabf7f7025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Editor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalBlog.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml"
  
    ViewData["Title"] = "Editor";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Body", async() => {
                WriteLiteral("\r\n    <div class=\"panel-heading\">\r\n    <h1 style=\"margin-left: 15%; margin-right: 15%;\">Редактирование поста</h1>\r\n</div>\r\n<div class=\"panel-body\">\r\n");
#nullable restore
#line 16 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml"
     using (Html.BeginForm("AuthorizationEdit", "Home"))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("      <div  style=\"margin-left: 15%; margin-right: 15%;\">\r\n        <div class=\"form-group\">\r\n            <label>Имя</label>\r\n            ");
#nullable restore
#line 21 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml"
       Write(Html.TextBoxFor(m => m.Author, new { @class = "form-control", @style = "width: 50%;"}));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            <label>Пароль для редактирования</label>\r\n            ");
#nullable restore
#line 25 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml"
       Write(Html.TextBoxFor(m => m.Password, new { @class = "form-control", @style = "width: 50%;" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n        </div>\r\n\r\n\r\n        <button type=\"submit\" class=\"btn btn-primary\">Войти</button>\r\n      </div>\r\n");
#nullable restore
#line 31 "C:\Users\donss\Desktop\Job\FinalBlog\FinalBlog\Views\Home\Editor.cshtml"
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FinalBlog.Models.Post> Html { get; private set; }
    }
}
#pragma warning restore 1591
