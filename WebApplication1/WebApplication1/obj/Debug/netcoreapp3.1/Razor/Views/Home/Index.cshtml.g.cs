#pragma checksum "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af942436525ecc4101e4ff573a4e9894954445c0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af942436525ecc4101e4ff573a4e9894954445c0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"729efaa87342638aecfe1a972ce9f9f8dff55b4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Basic Crm";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
	<table class=""table table-bordered "">
		<thead>
		<tr>
			<th scope=""col"">Müşteri Sıra No</th>
			<th scope=""col"">Müsteri ID</th>
			<th scope=""col"">Müşteri Ad</th>
			<th scope=""col"">Müşteri Soyad</th>

			<th scope=""col"">GÜNCELLE</th>
			<th scope=""col"">DETAY</th>
			<th scope=""col"">SİL</th>
		</tr>
		</thead>
		<tbody>
");
#nullable restore
#line 22 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
           int sirano = 0;

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
         foreach (var x in Model)
		{
			sirano++;

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t<tr>\r\n\t\t\t\t<th>");
#nullable restore
#line 27 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(sirano);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<th>");
#nullable restore
#line 28 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(x.customerID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n\t\t\t\t<td>");
#nullable restore
#line 29 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(x.customerName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\t\t\t\t<td>");
#nullable restore
#line 30 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
               Write(x.customerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 652, "\"", 693, 2);
            WriteAttributeValue("", 659, "/Home/customerUpdate/", 659, 21, true);
#nullable restore
#line 32 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 680, x.customerID, 680, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">GÜNCELLE</a></td>\r\n\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 748, "\"", 790, 2);
            WriteAttributeValue("", 755, "/Home/customerDetails/", 755, 22, true);
#nullable restore
#line 33 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 777, x.customerID, 777, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-info\">DETAY</a></td>\r\n\t\t\t\t<td><a");
            BeginWriteAttribute("href", " href=\"", 839, "\"", 880, 2);
            WriteAttributeValue("", 846, "/Home/CustomerDelete/", 846, 21, true);
#nullable restore
#line 34 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
WriteAttributeValue("", 867, x.customerID, 867, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">SİL</a></td>\r\n\t\t\t</tr>\r\n");
#nullable restore
#line 36 "C:\Users\tuneryusuf\source\project\WebApplication1\WebApplication1\Views\Home\Index.cshtml"
		}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</tbody>\r\n\r\n\t</table>\r\n</div>\r\n");
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