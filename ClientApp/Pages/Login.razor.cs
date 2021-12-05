using System;
using System.Threading.Tasks;
using Blazored.Modal;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class Login : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        private string Email { get; set; }
        private string _confirmationCode;
        private string _errorMessage;


        protected async override Task OnInitializedAsync()
        {
            _errorMessage = "";
            _confirmationCode = null;
        }

        private async Task LoginUser()
        {
            try
            {
               // await _userController.Login(Email, _confirmationCode);
                Email = null;
                _confirmationCode = null;
               await ModalInstance.CloseAsync();
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }

        void ShowRegister()
        {
            _modalService.Show<Register>("Sign Up");
        }
    }
}