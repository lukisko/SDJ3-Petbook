#pragma checksum "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6190e17bfc2db5033c392ef811e7841f5ca5efa8"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 5 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
 if (toShowPets == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(0, "<p>No pets found</p>");
#nullable restore
#line 8 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
}
else
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
   foreach (var item in toShowPets)
  {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "container flex flex-wrap pt-4 pb-10 m-auto mt-6 md:mt-15 lg:px-12 xl:px-16");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "w-full px-0 lg:px-4");
            __builder.AddMarkupContent(5, "<h2 class=\"px-12 text-base font-bold text-center md:text-2xl text-pink-700\"></h2>\r\n\r\n        ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "flex flex-wrap items-center justify-center py-4 pt-0");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "w-full p-4 md:w-1/2 lg:w-1/4 plan-card");
            __builder.OpenElement(10, "label");
            __builder.AddAttribute(11, "class", "flex flex-col rounded-lg shadow-lg group relative cursor-pointer hover:shadow-2xl");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "w-full px-4 py-6 rounded-t-lg card-section-1");
            __builder.OpenElement(14, "h3");
            __builder.AddAttribute(15, "class", "mx-auto text-base font-semibold text-center underline text-pink-500 group-hover:text-blue");
            __builder.AddMarkupContent(16, "\r\n                  Type: ");
            __builder.AddContent(17, 
#nullable restore
#line 24 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
                         item.Type

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "p");
            __builder.AddAttribute(20, "class", "text-5xl font-bold text-center group-hover:text-blue text-pink-500");
            __builder.AddMarkupContent(21, "\r\n                  Name: ");
            __builder.AddContent(22, 
#nullable restore
#line 27 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
                         item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(23, " <span class=\"text-3xl\"></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "p");
            __builder.AddAttribute(26, "class", "text-xs text-center uppercase group-hover:text-blue text-pink-500");
            __builder.AddMarkupContent(27, "\r\n                  Breed: ");
            __builder.AddContent(28, 
#nullable restore
#line 30 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
                          item.Breed

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n              ");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "flex flex-col items-center justify-center w-full h-full py-6 rounded-b-lg bg-pink-500");
            __builder.OpenElement(32, "p");
            __builder.AddAttribute(33, "class", "text-xl text-white");
            __builder.AddMarkupContent(34, "\r\n                  Description: ");
            __builder.AddContent(35, 
#nullable restore
#line 36 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
                                item.Description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "w-5/6 py-2 mt-2 font-semibold text-center uppercase bg-white border border-transparent rounded text-pink-500");
            __builder.AddMarkupContent(39, "\r\n                  Adopt ");
            __builder.AddContent(40, 
#nullable restore
#line 39 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
                         item.Status

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
#line 48 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
   }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\Index.razor"
     
  }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPetController _petController { get; set; }
    }
}
#pragma warning restore 1591
