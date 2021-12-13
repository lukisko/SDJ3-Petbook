using System;
using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Modal.Services;
using ClientApp.Authentication;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;

namespace ClientApp.Pages
{
    public partial class Register : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        private string Email { get; set; }
        private User _userToRegister;
        private string _errorMessage;


        protected override async Task OnInitializedAsync()
        {
            _userToRegister = new User();
            _errorMessage = "";
        }

        private async Task RegisterUser()
        { 
            try
            {
                 await _userController.Register(_userToRegister);
                 Email = _userToRegister.email;
                _modalService.Show<Login>();
                await ModalInstance.CloseAsync();
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
                Console.WriteLine(e);
                _userToRegister.name = "";
            }
        }
        

        public async void ShowLogIn()
        {
            _modalService.Show<SendCode>();
            await ModalInstance.CloseAsync();
        }
    }
}