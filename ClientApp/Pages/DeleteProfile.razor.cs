using System.Threading.Tasks;
using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class DeleteProfile : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        [Parameter] public int id { get; set; }


        private  async Task DeletePetProfile()
        {
            await _petController.DeletePetAsync(id);
            await ModalInstance.CloseAsync();
            NavMgr.NavigateTo("/");
        }
        private  async Task Cancel()
        {
           await ModalInstance.CancelAsync();
        }
        
        
        
    }
}