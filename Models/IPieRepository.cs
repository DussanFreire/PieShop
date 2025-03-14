using System;
namespace dotnet.Models
{
	public interface IPieRepository
	{
		IEnumerable<Pie> AllPies { get; }
		IEnumerable<Pie> PiesOfTheWeek { get; }
		Pie? GetPieByID(int pieId);
	}
}

