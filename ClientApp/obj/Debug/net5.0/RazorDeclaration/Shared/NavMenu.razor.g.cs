// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace ClientApp.Shared
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
#nullable restore
#line 1 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Data.Implementation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using ClientApp.Authentication;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 230 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
 
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
        //_modalService.Show<AddPet>();
    }
    
    void ShowMessagePane()
    {
        NavMgr.NavigateTo($"/MessagePane");
    
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

    void LogOut()
    {
    //   ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
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
