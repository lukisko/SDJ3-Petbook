#pragma checksum "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bc1ca1c8a3545840c0dd7c7dbfcc92ae65a3a233"
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "button");
            __builder.AddAttribute(1, "class", "navbar-toggler");
            __builder.AddAttribute(2, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 1 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "b-3dzslfjxd2");
            __builder.AddMarkupContent(4, "<span class=\"navbar-toggler-icon\" b-3dzslfjxd2></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n    ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "flex");
            __builder.AddAttribute(8, "style", "margin-top: -30px;");
            __builder.AddAttribute(9, "b-3dzslfjxd2");
            __builder.OpenElement(10, "section");
            __builder.AddAttribute(11, "class", "relative mx-auto");
            __builder.AddAttribute(12, "b-3dzslfjxd2");
            __builder.OpenElement(13, "nav");
            __builder.AddAttribute(14, "class", "flex justify-between bg-pink-900 text-white w-screen");
            __builder.AddAttribute(15, "b-3dzslfjxd2");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", " flex w-full items-center");
            __builder.AddAttribute(18, "b-3dzslfjxd2");
            __builder.AddMarkupContent(19, "<a class=\"text-3xl font-bold font-heading\" href=\"/\" b-3dzslfjxd2><img class=\"h-9 ml-3 mt-3\" src=\"Images/Logo1.png\" style=\"height: 80px;\" alt=\"Petbook\" b-3dzslfjxd2></a>\r\n                    \r\n                    ");
            __builder.OpenElement(20, "ul");
            __builder.AddAttribute(21, "class", "hidden md:flex px-4 mx-auto font-semibold font-heading space-x-12");
            __builder.AddAttribute(22, "b-3dzslfjxd2");
            __builder.AddMarkupContent(23, "<li b-3dzslfjxd2><a class=\"hover:text-gray-200\" href b-3dzslfjxd2>Home</a></li>\r\n                        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(24);
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(26, "<li b-3dzslfjxd2><a class=\"hover:text-gray-200\" href=\"/AddPet\" b-3dzslfjxd2>Add Pet</a></li>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n                        ");
            __builder.AddMarkupContent(28, "<li b-3dzslfjxd2><a class=\"hover:text-gray-200\" href=\"/Login\" b-3dzslfjxd2>Login</a></li>\r\n                        ");
            __builder.AddMarkupContent(29, "<li b-3dzslfjxd2><a class=\"hover:text-gray-200\" href=\"/Register\" b-3dzslfjxd2>Register</a></li>");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                    \r\n                    ");
            __builder.AddMarkupContent(31, @"<div class=""hidden xl:flex items-center space-x-5 items-center"" b-3dzslfjxd2><a class=""hover:text-gray-200"" href=""#"" b-3dzslfjxd2><svg class=""h-6 w-6"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M4.318 6.318a4.5 4.5 0 000 6.364L12 20.364l7.682-7.682a4.5 4.5 0 00-6.364-6.364L12 7.636l-1.318-1.318a4.5 4.5 0 00-6.364 0z"" b-3dzslfjxd2></path></svg></a>
                        
                        <a class=""flex items-center hover:text-gray-200 mr-3"" href=""#"" b-3dzslfjxd2><svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6 hover:text-gray-200 mr-3"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M5.121 17.804A13.937 13.937 0 0112 16c2.5 0 4.847.655 6.879 1.804M15 10a3 3 0 11-6 0 3 3 0 016 0zm6 2a9 9 0 11-18 0 9 9 0 0118 0z"" b-3dzslfjxd2></path></svg></a></div>");
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                \r\n                ");
            __builder.AddMarkupContent(33, @"<a class=""xl:hidden flex mr-6 items-center"" href=""#"" b-3dzslfjxd2><svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6 hover:text-gray-200"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M3 3h2l.4 2M7 13h10l4-8H5.4M7 13L5.4 5M7 13l-2.293 2.293c-.63.63-.184 1.707.707 1.707H17m0 0a2 2 0 100 4 2 2 0 000-4zm-8 2a2 2 0 11-4 0 2 2 0 014 0z"" b-3dzslfjxd2></path></svg>
                    <span class=""flex absolute -mt-5 ml-4"" b-3dzslfjxd2><span class=""animate-ping absolute inline-flex h-3 w-3 rounded-full bg-pink-400 opacity-75"" b-3dzslfjxd2></span>
                        <span class=""relative inline-flex rounded-full h-3 w-3 bg-pink-500"" b-3dzslfjxd2></span></span></a>
                ");
            __builder.AddMarkupContent(34, @"<a class=""navbar-burger self-center mr-12 xl:hidden"" href=""#"" b-3dzslfjxd2><svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6 hover:text-gray-200"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M4 6h16M4 12h16M4 18h16"" b-3dzslfjxd2></path></svg></a>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 62 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
           
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
