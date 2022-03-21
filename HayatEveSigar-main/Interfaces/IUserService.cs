
namespace HayatEveSigar.Interfaces
{
    public interface IUserService
    {
        Task<ActionResult<IEnumerable<UserDTO>>> GetAllUser();
        Task<ActionResult<UserDTO>> GetUserById(int id);
        Task<ActionResult<UserDTO>> GetUserByTc(string tc);
        Task<ActionResult<UserDTO>> GetUserByEmail(string email);
        Task<ActionResult> CreateUserOperation(User user);
        Task<ActionResult> DeleteUserOperation(int id);
        Task<ActionResult<UserDTO>> UpdateUserOperation(User User);
    }
}