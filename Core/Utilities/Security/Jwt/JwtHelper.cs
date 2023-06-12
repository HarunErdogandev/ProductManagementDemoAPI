using Core.Entities.Concrete;
using Core.Utilities.Security.Encyption;
using Microsoft.Extensions.Configuration    ;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;




namespace Core.Utilities.Security.Jwt
{
    public class JwtHelper : ITokenHelper
    {
        public  IConfiguration Configuration { get; }
        TokenOptions _tokenOptions;

        public JwtHelper(IConfiguration configuration)
        {
             Configuration = configuration;
            _tokenOptions = Configuration.GetSection(key: "TokenOptions").Get<TokenOptions>();



        }
        public AccessToken CreateToken(User user, List<OperationClaim> operationClaims)
        {
            var securityKey = SecurityKeyHelper.CreateSecurityKey(key:_tokenOptions.SecurityKey);
            var signingCredentials = SigningCredentialsHelper.CreateSigningCredentails(securityKey);
            return null;
        }
        public JwtSecurityToken CreateJwtSecurityToken()
        {
            return null;
        }
    }
}
