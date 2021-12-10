using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;
using Microsoft.AspNetCore.Components;

namespace ClientApp.Pages
{
    public partial class BrowsePets : ComponentBase
    {
        [Parameter] public int petId { get; set; }
        private IList<Pet> allPets;
        private IList<Pet> toShowPets;
        private IList<Message> _toShowPetProfileMessagesWithAPet;
        private bool MessagePaneWindow { get; set; }
        private string _messageBody;
        private int senderPetId { get; set; }
        private Pet _petToLoad;
        private string filterBy;


        private string? filterArgument;

        protected override async Task OnInitializedAsync()
        {
            _toShowPetProfileMessagesWithAPet = new List<Message>();
            allPets = new List<Pet>();
            toShowPets = new List<Pet>();
            _petToLoad = new Pet();
            allPets = await _petController.GetAllPetsAsync(null, null, null, null, null);
            toShowPets = allPets;
        }
        async Task ShowMessagePane(int sendMessageToPetId)
        {
            senderPetId = sendMessageToPetId;
            _toShowPetProfileMessagesWithAPet =
                await _messageController.GetAllMessagesAsync(petId, sendMessageToPetId);
            _petToLoad = await _petController.GetPetProfileAsync(sendMessageToPetId);
            if (MessagePaneWindow)
            {
                MessagePaneWindow = false;
            }
            else
            {
                MessagePaneWindow = true;
            }
        }

        async Task SendMessage()
        {
            Message newMessage = new Message();
            newMessage.MessageBody = _messageBody;
            if (!_messageBody.Equals("") || _messageBody != null)
            {
                newMessage.SenderPetId = petId;
                newMessage.ReceiverPetId = senderPetId;
                await _messageController.SendMessageAsync(newMessage);
                _toShowPetProfileMessagesWithAPet.Add(newMessage);
                _messageBody = "";
            }
        }

        void ShowSendCode()
        {
            _modalService.Show<Register>();
        }

        private void FilterBy(ChangeEventArgs eventArgs)
        {
            filterBy = eventArgs.Value.ToString();
        }

        private async Task FilterArg(ChangeEventArgs eventArgs, String typeOfObject)
        {
            filterArgument = eventArgs.Value.ToString();


            if (typeOfObject.Equals("Pets"))
            {
                await ExecuteFilteringFamilies();
            }
        }

        private async Task ExecuteFilteringFamilies()
        {
            switch (filterBy)
            {
                case "Email":
                    toShowPets =
                        await _petController.GetAllPetsAsync(filterArgument, null, null, null, null);
                    break;
                case "Status":
                    toShowPets =
                        await _petController.GetAllPetsAsync(null, filterArgument, null, null, null);
                    break;
                case "Type":
                    toShowPets =
                        await _petController.GetAllPetsAsync(null, null, filterArgument, null, null);
                    break;
                case "Breed":
                    toShowPets =
                        await _petController.GetAllPetsAsync(null, null, null, filterArgument, null);
                    break;
                // case "Gender":
                //     toShowPets = await _petController.GetAllPetsAsync(null, null, null, null,
                //         filterArgument.ToCharArray(), null, null);
                //     break;
                // case "Birthday":
                //     toShowPets =
                //         await _petController.GetAllPetsAsync(null, null, null, null, null, filterArgument, null);
                //     break;
                case "Name":
                    toShowPets =
                        await _petController.GetAllPetsAsync(null, null, null, null, filterArgument);
                    break;
            }
        }
    }
}