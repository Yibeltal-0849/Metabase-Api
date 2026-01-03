using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using System;
using XOKA.WebUI.Model;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace XOKA.WebUI.Repos
{
    public class JwtRepos : IJWTRepos
    {
        public string path1 = "c:\\log\\log1.txt";
        private readonly IConfiguration configuration;
        Dictionary<string, string> UserRecords = new Dictionary<string, string>
        {
            {"user1","Pass1" },
            {"user2","Pass2" },
            {"user3","Pass3" }
        };
        public JwtRepos(IConfiguration configuration) 
        { 
            this.configuration = configuration;
        }
        public JwtTokens Authenticate(JwtUsers user)
        {
            
            if (!UserRecords.Any (x => x.Key == user.Uname && x.Value == user.Password))
            {

                return null;
            }
           
            //else generate tokens
            var tokehandler = new JwtSecurityTokenHandler();
            
            var TokenKey = Encoding.UTF8.GetBytes(configuration["JWT:key"]);
            //using (StreamWriter writer = new StreamWriter(path1, true))
            //{
            //    writer.WriteLine(TokenKey);
            //    writer.Close();
            //}
            var TokenDiscriptor = new SecurityTokenDescriptor
            {
                Subject = new System.Security.Claims.ClaimsIdentity(
                    new Claim[]
                    {
                        new Claim(ClaimTypes.Name, user.Uname),
                    }),
                Expires = DateTime.UtcNow.AddMinutes(5),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(TokenKey), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokehandler.CreateToken(TokenDiscriptor);
            
            return new JwtTokens { Token = tokehandler.WriteToken(token) };
        }
    }
}
