using System;
using System.Threading.Tasks;
using business_logic.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class Authentication : ComponentBase
    {
        [Parameter] public string Email { get; set; }

        private User _userToRegister;
        private string _errorMessage;


        protected override async Task OnInitializedAsync()
        {
            _userToRegister = new User();
            Email = _userToRegister.email; //not sure about that
            _errorMessage = "";
        }

        private async void RegisterUser()
        {
            try
            {
                await _userController.Register(_userToRegister);
                // _modalService.Show<Login>("Login");
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
                _userToRegister.name = "";
            }
        }
    }
}