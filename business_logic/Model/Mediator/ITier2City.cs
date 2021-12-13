using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.Mediator
{
    public interface ITier2City
    {
        Task<City> getCity(City city);
        Task<City> addCity(City country);
    }
}