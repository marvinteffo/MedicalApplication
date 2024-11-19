using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Account;
using api.Models;

namespace api.Mappers
{
    public static class UserMapper
    {
        public static AppUser MapToAppUser(RegisterDto dto){
            return new AppUser{
                UserName = dto.Username,
                Email = dto.Email
            };
        }

        public static UserResponseDto MapToUserResponseDto(AppUser user, string token = null){
            return new UserResponseDto{
                Username=user.UserName,
                Email=user.Email,
                Token=token
            };
        }
    }
}