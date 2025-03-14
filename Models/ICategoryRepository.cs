using System;
namespace dotnet.Models
{
	public interface ICategoryRepository
	{
		IEnumerable<Category> AllCategories{ get; }
    }
}

