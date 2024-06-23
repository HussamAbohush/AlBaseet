using AlBaseet.Core.Interfaces;
using AlBaseet.Core.Models;
using AlBaseet.DAL;
using Microsoft.EntityFrameworkCore;


namespace AlBaseet.Core.Service;

public class UserService : IUserService
{
    private readonly ApplicationDbContext _context;

    public UserService(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAllUsers() =>
        _context.Users.Include(u => u.UserRole).ToList();


    public User GetUserById(int id) =>
        _context.Users.Include(u => u.UserRole).First(u => u.ID == id);


    public void AddUser(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void UpdateUser(User user)
    {
        _context.Users.Update(user);
        _context.SaveChanges();
    }

    public void DeleteUser(int id)
    {
        var user = _context.Users.Find(id);
        if (user != null)
        {
            _context.Users.Remove(user);
            _context.SaveChanges();
        }
    }

    public User GetUserByUserName(string userName) =>
        _context.Users.Include(u => u.UserRole).First(u => u.Username == userName);
}
