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
                name = "adopting"
            };
        }
        private async Task AddNewPet()
        {
            await _petController.AddPetAsync(petToAdd);
            NavMgr.NavigateTo("/BrowsePets");
        }

        public void setWalking(ChangeEventArgs evt)
        {
            if((bool) evt.Value)
            {
                petToAdd.statuses.Add(walking);
            }
            else
            {
                petToAdd.statuses.Remove(walking);
            }
        }
        public void setFostering(ChangeEventArgs evt)
        {
            if((bool) evt.Value)
            {
                petToAdd.statuses.Add(fostering);
            }
            else
            {
                petToAdd.statuses.Remove(fostering);
            }
        }
        public void setAdopting(ChangeEventArgs evt)
        {
            if((bool) evt.Value)
            {
                petToAdd.statuses.Add(adopting);
            }
            else
            {
                petToAdd.statuses.Remove(adopting);
            }
        }
    }
}