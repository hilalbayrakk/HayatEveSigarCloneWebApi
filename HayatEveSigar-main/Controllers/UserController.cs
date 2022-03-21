
namespace HayatEveSigar.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUserOperation()
        {
            return await _userService.GetAllUser();
        }

        [HttpGet("id")]
        public async Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            return await _userService.GetUserById(id);
        }

        [HttpGet("tc")]
        public async Task<ActionResult<UserDTO>> GetUserByTc(string tc)
        {
            return await _userService.GetUserByTc(tc);
        }

        [HttpGet("email")]
        public async Task<ActionResult<UserDTO>> GetUserByEmail(string email)
        {
            return await _userService.GetUserByEmail(email);
        }

        [HttpPut]
        public async Task<ActionResult<UserDTO>> UpdateUserOperation(User user)
        {
            return await _userService.UpdateUserOperation(user);
        }

        [HttpPost]
        public async Task<ActionResult> CreateUserOperation(User user)
        {
            return await _userService.CreateUserOperation(user);
        }

        [HttpDelete("id")]
        public async Task<ActionResult> DeleteUserOperation(int id)
        {
            return await _userService.DeleteUserOperation(id);
        }

    }
}