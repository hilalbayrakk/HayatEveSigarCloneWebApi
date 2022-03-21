
namespace HayatEveSigar.Services
{
    public class UserService : ControllerBase, IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        public async Task<ActionResult> CreateUserOperation(User user)
        {
            try
            {
                User inComingUser = await _userRepository.GetUserByTc(user.Tc);
                if(inComingUser == null)
                {
                    await _userRepository.CreateUserOperation(user);
                    return Ok("Kayit Islemi Basari ile Tamamlanmistir.");
                }
                return Conflict("Kayit Etmek Istediginiz Kullanici Db' de Kayitlidir !!!");
            }
            catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
        }

        public async Task<ActionResult> DeleteUserOperation(int id)
        {
            try
            {
                User inComingUser = await _userRepository.GetUserById(id);
                if(inComingUser == null)
                {
                    await _userRepository.DeleteUserOperation(inComingUser);
                    return Ok("Kayit Silme Islemi Basari ile Tamamlanmistir.");
                }
                return Conflict("Kayit Silmek Istediginiz Kullanici Db' de Kayitlidir !!!");
            }
            catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
        }

        public async Task<ActionResult<IEnumerable<UserDTO>>> GetAllUser()
        {
            try
            {
                return Ok((await _userRepository.GetAllUser()).UserToUserDTO());
            }catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
            
        }

        public async Task<ActionResult<UserDTO>> GetUserByEmail(string email)
        {
            try
            {
                User inComingUser = await _userRepository.GetUserByEmail(email);
                if(inComingUser != null)
                {
                    return Ok(inComingUser.UserToUserDTO());
                }
                return NotFound("Aranan Kullanici Db' de Kayitli Degildir !!!");
            }catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
        }

        public async Task<ActionResult<UserDTO>> GetUserById(int id)
        {
            try
            {
                User inComingUser = await _userRepository.GetUserById(id);
                if(inComingUser != null)
                {
                    return Ok(inComingUser.UserToUserDTO());
                }
                return NotFound("Aranan Kullanici Db' de Kayitli Degildir !!!");
            }catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
        }

        public async Task<ActionResult<UserDTO>> GetUserByTc(string tc)
        {
            try
            {
                User inComingUser = await _userRepository.GetUserByTc(tc);
                if(inComingUser != null)
                {
                    return Ok(inComingUser.UserToUserDTO());
                }
                return NotFound("Aranan Kullanici Db' de Kayitli Degildir !!!");
            }catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
        }

        public async Task<ActionResult<UserDTO>> UpdateUserOperation(User User)
        {
            try
            {
                User inComingUser = await _userRepository.GetUserByTc(User.Tc);
                if(inComingUser != null)
                {
                    return Ok((await _userRepository.UpdateUserOperation(inComingUser.Id,User)).UserToUserDTO());
                }
                return NotFound("Guncellemek Istediginiz Kullanici Db' de Kayitli Degildir !!!");
            }catch(Exception ex)
            {
                return BadRequest("Hay Aksi Bir Sorun ile Karsilasildi !!! Ex => "+ex.Message);
            }
        }
    }
}