#pragma checksum "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9f6b25e4bf4e494acb5ed1c08908d1c9498f004"
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
#nullable restore
#line 2 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
           [Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/AddPet")]
    public partial class AddPet : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(0);
            __builder.AddAttribute(1, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 6 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                  petToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                            AddNewPet

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
                __builder2.AddMarkupContent(7, "\r\n");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "grid min-h-screen place-items-center");
                __builder2.AddAttribute(10, "style", "margin-top: -1rem;");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "w-11/12 p-3 bg-white sm:w-8/12 md:w-1/2 lg:w-5/12");
                __builder2.AddMarkupContent(13, "<h1 class=\"text-xl font-semibold\">Hello there 👋, <span class=\"font-normal\">please fill in your pet information 🐶</span></h1>\r\n    ");
                __builder2.OpenElement(14, "form");
                __builder2.AddAttribute(15, "class", "mt-6");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "flex justify-between gap-3");
                __builder2.OpenElement(18, "span");
                __builder2.AddAttribute(19, "class", "w-1/2");
                __builder2.AddMarkupContent(20, "<label for=\"Name\" class=\"block text-xs font-semibold text-gray-600 uppercase\">Name</label>\r\n          ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "id", "Name");
                __builder2.AddAttribute(23, "name", "name");
                __builder2.AddAttribute(24, "placeholder", "Lucky");
                __builder2.AddAttribute(25, "autocomplete", "given-name");
                __builder2.AddAttribute(26, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(27, "required", true);
                __builder2.AddAttribute(28, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                      petToAdd.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.Name = __value, petToAdd.Name))));
                __builder2.AddAttribute(30, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n        ");
                __builder2.OpenElement(32, "span");
                __builder2.AddAttribute(33, "class", "w-1/2");
                __builder2.AddMarkupContent(34, "<label for=\"Type\" class=\"block text-xs font-semibold text-gray-600 uppercase\">Type</label>\r\n        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(35);
                __builder2.AddAttribute(36, "id", "Type");
                __builder2.AddAttribute(37, "name", "type");
                __builder2.AddAttribute(38, "placeholder", "Dog");
                __builder2.AddAttribute(39, "autocomplete", "animal-type");
                __builder2.AddAttribute(40, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(41, "required", true);
                __builder2.AddAttribute(42, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                   petToAdd.Type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(43, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.Type = __value, petToAdd.Type))));
                __builder2.AddAttribute(44, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.Type));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(45, "\r\n      ");
                __builder2.AddMarkupContent(46, "<label for=\"Breed\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Breed</label>\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(47);
                __builder2.AddAttribute(48, "id", "Breed");
                __builder2.AddAttribute(49, "type", "text");
                __builder2.AddAttribute(50, "name", "breed");
                __builder2.AddAttribute(51, "placeholder", "Bichon Maltese");
                __builder2.AddAttribute(52, "autocomplete", "breed");
                __builder2.AddAttribute(53, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(54, "required", true);
                __builder2.AddAttribute(55, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                                    petToAdd.Breed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(56, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.Breed = __value, petToAdd.Breed))));
                __builder2.AddAttribute(57, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.Breed));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(58, "\r\n      ");
                __builder2.AddMarkupContent(59, "<label for=\"Birthday\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Birth date</label>\r\n      ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputDate_0(__builder2, 60, 61, "Birthday", 62, "date", 63, "Birthdate", 64, "Birthday", 65, "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner", 66, true, 67, 
#nullable restore
#line 26 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                 petToAdd.Birthdate

#line default
#line hidden
#nullable disable
                , 68, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.Birthdate = __value, petToAdd.Birthdate)), 69, () => petToAdd.Birthdate);
                __builder2.AddMarkupContent(70, "\r\n      ");
                __builder2.AddMarkupContent(71, "<label for=\"Description\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Description</label>\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(72);
                __builder2.AddAttribute(73, "id", "Description");
                __builder2.AddAttribute(74, "name", "Description");
                __builder2.AddAttribute(75, "placeholder", "A good boy");
                __builder2.AddAttribute(76, "autocomplete", "Description");
                __builder2.AddAttribute(77, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(78, "required", true);
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                                      petToAdd.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.Description = __value, petToAdd.Description))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(82, "\r\n      ");
                __builder2.AddMarkupContent(83, "<label for=\"City\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">City</label>\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "id", "City");
                __builder2.AddAttribute(86, "name", "City");
                __builder2.AddAttribute(87, "placeholder", "Varde");
                __builder2.AddAttribute(88, "autocomplete", "City");
                __builder2.AddAttribute(89, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(90, "required", true);
                __builder2.AddAttribute(91, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                             petToAdd.City.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(92, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.City.name = __value, petToAdd.City.name))));
                __builder2.AddAttribute(93, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.City.name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(94, "\r\n      ");
                __builder2.AddMarkupContent(95, "<label for=\"Country\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Country</label>\r\n      ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(96);
                __builder2.AddAttribute(97, "id", "Country");
                __builder2.AddAttribute(98, "name", "Country");
                __builder2.AddAttribute(99, "placeholder", "Denmark");
                __builder2.AddAttribute(100, "autocomplete", "Country");
                __builder2.AddAttribute(101, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(102, "required", true);
                __builder2.AddAttribute(103, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 32 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                       petToAdd.City.country.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(104, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.City.country.name = __value, petToAdd.City.country.name))));
                __builder2.AddAttribute(105, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.City.country.name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n      \r\n      ");
                __builder2.AddMarkupContent(107, "<p for=\"Status\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Status</p>\r\n      ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputSelect_1(__builder2, 108, 109, 
#nullable restore
#line 35 "C:\Users\ionge\Desktop\VIA UNIVERSITY\3sem\SEP3\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                petToAdd.Status

#line default
#line hidden
#nullable disable
                , 110, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.Status = __value, petToAdd.Status)), 111, () => petToAdd.Status, 112, (__builder3) => {
                    __builder3.AddMarkupContent(113, "<option value=\"Regular\">Regular</option>\r\n        ");
                    __builder3.AddMarkupContent(114, "<option value=\"Adoption\">Adoption</option>\r\n        ");
                    __builder3.AddMarkupContent(115, "<option value=\"Fostering\">Fostering</option>\r\n        ");
                    __builder3.AddMarkupContent(116, "<option value=\"Walking\">Walking</option>");
                }
                );
                __builder2.AddMarkupContent(117, "\r\n      \r\n      ");
                __builder2.AddMarkupContent(118, "<button type=\"submit\" class=\"w-full py-3 mt-6 font-medium tracking-widest text-white uppercase bg-pink shadow-lg focus:outline-none hover:bg-pink-900 hover:shadow-none\">\r\n        Create Pet Profile\r\n      </button>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPetController _petController { get; set; }
    }
}
namespace __Blazor.ClientApp.Pages.AddPet
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, System.Object __arg5, int __seq6, TValue __arg6, int __seq7, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg7, int __seq8, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg8)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "type", __arg1);
        __builder.AddAttribute(__seq2, "name", __arg2);
        __builder.AddAttribute(__seq3, "autocomplete", __arg3);
        __builder.AddAttribute(__seq4, "class", __arg4);
        __builder.AddAttribute(__seq5, "required", __arg5);
        __builder.AddAttribute(__seq6, "Value", __arg6);
        __builder.AddAttribute(__seq7, "ValueChanged", __arg7);
        __builder.AddAttribute(__seq8, "ValueExpression", __arg8);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
