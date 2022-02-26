using HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Intefaces;
using HASHEM_ASSESSMENT_PROJECT.DATA.DTO;
using HASHEM_ASSESSMENT_PROJECT.DATA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HASHEM_ASSESSMENT_PROJECT.BUSINESSLOGIC.Logic
{
    public class UserService : IUsers
    {
        DbContextClass _dxt;
        ILogger _log;
        ISecure _sec;
        public UserService(DbContextClass dxt, ILogger log, ISecure sec)
        {
            _dxt = dxt;
            _log = log;
            _sec = sec;
        }
        public async Task<bool> IsLoginValid(string email, string password)
        {
            bool isvalid = false;
            try
            {
                Users userdetails = await GetUser(email);
                string plainpassword = _sec.DecryptString(userdetails.Password);
                if(password == plainpassword)
                {
                    isvalid = true;
                }

            }catch(Exception ex)
            {
              await  _log.LogMessage(ex.Message, "IsLoginValid / UserService", "ERROR");
            }
            return isvalid;
        }
        public async Task<Users> GetUser(string email)
        {
            Users us = new Users();
            try
            {
               us = await _dxt.Users.Where(x => x.Email == email).FirstOrDefaultAsync();
            }
            catch (Exception ex)
            {
               await _log.LogMessage(ex.Message, "GetUser / UserService", "ERROR");
            }
            return us;
        }
        public async Task<long> CreateUser(UserDTO u, string currentuser)
        {
            long response = 0;
            try
            {
                await _dxt.Users.AddAsync(new Users() 
                { 
                    Date = DateTime.Now, 
                    FirstName = u.FirstName, 
                    LastName = u.LastName, 
                    Email = u.Email, 
                    Password = _sec.EncryptString(u.Password), 
                    CreatedBy = currentuser 
                }); 
               response = await _dxt.SaveChangesAsync();
            }
            catch (Exception ex)
            {
               await _log.LogMessage(ex.Message, "CreateUser / UserService", "ERROR");
            }
            return response;
        }
        public async Task<List<Users>> GetAllUsers()
        {
            List<Users> all = new List<Users>();
            try
            {
                all = await _dxt.Users.ToListAsync();
            }
            catch (Exception ex)
            {
                await _log.LogMessage(ex.Message, "GetAllUsers / UserService", "ERROR");
            }
            return all;
        }

    }
}
