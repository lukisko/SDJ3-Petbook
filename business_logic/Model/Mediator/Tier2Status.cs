using System.Threading.Tasks;
using System.Collections.Generic;
using Entities;

namespace business_logic.Model.Mediator
{
    public class Tier2Status : ITier2Status
    {
        private ITier2Singleton tier2;
        public Tier2Status(ITier2Singleton tier2){
            this.tier2 = tier2;
        }

        public async Task<Status> getStatus(Status status){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Get",status);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }

        public async Task<IList<Status>> getStatusesOf(Pet pet){
            Comunication<Status> communicationClass = new Comunication<Status>("status","GetAllOfPet",new Status(){pet = pet});

            if (pet == null){
                return new List<Status>();
            }

            Comunication<IList<Status>> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<IList<Status>>>(communicationClass);

            return theStatus.value;
        }
        public async Task<Status> addStatus(Status newStatus){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Add",newStatus);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }

        public async Task<IList<Status>> requestStatusByName(string statusName){
            Comunication<Status> communicationClass = new Comunication<Status>("status","GetAllOf",new Status(){name = statusName});

            Comunication<IList<Status>> pets = await tier2.requestServerAsync<Comunication<Status>,Comunication<IList<Status>>>(communicationClass);

            return pets.value;
        }

        public async Task<Status> updateStatus(Status newerStatus){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Update",newerStatus);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }
        public async Task<Status> removeStatus(Status oldStatus){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Remove",oldStatus);

            Comunication<string> answer = await tier2.requestServerAsync<Comunication<Status>,Comunication<string>>(communicationClass);

            return oldStatus;
        }
    }
}