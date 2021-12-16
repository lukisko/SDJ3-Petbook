using System;
using System.Threading.Tasks;
using Blazored.Modal;
using ClientApp.Authentication;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using ClientApp.Authentication;
using ClientApp.Model;

namespace ClientApp.Pages
{
    public partial class Login : ComponentBase
    {
        [CascadingParameter] BlazoredModalInstance ModalInstance { get; set; }
        private string Email { get; set; }
        private string _confirmationCode;
        private string _errorMessage;
        private bool sendButton { get; set; }
        private bool logButtons { get; set; }

        protected async override Task OnInitializedAsync()
        {
            _errorMessage = "";
            _confirmationCode = null;
            sendButton = true;
            logButtons = false;
        }
        
        private async Task SendCode()
        {
            try
            {
                await _userController.SendEmail(Email);
                _errorMessage = "Code has been sent to your email ";
                sendButton = false;
                logButtons = true;
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
                Console.WriteLine(e);
            }
        }
        
        private async Task LoginUser()
        {
            try
            {
               await ((CustomAuthenticationStateProvider) AuthenticationStateProvider).ValidateLogin(Email,
                   _confirmationCode);
                Email = null;
                _confirmationCode = null;
                var result = _modalService.Show<SwitchProfile>();
                var petId = await result.Result;
                if (petId.Data != null)
                {
                    await ModalInstance.CloseAsync(petId);
                }
                else
                {
                   await ModalInstance.CloseAsync();
                }
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
                Console.WriteLine(e);
            }
        }

        async void ShowRegister()
        {
            _modalService.Show<Register>("Sign Up");
            await ModalInstance.CloseAsync();
        }
    }
}