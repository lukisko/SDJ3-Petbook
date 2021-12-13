using System.Collections.Generic;

namespace business_logic.Model.RequestPack
{
    public interface IRequestManager<T,V>
    {
        IList<T> getRequestOfPetAndUser(int identifier, V secondIdentifier);
        IList<V> getRequestsOfPet(int petId);
        void makeRequest(T request);
    }
}