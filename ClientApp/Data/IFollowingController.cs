using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;

namespace ClientApp.Data
{
    public interface IFollowingController
    {
        Task AddFollowerAsync(int petId, int followPetId);

        Task RemoveFollowerAsync(int petId, int followPetId);

        //   Task<IList<Post>> GetAllFollowingPetPostsAsync(int petId);
        Task<IList<Pet>> GetAllFollowingPetAccountsAsync(int petId);
        
    }
}