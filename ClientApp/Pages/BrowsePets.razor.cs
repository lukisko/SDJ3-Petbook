using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Mime;
using System.Linq;
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
            allPets = await _petController.GetAllPetsAsync();
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

        void ShowLogin()
        {
            _modalService.Show<Register>();
        }

        private async Task FilterBy(ChangeEventArgs eventArgs)
        {
            filterBy = eventArgs.Value.ToString();
        }

        private async Task FilterArg(ChangeEventArgs eventArgs, String typeOfObject)
        {
            filterArgument = eventArgs.Value.ToString();


            if (typeOfObject.Equals("Pets"))
            {
                await ExecuteFilteringPets();
            }
        }

        private async Task ExecuteFilteringPets()
        {
            switch (filterBy)
            {
                
                case "Name":
                    toShowPets =
                        allPets.Where(t => t.name.ToString().Contains(filterArgument)).ToList();
                    break;

                case "Status":
                    toShowPets =
                        allPets.Where(t => t.statuses.Any(s=>s.name.Contains(filterArgument))).ToList();
                    break;
                case "Type":
                    toShowPets =
                        allPets.Where(t => t.type.ToString().Contains(filterArgument)).ToList();
                    break;
                case "Breed":
                    toShowPets =
                        allPets.Where(t => t.breed.ToString().Contains(filterArgument)).ToList();
                    break;
                case "Gender":
                    toShowPets = allPets.Where(t => t.gender.ToString().Contains(filterArgument)).ToList();
                    break;
                case "Birthday":
                    toShowPets =
                        allPets.Where(t => t.birthdate.ToString().Contains(filterArgument)).ToList();
                    break;
            }
        }

        async Task SendRequest(int petIdRequest,string typeName,string email )
        {
            Request request = new Request();
            request.petId = petIdRequest;
            request.typeName = typeName;
            request.userEmail = email;
            await _requestController.SendRequestAsync(request);
        }
    }
}