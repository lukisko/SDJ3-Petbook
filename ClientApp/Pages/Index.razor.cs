﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace  ClientApp.Pages
{ 
   public partial class Index :ComponentBase {
    
       private IList<Pet> allPets;
       private IList<Pet> toShowPets;

       protected override async Task OnInitializedAsync()
       {
          // allPets = await _petController.GetAllPetsAsync();
          
           toShowPets = allPets;
       }
       private void NavigateToAddPet()
       {
           NavMgr.NavigateTo($"/AddPet");
       }
    }
}