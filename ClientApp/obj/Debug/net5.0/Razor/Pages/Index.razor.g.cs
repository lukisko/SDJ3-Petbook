#pragma checksum "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e5e9aa4f180a5c0c1263d01e09d26b292c35c0d"
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
#line 1 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Blazored;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
using business_logic.Model;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Pet book</h1>\r\n\r\n\r\n");
            __builder.OpenElement(1, "a");
            __builder.AddAttribute(2, "class", "btn btn-success mb-2");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
                                          ()=>NavigateToAddPet()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Add Pet");
            __builder.CloseElement();
#nullable restore
#line 9 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
 if (toShowPets == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(5, "<p>No pets found</p>");
#nullable restore
#line 12 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(6, "table");
            __builder.AddAttribute(7, "class", "table");
            __builder.AddMarkupContent(8, "<thead class=\"table-primary\"><tr><th>Id</th>\r\n            <th>Name</th>\r\n            <th>Type</th>\r\n            <th>Breed</th>\r\n            <th>Description</th></tr></thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
#nullable restore
#line 26 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
         foreach (var item in toShowPets)
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(10, "tr");
            __builder.OpenElement(11, "td");
#nullable restore
#line 29 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
__builder.AddContent(12, item.id);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "td");
#nullable restore
#line 30 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
__builder.AddContent(15, item.name);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
#nullable restore
#line 31 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
__builder.AddContent(18, item.type);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
#nullable restore
#line 32 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
__builder.AddContent(21, item.breed);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                ");
            __builder.OpenElement(23, "td");
#nullable restore
#line 33 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
__builder.AddContent(24, item.description);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 35 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 38 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Index.razor"
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
