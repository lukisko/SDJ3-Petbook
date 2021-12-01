#pragma checksum "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "137a607287d876209e4aa2066d271cf08eeec347"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/Login/{Email}")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 7 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
 if (ShowPopUpDialog)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "fixed z-10 inset-0 overflow-y-auto");
            __builder.AddAttribute(2, "aria-labelledby", "modal-title");
            __builder.AddAttribute(3, "role", "dialog");
            __builder.AddAttribute(4, "aria-modal", "true");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "flex items-end justify-center min-h-screen pt-4 px-4 pb-20 text-center sm:block sm:p-0");
            __builder.AddMarkupContent(7, "<div class=\"fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity\" aria-hidden=\"true\"></div>\r\n            \r\n            ");
            __builder.AddMarkupContent(8, "<span class=\"hidden sm:inline-block sm:align-middle sm:h-screen\" aria-hidden=\"true\">&#8203;</span>\r\n            ");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "inline-block align-bottom   rounded-lg text-left overflow-hidden shadow-xl transform transition-all sm:my-8 sm:align-middle sm:max-w-lg sm:w-full");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(11);
            __builder.AddAttribute(12, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                  _userController

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(13, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                    () => SendCode(Email)

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(14, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "bg-transparent h-screen flex flex-col sm:justify-center items-center");
                __builder2.OpenElement(17, "div");
                __builder2.AddAttribute(18, "class", "absolute sm:max-w-sm w-full");
                __builder2.OpenElement(19, "div");
                __builder2.AddAttribute(20, "class", "relative w-full rounded-3xl  px-6 py-4 bg-pink-900 hover:scale- ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "font-sans text-xl text-black-700 text-center");
                __builder2.AddMarkupContent(23, "<div class=\"block mt-3 mb-10 text-white font-bold text-2xl \">\r\n                                        Log In\r\n                                    </div>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "text-center mt-5 block w-full border-none bg-gray-50 h-11 rounded-xl shadow-lg hover:bg-pink-300 focus:bg-pink-100    focus:border-white");
                __builder2.AddAttribute(26, "type", "email");
                __builder2.AddAttribute(27, "placeholder", "Email");
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 23 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                              Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Email));
                __builder2.AddAttribute(31, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(32, 
#nullable restore
#line 23 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                                      Email

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(33, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(34);
                __builder2.CloseComponent();
                __builder2.AddContent(35, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(36);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(37, "\r\n                                    ");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "text-red-500 text-center");
                __builder2.AddContent(40, 
#nullable restore
#line 25 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                           _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(41, "\r\n                                    ");
                __builder2.AddMarkupContent(42, "<div class=\"flex flex-row\"><button class=\"bg-white w-full py-3 m-7 rounded-xl hover:bg-pink-300  shadow-xl  focus:outline-none transition duration-500 ease-in-out  transform hover:-translate-x hover:scale-80\" type=\"submit\">Send Code</button></div>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 37 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(43, "div");
            __builder.AddAttribute(44, "class", "fixed z-10 inset-0 overflow-y-auto");
            __builder.AddAttribute(45, "aria-labelledby", "modal-title");
            __builder.AddAttribute(46, "role", "dialog");
            __builder.AddAttribute(47, "aria-modal", "true");
            __builder.OpenElement(48, "div");
            __builder.AddAttribute(49, "class", "flex items-end justify-center min-h-screen pt-4 px-4 pb-20 text-center sm:block sm:p-0");
            __builder.AddMarkupContent(50, "<div class=\"fixed inset-0 bg-gray-500 bg-opacity-75 transition-opacity\" aria-hidden=\"true\"></div>\r\n            \r\n            ");
            __builder.AddMarkupContent(51, "<span class=\"hidden sm:inline-block sm:align-middle sm:h-screen\" aria-hidden=\"true\">&#8203;</span>\r\n            ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "class", "inline-block align-bottom   rounded-lg text-left overflow-hidden shadow-xl transform transition-all sm:my-8 sm:align-middle sm:max-w-lg sm:w-full");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(54);
            __builder.AddAttribute(55, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 46 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                  _userController

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(56, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 46 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                   LoginUser

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(58, "div");
                __builder2.AddAttribute(59, "class", "relative min-h-screen flex flex-col sm:justify-center items-center ");
                __builder2.OpenElement(60, "div");
                __builder2.AddAttribute(61, "class", "absolute sm:max-w-sm w-full");
                __builder2.OpenElement(62, "div");
                __builder2.AddAttribute(63, "class", "relative w-full rounded-3xl  px-6 py-4 bg-pink-900 hover:scale- ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "font-sans text-xl text-black-700 text-center");
                __builder2.AddMarkupContent(66, "<div class=\"block mt-3 mb-10 text-white font-bold text-2xl \">\r\n                                        Log In\r\n                                    </div>\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(67);
                __builder2.AddAttribute(68, "class", "text-center mt-5 block w-full border-none bg-gray-50 h-11 rounded-xl shadow-lg hover:bg-pink-300 focus:bg-pink-100    focus:border-white");
                __builder2.AddAttribute(69, "type", "email");
                __builder2.AddAttribute(70, "placeholder", "Email");
                __builder2.AddAttribute(71, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 54 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                              Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(72, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Email = __value, Email))));
                __builder2.AddAttribute(73, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Email));
                __builder2.AddAttribute(74, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(75, 
#nullable restore
#line 54 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                                      Email

#line default
#line hidden
#nullable disable
                    );
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(76, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(77);
                __builder2.AddAttribute(78, "class", "text-center mt-5 block w-full border-none bg-gray-50 h-11 rounded-xl shadow-lg hover:bg-pink-300 focus:bg-pink-100 focus:ring-0 focus:border-white");
                __builder2.AddAttribute(79, "type", "text");
                __builder2.AddAttribute(80, "placeholder", "Code");
                __builder2.AddAttribute(81, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 55 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                                      _confirmationCode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(82, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => _confirmationCode = __value, _confirmationCode))));
                __builder2.AddAttribute(83, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => _confirmationCode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(84, "\r\n                                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(85);
                __builder2.CloseComponent();
                __builder2.AddContent(86, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(87);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(88, "\r\n                                    ");
                __builder2.OpenElement(89, "div");
                __builder2.AddAttribute(90, "class", "text-red-500 text-center");
                __builder2.AddContent(91, 
#nullable restore
#line 57 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                           _errorMessage

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(92, "\r\n\r\n                                    ");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "flex flex-row");
                __builder2.AddMarkupContent(95, "<button class=\"bg-white w-full py-3 m-7 rounded-xl hover:bg-pink-300  shadow-xl  focus:outline-none transition duration-500 ease-in-out  transform hover:-translate-x hover:scale-80\" type=\"submit\">Log In</button>\r\n                                        ");
                __builder2.OpenElement(96, "button");
                __builder2.AddAttribute(97, "class", "bg-white w-full py-3 m-7 rounded-xl hover:bg-pink-300  shadow-xl  focus:outline-none transition duration-500 ease-in-out  transform hover:-translate-x hover:scale-80");
                __builder2.AddAttribute(98, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
                                                                                                                                                                                                                                          () => NavigateToRegister()

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(99, "Register");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 72 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Pages\Login.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IUserController _userController { get; set; }
    }
}
#pragma warning restore 1591
