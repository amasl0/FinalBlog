#pragma checksum "C:\Users\donss\Desktop\FinalBlog\FinalBlog\Views\Home\Post.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff782727372a9ef4ab903d283f3fa2ecf0da11f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Post), @"mvc.1.0.view", @"/Views/Home/Post.cshtml")]
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
#line 1 "C:\Users\donss\Desktop\FinalBlog\FinalBlog\Views\_ViewImports.cshtml"
using FinalBlog;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\donss\Desktop\FinalBlog\FinalBlog\Views\_ViewImports.cshtml"
using FinalBlog.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ff782727372a9ef4ab903d283f3fa2ecf0da11f1", @"/Views/Home/Post.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ee43d60ae1ce3e22293700c4355eabeabf7f7025", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Post : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FinalBlog.Models.Post>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
            }
            );
            WriteLiteral("\r\n");
            DefineSection("Body", async() => {
                WriteLiteral("\r\n    <div class=\"content\" style=\"margin-left: 15%; margin-right: 15%;\">\r\n        <div>\r\n            <h1>");
#nullable restore
#line 10 "C:\Users\donss\Desktop\FinalBlog\FinalBlog\Views\Home\Post.cshtml"
           Write(Model.Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h1>\r\n        </div>\r\n\r\n        <div align=\"justify\" style=\"font-family: \'Roboto\', sans-serif;\">\r\n            <h4><pre>");
#nullable restore
#line 14 "C:\Users\donss\Desktop\FinalBlog\FinalBlog\Views\Home\Post.cshtml"
                Write(Model.Description);

#line default
#line hidden
#nullable disable
                WriteLiteral("</pre></h4>\r\n        </div>\r\n        <div align=\"right\">\r\n            <h5>Автор: ");
#nullable restore
#line 17 "C:\Users\donss\Desktop\FinalBlog\FinalBlog\Views\Home\Post.cshtml"
                  Write(Model.Author);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</h5>
        </div>

        <div>
            <div id=""disqus_thread""></div>
                <script>

                (function() { // DON'T EDIT BELOW THIS LINE
                var d = document, s = d.createElement('script');
                s.src = 'https://final-8.disqus.com/embed.js';
                s.setAttribute('data-timestamp', +new Date());
                (d.head || d.body).appendChild(s);
                })();
                </script>
     
           </div>

    </div>
");
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
