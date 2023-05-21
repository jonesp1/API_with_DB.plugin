using System;
using System.ComponentModel.DataAnnotations;

namespace API.Dtos
{
    public record UserDto(string Id, string Name);

    public record CreateUserDto(string Id, string Name);
}