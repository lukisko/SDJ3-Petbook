#pragma checksum "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "be73038c81e100a3669dd7b09eff89f60f147708"
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
#nullable restore
#line 12 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\_Imports.razor"
using Blazored.Modal.Services;

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
#line 6 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                  petToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(2, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 6 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
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
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenElement(8, "div");
                __builder2.AddAttribute(9, "class", "grid min-h-auto place-items-center bg-pink-100");
                __builder2.OpenElement(10, "div");
                __builder2.AddAttribute(11, "class", "w-11/12 p-6 rounded-lg bg-white sm:w-8/12 md:w-1/2 lg:w-5/12");
                __builder2.AddMarkupContent(12, "<h1 class=\"text-xl font-semibold\">Hello there 👋, <span class=\"font-normal\">please fill in your pet information 🐶</span></h1>\r\n            ");
                __builder2.OpenElement(13, "div");
                __builder2.AddAttribute(14, "class", "flex justify-between gap-3");
                __builder2.OpenElement(15, "span");
                __builder2.AddAttribute(16, "class", "w-1/2");
                __builder2.AddMarkupContent(17, "<label for=\"Name\" class=\"block text-xs font-semibold text-gray-600 uppercase\">Name</label>\r\n                         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(18);
                __builder2.AddAttribute(19, "name", "name");
                __builder2.AddAttribute(20, "placeholder", "Lucky");
                __builder2.AddAttribute(21, "autocomplete", "given-name");
                __builder2.AddAttribute(22, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(23, "required", true);
                __builder2.AddAttribute(24, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                           petToAdd.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(25, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.name = __value, petToAdd.name))));
                __builder2.AddAttribute(26, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(27, "\r\n                     ");
                __builder2.OpenElement(28, "span");
                __builder2.AddAttribute(29, "class", "w-1/2");
                __builder2.AddMarkupContent(30, "<label class=\"block text-xs font-semibold text-gray-600 uppercase\">Type</label>\r\n                         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(31);
                __builder2.AddAttribute(32, "name", "type");
                __builder2.AddAttribute(33, "placeholder", "Dog");
                __builder2.AddAttribute(34, "autocomplete", "animal-type");
                __builder2.AddAttribute(35, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(36, "required", true);
                __builder2.AddAttribute(37, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                          petToAdd.type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(38, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.type = __value, petToAdd.type))));
                __builder2.AddAttribute(39, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.type));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(40, "\r\n                 ");
                __builder2.AddMarkupContent(41, "<label class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Breed</label>\r\n                 ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(42);
                __builder2.AddAttribute(43, "type", "text");
                __builder2.AddAttribute(44, "name", "breed");
                __builder2.AddAttribute(45, "placeholder", "Bichon Maltese");
                __builder2.AddAttribute(46, "autocomplete", "breed");
                __builder2.AddAttribute(47, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(48, "required", true);
                __builder2.AddAttribute(49, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                                    petToAdd.breed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.breed = __value, petToAdd.breed))));
                __builder2.AddAttribute(51, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.breed));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\r\n                 ");
                __builder2.AddMarkupContent(53, "<label class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Description</label>\r\n                 ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(54);
                __builder2.AddAttribute(55, "type", "text");
                __builder2.AddAttribute(56, "name", "Description");
                __builder2.AddAttribute(57, "placeholder", "A good boy");
                __builder2.AddAttribute(58, "autocomplete", "Description");
                __builder2.AddAttribute(59, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(60, "required", true);
                __builder2.AddAttribute(61, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                                            petToAdd.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(62, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.description = __value, petToAdd.description))));
                __builder2.AddAttribute(63, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(64, "\r\n                 ");
                __builder2.OpenElement(65, "div");
                __builder2.AddAttribute(66, "class", "flex justify-between gap-3");
                __builder2.OpenElement(67, "span");
                __builder2.AddAttribute(68, "class", "w-1/3");
                __builder2.AddMarkupContent(69, "<label class=\"block text-xs font-semibold text-gray-600 uppercase\">City</label>\r\n                         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(70);
                __builder2.AddAttribute(71, "name", "City");
                __builder2.AddAttribute(72, "placeholder", "Horsens");
                __builder2.AddAttribute(73, "autocomplete", "given-name");
                __builder2.AddAttribute(74, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(75, "required", true);
                __builder2.AddAttribute(76, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                             petToAdd.city.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(77, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.city.name = __value, petToAdd.city.name))));
                __builder2.AddAttribute(78, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.city.name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(79, "\r\n                     ");
                __builder2.OpenElement(80, "span");
                __builder2.AddAttribute(81, "class", "w-1/3");
                __builder2.AddMarkupContent(82, "<label class=\" block mt-2 text-xs font-semibold text-gray-600 uppercase\">Country</label>\r\n                         ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputSelect_0(__builder2, 83, 84, "", 85, @"flex-1 pt-5 w-full border-b-2 border-gray-400 focus:border-green-400
                                                                            text-gray-600 placeholder-gray-400
                                                                            outline-none", 86, 
#nullable restore
#line 32 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                    petToAdd.city.country.name

#line default
#line hidden
#nullable disable
                , 87, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.city.country.name = __value, petToAdd.city.country.name)), 88, () => petToAdd.city.country.name, 89, (__builder3) => {
                    __builder3.AddMarkupContent(90, "<option value></option>\r\n                             ");
                    __builder3.AddMarkupContent(91, "<option value=\"Denmark\">Denmark</option>\r\n                             ");
                    __builder3.AddMarkupContent(92, "<option value=\"Slovakia\">Slovakia</option>\r\n                             ");
                    __builder3.AddMarkupContent(93, "<option value=\"test\">test</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(94, "\r\n                     ");
                __builder2.OpenElement(95, "span");
                __builder2.AddAttribute(96, "class", "w-1/3");
                __builder2.AddMarkupContent(97, "<label class=\" block mt-2 text-xs font-semibold text-gray-600 uppercase\">Gender</label>\r\n                         ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputSelect_1(__builder2, 98, 99, "", 100, @"flex-1 pt-5 w-full border-b-2 border-gray-400 focus:border-green-400
                                                                                                 text-gray-600 placeholder-gray-400
                                                                                                 outline-none", 101, 
#nullable restore
#line 43 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                    petToAdd.gender

#line default
#line hidden
#nullable disable
                , 102, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.gender = __value, petToAdd.gender)), 103, () => petToAdd.gender, 104, (__builder3) => {
                    __builder3.AddMarkupContent(105, "<option value></option>\r\n                             ");
                    __builder3.AddMarkupContent(106, "<option value=\"F\">Female</option>\r\n                             ");
                    __builder3.AddMarkupContent(107, "<option value=\"M\">Male</option>\r\n                             ");
                    __builder3.AddMarkupContent(108, "<option value=\"X\">Other</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(109, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(110, "<label for=\"Type\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">BirthDate</label>\r\n                    ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputDate_2(__builder2, 111, 112, "text", 113, "date", 114, "xx/xx/xxxx", 115, "this.setAttribute(\'type\', \'date\')", 116, "pt-3 pb-2 block w-full px-0 mt-0 bg-transparent border-0 border-b-2 appearance-none focus:outline-none focus:ring-0 focus:border-black border-gray-200", 117, 
#nullable restore
#line 56 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                             petToAdd.birthdate

#line default
#line hidden
#nullable disable
                , 118, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.birthdate = __value, petToAdd.birthdate)), 119, () => petToAdd.birthdate);
                __builder2.AddMarkupContent(120, "\r\n\r\n\r\n                ");
                __builder2.AddMarkupContent(121, "<p for=\"Status\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Status</p>\r\n                <div class=\"flex justify-between gap-3\"></div>\r\n\r\n                 ");
                __builder2.AddMarkupContent(122, @"<div><button type=""submit"" class="" w-full py-3 mt-6 font-medium tracking-widest text-white uppercase bg-black shadow-lg focus:outline-none hover:bg-green-400 hover:shadow-none"">
                         Create Pet Profile
                     </button></div>");
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
        public static void CreateInputSelect_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, TValue __arg2, int __seq3, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg3, int __seq4, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "placeholder", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "Value", __arg2);
        __builder.AddAttribute(__seq3, "ValueChanged", __arg3);
        __builder.AddAttribute(__seq4, "ValueExpression", __arg4);
        __builder.AddAttribute(__seq5, "ChildContent", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputDate_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, System.Object __arg4, int __seq5, TValue __arg5, int __seq6, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg6, int __seq7, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg7)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "name", __arg1);
        __builder.AddAttribute(__seq2, "placeholder", __arg2);
        __builder.AddAttribute(__seq3, "onclick", __arg3);
        __builder.AddAttribute(__seq4, "class", __arg4);
        __builder.AddAttribute(__seq5, "Value", __arg5);
        __builder.AddAttribute(__seq6, "ValueChanged", __arg6);
        __builder.AddAttribute(__seq7, "ValueExpression", __arg7);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
