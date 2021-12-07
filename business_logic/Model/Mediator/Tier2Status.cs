using System.Threading.Tasks;

namespace business_logic.Model.Mediator
{
    public class Tier2Status
    {
        private Tier2 tier2;
        public Tier2Status(Tier2 tier2){
            this.tier2 = tier2;
        }

        public async Task<Status> getStatus(Status status){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Get",status);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }
        public async Task<Status> addStatus(Status newStatus){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Add",newStatus);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }
        public async Task<Status> updateStatus(Status newerStatus){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Update",newerStatus);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }
        public async Task<Status> removeStatus(Status oldStatus){
            Comunication<Status> communicationClass = new Comunication<Status>("status","Remove",oldStatus);

            Comunication<Status> theStatus = await tier2.requestServerAsync<Comunication<Status>,Comunication<Status>>(communicationClass);

            return theStatus.value;
        }
    }
}