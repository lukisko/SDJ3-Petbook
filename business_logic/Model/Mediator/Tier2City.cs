using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.Mediator
{
    public class Tier2City : ITier2City
    {
        private ITier2Singleton tier2;
        public Tier2City(ITier2Singleton tier2){
            this.tier2 = tier2;
        }
        public async Task<City> getCity(City city){
            Comunication<City> commClass = new Comunication<City>("city","Get",city);

            Comunication<City> theCity = await tier2.requestServerAsync<Comunication<City>,Comunication<City>>(commClass);

            return theCity.value;
        }

        public async Task<City> addCity(City country){
            Comunication<City> commClass = new Comunication<City>("city","Add",country);

            Comunication<City> theCountry = await tier2.requestServerAsync<Comunication<City>,Comunication<City>>(commClass);

            return theCountry.value;
        }
    }
}