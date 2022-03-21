
namespace HayatEveSigar.Helper
{
    public static class ModelToModelDTO
    {
        public static UserDTO UserToUserDTO(this User user)
        {
            return new UserDTO(user);
        }

        public static List<UserDTO> UserToUserDTO(this List<User> users)
        {
            List<UserDTO> userDTOs = new List<UserDTO>();
            foreach(User user in users)
            {
                userDTOs.Add(new UserDTO(user));
            }
            return userDTOs;
        }
    }
}