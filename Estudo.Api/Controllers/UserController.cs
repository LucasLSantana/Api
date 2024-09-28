using Estudo.Application.Application.DTOs;
using Estudo.Application.Interface;
using Microsoft.AspNetCore.Mvc;

namespace Estudo.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserAppService _userAppService;

        public UserController(IUserAppService userAppService)
        {
            _userAppService = userAppService;
        }

        [HttpPost]
        [Route("create-user")]
        public async Task<ActionResult> AddUserAsync(UserDto userDto)
        {
            try
            {
                await _userAppService.AddAsync(userDto);
                return Ok();
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet]
        [Route("get-all-users")]
        public async Task<ActionResult<List<UserDto>>> GetAllUserAsync()
        {
            try
            {
                var users = await _userAppService.GetAllAsync();
                return Ok(users);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("get-user")]
        public async Task<ActionResult<List<UserDto>>> GetUserAsync(string login)
        {
            try
            {
                var user = await _userAppService.GetAsync(login);
                return Ok(user);
            }
            catch
            {
                return NotFound();
            }
        }

        [HttpPost]
        [Route("update-user")]
        public async Task<ActionResult<UserDto>> UpdateUserAsync(UserDto user)
        {
            try
            {
                await _userAppService.UpdateAsync(user);
                return Ok(user);
            }
            catch
            {
                return BadRequest();
            }
        }
    }
}