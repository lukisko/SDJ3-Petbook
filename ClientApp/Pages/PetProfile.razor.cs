using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

        public void NavigateToEditProfile()
        {
            NavMgr.NavigateTo($"/EditPetProfile/{petId}");
        }
        
    }
}