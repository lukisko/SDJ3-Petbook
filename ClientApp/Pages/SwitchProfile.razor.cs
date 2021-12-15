﻿using System.Collections.Generic;
using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Modal.Services;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class SwitchProfile : ComponentBase
    {
        private IList<Pet> _toShowPetsPetProfiles;
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        protected override async Task OnInitializedAsync()
        {
            
            _toShowPetsPetProfiles = new List<Pet>();
            _toShowPetsPetProfiles = await _petController.GetAllUserPetsAsync();
        }

        void ProfileLoggedInWith(int petId)
        {
            ModalInstance.CloseAsync(ModalResult.Ok(petId));
        }
        void NavigateAddPet()
        {
            NavMgr.NavigateTo("/AddPet");
        }
    }
}