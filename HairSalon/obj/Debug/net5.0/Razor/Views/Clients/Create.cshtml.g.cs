#pragma checksum "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a74da1b351e788d546fcea70f361a20192d0cd0f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clients_Create), @"mvc.1.0.view", @"/Views/Clients/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a74da1b351e788d546fcea70f361a20192d0cd0f", @"/Views/Clients/Create.cshtml")]
    public class Views_Clients_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HairSalon.Models.Client>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h3>Add a New Client</h3>\n<br>\n\n");
#nullable restore
#line 10 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Client Name:</h4>\n");
#nullable restore
#line 13 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.ClientName, new { @class = "form-control", @required = "required" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.TextBoxFor(model => model.ClientDetails, new { @class = "form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Stylist:</h4>\n");
#nullable restore
#line 17 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
Write(Html.DropDownList("StylistId", null, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <br>\n  <input type=\"submit\" value=\"Add New Client\"/>\n");
#nullable restore
#line 20 "/Users/nickhennessy/Desktop/HairSalon.Solution/HairSalon/Views/Clients/Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HairSalon.Models.Client> Html { get; private set; }
    }
}
#pragma warning restore 1591
