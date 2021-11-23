using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class Login :ComponentBase
    {
        [Parameter] public string Email { get; set; }
        private string _confirmationCode;
        private string _errorMessage;
        protected override async Task OnInitializedAsync()
        {
            _errorMessage = "";
            _confirmationCode = null;
        }
    
        private void LoginUser()
        {
            try
            {
                _userController.Login(Email, _confirmationCode);
                Email = null;
                _confirmationCode = null;
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }
    }
}