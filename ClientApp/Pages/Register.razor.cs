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
                
                 //pass the email
                 _modalService.Show<Login>();
            }
            catch (Exception e)
            { 
                _errorMessage = e.Message;
                Console.WriteLine(e);
                _userToRegister.name = "";
            }
        }
        

        private async  Task  ShowLogIn()
        {
           
            var result = _modalService.Show<Login>();
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
    }
}