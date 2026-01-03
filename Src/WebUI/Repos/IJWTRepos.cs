using XOKA.WebUI.Model;

namespace XOKA.WebUI.Repos
{
    public interface IJWTRepos
    {
        JwtTokens Authenticate(JwtUsers user);
    }
}
