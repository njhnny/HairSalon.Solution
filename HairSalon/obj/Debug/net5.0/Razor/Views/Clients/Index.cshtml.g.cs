#pragma checksum "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "249a581988679a275cb5091b8e1bf92b8476ea86"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Index), @"mvc.1.0.view", @"/Views/Clients/Index.cshtml")]
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
#line 5 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
using HairSalon.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"249a581988679a275cb5091b8e1bf92b8476ea86", @"/Views/Clients/Index.cshtml")]
    public class Views_Clients_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HairSalon.Models.Client>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>All Clients</h1>\n<hr>\n\n");
#nullable restore
#line 11 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No clients have been added</h3>\n");
#nullable restore
#line 14 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 16 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 foreach (Client client in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 18 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
 Write(Html.ActionLink($"{client.ClientName}", "Details", new { id = client.ClientId }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" | </li>\n");
#nullable restore
#line 19 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 20 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HairSalon.Models.Client>> Html { get; private set; }
    }
}
#pragma warning restore 1591
