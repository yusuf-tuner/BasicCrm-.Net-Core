#pragma checksum "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdbd92884037ae2e8f9398cce52a35026a89c00a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdbd92884037ae2e8f9398cce52a35026a89c00a", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<h2>Müşterilerin Detaylı Bilgieri</h2>


<div>
	<table class=""table table-bordered "">
		<thead>
		<tr>
			<th scope=""col"">Müşteri Sıra No</th>
			<th scope=""col"">Müsteri ID</th>
			<th scope=""col"">Müşteri Ad</th>
			<th scope=""col"">Müşteri Soyad</th>
			<th scope=""col"">Yaş</th>
			<th scope=""col"">Cinsiyet</th>
			<th scope=""col"">Adres</th>
		</tr>
		</thead>
		<tbody>

");
#nullable restore
#line 23 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
           int sirano = 0;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 25 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
         foreach (var x in Model)
		{
			sirano++;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th>");
#nullable restore
#line 29 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(sirano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 30 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(x.customerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<td>");
#nullable restore
#line 31 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(x.customerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 32 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(x.customerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 33 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(x.customerAge);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 34 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(x.customerGender);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 35 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
               Write(x.customerAdress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 37 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Details.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</tbody>\r\n\r\n\t</table>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591