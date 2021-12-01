using System.Collections.Generic;
using System.Threading.Tasks;
using ClientApp.Model;


namespace ClientApp.Data
{
    public interface IGroupController
    {
      //  Task AddGroupAsync(Group group);
        Task DeleteGroupAsync(int groupId);
       // Task AddPetAccountToGroupAsync(int petId, int petId);
       //  Task RemovePetAccountFromGroupAsync(int petId, int petId);
      //   Task<IList<Post>> GetAllFollowingPetPostsAsync(int petId);
        Task<IList<Pet>> GetAllGroupMembersAsync(int petId);
    }
}