using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class EditPetProfile : ComponentBase
    {
        public Pet petToEdit;

        protected override async Task OnInitializedAsync()
        {
            petToEdit = new Pet();
        }

        private async Task EditPet()
        {
            // await _petController.AddPetAsync(petToAdd);
            NavMgr.NavigateTo("/");
        }
    }
}