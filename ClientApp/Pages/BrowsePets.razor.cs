using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class BrowsePets : ComponentBase
    {
        private IList<Pet> allPets;
        private IList<Pet> toShowPets;

        protected override async Task OnInitializedAsync()
        {
            allPets = await _petController.GetAllPetsAsync();
            toShowPets = allPets;
        }
        
    }
}