
namespace HayatEveSigar.Interfaces
{
    public interface IUserRepository
    {
        Task<List<User>> GetAllUser();
        Task<User> GetUserById(int id);
        Task<User> GetUserByTc(string tc);
        Task<User> GetUserByEmail(string email);
        Task CreateUserOperation(User user);
        Task DeleteUserOperation(User user);
        Task<User> UpdateUserOperation(int id,User User);
    }
}