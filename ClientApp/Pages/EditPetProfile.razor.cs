using System;
using System.Threading.Tasks;
using ClientApp.Model;
using System;
using System.IO;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;

namespace ClientApp.Pages
{
    public partial class EditPetProfile : ComponentBase
    {
        public Pet petToEdit;
        private Status walking;
        private Status fostering;
        private Status adopting;

        private bool isWalked;
        private bool isFoster;
        private bool isAdoption;
        
        
        [Parameter] public int Id { set; get; }

        protected override async Task OnInitializedAsync()
        {
            petToEdit = await _petController.GetPetProfileAsync(Id);

            walking = new Status()
            {
                name = ""
            };
            fostering = new Status(){
                name = ""
            };
            adopting = new Status(){
                name = ""
            };
            
            isWalked = false;
            isFoster = false;
            isAdoption = false;
            
            foreach (var status in petToEdit.statuses)
            {

                switch (@status.name)
                {
                    case "walking":
                        isWalked = true;
                        walking = status;
                        walking.name = "exist";
                        break;
                    case "fostering":
                        isFoster = true;
                        fostering = status;
                        fostering.name = "exist";
                        break;
                    case "adopting":
                        isAdoption = true;
                        adopting = status;
                        adopting.name = "exist";
                        break;
                }
            }
            
        }

        private async void LoadFile(InputFileChangeEventArgs e){
            Console.WriteLine("wow file works.");
            await using FileStream fs = new($"wwwroot/Images/{petToEdit.id}.jpg", FileMode.Create);
            await e.File.OpenReadStream(5000000).CopyToAsync(fs);
        }

        private async Task EditPet()
        {
            setWalking();
            setFostering();
            setAdopting();
            await _petController.UpdatePetAsync(petToEdit);
            NavMgr.NavigateTo($"/PetProfile/{petToEdit.id}");
        }
        public void setWalking()
        {
            if(isWalked && !walking.name.Equals("exist"))
            {
                walking.name = "walking";
                petToEdit.statuses.Add(walking);
            }
            else if (walking.name.Equals("exist"))
            {
                walking.name = "walking";
                petToEdit.statuses.Remove(walking);
            }
        }
        public void setFostering()
        {
            if(isFoster && !fostering.name.Equals("exist"))
            {
                fostering.name = "fostering";
                petToEdit.statuses.Add(fostering);
            }
            else if (walking.name.Equals("exist"))
            {
                fostering.name = "fostering";
                petToEdit.statuses.Remove(fostering);
            }
        }
        public void setAdopting()
        {
            if(isAdoption && !adopting.name.Equals("exist"))
            {
                adopting.name = "adopting";
                petToEdit.statuses.Add(adopting);
            }
            else if (walking.name.Equals("exist"))
            {
                adopting.name = "adopting";
                petToEdit.statuses.Remove(adopting);
            }
        }
    }
}