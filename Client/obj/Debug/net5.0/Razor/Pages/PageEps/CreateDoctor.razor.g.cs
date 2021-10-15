#pragma checksum "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "851f7b18204f8f837f6929a4048d0729c4f6ce87"
// <auto-generated/>
#pragma warning disable 1591
namespace Home2Med.Client.Pages.PageEps
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createdoctor")]
    public partial class CreateDoctor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima mb-5\"><div class=\"container\"><a class=\"navbar-brand\" href=\"#\"><strong>EPS - Crear Médico</strong></a></div></nav>\r\n\r\n");
            __builder.OpenComponent<Home2Med.Client.Pages.Components.FormDoctor>(1);
            __builder.AddAttribute(2, "Doctor", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Home2Med.Shared.Entity.Doctor>(
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
                      Doctor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
                                             Create

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreateDoctor.razor"
       
   private Doctor Doctor = new Doctor();
       private async Task Create(){
        var httpResponse = await doctor_i.Post("api/doctors", Doctor);
        if(httpResponse.Error){
           var body = await httpResponse.HttpResponseMessage.Content.ReadAsStringAsync();
         Console.WriteLine(body);
        }else{
            navigationManager.NavigateTo("/eps/createdoctor");
        }
         Console.WriteLine("Creando el Médico : ");
         Console.WriteLine($"Nombre {Doctor.Name}");
         Console.WriteLine($"Tipo de Documento {Doctor.DocumentType}");
         Console.WriteLine($"Documento {Doctor.Document}");
         Console.WriteLine($"Genero {Doctor.Gender}");
         Console.WriteLine($"Telefono {Doctor.Phone}");
         Console.WriteLine($"Especialidad {Doctor.Speciality}");
         Console.WriteLine($"Estado {Doctor.Status}");
   }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IServiceDoctor doctor_i { get; set; }
    }
}
#pragma warning restore 1591
