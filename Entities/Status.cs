namespace Entities
{
    public class Status
    {
        public string name {get;set;}
        public User user {get;set;}
        public int id {get;set;}
        public Pet pet {get;set;}
        public Status copy(){
            return new Status(){
                name = this.name,
                user = this.user.copy(),
                id = this.id,
                pet = this.pet.copy()
            };
        }
    }
}