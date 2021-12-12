using System;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Entities;

namespace business_logic.Model.Mediator
{
    public class Tier2User
    {
        private Tier2 tier2;
        public Tier2User(Tier2 tier2){
            this.tier2 = tier2;
        }

        public async Task<AuthorisedUser> GetUser(AuthorisedUser user){
            Console.WriteLine("name before serialize: "+ user.name);
            Comunication<AuthorisedUser> commClass = new Comunication<AuthorisedUser>("user","Get",user);

            Comunication<AuthorisedUser> theUser = await tier2.requestServerAsync<Comunication<AuthorisedUser>,Comunication<AuthorisedUser>>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(theUser));
            return theUser.value;//TODO should I get pet or comunication pet???
        }
        
        public async Task<AuthorisedUser> MakeUser(AuthorisedUser user){
            Console.WriteLine("name before serialize: "+ user.name);
            Comunication<AuthorisedUser> commClass = new Comunication<AuthorisedUser>("user","Add",user);

            Comunication<AuthorisedUser> theCommun = await tier2.requestServerAsync<Comunication<AuthorisedUser>,Comunication<AuthorisedUser>>(commClass);

            Console.WriteLine(JsonSerializer.Serialize(theCommun));
            return theCommun.value;
        }
    }
}