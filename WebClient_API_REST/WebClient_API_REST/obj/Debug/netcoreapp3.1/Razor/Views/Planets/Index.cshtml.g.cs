#pragma checksum "C:\Users\colin\Wild\C#\quests\WebClient_API_REST\WebClient_API_REST\Views\Planets\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ded0e832313649c880f9fb5a79b9107a50fb22f1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Planets_Index), @"mvc.1.0.view", @"/Views/Planets/Index.cshtml")]
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
#line 1 "C:\Users\colin\Wild\C#\quests\WebClient_API_REST\WebClient_API_REST\Views\_ViewImports.cshtml"
using WebClient_API_REST;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\colin\Wild\C#\quests\WebClient_API_REST\WebClient_API_REST\Views\_ViewImports.cshtml"
using WebClient_API_REST.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ded0e832313649c880f9fb5a79b9107a50fb22f1", @"/Views/Planets/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a27aab839a1a47f8fa54f64b99dae0d3ee89289a", @"/Views/_ViewImports.cshtml")]
    public class Views_Planets_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<PlanetsModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2 class=\"display-4\">Les planètes</h2>\r\n    <div class=\"container\">\r\n\r\n        <tr>\r\n            <td class=\"p-3\">\r\n                Name\r\n            </td>\r\n            <td class=\"p-3\">\r\n                ");
#nullable restore
#line 12 "C:\Users\colin\Wild\C#\quests\WebClient_API_REST\WebClient_API_REST\Views\Planets\Index.cshtml"
           Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n        </tr>\r\n        <tr>\r\n            <td class=\"p-3\">\r\n                Climate\r\n            </td>\r\n            <td class=\"p-3\">\r\n                ");
#nullable restore
#line 21 "C:\Users\colin\Wild\C#\quests\WebClient_API_REST\WebClient_API_REST\Views\Planets\Index.cshtml"
           Write(Model.Climate);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n        <tr>\r\n            <td class=\"p-3\">\r\n                Diameter\r\n            </td>\r\n            <td class=\"p-3\">\r\n                ");
#nullable restore
#line 29 "C:\Users\colin\Wild\C#\quests\WebClient_API_REST\WebClient_API_REST\Views\Planets\Index.cshtml"
           Write(Model.Diameter);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n</div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<PlanetsModel> Html { get; private set; }
    }
}
#pragma warning restore 1591