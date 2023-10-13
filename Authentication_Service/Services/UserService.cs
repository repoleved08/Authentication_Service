using AutoMapper;
using HMS_Authentication.DbConn;
using HMS_Authentication.Models;
using HMS_Authentication.Models.Dto;
using HMS_Authentication.Services.IServices;
using Microsoft.AspNetCore.Identity;

namespace HMS_Authentication.Services
{
    public class UserService : IUserInterface
    {
        private readonly AppDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IMapper _mapper;

        public UserService(AppDbContext database, UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager, IMapper mapper)
        {
            _context = database;
            _userManager = userManager;
            _roleManager = roleManager;
            _mapper = mapper;
        }
        public Task<bool> AssignRole(string Email, string RoleName)
        {
            throw new NotImplementedException();
        }

        public Task<LoginResponse> LoginUser(LoginRequestDto loginRequestDto)
        {
            throw new NotImplementedException();
        }

        public async Task<string> RegisterUser(RegisterRequestDto registerRequestDto)
        {
            var user = _mapper.Map<ApplicationUser>(registerRequestDto);
            try
            {
                var result = await _userManager.CreateAsync(user, registerRequestDto.Password);
                if(result.Succeeded)
                {
                    return "";
                }
                else
                {
                    return result.Errors.FirstOrDefault().Description;
                }
            }catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
