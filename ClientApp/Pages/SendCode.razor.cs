using System;
using System.Threading.Tasks;
using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class SendCode : ComponentBase
    {
        private string Email { get; set; }
        private string _errorMessage;
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _errorMessage = "";
        }

        private async Task SendCodeAsync()
        {
            try
            {
                //await _userController.SendEmail(email);
                _modalService.Show<Login>();
              await  ModalInstance.CloseAsync();

            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }
    }
}