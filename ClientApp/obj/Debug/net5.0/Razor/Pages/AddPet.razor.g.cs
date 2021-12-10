#pragma checksum "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c1efb560a73e34c02c53e026dd0aac9483cfd3d7"
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
            __builder.AddMarkupContent(0, @"<div class=""custom-shape-divider-top-1638800534 bg-pink-100""><svg data-name=""Layer 2"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1200 120"" preserveAspectRatio=""none""><path d=""M321.39,56.44c58-10.79,114.16-30.13,172-41.86,82.39-16.72,168.19-17.73,250.45-.39C823.78,31,906.67,72,985.66,92.83c70.05,18.48,146.53,26.09,214.34,3V0H0V27.35A600.21,600.21,0,0,0,321.39,56.44Z"" class=""shape-fill""></path></svg></div>

");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 11 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                  petToAdd

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 11 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                            AddNewPet

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(5);
                __builder2.CloseComponent();
                __builder2.AddContent(6, " ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(7);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(8, "\r\n    ");
                __builder2.OpenElement(9, "div");
                __builder2.AddAttribute(10, "class", "grid min-h-auto place-items-center bg-pink-100");
                __builder2.OpenElement(11, "div");
                __builder2.AddAttribute(12, "class", "w-11/12 p-6 rounded-lg bg-white sm:w-8/12 md:w-1/2 lg:w-5/12");
                __builder2.AddMarkupContent(13, "<h1 class=\"text-xl font-semibold\">Hello there 👋, <span class=\"font-normal\">please fill in your pet information 🐶</span></h1>\r\n            ");
                __builder2.OpenElement(14, "form");
                __builder2.AddAttribute(15, "class", "mt-6");
                __builder2.OpenElement(16, "div");
                __builder2.AddAttribute(17, "class", "flex justify-between gap-3");
                __builder2.OpenElement(18, "span");
                __builder2.AddAttribute(19, "class", "w-1/2");
                __builder2.AddMarkupContent(20, "<label for=\"Name\" class=\"block text-xs font-semibold text-gray-600 uppercase\">Name</label>\r\n                         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(21);
                __builder2.AddAttribute(22, "name", "name");
                __builder2.AddAttribute(23, "placeholder", "Lucky");
                __builder2.AddAttribute(24, "autocomplete", "given-name");
                __builder2.AddAttribute(25, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(26, "required", true);
                __builder2.AddAttribute(27, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                           petToAdd.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.name = __value, petToAdd.name))));
                __builder2.AddAttribute(29, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                     ");
                __builder2.OpenElement(31, "span");
                __builder2.AddAttribute(32, "class", "w-1/2");
                __builder2.AddMarkupContent(33, "<label class=\"block text-xs font-semibold text-gray-600 uppercase\">Type</label>\r\n                         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(34);
                __builder2.AddAttribute(35, "name", "type");
                __builder2.AddAttribute(36, "placeholder", "Dog");
                __builder2.AddAttribute(37, "autocomplete", "animal-type");
                __builder2.AddAttribute(38, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(39, "required", true);
                __builder2.AddAttribute(40, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 24 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                          petToAdd.type

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(41, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.type = __value, petToAdd.type))));
                __builder2.AddAttribute(42, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.type));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(43, "\r\n                 ");
                __builder2.AddMarkupContent(44, "<label class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Breed</label>\r\n                 ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(45);
                __builder2.AddAttribute(46, "type", "text");
                __builder2.AddAttribute(47, "name", "breed");
                __builder2.AddAttribute(48, "placeholder", "Bichon Maltese");
                __builder2.AddAttribute(49, "autocomplete", "breed");
                __builder2.AddAttribute(50, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(51, "required", true);
                __builder2.AddAttribute(52, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                                    petToAdd.breed

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(53, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.breed = __value, petToAdd.breed))));
                __builder2.AddAttribute(54, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.breed));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(55, "\r\n                 ");
                __builder2.AddMarkupContent(56, "<label class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Description</label>\r\n                 ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(57);
                __builder2.AddAttribute(58, "type", "text");
                __builder2.AddAttribute(59, "name", "Description");
                __builder2.AddAttribute(60, "placeholder", "A good boy");
                __builder2.AddAttribute(61, "autocomplete", "Description");
                __builder2.AddAttribute(62, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(63, "required", true);
                __builder2.AddAttribute(64, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 30 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                                            petToAdd.description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(65, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.description = __value, petToAdd.description))));
                __builder2.AddAttribute(66, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(67, "\r\n                 ");
                __builder2.OpenElement(68, "div");
                __builder2.AddAttribute(69, "class", "flex justify-between gap-3");
                __builder2.OpenElement(70, "span");
                __builder2.AddAttribute(71, "class", "w-1/3");
                __builder2.AddMarkupContent(72, "<label class=\"block text-xs font-semibold text-gray-600 uppercase\">City</label>\r\n                         ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(73);
                __builder2.AddAttribute(74, "name", "City");
                __builder2.AddAttribute(75, "placeholder", "Horsens");
                __builder2.AddAttribute(76, "autocomplete", "given-name");
                __builder2.AddAttribute(77, "class", "block w-full p-3 mt-2 text-gray-700 bg-gray-200 appearance-none focus:outline-none focus:bg-gray-300 focus:shadow-inner");
                __builder2.AddAttribute(78, "required", true);
                __builder2.AddAttribute(79, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                                             petToAdd.city.name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(80, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.city.name = __value, petToAdd.city.name))));
                __builder2.AddAttribute(81, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => petToAdd.city.name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(82, "\r\n                     ");
                __builder2.OpenElement(83, "span");
                __builder2.AddAttribute(84, "class", "w-1/3");
                __builder2.AddMarkupContent(85, "<label class=\" block mt-2 text-xs font-semibold text-gray-600 uppercase\">Country</label>\r\n                         ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputSelect_0(__builder2, 86, 87, "", 88, @"flex-1 pt-5 w-full border-b-2 border-gray-400 focus:border-green-400
                                                                            text-gray-600 placeholder-gray-400
                                                                            outline-none", 89, 
#nullable restore
#line 38 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                    petToAdd.city.country.name

#line default
#line hidden
#nullable disable
                , 90, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.city.country.name = __value, petToAdd.city.country.name)), 91, () => petToAdd.city.country.name, 92, (__builder3) => {
                    __builder3.AddMarkupContent(93, "<option value></option>\r\n                             ");
                    __builder3.AddMarkupContent(94, "<option value=\"Denmark\">Denmark</option>\r\n                             ");
                    __builder3.AddMarkupContent(95, "<option value=\"Slovakia\">Slovakia</option>\r\n                             ");
                    __builder3.AddMarkupContent(96, "<option value=\"test\">test</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(97, "\r\n                     ");
                __builder2.OpenElement(98, "span");
                __builder2.AddAttribute(99, "class", "w-1/3");
                __builder2.AddMarkupContent(100, "<label class=\" block mt-2 text-xs font-semibold text-gray-600 uppercase\">Gender</label>\r\n                         ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputSelect_1(__builder2, 101, 102, "", 103, @"flex-1 pt-5 w-full border-b-2 border-gray-400 focus:border-green-400
                                                                                                 text-gray-600 placeholder-gray-400
                                                                                                 outline-none", 104, 
#nullable restore
#line 49 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                    petToAdd.gender

#line default
#line hidden
#nullable disable
                , 105, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.gender = __value, petToAdd.gender)), 106, () => petToAdd.gender, 107, (__builder3) => {
                    __builder3.AddMarkupContent(108, "<option value></option>\r\n                             ");
                    __builder3.AddMarkupContent(109, "<option value=\"F\">Female</option>\r\n                             ");
                    __builder3.AddMarkupContent(110, "<option value=\"M\">Male</option>");
                }
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(111, "\r\n\r\n                    ");
                __builder2.AddMarkupContent(112, "<label for=\"Type\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">BirthDate</label>\r\n                    ");
                __Blazor.ClientApp.Pages.AddPet.TypeInference.CreateInputDate_2(__builder2, 113, 114, "text", 115, "date", 116, "xx/xx/xxxx", 117, "this.setAttribute(\'type\', \'date\')", 118, "pt-3 pb-2 block w-full px-0 mt-0 bg-transparent border-0 border-b-2 appearance-none focus:outline-none focus:ring-0 focus:border-black border-gray-200", 119, 
#nullable restore
#line 61 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                                                             petToAdd.birthdate

#line default
#line hidden
#nullable disable
                , 120, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => petToAdd.birthdate = __value, petToAdd.birthdate)), 121, () => petToAdd.birthdate);
                __builder2.AddMarkupContent(122, "\r\n\r\n\r\n                ");
                __builder2.AddMarkupContent(123, "<p for=\"Status\" class=\"block mt-2 text-xs font-semibold text-gray-600 uppercase\">Status</p>\r\n                ");
                __builder2.OpenElement(124, "div");
                __builder2.AddAttribute(125, "class", "flex justify-between gap-3");
                __builder2.OpenElement(126, "div");
                __builder2.AddAttribute(127, "class", "flex items-center pt-3");
                __builder2.OpenElement(128, "input");
                __builder2.AddAttribute(129, "type", "checkbox");
                __builder2.AddAttribute(130, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 67 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                            (arg) => setWalking(arg)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(131, "class", "w-4 h-4 text-black bg-gray-300 border-none rounded-md focus:ring-transparent");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(132, "<label class=\"block ml-2 text-sm text-gray-900\">walking</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(133, "\r\n                    ");
                __builder2.OpenElement(134, "div");
                __builder2.AddAttribute(135, "class", "flex items-center pt-3");
                __builder2.OpenElement(136, "input");
                __builder2.AddAttribute(137, "type", "checkbox");
                __builder2.AddAttribute(138, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 70 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                            (arg) => setFostering(arg)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(139, "class", "w-4 h-4 text-black bg-gray-300 border-none rounded-md focus:ring-transparent");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(140, "<label class=\"block ml-2 text-sm text-gray-900\">fostering</label>");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(141, "\r\n                    ");
                __builder2.OpenElement(142, "div");
                __builder2.AddAttribute(143, "class", "flex items-center pt-3");
                __builder2.OpenElement(144, "input");
                __builder2.AddAttribute(145, "type", "checkbox");
                __builder2.AddAttribute(146, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                             (arg) => setAdopting(arg)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(147, "class", "w-4 h-4 text-black bg-gray-300 border-none rounded-md focus:ring-transparent");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(148, "<label class=\"block ml-2 text-sm text-gray-900\">adopting</label>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(149, "\r\n\r\n                 ");
                __builder2.OpenElement(150, "div");
                __builder2.OpenElement(151, "button");
                __builder2.AddAttribute(152, "type", "submit");
                __builder2.AddAttribute(153, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 78 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Pages\AddPet.razor"
                                                     AddNewPet

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(154, "class", " w-full py-3 mt-6 font-medium tracking-widest text-white uppercase bg-black shadow-lg focus:outline-none hover:bg-green-400 hover:shadow-none");
                __builder2.AddMarkupContent(155, "\r\n                         Create Pet Profile\r\n                     ");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(156, "\r\n\r\n\r\n");
            __builder.AddMarkupContent(157, @"<div class="" bg-pink-100 custom-shape-divider-bottom-1638803667""><svg data-name=""Layer 1"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 1200 120"" preserveAspectRatio=""none""><path d=""M321.39,56.44c58-10.79,114.16-30.13,172-41.86,82.39-16.72,168.19-17.73,250.45-.39C823.78,31,906.67,72,985.66,92.83c70.05,18.48,146.53,26.09,214.34,3V0H0V27.35A600.21,600.21,0,0,0,321.39,56.44Z"" class=""shape-fill""></path></svg></div>");
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
