using System;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class Register : ComponentBase
    {
        [Parameter] public string Email { get; set; }

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
                NavMgr.NavigateTo($"/Login/{Email}");
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
                _userToRegister.name = "";
            }
        }
        public void NavigateToLogIn()
        {
            NavMgr.NavigateTo($"/Login");
        }
    }
}