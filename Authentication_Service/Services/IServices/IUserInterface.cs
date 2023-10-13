using HMS_Authentication.Models.Dto;

namespace HMS_Authentication.Services.IServices
{
    public interface IUserInterface
    {
        Task<string> RegisterUser(RegisterRequestDto registerRequestDto);

        Task<LoginResponse> LoginUser(LoginRequestDto loginRequestDto);

        Task<bool> AssignRole(string Email, string RoleName);
    }
}
