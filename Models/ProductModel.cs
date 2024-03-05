using System.ComponentModel.DataAnnotations;

namespace kauppapaikka_backend;

public class ProductModel
{
	[Key]
	public long id { get; set; }
	
	public string Brand { get; set; }

	public string Title { get; set; }
	public DateTime CreatedAt { get; set; } = DateTime.Now;
	public DateTime UpdatedAt { get; set; } = DateTime.Now;

}
