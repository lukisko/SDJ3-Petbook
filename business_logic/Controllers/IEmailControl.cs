using System.Threading.Tasks;

namespace business_logic.Controllers
{
    public interface IEmailControl
    {
        Task<bool> sendCode(string email);
    }
}