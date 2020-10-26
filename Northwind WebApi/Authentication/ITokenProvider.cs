using Microsoft.IdentityModel.Tokens;
using Northwind.Models;
using System;

namespace Northwind_WebApi.Authentication
{
    public interface ITokenProvider
    {
        string CreateToken(User user, DateTime expiry);
        TokenValidationParameters GetValidationParameters();
    }
}
