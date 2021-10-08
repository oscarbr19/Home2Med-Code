#pragma checksum "F:\Home2Med\clone\Home2Med-Code\Client\Pages\PageEps\CreatePatient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63091f939d43955216609652adcf98ef95b65485"
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
#line 1 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Shared.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "F:\Home2Med\clone\Home2Med-Code\Client\_Imports.razor"
using Home2Med.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eps/createpatient")]
    public partial class CreatePatient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<nav class=\"navbar navbar-expand-sm navbar-h2m bg-prima \" mb-3><div class=\"container\"><a class=\"navbar-brand\" href=\"#\">E P S - Creación Paciente</a></div></nav>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row justify-content-center align-items-center");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "jumbotron col-8");
            __builder.AddMarkupContent(5, "<div class=\"form-group ml-4 mb-2 col-11\"><p class=\"mb-0\"><strong>Nombres y Apellidos</strong></p>\r\n         <input type=\"text\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresar Nombres y Apellidos\"></div>\r\n      ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "row");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "form-group ml-5 mb-2 col-5");
            __builder.AddMarkupContent(10, "<p class=\"mb-0\"><strong>Tipo Documento</strong></p>\r\n            ");
            __builder.OpenElement(11, "select");
            __builder.AddAttribute(12, "class", "form-control");
            __builder.OpenElement(13, "option");
            __builder.AddAttribute(14, "value", "0");
            __builder.AddContent(15, "Selecciona un Tipo Documento");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n               ");
            __builder.OpenElement(17, "option");
            __builder.AddAttribute(18, "value", "1");
            __builder.AddMarkupContent(19, "Cédula de Ciudadanía");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n               ");
            __builder.OpenElement(21, "option");
            __builder.AddAttribute(22, "value", "2");
            __builder.AddMarkupContent(23, "Cédula de Extranjería");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n               ");
            __builder.OpenElement(25, "option");
            __builder.AddAttribute(26, "value", "3");
            __builder.AddContent(27, "Pasaporte");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n         ");
            __builder.AddMarkupContent(29, "<div class=\"form-group ml-1 mb-2 col-5\"><p class=\"mb-0\"><strong>Número de Documento</strong></p>\r\n            <input type=\"text\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresar Número de Documento\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n\r\n      ");
            __builder.OpenElement(31, "div");
            __builder.AddAttribute(32, "class", "row");
            __builder.OpenElement(33, "div");
            __builder.AddAttribute(34, "class", "form-group ml-5 mb-2 col-5");
            __builder.AddMarkupContent(35, "<p class=\"mb-0\"><strong>Genero</strong></p>\r\n            ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "class", "form-control");
            __builder.OpenElement(38, "option");
            __builder.AddAttribute(39, "value", "0");
            __builder.AddContent(40, "Selecciona Genero");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n               ");
            __builder.OpenElement(42, "option");
            __builder.AddAttribute(43, "value", "1");
            __builder.AddContent(44, "Femenino");
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n               ");
            __builder.OpenElement(46, "option");
            __builder.AddAttribute(47, "value", "2");
            __builder.AddContent(48, "Masculino");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n         ");
            __builder.AddMarkupContent(50, "<div class=\"form-group ml-1 mb-2 col-5\"><p class=\"mb-0\"><strong>Número de Contacto</strong></p>\r\n            <input type=\"text\" class=\"form-control\" id=\"patient_name\" placeholder=\"Ingresar Número de Contacto\"></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n\r\n      ");
            __builder.AddMarkupContent(52, @"<div class=""row""><div class=""form-group ml-5 mb-2 col-5""><p class=""mb-0""><strong>Dirección de Residencia</strong></p>
            <input type=""text"" class=""form-control"" id=""patient_name"" placeholder=""Ingresar Dirección de Residencia""></div>
         <div class=""form-group ml-1 mb-2 col-5""><p class=""mb-0""><strong>Georeferenciación</strong></p>
            <input type=""text"" class=""form-control"" id=""patient_name"" placeholder=""Ingresar Georeferenciación""></div></div>

      ");
            __builder.OpenElement(53, "div");
            __builder.AddAttribute(54, "class", "row");
            __builder.OpenElement(55, "div");
            __builder.AddAttribute(56, "class", "form-group ml-5 mb-2 col-5");
            __builder.AddMarkupContent(57, "<p class=\"mb-0\"><strong>Diagnóstico</strong></p>\r\n            ");
            __builder.OpenElement(58, "select");
            __builder.AddAttribute(59, "class", "form-control");
            __builder.OpenElement(60, "option");
            __builder.AddAttribute(61, "value", "0");
            __builder.AddMarkupContent(62, "Selecciona un Diagnóstico");
            __builder.CloseElement();
            __builder.AddMarkupContent(63, "\r\n               ");
            __builder.OpenElement(64, "option");
            __builder.AddAttribute(65, "value", "1");
            __builder.AddContent(66, "Enfermedad 1");
            __builder.CloseElement();
            __builder.AddMarkupContent(67, "\r\n               ");
            __builder.OpenElement(68, "option");
            __builder.AddAttribute(69, "value", "2");
            __builder.AddContent(70, "Enfermedad 2");
            __builder.CloseElement();
            __builder.AddMarkupContent(71, "\r\n               ");
            __builder.OpenElement(72, "option");
            __builder.AddAttribute(73, "value", "3");
            __builder.AddContent(74, "Enfermedad 3");
            __builder.CloseElement();
            __builder.AddMarkupContent(75, "\r\n               ");
            __builder.OpenElement(76, "option");
            __builder.AddAttribute(77, "value", "4");
            __builder.AddContent(78, "Enfermedad 4");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(79, "\r\n         ");
            __builder.OpenElement(80, "div");
            __builder.AddAttribute(81, "class", "form-group ml-1 mb-2 col-5");
            __builder.AddMarkupContent(82, "<p class=\"mb-0\"><strong>Médico Tratante</strong></p>\r\n            ");
            __builder.OpenElement(83, "select");
            __builder.AddAttribute(84, "class", "form-control");
            __builder.OpenElement(85, "option");
            __builder.AddAttribute(86, "value", "0");
            __builder.AddMarkupContent(87, "Selecciona un Médico Tratante");
            __builder.CloseElement();
            __builder.AddMarkupContent(88, "\r\n               ");
            __builder.OpenElement(89, "option");
            __builder.AddAttribute(90, "value", "1");
            __builder.AddMarkupContent(91, "Médico 1");
            __builder.CloseElement();
            __builder.AddMarkupContent(92, "\r\n               ");
            __builder.OpenElement(93, "option");
            __builder.AddAttribute(94, "value", "2");
            __builder.AddMarkupContent(95, "Médico 2");
            __builder.CloseElement();
            __builder.AddMarkupContent(96, "\r\n               ");
            __builder.OpenElement(97, "option");
            __builder.AddAttribute(98, "value", "3");
            __builder.AddMarkupContent(99, "Médico 3");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n               ");
            __builder.OpenElement(101, "option");
            __builder.AddAttribute(102, "value", "4");
            __builder.AddMarkupContent(103, "Médico 4");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(104, "\r\n      ");
            __builder.AddMarkupContent(105, "<div><button type=\"button\" class=\"btn btn-success mt-4 mb-2 ml-5\">Guardar</button> \r\n         <button type=\"button\" class=\"btn btn-danger mt-4 mb-2 ml-3\">Limpiar campos</button></div>");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
