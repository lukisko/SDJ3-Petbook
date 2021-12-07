using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class PetProfile : ComponentBase
    {
        [Parameter] public int petId { get; set; }

        private Pet pet { get; set; }
        private Pet petToShow { get; set; }

        protected override async Task OnInitializedAsync()
        {
           // pet = await _petController.getPetProfileAsync(int petId);
            petToShow = pet;
        }

        public void NavigateToEditProfile()
        {
            NavMgr.NavigateTo("/EditPetProfile");
        }

        public void NavigateToAboutPetProfile()
        {
            NavMgr.NavigateTo("/AboutPetProfile");
        }

        public void NavigateToPetPosts()
        {
            NavMgr.NavigateTo("/AboutPetProfilePosts");
        }

        public void NavigateToPetFollowings()
        {
            NavMgr.NavigateTo("/PetProfileFollowings");
        }

        public void NavigateToPetGroups()
        {
            NavMgr.NavigateTo("/PetGroups");
        }
    }
}