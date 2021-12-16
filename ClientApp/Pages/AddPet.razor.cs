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
        private Status walking;
        private Status fostering;
        private Status adopting;

        private bool isWalked;
        private bool isFoster;
        private bool isAdoption;

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
            
            isWalked = false;
            isFoster = false;
            isAdoption = false;
            
            walking = new Status()
            {
                name = "walking"
            };
            fostering = new Status()
            {
                name = "fostering"
            };
            adopting = new Status()
            {
                name = "adopting",
            };
        }
        private async Task AddNewPet()
        {
            setWalking();
            setFostering();
            setAdopting();
            await _petController.AddPetAsync(petToAdd);
            NavMgr.NavigateTo("/BrowsePets");
        }

        public void setWalking()
        {
            if(isWalked)
            {
                petToAdd.statuses.Add(walking);
            }
            
        }
        public void setFostering()
        {
            if(isFoster)
            {
                petToAdd.statuses.Add(fostering);
            }
        }
        public void setAdopting()
        {
            if(isAdoption)
            {
                petToAdd.statuses.Add(adopting);
            }
        }
    }
}