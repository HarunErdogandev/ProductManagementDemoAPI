using Core.Entities.Concrete;
using Microsoft.Extensions.Configuration    ;
using System;
using System.Collections.Generic;
using System.Linq;
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
            var securityKey= _tokenOptions.SecurityKey;
            return new AccessToken();
        }
    }
}
