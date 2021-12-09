using business_logic.Model.PetPack;

namespace business_logic.Model
{
    public class Status
    {
        //string userEmail {get;set;}
        public User user {get;set;}
        public string name{get;set;}
        public int id {get;set;}
        public Pet pet {get;set;}

        public Status copy(){
            return new Status(){
                user = this.user,
                name = this.name,
                id = this.id,
                pet = Pet.copy(this.pet)
            };
        }
    }
}