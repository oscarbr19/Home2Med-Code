#pragma checksum "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\EditNurse.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d4ab60be682b683b5630cc57459737d96e02b96"
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
#line 2 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\EditNurse.razor"
using Home2Med.Client.Pages.Components;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/editnurse")]
    public partial class EditNurse : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima mb-5\"><div class=\"container\"><a class=\"navbar-brand\" href=\"#\"><strong>EPS - Editar Enfermera</strong></a></div></nav>\r\n\r\n");
            __builder.OpenComponent<Home2Med.Client.Pages.Components.FormNurse>(1);
            __builder.AddAttribute(2, "Nurse", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Home2Med.Shared.Entity.Nurse>(
#nullable restore
#line 10 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\EditNurse.razor"
                    Nurse

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 10 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\EditNurse.razor"
                                          Edit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 12 "F:\ProysCicloIII\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\EditNurse.razor"
       

   [Parameter] public int Id { get; set; }
   public Nurse Nurse; 

   protected override void OnInitialized()
   {

       Nurse = new Nurse(){
      
         Id = 1,
         NurseName = "Piedad Piedras",
         NurseDocumentType = 1,
         NurseDocument = "12345689",
         NurseGender = 1,
         NursePhone = "3104789632",
         NurseSpeciality = 1,
         NursePhoto = "/Images/medicos/fotoe01.jpg",
         NurseStatus = true
     
       };

   }   

   private void Edit()
   {
      Console.WriteLine($"Editando Enfermera Id {Nurse.Id}");
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591