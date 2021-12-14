using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.Mediator
{
    public interface ITier2Country
    {
        Task<Country> getCountry(Country country);
        Task<Country> addCountry(Country country);
    }
}