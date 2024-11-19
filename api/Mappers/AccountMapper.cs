using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Account;
using api.Models;

namespace api.Mappers
{
    public static class AccountMapper
    {
        public static AppUser MapToUser(RegisterDto dto){
            return new AppUser{
                UserName = dto.Username,
                Email = dto.Email
            };
        }

        public static NewUserDto MapToNewUserDto(AppUser user, string token){
            return new NewUserDto{
                Username = user.UserName,
                Email = user.Email,
                Token = token

            };
        }
    }
}