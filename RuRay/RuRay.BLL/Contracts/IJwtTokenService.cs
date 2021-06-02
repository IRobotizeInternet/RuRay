namespace RuRay.BLL.Contracts
{
    /// <summary>
    /// Defines the <see cref="IJwtTokenService" />.
    /// </summary>
    public interface IJwtTokenService
    {
        /// <summary>
        /// The GenerateToken.
        /// </summary>
        /// <returns>The <see cref="string"/>.</returns>
        string GenerateToken();

        /// <summary>
        /// The ValidateToken.
        /// </summary>
        /// <param name="token">The token<see cref="string"/>.</param>
        /// <returns>The <see cref="bool"/>.</returns>
        bool ValidateToken(string token);
    }
}
