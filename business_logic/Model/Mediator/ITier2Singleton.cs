using System.Threading.Tasks;

namespace business_logic.Model.Mediator
{
    public interface ITier2Singleton
    {
         Task<V> requestServerAsync<T,V>(T classToSend);
    }
}