using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class EditPetProfile : ComponentBase
    {
        public Pet petToAdd = new Pet() {id = 0};

        protected override async Task OnInitializedAsync()
        {
        }

        private async Task AddNewPet()
        {
            // await _petController.AddPetAsync(petToAdd);
            NavMgr.NavigateTo("/");
        }
    }
}