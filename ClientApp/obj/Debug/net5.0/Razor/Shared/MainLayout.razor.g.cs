#pragma checksum "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d10cb6e558289635f4df3c9262497649fb32e87"
// <auto-generated/>
#pragma warning disable 1591
namespace ClientApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-9hqbptr0vy");
            __builder.OpenComponent<ClientApp.Shared.NavMenu>(3);
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n    ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "main");
            __builder.AddAttribute(7, "b-9hqbptr0vy");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "top-row ");
            __builder.AddAttribute(10, "b-9hqbptr0vy");
            __builder.OpenElement(11, "Login");
            __builder.AddAttribute(12, "b-9hqbptr0vy");
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n            <a href=\"https://docs.microsoft.com/aspnet/\" target=\"_blank\" b-9hqbptr0vy></a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n\r\n         ");
            __builder.OpenElement(15, "div");
            __builder.AddAttribute(16, "class", "content px-4");
            __builder.AddAttribute(17, "b-9hqbptr0vy");
            __builder.AddContent(18, 
#nullable restore
#line 15 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\MainLayout.razor"
 
    [CascadingParameter] protected Task<AuthenticationState>AuthStat { get; set; }

    protected async override Task OnInitializedAsync()
    {
        base.OnInitialized();
        var user = (await AuthStat).User;
        // if(!user.Identity.IsAuthenticated)
        //     NavigationManager.NavigateTo($"/Login");
    //   NavigatonManager:NavigateTo($"/Login?returnUrl={Uri.EscapeDataString(NavigationManager: Uri)}");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
    }
}
#pragma warning restore 1591
