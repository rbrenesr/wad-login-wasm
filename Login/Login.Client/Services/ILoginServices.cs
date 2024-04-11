using Login.Shared.DTOs;

namespace Login.Client.Services
{
    public interface ILoginService
    {
        Task Login(UserTokenDTO userTokenDTO);
        Task Logout();
        Task ManejarRenovacionToken();
    }
}
