#pragma checksum "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a8977047d2ee5e9acdf52ca89c2f932ba3ebf500"
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
#nullable restore
#line 1 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Data.Implementation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "bg-pink-900");
            __builder.AddAttribute(2, "b-3dzslfjxd2");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "max-w-7xl mx-auto px-2 sm:px-6 lg:px-8");
            __builder.AddAttribute(5, "b-3dzslfjxd2");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "relative flex items-center justify-between h-16");
            __builder.AddAttribute(8, "b-3dzslfjxd2");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "absolute inset-y-0 left-0 flex items-center sm:hidden");
            __builder.AddAttribute(11, "b-3dzslfjxd2");
            __builder.OpenElement(12, "button");
            __builder.AddAttribute(13, "type", "button");
            __builder.AddAttribute(14, "class", "inline-flex items-center justify-center p-2 rounded-md text-white  hover:text-gray-600  focus:outline-none  focus:ring-inset focus:ring-white");
            __builder.AddAttribute(15, "aria-controls", "mobile-menu");
            __builder.AddAttribute(16, "aria-expanded", "false");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                                                          () => DropDownBurgerMenu()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(18, "b-3dzslfjxd2");
            __builder.AddMarkupContent(19, "<span class=\"sr-only\" b-3dzslfjxd2>Open main menu</span>\r\n\r\n                    ");
            __builder.AddMarkupContent(20, @"<svg class="" h-6 w-6"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M4 6h16M4 12h16M4 18h16"" b-3dzslfjxd2></path></svg>

                    ");
            __builder.AddMarkupContent(21, @"<svg class=""hidden h-6 w-6"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M6 18L18 6M6 6l12 12"" b-3dzslfjxd2></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.AddMarkupContent(23, @"<div class=""flex-1 flex items-center space-x-4 justify-center sm:items-stretch sm:justify-start "" b-3dzslfjxd2><div class=""flex-shrink-0 flex items-center text-white "" b-3dzslfjxd2><img class=""block lg:hidden mt-1 h-16 w-auto"" src=""Images/Logo1.png"" alt=""PetBook Logo"" b-3dzslfjxd2>
                    <img class=""hidden lg:block mt-1 h-16  w-auto"" src=""Images/Logo1.png"" alt=""PetBook Logo"" b-3dzslfjxd2></div>
                <div class=""absolute sm:relative  flex-1 flex items-center"" b-3dzslfjxd2><div class=""flex-shrink-0  hidden sm:inline-block border-2 rounded-xl "" b-3dzslfjxd2><button class="" px-3 border-r"" b-3dzslfjxd2><svg class=""w-auto h-4 text-white"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" b-3dzslfjxd2><path d=""M16.32 14.9l5.39 5.4a1 1 0 0 1-1.42 1.4l-5.38-5.38a8 8 0 1 1 1.41-1.41zM10 16a6 6 0 1 0 0-12 6 6 0 0 0 0 12z"" b-3dzslfjxd2></path></svg></button>
                        <input type=""text"" class=""bg-transparent px-2 py-2 w-auto h-8 rounded-r-xl text-gray-50"" placeholder=""Search..."" b-3dzslfjxd2></div></div></div>

            ");
            __builder.OpenElement(24, "div");
            __builder.AddAttribute(25, "class", "absolute inset-y-0 right-0 flex items-center pr-2 sm:static sm:inset-auto sm:ml-6 sm:pr-0");
            __builder.AddAttribute(26, "b-3dzslfjxd2");
            __builder.OpenElement(27, "div");
            __builder.AddAttribute(28, "class", "hidden sm:block sm:ml-6");
            __builder.AddAttribute(29, "b-3dzslfjxd2");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", " ml-10 flex space-x-9");
            __builder.AddAttribute(32, "b-3dzslfjxd2");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "alt", "Browse Pets");
            __builder.AddAttribute(35, "type", "button");
            __builder.AddAttribute(36, "class", "bg-transparent p-1 rounded-full hover:text-gray-300 text-white focus:outline-none  focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white");
            __builder.AddAttribute(37, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 52 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                                     NavigateToBrowsePets

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(38, "b-3dzslfjxd2");
            __builder.AddMarkupContent(39, "<span class=\"sr-only\" b-3dzslfjxd2>Browse Pets</span>\r\n\r\n                            ");
            __builder.AddMarkupContent(40, @"<svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z"" b-3dzslfjxd2></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n                        ");
            __builder.OpenElement(42, "button");
            __builder.AddAttribute(43, "type", "button");
            __builder.AddAttribute(44, "class", "bg-transparent p-1 rounded-full  hover:text-gray-300 text-white focus:outline-none  focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white");
            __builder.AddAttribute(45, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 59 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                    NavigateHome

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "b-3dzslfjxd2");
            __builder.AddMarkupContent(47, "<span class=\"sr-only\" b-3dzslfjxd2>Go home</span>\r\n\r\n                            ");
            __builder.AddMarkupContent(48, @"<svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M3 12l2-2m0 0l7-7 7 7M5 10v10a1 1 0 001 1h3m10-11l2 2m-2-2v10a1 1 0 01-1 1h-3m-6 0a1 1 0 001-1v-4a1 1 0 011-1h2a1 1 0 011 1v4a1 1 0 001 1m-6 0h6"" b-3dzslfjxd2></path></svg>");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.AddMarkupContent(50, @"<button type=""button"" class=""bg-transparent p-1 rounded-full  hover:text-gray-300 text-white focus:outline-none  focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white"" b-3dzslfjxd2><span class=""sr-only"" b-3dzslfjxd2>View notifications</span>
                            
                            <svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M8 12h.01M12 12h.01M16 12h.01M21 12c0 4.418-4.03 8-9 8a9.863 9.863 0 01-4.255-.949L3 20l1.395-3.72C3.512 15.042 3 13.574 3 12c0-4.418 4.03-8 9-8s9 3.582 9 8z"" b-3dzslfjxd2></path></svg></button>
                        ");
            __builder.OpenElement(51, "button");
            __builder.AddAttribute(52, "type", "button");
            __builder.AddAttribute(53, "class", "bg-transparent p-1 rounded-full hover:text-gray-300 text-white focus:outline-none  focus:ring-offset-2 focus:ring-offset-gray-800 focus:ring-white");
            __builder.AddAttribute(54, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 73 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                   () => ShowSendCode()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(55, "b-3dzslfjxd2");
            __builder.AddMarkupContent(56, "<span class=\"sr-only\" b-3dzslfjxd2>View Messages</span>\r\n                            \r\n                            ");
            __builder.AddMarkupContent(57, @"<svg class=""h-6 w-6"" xmlns=""http://www.w3.org/2000/svg"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" aria-hidden=""true"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m6 0v1a3 3 0 11-6 0v-1m6 0H9"" b-3dzslfjxd2></path></svg>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(58, "\r\n\r\n                ");
            __builder.OpenElement(59, "div");
            __builder.AddAttribute(60, "class", "ml-8 ");
            __builder.AddAttribute(61, "b-3dzslfjxd2");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "c");
            __builder.AddAttribute(64, "b-3dzslfjxd2");
            __builder.OpenElement(65, "button");
            __builder.AddAttribute(66, "type", "button");
            __builder.AddAttribute(67, "class", "max-w-xs rounded-full flex items-center text-sm  ");
            __builder.AddAttribute(68, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 85 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                    DropDownProfileWindow

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(69, "b-3dzslfjxd2");
            __builder.AddMarkupContent(70, "<span class=\"sr-only\" b-3dzslfjxd2>Open user menu</span>\r\n                            <img class=\"h-8 w-8 rounded-full\" src=\"Images/dog.jpg\" alt=\"Pet Profile Picture\" b-3dzslfjxd2>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 90 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                     if (ProfileWindow)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(71, "div");
            __builder.AddAttribute(72, "class", " ali  origin-top-right absolute right-0 mt-2 w-48 rounded-md shadow-lg py-1 bg-white ring-1 ring-black ring-opacity-5 focus:outline-none");
            __builder.AddAttribute(73, "role", "menu");
            __builder.AddAttribute(74, "aria-orientation", "vertical");
            __builder.AddAttribute(75, "aria-labelledby", "user-menu-button");
            __builder.AddAttribute(76, "tabindex", "-1");
            __builder.AddAttribute(77, "b-3dzslfjxd2");
            __builder.OpenElement(78, "ul");
            __builder.AddAttribute(79, "b-3dzslfjxd2");
            __builder.OpenElement(80, "li");
            __builder.AddAttribute(81, "b-3dzslfjxd2");
            __builder.OpenElement(82, "a");
            __builder.AddAttribute(83, "class", " px-4 py-2 text-sm text-gray-700 hover:bg-gray-100  flex flex-row");
            __builder.AddAttribute(84, "role", "menuitem");
            __builder.AddAttribute(85, "tabindex", "-1");
            __builder.AddAttribute(86, "id", "user-menu-item-1");
            __builder.AddAttribute(87, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 97 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                               (DropDownAccountsWindow)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(88, "b-3dzslfjxd2");
            __builder.AddMarkupContent(89, "<label b-3dzslfjxd2>Your Profiles</label>\r\n                                        ");
            __builder.AddMarkupContent(90, @"<svg class=""h-5 w-5 text-gray-800 ml-14"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 20 20"" fill=""currentColor"" b-3dzslfjxd2><path fill-rule=""evenodd"" d=""M5.293 7.293a1 1 0 011.414 0L10 10.586l3.293-3.293a1 1 0 111.414 1.414l-4 4a1 1 0 01-1.414 0l-4-4a1 1 0 010-1.414z"" clip-rule=""evenodd"" b-3dzslfjxd2></path></svg>");
            __builder.CloseElement();
#nullable restore
#line 104 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                     if (AccountsWindow)
                                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(91, "ul");
            __builder.AddAttribute(92, "class", "absolute rounded-md shadow-lg mt-14 ml-4 bg-white z-20  ");
            __builder.AddAttribute(93, "b-3dzslfjxd2");
#nullable restore
#line 107 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                             foreach (Pet item in _toShowPetsPetProfiles)
                                            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(94, "li");
            __builder.AddAttribute(95, "class", " rounded-md ");
            __builder.AddAttribute(96, "b-3dzslfjxd2");
            __builder.OpenElement(97, "a");
            __builder.AddAttribute(98, "class", " block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 flex flex-row");
            __builder.AddAttribute(99, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 110 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                  () => NavigateToPetProfile(@item.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(100, "b-3dzslfjxd2");
            __builder.OpenElement(101, "img");
            __builder.AddAttribute(102, "class", "h-8 w-8 rounded-full");
            __builder.AddAttribute(103, "src", 
#nullable restore
#line 111 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                item.imageUrl

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(104, "alt", "Pet Profile Picture");
            __builder.AddAttribute(105, "b-3dzslfjxd2");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                                                        ");
            __builder.OpenElement(107, "label");
            __builder.AddAttribute(108, "class", "mt-1 ml-2 flex-shrink-0");
            __builder.AddAttribute(109, "b-3dzslfjxd2");
            __builder.AddContent(110, 
#nullable restore
#line 112 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                 item.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 115 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                            }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(111, "li");
            __builder.AddAttribute(112, "class", " rounded-md  ");
            __builder.AddAttribute(113, "b-3dzslfjxd2");
            __builder.OpenElement(114, "a");
            __builder.AddAttribute(115, "class", "block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100 rounded-md flex flex-row ");
            __builder.AddAttribute(116, "role", "menuitem");
            __builder.AddAttribute(117, "tabindex", "-1");
            __builder.AddAttribute(118, "id", "user-menu-item-1");
            __builder.AddAttribute(119, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 117 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                           (NavigateAddPet)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(120, "b-3dzslfjxd2");
            __builder.AddMarkupContent(121, @"<svg xmlns=""http://www.w3.org/2000/svg"" class=""h-6 w-6 ml-1"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M12 9v3m0 0v3m0-3h3m-3 0H9m12 0a9 9 0 11-18 0 9 9 0 0118 0z"" b-3dzslfjxd2></path></svg>
                                                    ");
            __builder.AddMarkupContent(122, "<label class=\"ml-2\" b-3dzslfjxd2>Add Profile</label>");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 127 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(123, "\r\n\r\n                                ");
            __builder.OpenElement(124, "li");
            __builder.AddAttribute(125, "b-3dzslfjxd2");
            __builder.OpenElement(126, "button");
            __builder.AddAttribute(127, "class", "block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100");
            __builder.AddAttribute(128, "role", "menuitem");
            __builder.AddAttribute(129, "tabindex", "-1");
            __builder.AddAttribute(130, "id", "user-menu-item-2");
            __builder.AddAttribute(131, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 132 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                            ShowSendCode

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(132, "b-3dzslfjxd2");
            __builder.AddMarkupContent(133, "\r\n                                        Log In\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n\r\n                                ");
            __builder.OpenElement(135, "li");
            __builder.AddAttribute(136, "b-3dzslfjxd2");
            __builder.OpenElement(137, "a");
            __builder.AddAttribute(138, "class", "block px-4 py-2 text-sm text-gray-700 hover:bg-gray-100");
            __builder.AddAttribute(139, "role", "menuitem");
            __builder.AddAttribute(140, "tabindex", "-1");
            __builder.AddAttribute(141, "id", "user-menu-item-2");
            __builder.AddAttribute(142, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 138 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                       ShowRegister

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(143, "b-3dzslfjxd2");
            __builder.AddMarkupContent(144, "\r\n                                        Sign Up\r\n                                    ");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 144 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n\r\n    \r\n    ");
            __builder.OpenElement(146, "div");
            __builder.AddAttribute(147, "class", "sm:hidden");
            __builder.AddAttribute(148, "id", "mobile-menu");
            __builder.AddAttribute(149, "b-3dzslfjxd2");
            __builder.OpenElement(150, "div");
            __builder.AddAttribute(151, "class", "px-2 pt-2 pb-3 space-y-1");
            __builder.AddAttribute(152, "b-3dzslfjxd2");
#nullable restore
#line 155 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
             if (BurgerMenu)
            {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(153, @"<div class="" flex items-center  justify-start my-2"" b-3dzslfjxd2><div class=""  flex items-center border-2 rounded-xl "" b-3dzslfjxd2><button class="" px-3 border-r"" b-3dzslfjxd2><svg class=""w-auto h-4 text-white"" fill=""currentColor"" xmlns=""http://www.w3.org/2000/svg"" viewBox=""0 0 24 24"" b-3dzslfjxd2><path d=""M16.32 14.9l5.39 5.4a1 1 0 0 1-1.42 1.4l-5.38-5.38a8 8 0 1 1 1.41-1.41zM10 16a6 6 0 1 0 0-12 6 6 0 0 0 0 12z"" b-3dzslfjxd2></path></svg></button>
                        <input type=""text"" class=""bg-transparent px-2 py-2 w-auto h-8 rounded-r-xl text-gray-50"" placeholder=""Search..."" b-3dzslfjxd2></div></div>");
            __builder.OpenElement(154, "div");
            __builder.AddAttribute(155, "class", "flex flex-row space-x-1 hover:text-gray-300  text-white block px-3 py-2 rounded-md text-base font-medium");
            __builder.AddAttribute(156, "b-3dzslfjxd2");
            __builder.OpenElement(157, "svg");
            __builder.AddAttribute(158, "xmlns", "http://www.w3.org/2000/svg");
            __builder.AddAttribute(159, "class", "h-5 w-auto mt-0.5");
            __builder.AddAttribute(160, "fill", "none");
            __builder.AddAttribute(161, "viewBox", "0 0 24 24");
            __builder.AddAttribute(162, "stroke", "currentColor");
            __builder.AddAttribute(163, "b-3dzslfjxd2");
            __builder.OpenElement(164, "path");
            __builder.AddAttribute(165, "stroke-linecap", "round");
            __builder.AddAttribute(166, "stroke-linejoin", "round");
            __builder.AddAttribute(167, "stroke-width", "2");
            __builder.AddAttribute(168, "d", "M12 4.354a4 4 0 110 5.292M15 21H3v-1a6 6 0 0112 0v1zm0 0h6v-1a6 6 0 00-9-5.197M13 7a4 4 0 11-8 0 4 4 0 018 0z");
            __builder.AddAttribute(169, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 173 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                          () => NavigateToBrowsePets()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(170, "b-3dzslfjxd2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(171, "\r\n                    ");
            __builder.AddMarkupContent(172, "<a class=\" space-x-6\" aria-current=\"page\" b-3dzslfjxd2>Browse Pets</a>");
            __builder.CloseElement();
            __builder.OpenElement(173, "div");
            __builder.AddAttribute(174, "class", "flex flex-row space-x-1 hover:text-gray-300  text-white block px-3 py-2 rounded-md text-base font-medium");
            __builder.AddAttribute(175, "b-3dzslfjxd2");
            __builder.OpenElement(176, "svg");
            __builder.AddAttribute(177, "xmlns", "http://www.w3.org/2000/svg");
            __builder.AddAttribute(178, "class", "h-5 w-auto mt-0.5");
            __builder.AddAttribute(179, "fill", "none");
            __builder.AddAttribute(180, "viewBox", "0 0 24 24");
            __builder.AddAttribute(181, "stroke", "currentColor");
            __builder.AddAttribute(182, "b-3dzslfjxd2");
            __builder.OpenElement(183, "path");
            __builder.AddAttribute(184, "stroke-linecap", "round");
            __builder.AddAttribute(185, "stroke-linejoin", "round");
            __builder.AddAttribute(186, "stroke-width", "2");
            __builder.AddAttribute(187, "d", "M3 12l2-2m0 0l7-7 7 7M5 10v10a1 1 0 001 1h3m10-11l2 2m-2-2v10a1 1 0 01-1 1h-3m-6 0a1 1 0 001-1v-4a1 1 0 011-1h2a1 1 0 011 1v4a1 1 0 001 1m-6 0h6");
            __builder.AddAttribute(188, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 180 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                                                             () => NavigateHome()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(189, "b-3dzslfjxd2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(190, "\r\n                    ");
            __builder.AddMarkupContent(191, "<a class=\" space-x-6\" aria-current=\"page\" b-3dzslfjxd2>Home</a>");
            __builder.CloseElement();
            __builder.AddMarkupContent(192, @"<div class=""flex flex-row space-x-1 hover:text-gray-300  text-white block px-3 py-2 rounded-md text-base font-medium"" b-3dzslfjxd2><svg xmlns=""http://www.w3.org/2000/svg"" class=""h-5 w-auto mt-0.5"" fill=""none"" viewBox=""0 0 24 24"" stroke=""currentColor"" b-3dzslfjxd2><path stroke-linecap=""round"" stroke-linejoin=""round"" stroke-width=""2"" d=""M8 12h.01M12 12h.01M16 12h.01M21 12c0 4.418-4.03 8-9 8a9.863 9.863 0 01-4.255-.949L3 20l1.395-3.72C3.512 15.042 3 13.574 3 12c0-4.418 4.03-8 9-8s9 3.582 9 8z"" b-3dzslfjxd2></path></svg>
                    <a class="" space-x-6"" aria-current=""page"" b-3dzslfjxd2>Messages</a></div>");
            __builder.OpenElement(193, "div");
            __builder.AddAttribute(194, "class", "flex flex-row space-x-1 hover:text-gray-300  text-white block px-3 py-2 rounded-md text-base font-medium");
            __builder.AddAttribute(195, "b-3dzslfjxd2");
            __builder.OpenElement(196, "svg");
            __builder.AddAttribute(197, "class", "h-5 w-auto mt-0.5");
            __builder.AddAttribute(198, "xmlns", "http://www.w3.org/2000/svg");
            __builder.AddAttribute(199, "fill", "none");
            __builder.AddAttribute(200, "viewBox", "0 0 24 24");
            __builder.AddAttribute(201, "stroke", "currentColor");
            __builder.AddAttribute(202, "aria-hidden", "true");
            __builder.AddAttribute(203, "b-3dzslfjxd2");
            __builder.OpenElement(204, "path");
            __builder.AddAttribute(205, "stroke-linecap", "round");
            __builder.AddAttribute(206, "stroke-linejoin", "round");
            __builder.AddAttribute(207, "stroke-width", "2");
            __builder.AddAttribute(208, "d", "M15 17h5l-1.405-1.405A2.032 2.032 0 0118 14.158V11a6.002 6.002 0 00-4-5.659V5a2 2 0 10-4 0v.341C7.67 6.165 6 8.388 6 11v3.159c0 .538-.214 1.055-.595 1.436L4 17h5m6 0v1a3 3 0 11-6 0v-1m6 0H9");
            __builder.AddAttribute(209, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 194 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
                                                                                                                                                                                                                                                                                                          NavigateAddPet

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(210, "b-3dzslfjxd2");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(211, "\r\n                    ");
            __builder.AddMarkupContent(212, "<a class=\" space-x-6\" aria-current=\"page\" b-3dzslfjxd2>Notifications</a>");
            __builder.CloseElement();
#nullable restore
#line 198 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 205 "C:\Users\hanch\Desktop\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
 
    private bool ProfileWindow { get; set; }
    private bool BurgerMenu { get; set; }
    private bool AccountsWindow { get; set; }
    private IList<Pet> _allPetProfiles;
    private IList<Pet> _toShowPetsPetProfiles;
    private User userLoggedIn { get; set; }
    Pet pet1 { get; set; }
    Pet pet2 { get; set; }

    protected async override Task OnInitializedAsync()
    {
        pet1 = new Pet();
        pet2 = new Pet();
        _allPetProfiles = new List<Pet>();
        _toShowPetsPetProfiles = new List<Pet>();
    //get the logged in user

    //_allPetProfiles = await _petController.GetAllUserPetsAsync();
        pet1.imageUrl = "Images/dog2.jpg";
        pet1.name = "Jackie Bo";
        pet1.breed = "Terrier";


        pet2.imageUrl = "Images/dog.jpg";
        pet2.id = 2;
        pet2.name = "Andrew Wong";
        pet2.breed = "Terrier";

        _allPetProfiles.Add(pet1);
        _allPetProfiles.Add(pet2);

        _toShowPetsPetProfiles = _allPetProfiles;
        ProfileWindow = false;
        AccountsWindow = false;
        BurgerMenu = false;
    }


    void ShowSendCode()
    {
        _modalService.Show<SendCode>();
    }


    void ShowRegister()
    {
        _modalService.Show<Register>();
    }

    void ShowAddPet()
    {
        NavMgr.NavigateTo($"/AddPet");
        _modalService.Show<AddPet>();
    }

    void NavigateToBrowsePets()
    {
        NavMgr.NavigateTo("/BrowsePets");
    }

    void NavigateHome()
    {
        NavMgr.NavigateTo("/");
    }

    void NavigateAddPet()
    {
        NavMgr.NavigateTo("/AddPet");
    }

    void NavigateToPetProfile(int petId)
    {
        NavMgr.NavigateTo($"/PetProfile/{petId}");
    }

    public void DropDownProfileWindow()
    {
        if (ProfileWindow)
        {
            ProfileWindow = false;
            AccountsWindow = false;
        }
        else
        {
            ProfileWindow = true;
        }
    }

    public void DropDownAccountsWindow()
    {
        if (AccountsWindow)
        {
            AccountsWindow = false;
        }
        else
        {
            AccountsWindow = true;
        }
    }

    public void DropDownBurgerMenu()
    {
        if (BurgerMenu)
        {
            BurgerMenu = false;
        }
        else
        {
            BurgerMenu = true;
        }
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPetController _petController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService _modalService { get; set; }
    }
}
#pragma warning restore 1591
