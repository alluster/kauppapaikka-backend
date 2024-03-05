using Microsoft.EntityFrameworkCore;

namespace kauppapaikka_backend.Context;

public class ProductContext : DbContext
{
	public ProductContext(DbContextOptions<ProductContext> options) : base(options)
	{

	}
	public DbSet<ProductModel> Products { get; set; }
}
