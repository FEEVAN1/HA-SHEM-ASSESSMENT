using HASHEM_ASSESSMENT_PROJECT.DATA.DTO;
using HASHEM_ASSESSMENT_PROJECT.DATA.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces
{
   public interface IUsers
    {
        Task<bool> IsLoginValid(string email, string password);
        Task<Users> GetUser(string email);
        Task<long> CreateUser(UserDTO u, string currentuser);
        Task<List<Users>> GetAllUsers();
    }
}
