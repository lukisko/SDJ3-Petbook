using System.Collections.Generic;

namespace business_logic.Model.RequestPack
{
    public interface IRequestManager
    {
        IList<Request> getRequestOfPetAndUser(int petId, int userId);
        IList<int> getRequestOfPet(int petId);
        void makeRequest(Request request);
    }
}