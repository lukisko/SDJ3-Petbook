using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class Login : ComponentBase
    {
        [Parameter] public string Email { get; set; }
        private string _confirmationCode;
        private string _errorMessage;
        private bool ShowPopUpDialog;

        protected async override Task OnInitializedAsync()
        {
            if (String.IsNullOrEmpty(Email))
            {
                ShowPopUpDialog = true;
            }

            _errorMessage = "";
            _confirmationCode = null;
        }
        private async Task LoginUser()
        {
            try
            {
                await _userController.Login(Email, _confirmationCode);
                Email = null;
                _confirmationCode = null;
                NavMgr.NavigateTo("/");
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }

        private async Task SendCode(string email)
        {
            try
            {
                await _userController.SendEmail(email);
                ShowPopUpDialog = false;
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }
        public void NavigateToRegister()
        {
            NavMgr.NavigateTo("/Register");
        }
    }
}