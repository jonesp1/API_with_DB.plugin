using API.Dtos;
using API.Entities;

namespace API.Service
{

    public static class Extensions
    {
        public static UserDto AsDto(this User user)
        {
            return new UserDto(user.Id, user.Name);
        }
    }
}