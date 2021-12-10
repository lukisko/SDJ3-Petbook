﻿using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class EditPetProfile : ComponentBase
    {
        public Pet petToEdit;
        private Status walking;
        private Status fostering;
        private Status adopting;
        
        [Parameter] public int Id { set; get; }

        protected override async Task OnInitializedAsync()
        {
            petToEdit = await _petController.GetPetProfileAsync(Id);
            
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

        private async Task EditPet()
        {
            await _petController.UpdatePetAsync(petToEdit);
            NavMgr.NavigateTo("/");
        }
        public void setWalking(ChangeEventArgs evt)
        {
            if((bool) evt.Value)
            {
                petToEdit.statuses.Add(walking);
            }
            else
            {
                petToEdit.statuses.Remove(walking);
            }
        }
        public void setFostering(ChangeEventArgs evt)
        {
            if((bool) evt.Value)
            {
                petToEdit.statuses.Add(fostering);
            }
            else
            {
                petToEdit.statuses.Remove(fostering);
            }
        }
        public void setAdopting(ChangeEventArgs evt)
        {
            if((bool) evt.Value)
            {
                petToEdit.statuses.Add(adopting);
            }
            else
            {
                petToEdit.statuses.Remove(adopting);
            }
        }
    }
}