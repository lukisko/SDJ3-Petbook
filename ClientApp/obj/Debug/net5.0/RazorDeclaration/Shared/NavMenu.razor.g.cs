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
#nullable restore
#line 5 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
using System.Runtime.CompilerServices;

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
#line 333 "C:\Users\nicol\RiderProjects\SDJ3-Petbook\ClientApp\Shared\NavMenu.razor"
 
    private bool ProfileWindow { get; set; }
    private bool BurgerMenu { get; set; }
    private bool AccountsWindow { get; set; }
    private bool LogPaneWindow { get; set; }
    private bool MessagePaneWindow { get; set; }

    private IList<Pet> _allPetProfiles;
    private IList<Pet> _toShowPetsPetProfiles;

    private User userLoggedIn { get; set; }

    private IList<Pet> _allPetMessagesWithAPet;
    private IList<Message> _toShowPetProfileMessagesWithAPet;

    private IList<Pet> _allMessageLog;
    private IList<Pet> _toShowMessageLog;
    private Pet petLoggedIn { get; set; }
    private int petToSendMessage { get; set; }
    Message newMessage;

    private string _messageBody;


    protected async override Task OnInitializedAsync()
    {
        petLoggedIn = new Pet();
        _allPetProfiles = new List<Pet>();
        _toShowPetsPetProfiles = new List<Pet>();

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
        ((CustomAuthenticationStateProvider) AuthenticationStateProvider).Logout();
    }

    void NavigateToPetProfile(int petId)
    {
        NavMgr.NavigateTo($"/PetProfile/{petId}");
    }

    async void LoggedInPet()
    {
        _allPetProfiles = await _petController.GetAllUserPetsAsync();
        if (_allPetProfiles.Count == 1)
        {
            int petId = _allPetProfiles[0].id;
            petLoggedIn = await _petController.GetPetProfileAsync(petId);
        }
        else
        {
        }
    }

    public async Task DropDownProfileWindow()
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

    public async void DropDownAccountsWindow()
    {
        LoggedInPet();
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

    async Task ShowMessagePane(int messageToPetId)
    {
        petToSendMessage = messageToPetId;
        _toShowPetProfileMessagesWithAPet = await _messageController.GetAllMessagesAsync(messageToPetId, petLoggedIn.id);
        if (MessagePaneWindow)
        {
            MessagePaneWindow = false;
        }
        else
        {
            LogPaneWindow = false;
            MessagePaneWindow = true;
        }
    }

    async Task ShowLogPane()
    {
        LoggedInPet();
        _toShowMessageLog = await _messageController.GetAllMessagePets(petLoggedIn.id);
        if (LogPaneWindow)
        {
            LogPaneWindow = false;
        }
        else
        {
            LogPaneWindow = true;
        }
    }

    async Task SendMessage()
    {
        newMessage = new Message();
        newMessage.MessageBody = _messageBody;
        newMessage.SenderPetId = petLoggedIn.id;
        newMessage.ReceiverPetId = petToSendMessage;
        await _messageController.SendMessageAsync(newMessage);
        _messageBody = "";
    }





#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private AuthenticationStateProvider AuthenticationStateProvider { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IMessageController _messageController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IPetController _petController { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavMgr { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService _modalService { get; set; }
    }
}
#pragma warning restore 1591
