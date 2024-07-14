using CRMApplication.Models;
using System.Threading.Tasks;
namespace CRMApplication.Services
{
    public interface IAuthService
    {
        Task<string> Authenticate(LoginRequest loginRequest);
        Task Register(RegisterRequest registerRequest);
    }
}
