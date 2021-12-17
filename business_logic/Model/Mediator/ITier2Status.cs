using System.Threading.Tasks;
using Entities;
using System.Collections.Generic;

namespace business_logic.Model.Mediator
{
    public interface ITier2Status
    {
        Task<Status> getStatus(Status status);
        Task<IList<Status>> getStatusesOf(Pet pet);
        Task<Status> addStatus(Status newStatus);
        Task<IList<Status>> requestStatusByName(string statusName);
        Task<Status> updateStatus(Status newerStatus);
        Task<Status> removeStatus(Status oldStatus);
    }
}