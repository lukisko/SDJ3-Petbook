﻿using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class AddPet : ComponentBase
    {
        public Pet petToAdd = new Pet() {Id = 0, Birthdate = new DateTime(2013, 03, 03), Status = "Regular", City = new City()
        {
            country = new Country()
        }};
        public Pet petToAdd = new Pet() {id = 0};

        private async Task AddNewPet()
        {
            await _petController.AddPetAsync(petToAdd);
            // await _petController.AddPetAsync(new Pet()
            // {
            //     Name = petToAdd.Name, Type = petToAdd.Name, Breed = petToAdd.Breed, Status = petToAdd.Status, Birthdate = petToAdd.Birthdate,
            //     City = new City()
            //     {
            //         name = city.name,
            //         country = new Country()
            //         {
            //             name = country.name
            //         }
            //     }
            // });
            NavMgr.NavigateTo("/");
        }
    }
}