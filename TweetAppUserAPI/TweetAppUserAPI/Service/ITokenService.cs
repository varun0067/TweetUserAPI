using TweetAppUserAPI.Models;

namespace TweetAppUserAPI.Service
{
    public interface ITokenService
    {
        string GenerateToken(User user);
    }
}
