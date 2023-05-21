using API.Dtos;
using API.Entities;
using API.Service;
using Database.plugin;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers;

[ApiController]
[Route("[controller]")]
public class UsersController : ControllerBase

{
    private readonly IRepository<User> usersRepository;



    public UsersController(IRepository<User> usersRepository)
    {
        this.usersRepository = usersRepository;

    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<UserDto>>> GetAsync()
    {

        var users = (await usersRepository.GetAllAsync()).Select(user => user.AsDto());


        return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<UserDto>> GetByIdAsync(string id)
    {
        var user = await usersRepository.GetAsync(id);

        if (user == null)
        {
            return NotFound();
        }
        return user.AsDto();
    }
    //Post /Items
    [HttpPost]
    public async Task<ActionResult<UserDto>> PostAsync(CreateUserDto createUserDto)
    {
        var user = new User
        {
            Id = createUserDto.Id,
            Name = createUserDto.Name

        };

        await usersRepository.CreateAsync(user);

        return Ok(user);
    }
}
