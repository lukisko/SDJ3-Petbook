#pragma checksum "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbb5465195739ea9968b91365a88ec56faccc80d"
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
#line 1 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using ClientApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using ClientApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/_Imports.razor"
using ClientApp.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 4 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                 _userController

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 4 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                                              LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(3, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(4);
                __builder2.CloseComponent();
                __builder2.AddContent(5, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\n    ");
                __builder2.AddMarkupContent(8, "<label>Email</label>\n    <br>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(9);
                __builder2.AddAttribute(10, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 7 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                                 Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(11, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email))));
                __builder2.AddAttribute(12, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\n    ");
                __builder2.AddMarkupContent(14, "<label>Code</label>\n    <br>");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 9 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                                 _confirmationCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(17, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _confirmationCode = __value, _confirmationCode))));
                __builder2.AddAttribute(18, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _confirmationCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(19, "\n    <br>");
                __builder2.OpenElement(20, "label");
                __builder2.AddAttribute(21, "style", "text-decoration-color: red");
                __builder2.AddContent(22, 
#nullable restore
#line 10 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                                                    _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(23, "\n\n    ");
                __builder2.AddMarkupContent(24, "<button class=\"btn btn-primary\" type=\"submit\">Login</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(25, "\n\n\n\n");
            __builder.OpenElement(26, "div");
            __builder.AddAttribute(27, "class", "flex items-center justify-center h-screen");
            __builder.OpenElement(28, "div");
            __builder.AddAttribute(29, "class", "bg-pink-900 flex flex-col w-80 border border-gray-900 rounded-lg px-8 py-10");
            __builder.AddMarkupContent(30, "<div class=\"text-white mt-10\"><h1 class=\"font-bold text-4xl\">Welcome</h1>\n    <p class=\"font-semibold\">Here you can request for code to recieve on your email threw which you can log in</p></div>\n  ");
            __builder.OpenElement(31, "form");
            __builder.AddAttribute(32, "class", "flex flex-col space-y-8 mt-10");
            __builder.OpenElement(33, "input");
            __builder.AddAttribute(34, "type", "text");
            __builder.AddAttribute(35, "placeholder", "Email");
            __builder.AddAttribute(36, "class", "border rounded-lg py-3 px-3 bg-white border-gray-700 placeholder-gray-500");
            __builder.AddAttribute(37, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 24 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                         Email

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => Email = __value, Email));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\n    ");
            __builder.OpenElement(40, "button");
            __builder.AddAttribute(41, "class", "border border-white bg-red-100 text-pink-900 rounded-lg py-3 font-semibold");
            __builder.AddAttribute(42, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/run/media/lukisko/Windows-SSD/VIA/SEMESTER3/SEP3/Project-SDJ3/ClientApp/Pages/Login.razor"
                                                                                                         LoginUser

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(43, "request code");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserController _userController { get; set; }
    }
}
#pragma warning restore 1591
