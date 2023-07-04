using ApiStudent.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ApiStudent.Models
{
    public class StudentContext : /*DbContext */IdentityDbContext<UserEntity, UserRole, int>
    {
        public StudentContext(DbContextOptions options): base(options)
        {

        }
        public DbSet<Student> Studnets { get; set; }
    }
}
