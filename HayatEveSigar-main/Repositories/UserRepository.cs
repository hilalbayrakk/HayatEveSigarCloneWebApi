
namespace HayatEveSigar.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly HayatEveSigarContext _context;
        public UserRepository(HayatEveSigarContext context)
        {
            _context = context;
        }

        public async Task CreateUserOperation(User user)
        {
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteUserOperation(User user)
        {
            _context.Users.Remove(user);
            await _context.SaveChangesAsync();
        }

        public async Task<List<User>> GetAllUser()
        {
            return await _context.Users.ToListAsync();
        }

        public async Task<User> GetUserByEmail(string email)
        {
            return await _context.Users.SingleOrDefaultAsync(q=>q.Email == email);
        }

        public async Task<User> GetUserById(int id)
        {
            return await _context.Users.SingleOrDefaultAsync(q=>q.Id==id);
        }

        public async Task<User> GetUserByTc(string tc)
        {
            return await _context.Users.SingleOrDefaultAsync(q=>q.Tc == tc);
        }

        public async Task<User> UpdateUserOperation(int id,User User)
        {
            User inComingUser = await GetUserById(id);
            inComingUser.Tc = User.Tc;
            inComingUser.Name = User.Name;
            inComingUser.Surname = User.Surname;
            inComingUser.Email = User.Email;
            inComingUser.Birthday = User.Birthday;
            inComingUser.Gender = User.Gender;
            
            await _context.SaveChangesAsync();
            return inComingUser;
        }
    }
}