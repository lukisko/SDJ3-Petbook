using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class AddPet : ComponentBase
    {
        public Pet petToAdd;
     

        protected override async Task OnInitializedAsync()
        {
            petToAdd = new Pet()
            {
                birthdate = DateTime.Now,
                city = new City()
                {
                    country = new Country()
                },
                statuses = new List<Status>(),
            };
            
        }
        private async Task AddNewPet()
        {
            await _petController.AddPetAsync(petToAdd);
            NavMgr.NavigateTo("/BrowsePets");
        }

        
    }
}