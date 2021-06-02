using System;
using System.Net;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RuRay.BLL.Contracts;
using Swashbuckle.AspNetCore.Annotations;

namespace RuRay.API.Controllers
{
    /// <summary>
    /// Defines the <see cref="TokenController" />.
    /// </summary>
    [Authorize]
    [Produces("application/json")]
    [Route("api/token")]
    [ApiVersionNeutral]
    [ApiController]
    public class TokenController : ControllerBase
    {
        /// <summary>
        /// Defines the _jwtTokenService.
        /// </summary>
        private readonly IJwtTokenService _jwtTokenService;

        /// <summary>
        /// Initializes a new instance of the <see cref="TokenController"/> class.
        /// </summary>
        /// <param name="jwtTokenService">The jwtTokenService<see cref="IJwtTokenService"/>.</param>
        public TokenController(IJwtTokenService jwtTokenService)
        {
            _jwtTokenService = jwtTokenService ?? throw new ArgumentNullException(nameof(jwtTokenService));
        }

        /// <summary>
        /// Generate sample token.
        /// </summary>
        /// <returns>Generated token.</returns>
        [AllowAnonymous]
        [HttpGet("generate")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Generated token")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public IActionResult GenerateToken()
        {
            var token = _jwtTokenService.GenerateToken();
            return Ok(token);
        }

        /// <summary>
        /// Validate sample token.
        /// </summary>
        /// <param name="token">Token for validation.</param>
        /// <returns>Token validation status.</returns>
        [HttpPost("validate")]
        [SwaggerResponse((int)HttpStatusCode.OK, Description = "Token validation status")]
        [SwaggerResponse((int)HttpStatusCode.BadRequest, Description = "Bad request for missing or invalid parameter")]
        [SwaggerResponse((int)HttpStatusCode.InternalServerError, Description = "Unexpected error")]
        public IActionResult ValidateToken([FromBody] string token)
        {
            if (string.IsNullOrEmpty(token))
            {
                return BadRequest();
            }
            var isValid = _jwtTokenService.ValidateToken(token);

            return Ok(new { isValid });
        }
    }
}
