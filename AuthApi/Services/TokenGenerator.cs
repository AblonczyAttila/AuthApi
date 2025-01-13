using AuthApi.Models;
using AuthApi.Services.IService;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace AuthApi.Services
{
    public class TokenGenerator : ITokenGenerator
    {
        private readonly JwtOption jwtOption;

        public TokenGenerator(IOptions<JwtOption> jwtOption)
        {
            this.jwtOption = jwtOption.Value;
        }
        public string GenerateToken(ApplicationUser applicationUser, IEnumerable<string> roles)
        {
            var tokenHandler = new JwtSecurityTokenHandler();

            var key = Encoding.ASCII.GetBytes(jwtOption.Secret);
        }

    }
}
