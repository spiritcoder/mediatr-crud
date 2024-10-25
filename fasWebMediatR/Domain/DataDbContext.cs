using fasWebMediatR.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace fasWebMediatR.Domain;
public class DataDbContext : DbContext
{
    public DbSet<User> Users { get; set; }

    public DataDbContext(DbContextOptions<DataDbContext> options)
        : base(options) { }
}
