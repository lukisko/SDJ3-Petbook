using System.Threading.Tasks;
using business_logic.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class AddPet : ComponentBase
    {
        public Pet petToAdd = new Pet() {id = 0};

        private async Task AddNewPet()
        {
            await _petController.addPetAsync(petToAdd);
            NavMgr.NavigateTo("/");
        }
    }
}