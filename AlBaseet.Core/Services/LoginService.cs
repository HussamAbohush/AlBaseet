using AlBaseet.Core.Entities;
using AlBaseet.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlBaseet.Core.Services;

public class LoginService : ILoginService
{
    IUserRepository repository;
    public LoginService(IUserRepository repository)
    {
        this.repository = repository;
    }
    public bool ChangePassword(string username, string newPassword)
    {
        var hasNumber = new Regex(@"[0-9]+");
        var hasUpperChar = new Regex(@"[A-Z]+");
        var hasMinimum8Chars = new Regex(@".{8,}");
        var isValidated = hasNumber.IsMatch(newPassword) && hasUpperChar.IsMatch(newPassword) && hasMinimum8Chars.IsMatch(newPassword);

        if (isValidated)
        {
            var user = repository.GetUserByUserName(username);
            if (user is not null)
            {
                user.Password = newPassword;
                repository.UpdateUser(user);
                return true;
            }
            else
                return false;
        }
        else
        {
            return false;
        }
        
    }

    public (bool isAuthenticated, Role? role) Authenticate(string username, string password)
    {
        
        var user = repository.GetUserByUserName(username);
        if (user is not null)
        {
            return user.Password == password ? (true, user.UserRole) : (false, null);
        }
        else
        {
            return (false, null);
        }
    }

    public bool ResetPassword(string username, string recoveryPhrase)
    {
        var user = repository.GetUserByUserName(username);
        if (user is not null)
        {
            return user.RecoveryPhrase == recoveryPhrase ? true : false ;
        }
        else
        {
            return false;
        }
    }
}

public interface ILoginService
{
    public (bool isAuthenticated, Role? role) Authenticate(string username, string password);
    public bool ResetPassword(string username, string recoverPhrase);
    public bool ChangePassword(string username,string newPassword);
}