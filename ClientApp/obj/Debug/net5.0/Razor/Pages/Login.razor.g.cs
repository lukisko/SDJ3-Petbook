#pragma checksum "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "183afad68a9246121024939f47859a1face2ed6a"
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
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "min-h-full flex  items-center justify-center py-12 px-4 sm:px-6 lg:px-8 rounded-xl");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "w-auto space-y-7  ");
            __builder.AddMarkupContent(4, "<div><img class=\"mx-auto h-38 w-auto\" src=\"Images/Logo1.png\" alt=\"PetBook Logo\">\r\n            <h2 class=\"mt-1 text-center text-3xl font-bold text-gray-500\">\r\n                Log in to your account\r\n            </h2></div>\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(5);
            __builder.AddAttribute(6, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 17 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                          _userController

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 17 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                            LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", " shadow-sm space-y-px  ");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "flex flex-col space-y-2 rounded-xl");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(13);
                __builder2.AddAttribute(14, "class", "rounded-xl  relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm");
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "required", true);
                __builder2.AddAttribute(17, "placeholder", "Email");
                __builder2.AddAttribute(18, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                                                                           Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(19, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email))));
                __builder2.AddAttribute(20, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(21, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "class", "rounded-xl  relative block w-full px-3 py-2 border border-gray-300 placeholder-gray-500 text-gray-900  focus:outline-none focus:ring-indigo-500 focus:border-indigo-500 focus:z-10 sm:text-sm");
                __builder2.AddAttribute(24, "type", "text");
                __builder2.AddAttribute(25, "required", true);
                __builder2.AddAttribute(26, "placeholder", "Confirmation Code");
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 21 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                                                                                       _confirmationCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _confirmationCode = __value, _confirmationCode))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _confirmationCode));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(31);
                __builder2.CloseComponent();
                __builder2.AddContent(32, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(33);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(34, "\r\n            ");
                __builder2.OpenElement(35, "div");
                __builder2.AddAttribute(36, "class", "text-red-500 text-center");
                __builder2.AddContent(37, 
#nullable restore
#line 25 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                   _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(38, "\r\n            ");
                __builder2.OpenElement(39, "div");
                __builder2.AddAttribute(40, "class", "flex flex-row mt-4 space-x-4 ");
                __builder2.AddMarkupContent(41, "<button class=\"bg-pink-200 w-full py-1  rounded-xl hover:bg-pink-400    focus:outline-none transition duration-500 ease-in-out  transform hover:-translate-x hover:scale-80\" type=\"submit\">Log in</button>\r\n                ");
                __builder2.OpenElement(42, "button");
                __builder2.AddAttribute(43, "class", "bg-white w-full py-1  rounded-xl hover:bg-gray-300   focus:outline-none transition duration-500 ease-in-out  transform hover:-translate-x hover:scale-80");
                __builder2.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 28 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                   () => ShowRegister()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(45, "Sign up");
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService _modalService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserController _userController { get; set; }
    }
}
#pragma warning restore 1591
