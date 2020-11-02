using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ServiceReference1;
using System;
using System.ComponentModel.DataAnnotations;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace WCFClientCore.Controllers
{
    [Route("Token")]
    public class TokenController : ApiControllerBase
    {
        private readonly AuthenticationService _authService;

        public TokenController(AuthenticationService authService)
        {
            _authService = authService;
        }

        [AllowAnonymous, HttpPost]
        public IActionResult Post(AuthenticateRequest model)
        {
            AuthenticateResponse response = _authService.Authenticate(model);
            return new OkObjectResult(response.Token);
        }
    }

    public class AuthenticateRequest
    {
        [Required]
        public string Username { get; set; }

        [Required]
        public string Password { get; set; }
    }

    public class AuthenticateResponse
    {
        public int Id { get; private set; }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public string Username { get; private set; }
        public string Token { get; private set; }


        public AuthenticateResponse(User user, string token)
        {
            Id = user.Id;
            FirstName = user.FirstName;
            LastName = user.LastName;
            Username = user.Username;
            Token = token;
        }
    }

    public class AuthenticationService
    {
        private readonly IUserService _userService = new UserServiceClient();
        private readonly AppSettings _appSettings;

        public AuthenticationService(IOptions<AppSettings> options)
        {
            _appSettings = options.Value;
        }

        public AuthenticateResponse Authenticate(AuthenticateRequest model)
        {
            var user = _userService.ValidateCredentialsAsync(model.Username, model.Password).GetAwaiter().GetResult();

            if (user is null) return null;

            var token = GenerateJwtToken(user);

            return new AuthenticateResponse(user, token);
        }

        private string GenerateJwtToken(User user)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new[] { new Claim("id", user.Id.ToString()) }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }
    }
}
