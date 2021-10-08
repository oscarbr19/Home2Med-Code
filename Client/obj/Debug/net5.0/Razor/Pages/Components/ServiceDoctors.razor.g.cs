#pragma checksum "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ffce82d56f9c935d5b3882196500a594b49cdccf"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.Components
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Home2Med\Home2Med-Code-1\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
    public partial class ServiceDoctors : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style type=""text/css"">
   .bg-prima {
      background-color: #b9e6eb !important
   }

   .bg-h2m {
      background-color: #87e6a7 !important
   }

   .jumbotron1 {
      padding: 2rem 1rem;
      margin-bottom: 2rem;
      background-color: #DFDFDF;
       !important border-radius: .3rem
   }
</style>


");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "jumbotron1 col-8");
            __builder.AddMarkupContent(3, "<div class=\"container\"></div>\r\n   ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "row mb-3");
#nullable restore
#line 23 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
       foreach (var doctor in Doctors)
      {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-md-4");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card flex-md-row mb-4 box-shadow h-md-300");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", "card-body d-flex flex-column align-items-start bg-h2m");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "card h-100");
            __builder.OpenElement(14, "img");
            __builder.AddAttribute(15, "src", 
#nullable restore
#line 29 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
                                doctor.Photo

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(16, "class", "img-thumbnail card-img-top");
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                     ");
            __builder.OpenElement(18, "div");
            __builder.AddAttribute(19, "class", "card-body");
            __builder.OpenElement(20, "h6");
            __builder.AddAttribute(21, "class", "card-title");
            __builder.AddContent(22, 
#nullable restore
#line 31 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
                                                doctor.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n                        ");
            __builder.OpenElement(24, "p");
            __builder.AddAttribute(25, "class", "text-muted");
            __builder.AddContent(26, 
#nullable restore
#line 33 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
                            doctor.DocumentType

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(27, "\r\n                           <br>\r\n                           ");
            __builder.OpenElement(28, "small");
            __builder.AddContent(29, 
#nullable restore
#line 35 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
                                   doctor.Document

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 42 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
      }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "F:\Home2Med\Home2Med-Code-1\Client\Pages\Components\ServiceDoctors.razor"
       
   [Parameter] public List<Doctor> Doctors { get; set; }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591