#pragma checksum "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0e5a1388c61ef7072a4e93598c82ffa7dccdcc6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_SendToSpecificUser), @"mvc.1.0.view", @"/Views/Admin/SendToSpecificUser.cshtml")]
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
#line 1 "D:\Demo\SignalRDemo\Views\_ViewImports.cshtml"
using SignalRDemo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
using SignalRDemo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0e5a1388c61ef7072a4e93598c82ffa7dccdcc6", @"/Views/Admin/SendToSpecificUser.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c83d3ee8c6725bc2b4b6675479d0fb357d480512", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_SendToSpecificUser : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Article>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
  
    ViewData["Title"] = "SendToSpecificUser";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Index</h1>\r\n");
#nullable restore
#line 7 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
 using (Html.BeginForm("SendToSpecificUser", "Admin", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            User Id\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 14 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
       Write(Html.TextBoxFor(model => Model.userId, new { @maxlength = "50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            Article Heading\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 23 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
       Write(Html.TextBoxFor(model => Model.articleHeading, new { @maxlength = "50" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <br />\r\n    <div class=\"row\">\r\n        <div class=\"col-6\">\r\n            Article Content\r\n        </div>\r\n        <div class=\"col-6\">\r\n            ");
#nullable restore
#line 32 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
       Write(Html.TextBoxFor(model => Model.articleContent, new { @maxlength = "100" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n    <div>\r\n        <button type=\"submit\">Send to Specific User</button>\r\n    </div>\r\n");
#nullable restore
#line 38 "D:\Demo\SignalRDemo\Views\Admin\SendToSpecificUser.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Article> Html { get; private set; }
    }
}
#pragma warning restore 1591
