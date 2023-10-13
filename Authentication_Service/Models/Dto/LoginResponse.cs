namespace HMS_Authentication.Models.Dto
{
    public class LoginResponse
    {
        public RegisterResponse User { get; set; } = default!;

        public string Token { get; set; } = string.Empty;
    }
}
