using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.Mediator
{
    public class Tier2Country : ITier2Country
    {
        private ITier2Singleton tier2;
        public Tier2Country(ITier2Singleton tier2){
            this.tier2 = tier2;
        }
        public async Task<Country> getCountry(Country country){
            Comunication<Country> commClass = new Comunication<Country>("country","Get",country);

            Comunication<Country> theCountry = await tier2.requestServerAsync<Comunication<Country>,Comunication<Country>>(commClass);

            return theCountry.value;
        }

        public async Task<Country> addCountry(Country country){
            Comunication<Country> commClass = new Comunication<Country>("country","Add",country);

            Comunication<Country> theCountry = await tier2.requestServerAsync<Comunication<Country>,Comunication<Country>>(commClass);

            return theCountry.value;
        }
    }
}