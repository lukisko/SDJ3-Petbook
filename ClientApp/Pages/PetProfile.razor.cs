using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class PetProfile:ComponentBase
    {
        
        
        
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