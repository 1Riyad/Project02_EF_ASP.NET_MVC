#pragma checksum "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/Project02_EF_ASP.NET_MVC/GameOnTheHouse/Views/User/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32aa0c75be9b926437b2c3818ddb628947cce751"
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
#line 1 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/Project02_EF_ASP.NET_MVC/GameOnTheHouse/Views/_ViewImports.cshtml"
using GameOnTheHouse;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/Project02_EF_ASP.NET_MVC/GameOnTheHouse/Views/_ViewImports.cshtml"
using GameOnTheHouse.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32aa0c75be9b926437b2c3818ddb628947cce751", @"/Views/User/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"67c24050a6031b8cbb0ef796d4f717127732d7eb", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/Project02_EF_ASP.NET_MVC/GameOnTheHouse/Views/User/Index.cshtml"
  
    var userImage = (string)ViewData["img"];
    var color = (string)ViewData["color"];


#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div>\n\n<img");
            BeginWriteAttribute("src", " src=", 107, "", 122, 1);
#nullable restore
#line 10 "/Users/riyadalghamdi/Desktop/TuwaiqBootcamp/Tuwaiq-ASPnet/projects/Project02_EF_ASP.NET_MVC/GameOnTheHouse/Views/User/Index.cshtml"
WriteAttributeValue("", 112, userImage, 112, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
