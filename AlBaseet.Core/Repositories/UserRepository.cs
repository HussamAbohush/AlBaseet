using AlBaseet.Core.Entities;
using AlBaseet.Core;
using Microsoft.EntityFrameworkCore;


namespace AlBaseet.Core.Repositories
    ;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _context;

    public UserRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public IEnumerable<User> GetAllUsers() =>
        _context.Users.Include(u => u.UserRole).ToList();


    public User GetUserById(int id) =>
        _context.Users.Include(u => u.UserRole).First(u => u.Id == id);


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

    public User GetUserByUserName(string userName)=>
        _context.Users.Where(u=>u.Username == userName).FirstOrDefault();

}
public interface IUserRepository
{
    IEnumerable<User> GetAllUsers();
    User GetUserByUserName(string userName);
    User GetUserById(int id);
    void AddUser(User user);
    void UpdateUser(User user);
    void DeleteUser(int id);
}