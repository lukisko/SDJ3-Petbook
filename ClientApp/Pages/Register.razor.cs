using System;
using System.Threading.Tasks;
using Blazored.Modal;
using Blazored.Modal.Services;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

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
                // await _userController.Register(_userToRegister);
                Console.WriteLine("registered");
                Email = _userToRegister.email;
                _modalService.Show<SendCode>();
                await ModalInstance.CloseAsync();
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
                _userToRegister.name = "";
            }
        }

        private void NavigateToMainPage()
        {
            NavMgr.NavigateTo("/");
        }

        public async void ShowLogIn()
        {
            _modalService.Show<SendCode>();
            await ModalInstance.CloseAsync();
        }
    }
}