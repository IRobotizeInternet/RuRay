namespace RobotizeAPI.BLL.Contracts
{
    public interface IJwtTokenService
    {
        string GenerateToken();
        bool ValidateToken(string token);
    }
}
