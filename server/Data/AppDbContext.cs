using Microsoft.EntityFrameworkCore;
using server.Protos;

namespace server.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
	public DbSet<Customer> Customers { get; set; }
}
