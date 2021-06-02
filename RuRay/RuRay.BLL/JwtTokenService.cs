using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using RuRay.BLL.Contracts;
using RuRay.BLL.Models;

namespace RuRay.BLL
{
    /// <summary>
    /// Defines the <see cref="JwtTokenService" />.
    /// </summary>
    public class JwtTokenService : IJwtTokenService
    {
        /// <summary>
        /// Defines the _options.
        /// </summary>
        private readonly IOptionsMonitor<CarsBLLOptions> _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="JwtTokenService"/> class.
        /// </summary>
        /// <param name="options">The options<see cref="IOptionsMonitor{CarsBLLOptions}"/>.</param>
        public JwtTokenService(IOptionsMonitor<CarsBLLOptions> options)
        {
            _options = options ?? throw new ArgumentNullException(nameof(options));
        }

        /// <summary>
        /// The GenerateToken.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        public string GenerateToken()
        {
            var nowDT = DateTime.UtcNow;
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_options.CurrentValue.JwtSecretKey);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                NotBefore = nowDT,
                Subject = new ClaimsIdentity(new Claim[]
                {
                        new Claim("dt", nowDT.ToString("yyyy-MM-ddTHH:mm:ssK"))
                }),
                Expires = nowDT.AddMonths(1),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            var finalToken = tokenHandler.WriteToken(token);

            return finalToken;
        }

        /// <summary>
        /// The ValidateToken.
        /// </summary>
        /// <param name="token">The token<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        public bool ValidateToken(string token)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var validationParameters = new TokenValidationParameters()
            {
                ValidateAudience = false,
                ValidateIssuer = false,
                ValidateIssuerSigningKey = true,
                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_options.CurrentValue.JwtSecretKey))
            };

            try
            {
                IPrincipal principal = tokenHandler.ValidateToken(token, validationParameters, out SecurityToken validatedToken);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
