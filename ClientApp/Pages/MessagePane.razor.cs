using System;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class MessagePane : ComponentBase
    {
        private Message _newMessage;
        private string _errorMessage;

        protected override async Task OnInitializedAsync()
        {
            this._newMessage = new Message();
            _errorMessage = "";
        }

        public async void SendMessage()
        {
            try
            {
                await _messageController.SendMessageAsync(_newMessage);
            }
            catch (Exception e)
            {
                _errorMessage = e.Message;
            }
        }
    }
}