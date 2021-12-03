using business_logic.Model.PetPack;

namespace business_logic.Model
{
    public class Status
    {
        string userEmail {get;set;}
        StatusName status {get;set;}
        int id {get;set;}
        int petId {get;set;}
    }
}