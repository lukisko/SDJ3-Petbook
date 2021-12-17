using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Blazored.Modal;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class PetProfile : ComponentBase
    {
        [Parameter] public int petId { get; set; }

        private Pet pet { get; set; }

        

        protected override async Task OnParametersSetAsync()
        {
            pet = await _petController.GetPetProfileAsync(petId);
        }

        private  void NavigateToEditProfile()
        {
            NavMgr.NavigateTo($"/EditPetProfile/{petId}");
        }
        private void NavigateToDeleteProfile(int petIdToDelete)
        {
            var parameters = new ModalParameters();
            parameters.Add(nameof(Pet.id), petIdToDelete);
            _modalService.Show<DeleteProfile>("Delete profile",parameters);
        }
        
    }
}